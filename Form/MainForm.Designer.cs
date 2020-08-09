namespace AlarmProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ucTimer1 = new AlarmProgram.ucTimer();
            this.ucAlarm1 = new AlarmProgram.ucAlarm();
            this.ucSetting1 = new AlarmProgram.ucSetting();
            this.ucConfig1 = new AlarmProgram.ucConfig();
            this.lbMinimum = new System.Windows.Forms.Label();
            this.lbMaximun = new System.Windows.Forms.Label();
            this.MainLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayoutPanel
            // 
            this.MainLayoutPanel.BackColor = System.Drawing.Color.Black;
            this.MainLayoutPanel.ColumnCount = 1;
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 525F));
            this.MainLayoutPanel.Controls.Add(this.ucTimer1, 0, 0);
            this.MainLayoutPanel.Controls.Add(this.ucAlarm1, 1, 0);
            this.MainLayoutPanel.Controls.Add(this.ucSetting1, 1, 0);
            this.MainLayoutPanel.Controls.Add(this.ucConfig1, 1, 0);
            this.MainLayoutPanel.Location = new System.Drawing.Point(0, -1);
            this.MainLayoutPanel.Name = "MainLayoutPanel";
            this.MainLayoutPanel.RowCount = 2;
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 380F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayoutPanel.Size = new System.Drawing.Size(525, 540);
            this.MainLayoutPanel.TabIndex = 0;
            // 
            // ucTimer1
            // 
            this.ucTimer1.BackColor = System.Drawing.Color.Black;
            this.ucTimer1.Location = new System.Drawing.Point(3, 3);
            this.ucTimer1.Name = "ucTimer1";
            this.ucTimer1.Size = new System.Drawing.Size(519, 154);
            this.ucTimer1.TabIndex = 0;
            // 
            // ucAlarm1
            // 
            this.ucAlarm1.BackColor = System.Drawing.Color.Black;
            this.ucAlarm1.Location = new System.Drawing.Point(3, 163);
            this.ucAlarm1.Name = "ucAlarm1";
            this.ucAlarm1.Size = new System.Drawing.Size(519, 374);
            this.ucAlarm1.TabIndex = 1;
            // 
            // ucSetting1
            // 
            this.ucSetting1.BackColor = System.Drawing.Color.Black;
            this.ucSetting1.Location = new System.Drawing.Point(3, 163);
            this.ucSetting1.Name = "ucSetting1";
            this.ucSetting1.Size = new System.Drawing.Size(519, 374);
            this.ucSetting1.TabIndex = 2;
            // 
            // ucConfig1
            // 
            this.ucConfig1.BackColor = System.Drawing.Color.Black;
            this.ucConfig1.Location = new System.Drawing.Point(3, 163);
            this.ucConfig1.Name = "ucConfig1";
            this.ucConfig1.Size = new System.Drawing.Size(519, 374);
            this.ucConfig1.TabIndex = 0;
            // 
            // lbMinimum
            // 
            this.lbMinimum.BackColor = System.Drawing.Color.Black;
            this.lbMinimum.Image = global::AlarmProgram.Properties.Resources.motor_jog_yp;
            this.lbMinimum.Location = new System.Drawing.Point(485, 510);
            this.lbMinimum.Name = "lbMinimum";
            this.lbMinimum.Size = new System.Drawing.Size(30, 20);
            this.lbMinimum.TabIndex = 2;
            this.lbMinimum.Click += new System.EventHandler(this.LbMinimum_Click);
            // 
            // lbMaximun
            // 
            this.lbMaximun.BackColor = System.Drawing.Color.Black;
            this.lbMaximun.Image = global::AlarmProgram.Properties.Resources.motor_jog_ym;
            this.lbMaximun.Location = new System.Drawing.Point(485, 130);
            this.lbMaximun.Name = "lbMaximun";
            this.lbMaximun.Size = new System.Drawing.Size(30, 20);
            this.lbMaximun.TabIndex = 1;
            this.lbMaximun.Click += new System.EventHandler(this.LbMaximun_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(524, 542);
            this.Controls.Add(this.lbMinimum);
            this.Controls.Add(this.lbMaximun);
            this.Controls.Add(this.MainLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "AlarmProgram_4.0ver";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MainLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ucConfig ucConfig1;
        private ucTimer ucTimer1;
        private ucSetting ucSetting1;
        private ucAlarm ucAlarm1;
        private System.Windows.Forms.TableLayoutPanel MainLayoutPanel;
        private System.Windows.Forms.Label lbMaximun;
        private System.Windows.Forms.Label lbMinimum;
    }
}

