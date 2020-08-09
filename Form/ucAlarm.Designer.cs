namespace AlarmProgram
{
    partial class ucAlarm
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
            this.btnAlarmOff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlarmOff
            // 
            this.btnAlarmOff.BackColor = System.Drawing.Color.Black;
            this.btnAlarmOff.Image = global::AlarmProgram.Properties.Resources.motor_servo_off;
            this.btnAlarmOff.Location = new System.Drawing.Point(210, 175);
            this.btnAlarmOff.Name = "btnAlarmOff";
            this.btnAlarmOff.Size = new System.Drawing.Size(100, 50);
            this.btnAlarmOff.TabIndex = 0;
            this.btnAlarmOff.UseVisualStyleBackColor = false;
            this.btnAlarmOff.Click += new System.EventHandler(this.BtnAlarmOff_Click);
            // 
            // ucAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btnAlarmOff);
            this.Name = "ucAlarm";
            this.Size = new System.Drawing.Size(520, 380);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlarmOff;
    }
}
