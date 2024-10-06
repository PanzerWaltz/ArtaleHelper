using System;
using System.Drawing;
using System.Drawing.Text;
using System.Media;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace ArtaleHelper
{
    public partial class Form1 : Form
    {
        private bool isActive = false;
        private bool isFocused = true;
        private bool keyFlag = false;
        private bool isAlarmPlayed = false;

        private Keys boundKey = Keys.None;
        private System.Windows.Forms.Timer timer;
        private TimeSpan timeLeft;
        private SoundPlayer alarmSound = null;
        private string soundFilePath = null;

        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(Keys vKey);

        public Form1()
        {
            InitializeComponent();
            InitSound();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            this.MouseClick += new MouseEventHandler(Form1_MouseClick);
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void buttonActive_Click(object sender, EventArgs e)
        {
            isActive = !isActive;

            labelActive.Text = $"상단 고정 : {isActive}";
            TopMost = isActive;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            isFocused = !isFocused;

            if (isFocused)
            {
                this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.None;
            }
        }

        private void buttonKeyInput_Click(object sender, EventArgs e)
        {
            keyFlag = true;
            buttonKeyInput.Text = " ";
        }

        private async  void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (keyFlag)
            {
                if (e.KeyCode == Keys.Escape)
                {
                    keyFlag = false;
                    buttonKeyInput.Text = "None";
                    boundKey = Keys.None;

                    timeLeft = TimeSpan.FromMinutes(1) + TimeSpan.FromSeconds(30);
                    timer.Stop();
                    UpdateTimerLabel();
                    labelTimer.ForeColor = Color.Black;
                }
                else
                {
                    boundKey = e.KeyCode;
                    buttonKeyInput.Text = boundKey.ToString(); 
                    await Task.Delay(100);
                    keyFlag = false;
                }
            }
        }

        private void StartTimer()
        {
            timeLeft = TimeSpan.FromMinutes(1) + TimeSpan.FromSeconds(30);
            timer.Start();
            UpdateTimerLabel();
            labelTimer.ForeColor = Color.Black;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (timeLeft.TotalSeconds > 0)
            {
                timeLeft = timeLeft.Subtract(TimeSpan.FromSeconds(1));
                UpdateTimerLabel();

                if (timeLeft.TotalSeconds <= 10)
                {
                    labelTimer.ForeColor = Color.Red;
                    if(isAlarmPlayed == false)
                    {
                        PlayAlarm();
                        isAlarmPlayed = true;
                    }
                }
            }
            else
            {
                timer.Stop();
            }
        }

        private void UpdateTimerLabel()
        {
            labelTimer.Text = string.Format("{0:D2}:{1:D2}", timeLeft.Minutes, timeLeft.Seconds);
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            Thread TH = new Thread(BGKeyDetect);
            TH.SetApartmentState(ApartmentState.STA);
            TH.IsBackground = true;
            TH.Start();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            isRunning = false;
        }

        private bool isRunning = true;
        private void BGKeyDetect()
        {
            while (isRunning)
            {
                Thread.Sleep(100);

                // 키 바인딩 중일 때는 타이머를 시작하지 않도록 함
                if (keyFlag)
                {
                    continue; // keyFlag가 true면 키 감지 스킵
                }

                if (boundKey != Keys.None && GetAsyncKeyState(boundKey) < 0)
                {
                    this.Invoke(new Action(() =>
                    {
                        timeLeft = TimeSpan.FromMinutes(1) + TimeSpan.FromSeconds(30);
                        labelTimer.ForeColor = Color.Black;
                        isAlarmPlayed = false;
                        if (!timer.Enabled)
                        {
                            timer.Start();
                        }
                        UpdateTimerLabel();
                    }));
                }
            }
        }

        #region Sound 
        private void PlayAlarm()
        {
            if (checkBoxAlarm.Checked && alarmSound != null)
            {
                alarmSound.Play(); 
            }
        }

        private void InitSound()
        {
            soundFilePath = "alarm.wav";
            if (System.IO.File.Exists(soundFilePath))
            {   
                alarmSound = new SoundPlayer(soundFilePath);
                MessageBox.Show("알림음이 설정되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                alarmSound = null;
                MessageBox.Show("알림음을 찾을 수 없습니다.\n실행파일과 같은 위치에 alarm.wav를 놓고 다시 실행해 주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}