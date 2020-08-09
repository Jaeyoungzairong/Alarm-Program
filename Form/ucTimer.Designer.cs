namespace AlarmProgram
{
    partial class ucTimer
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
            this.lbTime = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("HY강B", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbTime.ForeColor = System.Drawing.SystemColors.Window;
            this.lbTime.Location = new System.Drawing.Point(3, 85);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(247, 60);
            this.lbTime.TabIndex = 3;
            this.lbTime.Text = "00:00:00";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("HY강B", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbDate.ForeColor = System.Drawing.SystemColors.Window;
            this.lbDate.Location = new System.Drawing.Point(3, 10);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(412, 60);
            this.lbDate.TabIndex = 2;
            this.lbDate.Text = "1월 1일 Sunday";
            // 
            // ucTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbDate);
            this.Name = "ucTimer";
            this.Size = new System.Drawing.Size(520, 160);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lbDate;
        public System.Windows.Forms.Label lbTime;
    }
}
