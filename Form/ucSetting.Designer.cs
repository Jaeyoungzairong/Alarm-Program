namespace AlarmProgram
{
    partial class ucSetting
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSetting));
            this.udHour = new System.Windows.Forms.NumericUpDown();
            this.udMinute = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAM = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbMusicPlay = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMusic = new System.Windows.Forms.ComboBox();
            this.tbMusicPath = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbSave = new System.Windows.Forms.Label();
            this.lbCancel = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.cbAlarmON = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDurationTime = new System.Windows.Forms.ComboBox();
            this.lbLoadMusic = new System.Windows.Forms.Label();
            this.lbDataInit = new System.Windows.Forms.Label();
            this.LayoutAdminMode = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.udHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMinute)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.LayoutAdminMode.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // udHour
            // 
            this.udHour.BackColor = System.Drawing.Color.Black;
            this.udHour.Font = new System.Drawing.Font("HY강B", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.udHour.ForeColor = System.Drawing.Color.White;
            this.udHour.Location = new System.Drawing.Point(211, 4);
            this.udHour.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.udHour.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udHour.Name = "udHour";
            this.udHour.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.udHour.Size = new System.Drawing.Size(146, 45);
            this.udHour.TabIndex = 5;
            this.udHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udHour.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // udMinute
            // 
            this.udMinute.BackColor = System.Drawing.Color.Black;
            this.udMinute.Font = new System.Drawing.Font("HY강B", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.udMinute.ForeColor = System.Drawing.Color.White;
            this.udMinute.Location = new System.Drawing.Point(364, 4);
            this.udMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.udMinute.Name = "udMinute";
            this.udMinute.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.udMinute.Size = new System.Drawing.Size(146, 45);
            this.udMinute.TabIndex = 6;
            this.udMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.udHour, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.udMinute, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbAM, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(514, 50);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("HY강B", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(6, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 48);
            this.label1.TabIndex = 7;
            this.label1.Text = "TIME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbAM
            // 
            this.cbAM.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbAM.BackColor = System.Drawing.Color.DimGray;
            this.cbAM.Checked = true;
            this.cbAM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbAM.Font = new System.Drawing.Font("HY강B", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbAM.ForeColor = System.Drawing.SystemColors.Window;
            this.cbAM.Location = new System.Drawing.Point(109, 4);
            this.cbAM.Name = "cbAM";
            this.cbAM.Size = new System.Drawing.Size(95, 42);
            this.cbAM.TabIndex = 9;
            this.cbAM.Text = "AM";
            this.cbAM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbAM.UseVisualStyleBackColor = false;
            this.cbAM.CheckedChanged += new System.EventHandler(this.CbAM_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("HY강B", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(4, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 48);
            this.label2.TabIndex = 8;
            this.label2.Text = "ALARM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.lbMusicPlay, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbMusic, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 185);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(514, 50);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // lbMusicPlay
            // 
            this.lbMusicPlay.BackColor = System.Drawing.SystemColors.WindowText;
            this.lbMusicPlay.Image = ((System.Drawing.Image)(resources.GetObject("lbMusicPlay.Image")));
            this.lbMusicPlay.Location = new System.Drawing.Point(439, 1);
            this.lbMusicPlay.Name = "lbMusicPlay";
            this.lbMusicPlay.Size = new System.Drawing.Size(71, 48);
            this.lbMusicPlay.TabIndex = 16;
            this.lbMusicPlay.Click += new System.EventHandler(this.LbMusicPlay_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("HY강B", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(4, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 48);
            this.label3.TabIndex = 9;
            this.label3.Text = "MUSIC";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbMusic
            // 
            this.cbMusic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbMusic.BackColor = System.Drawing.Color.Black;
            this.cbMusic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbMusic.Font = new System.Drawing.Font("HY강M", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbMusic.ForeColor = System.Drawing.SystemColors.Window;
            this.cbMusic.FormattingEnabled = true;
            this.cbMusic.Location = new System.Drawing.Point(107, 7);
            this.cbMusic.Name = "cbMusic";
            this.cbMusic.Size = new System.Drawing.Size(325, 36);
            this.cbMusic.TabIndex = 15;
            this.cbMusic.SelectedIndexChanged += new System.EventHandler(this.CbMusic_SelectedIndexChanged);
            // 
            // tbMusicPath
            // 
            this.tbMusicPath.BackColor = System.Drawing.SystemColors.WindowText;
            this.tbMusicPath.Font = new System.Drawing.Font("HY강B", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbMusicPath.ForeColor = System.Drawing.SystemColors.Window;
            this.tbMusicPath.Location = new System.Drawing.Point(4, 4);
            this.tbMusicPath.Name = "tbMusicPath";
            this.tbMusicPath.ReadOnly = true;
            this.tbMusicPath.Size = new System.Drawing.Size(227, 92);
            this.tbMusicPath.TabIndex = 13;
            this.tbMusicPath.Text = "";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.lbTitle, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(514, 40);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("HY강B", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.lbTitle.Location = new System.Drawing.Point(3, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(508, 40);
            this.lbTitle.TabIndex = 8;
            this.lbTitle.Text = "ALARM SETTING";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSave
            // 
            this.lbSave.BackColor = System.Drawing.SystemColors.WindowText;
            this.lbSave.Image = global::AlarmProgram.Properties.Resources.icon_2;
            this.lbSave.Location = new System.Drawing.Point(6, 3);
            this.lbSave.Name = "lbSave";
            this.lbSave.Size = new System.Drawing.Size(69, 44);
            this.lbSave.TabIndex = 15;
            this.lbSave.Click += new System.EventHandler(this.LbSave_Click);
            // 
            // lbCancel
            // 
            this.lbCancel.BackColor = System.Drawing.SystemColors.WindowText;
            this.lbCancel.Image = global::AlarmProgram.Properties.Resources.icon_24;
            this.lbCancel.Location = new System.Drawing.Point(84, 3);
            this.lbCancel.Name = "lbCancel";
            this.lbCancel.Size = new System.Drawing.Size(65, 44);
            this.lbCancel.TabIndex = 17;
            this.lbCancel.Click += new System.EventHandler(this.LbCancel_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.cbAlarmON, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.cbDurationTime, 3, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 120);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(514, 50);
            this.tableLayoutPanel4.TabIndex = 11;
            // 
            // cbAlarmON
            // 
            this.cbAlarmON.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbAlarmON.BackColor = System.Drawing.Color.DimGray;
            this.cbAlarmON.Checked = true;
            this.cbAlarmON.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAlarmON.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbAlarmON.Font = new System.Drawing.Font("HY강B", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbAlarmON.ForeColor = System.Drawing.SystemColors.Window;
            this.cbAlarmON.Location = new System.Drawing.Point(106, 4);
            this.cbAlarmON.Name = "cbAlarmON";
            this.cbAlarmON.Size = new System.Drawing.Size(95, 42);
            this.cbAlarmON.TabIndex = 13;
            this.cbAlarmON.Text = "ON";
            this.cbAlarmON.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbAlarmON.UseVisualStyleBackColor = false;
            this.cbAlarmON.CheckedChanged += new System.EventHandler(this.CbAlarmON_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("HY강B", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(208, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 48);
            this.label4.TabIndex = 15;
            this.label4.Text = "ALARM DURATION";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbDurationTime
            // 
            this.cbDurationTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbDurationTime.BackColor = System.Drawing.Color.Black;
            this.cbDurationTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDurationTime.Font = new System.Drawing.Font("HY강M", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbDurationTime.ForeColor = System.Drawing.SystemColors.Window;
            this.cbDurationTime.FormattingEnabled = true;
            this.cbDurationTime.IntegralHeight = false;
            this.cbDurationTime.Location = new System.Drawing.Point(387, 7);
            this.cbDurationTime.Name = "cbDurationTime";
            this.cbDurationTime.Size = new System.Drawing.Size(123, 36);
            this.cbDurationTime.TabIndex = 19;
            this.cbDurationTime.SelectedIndexChanged += new System.EventHandler(this.CbDurationTime_SelectedIndexChanged);
            // 
            // lbLoadMusic
            // 
            this.lbLoadMusic.BackColor = System.Drawing.Color.Black;
            this.lbLoadMusic.Image = global::AlarmProgram.Properties.Resources.icon_26;
            this.lbLoadMusic.Location = new System.Drawing.Point(238, 1);
            this.lbLoadMusic.Name = "lbLoadMusic";
            this.lbLoadMusic.Size = new System.Drawing.Size(44, 98);
            this.lbLoadMusic.TabIndex = 12;
            this.lbLoadMusic.Click += new System.EventHandler(this.LbLoadMusic_Click);
            // 
            // lbDataInit
            // 
            this.lbDataInit.BackColor = System.Drawing.Color.Black;
            this.lbDataInit.Image = global::AlarmProgram.Properties.Resources.motor_reset;
            this.lbDataInit.Location = new System.Drawing.Point(289, 1);
            this.lbDataInit.Name = "lbDataInit";
            this.lbDataInit.Size = new System.Drawing.Size(45, 98);
            this.lbDataInit.TabIndex = 9;
            this.lbDataInit.Click += new System.EventHandler(this.LbDataInit_Click);
            // 
            // LayoutAdminMode
            // 
            this.LayoutAdminMode.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.LayoutAdminMode.ColumnCount = 3;
            this.LayoutAdminMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.LayoutAdminMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.LayoutAdminMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.LayoutAdminMode.Controls.Add(this.lbDataInit, 2, 0);
            this.LayoutAdminMode.Controls.Add(this.lbLoadMusic, 1, 0);
            this.LayoutAdminMode.Controls.Add(this.tbMusicPath, 0, 0);
            this.LayoutAdminMode.Location = new System.Drawing.Point(3, 250);
            this.LayoutAdminMode.Name = "LayoutAdminMode";
            this.LayoutAdminMode.RowCount = 1;
            this.LayoutAdminMode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutAdminMode.Size = new System.Drawing.Size(338, 100);
            this.LayoutAdminMode.TabIndex = 14;
            this.LayoutAdminMode.Visible = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.lbSave, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lbCancel, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(357, 250);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(160, 50);
            this.tableLayoutPanel5.TabIndex = 18;
            // 
            // ucSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.LayoutAdminMode);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucSetting";
            this.Size = new System.Drawing.Size(520, 380);
            this.VisibleChanged += new System.EventHandler(this.UcSetting_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.udHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMinute)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.LayoutAdminMode.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown udHour;
        private System.Windows.Forms.NumericUpDown udMinute;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbMusicPlay;
        private System.Windows.Forms.RichTextBox tbMusicPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSave;
        private System.Windows.Forms.Label lbCancel;
        private System.Windows.Forms.Label lbDataInit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.CheckBox cbAM;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.CheckBox cbAlarmON;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbLoadMusic;
        private System.Windows.Forms.TableLayoutPanel LayoutAdminMode;
        private System.Windows.Forms.ComboBox cbMusic;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ComboBox cbDurationTime;
    }
}
