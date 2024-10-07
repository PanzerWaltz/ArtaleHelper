namespace ArtaleHelper
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonActive = new System.Windows.Forms.Button();
            this.labelActive = new System.Windows.Forms.Label();
            this.buttonKeyInput = new System.Windows.Forms.Button();
            this.labeKeyBind = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.checkBoxAlarm = new System.Windows.Forms.CheckBox();
            this.textBoxInputTimer = new System.Windows.Forms.TextBox();
            this.labelInputTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonActive
            // 
            this.buttonActive.BackColor = System.Drawing.Color.Transparent;
            this.buttonActive.BackgroundImage = global::ArtaleHelper.Properties.Resources.imageButton;
            this.buttonActive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonActive.FlatAppearance.BorderSize = 0;
            this.buttonActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActive.Location = new System.Drawing.Point(248, 150);
            this.buttonActive.Name = "buttonActive";
            this.buttonActive.Size = new System.Drawing.Size(85, 40);
            this.buttonActive.TabIndex = 0;
            this.buttonActive.TabStop = false;
            this.buttonActive.UseVisualStyleBackColor = false;
            this.buttonActive.Click += new System.EventHandler(this.buttonActive_Click);
            // 
            // labelActive
            // 
            this.labelActive.AutoSize = true;
            this.labelActive.BackColor = System.Drawing.Color.Transparent;
            this.labelActive.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelActive.Location = new System.Drawing.Point(142, 164);
            this.labelActive.Name = "labelActive";
            this.labelActive.Size = new System.Drawing.Size(100, 12);
            this.labelActive.TabIndex = 1;
            this.labelActive.Text = "상단 고정 : False";
            // 
            // buttonKeyInput
            // 
            this.buttonKeyInput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonKeyInput.FlatAppearance.BorderSize = 0;
            this.buttonKeyInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKeyInput.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonKeyInput.Location = new System.Drawing.Point(248, 51);
            this.buttonKeyInput.Name = "buttonKeyInput";
            this.buttonKeyInput.Size = new System.Drawing.Size(75, 38);
            this.buttonKeyInput.TabIndex = 2;
            this.buttonKeyInput.TabStop = false;
            this.buttonKeyInput.Text = "None";
            this.buttonKeyInput.UseVisualStyleBackColor = false;
            this.buttonKeyInput.Click += new System.EventHandler(this.buttonKeyInput_Click);
            // 
            // labeKeyBind
            // 
            this.labeKeyBind.AutoSize = true;
            this.labeKeyBind.BackColor = System.Drawing.Color.Transparent;
            this.labeKeyBind.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labeKeyBind.Location = new System.Drawing.Point(265, 36);
            this.labeKeyBind.Name = "labeKeyBind";
            this.labeKeyBind.Size = new System.Drawing.Size(41, 12);
            this.labeKeyBind.TabIndex = 3;
            this.labeKeyBind.Text = "키설정";
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.BackColor = System.Drawing.Color.Transparent;
            this.labelTimer.Font = new System.Drawing.Font("맑은 고딕", 36F, System.Drawing.FontStyle.Bold);
            this.labelTimer.Location = new System.Drawing.Point(12, 34);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(153, 65);
            this.labelTimer.TabIndex = 4;
            this.labelTimer.Text = "00:00";
            // 
            // checkBoxAlarm
            // 
            this.checkBoxAlarm.AutoSize = true;
            this.checkBoxAlarm.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAlarm.Checked = true;
            this.checkBoxAlarm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAlarm.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBoxAlarm.Location = new System.Drawing.Point(255, 104);
            this.checkBoxAlarm.Name = "checkBoxAlarm";
            this.checkBoxAlarm.Size = new System.Drawing.Size(60, 16);
            this.checkBoxAlarm.TabIndex = 6;
            this.checkBoxAlarm.Text = "알림음";
            this.checkBoxAlarm.UseVisualStyleBackColor = false;
            // 
            // textBoxInputTimer
            // 
            this.textBoxInputTimer.Location = new System.Drawing.Point(120, 104);
            this.textBoxInputTimer.Name = "textBoxInputTimer";
            this.textBoxInputTimer.Size = new System.Drawing.Size(35, 21);
            this.textBoxInputTimer.TabIndex = 7;
            this.textBoxInputTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelInputTime
            // 
            this.labelInputTime.AutoSize = true;
            this.labelInputTime.BackColor = System.Drawing.Color.Transparent;
            this.labelInputTime.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelInputTime.Location = new System.Drawing.Point(27, 108);
            this.labelInputTime.Name = "labelInputTime";
            this.labelInputTime.Size = new System.Drawing.Size(87, 12);
            this.labelInputTime.TabIndex = 8;
            this.labelInputTime.Text = "타이머설정(초)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ArtaleHelper.Properties.Resources.imageBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(344, 201);
            this.Controls.Add(this.labelInputTime);
            this.Controls.Add(this.textBoxInputTimer);
            this.Controls.Add(this.checkBoxAlarm);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.labeKeyBind);
            this.Controls.Add(this.buttonKeyInput);
            this.Controls.Add(this.labelActive);
            this.Controls.Add(this.buttonActive);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "장판타이머";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonActive;
        private System.Windows.Forms.Label labelActive;
        private System.Windows.Forms.Button buttonKeyInput;
        private System.Windows.Forms.Label labeKeyBind;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.CheckBox checkBoxAlarm;
        private System.Windows.Forms.TextBox textBoxInputTimer;
        private System.Windows.Forms.Label labelInputTime;
    }
}

