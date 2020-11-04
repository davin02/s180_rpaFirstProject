namespace Raspberry_Arduino_LED
{
    partial class MainForm
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
            this.TestTextBox = new System.Windows.Forms.RichTextBox();
            this.REDon = new System.Windows.Forms.Button();
            this.REDoff = new System.Windows.Forms.Button();
            this.GREENon = new System.Windows.Forms.Button();
            this.GREENoff = new System.Windows.Forms.Button();
            this.BLUEon = new System.Windows.Forms.Button();
            this.BLUEoff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TestTextBox
            // 
            this.TestTextBox.EnableAutoDragDrop = true;
            this.TestTextBox.Location = new System.Drawing.Point(262, 29);
            this.TestTextBox.Name = "TestTextBox";
            this.TestTextBox.ReadOnly = true;
            this.TestTextBox.Size = new System.Drawing.Size(300, 300);
            this.TestTextBox.TabIndex = 1;
            this.TestTextBox.Text = "";
            this.TestTextBox.UseWaitCursor = true;
            // 
            // REDon
            // 
            this.REDon.Location = new System.Drawing.Point(37, 61);
            this.REDon.Name = "REDon";
            this.REDon.Size = new System.Drawing.Size(75, 23);
            this.REDon.TabIndex = 2;
            this.REDon.Text = "RED ON";
            this.REDon.UseVisualStyleBackColor = true;
            this.REDon.Click += new System.EventHandler(this.RED_ON);
            // 
            // REDoff
            // 
            this.REDoff.Location = new System.Drawing.Point(143, 61);
            this.REDoff.Name = "REDoff";
            this.REDoff.Size = new System.Drawing.Size(75, 23);
            this.REDoff.TabIndex = 3;
            this.REDoff.Text = "RED OFF";
            this.REDoff.UseVisualStyleBackColor = true;
            this.REDoff.Click += new System.EventHandler(this.RED_OFF);
            // 
            // GREENon
            // 
            this.GREENon.Location = new System.Drawing.Point(21, 133);
            this.GREENon.Name = "GREENon";
            this.GREENon.Size = new System.Drawing.Size(91, 23);
            this.GREENon.TabIndex = 4;
            this.GREENon.Text = "GREEN ON";
            this.GREENon.UseVisualStyleBackColor = true;
            this.GREENon.Click += new System.EventHandler(this.GREEN_ON);
            // 
            // GREENoff
            // 
            this.GREENoff.Location = new System.Drawing.Point(143, 133);
            this.GREENoff.Name = "GREENoff";
            this.GREENoff.Size = new System.Drawing.Size(96, 23);
            this.GREENoff.TabIndex = 5;
            this.GREENoff.Text = "GREEN OFF";
            this.GREENoff.UseVisualStyleBackColor = true;
            this.GREENoff.Click += new System.EventHandler(this.GREEN_OFF);
            // 
            // BLUEon
            // 
            this.BLUEon.Location = new System.Drawing.Point(37, 209);
            this.BLUEon.Name = "BLUEon";
            this.BLUEon.Size = new System.Drawing.Size(75, 23);
            this.BLUEon.TabIndex = 6;
            this.BLUEon.Text = "BLUE ON";
            this.BLUEon.UseVisualStyleBackColor = true;
            this.BLUEon.Click += new System.EventHandler(this.BLUE_ON);
            // 
            // BLUEoff
            // 
            this.BLUEoff.Location = new System.Drawing.Point(143, 209);
            this.BLUEoff.Name = "BLUEoff";
            this.BLUEoff.Size = new System.Drawing.Size(75, 23);
            this.BLUEoff.TabIndex = 7;
            this.BLUEoff.Text = "BLUE OFF";
            this.BLUEoff.UseVisualStyleBackColor = true;
            this.BLUEoff.Click += new System.EventHandler(this.BLUE_OFF);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.BLUEoff);
            this.Controls.Add(this.BLUEon);
            this.Controls.Add(this.GREENoff);
            this.Controls.Add(this.GREENon);
            this.Controls.Add(this.REDoff);
            this.Controls.Add(this.REDon);
            this.Controls.Add(this.TestTextBox);
            this.Name = "MainForm";
            this.Text = "TCP/IP 통신 LED";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox TestTextBox;
        private System.Windows.Forms.Button REDoff;
        private System.Windows.Forms.Button REDon;
        private System.Windows.Forms.Button GREENon;
        private System.Windows.Forms.Button GREENoff;
        private System.Windows.Forms.Button BLUEon;
        private System.Windows.Forms.Button BLUEoff;
    }
}

