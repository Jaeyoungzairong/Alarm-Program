namespace AlarmProgram
{
    partial class ucConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucConfig));
            this.lvConfig = new System.Windows.Forms.ListView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbModify = new System.Windows.Forms.Label();
            this.lbAdd = new System.Windows.Forms.Label();
            this.lbDelete = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvConfig
            // 
            this.lvConfig.BackColor = System.Drawing.SystemColors.Window;
            this.lvConfig.Font = new System.Drawing.Font("HY강B", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lvConfig.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lvConfig.FullRowSelect = true;
            this.lvConfig.GridLines = true;
            this.lvConfig.HideSelection = false;
            this.lvConfig.Location = new System.Drawing.Point(3, 3);
            this.lvConfig.MultiSelect = false;
            this.lvConfig.Name = "lvConfig";
            this.lvConfig.Size = new System.Drawing.Size(514, 250);
            this.lvConfig.TabIndex = 1;
            this.lvConfig.UseCompatibleStateImageBehavior = false;
            this.lvConfig.View = System.Windows.Forms.View.Details;
            this.lvConfig.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LvConfig_KeyDown);
            this.lvConfig.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LvConfig_MouseClick);
            this.lvConfig.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LvConfig_MouseDoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.lbModify, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbAdd, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbDelete, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 263);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(514, 50);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lbModify
            // 
            this.lbModify.BackColor = System.Drawing.SystemColors.WindowText;
            this.lbModify.Image = global::AlarmProgram.Properties.Resources.icon_22;
            this.lbModify.Location = new System.Drawing.Point(345, 2);
            this.lbModify.Name = "lbModify";
            this.lbModify.Size = new System.Drawing.Size(163, 46);
            this.lbModify.TabIndex = 18;
            this.lbModify.Click += new System.EventHandler(this.LbModify_Click);
            // 
            // lbAdd
            // 
            this.lbAdd.BackColor = System.Drawing.SystemColors.WindowText;
            this.lbAdd.Font = new System.Drawing.Font("HY강B", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbAdd.ForeColor = System.Drawing.Color.White;
            this.lbAdd.Image = ((System.Drawing.Image)(resources.GetObject("lbAdd.Image")));
            this.lbAdd.Location = new System.Drawing.Point(5, 2);
            this.lbAdd.Name = "lbAdd";
            this.lbAdd.Size = new System.Drawing.Size(162, 46);
            this.lbAdd.TabIndex = 16;
            this.lbAdd.Click += new System.EventHandler(this.LbAdd_Click);
            // 
            // lbDelete
            // 
            this.lbDelete.BackColor = System.Drawing.SystemColors.WindowText;
            this.lbDelete.Image = ((System.Drawing.Image)(resources.GetObject("lbDelete.Image")));
            this.lbDelete.Location = new System.Drawing.Point(175, 2);
            this.lbDelete.Name = "lbDelete";
            this.lbDelete.Size = new System.Drawing.Size(162, 46);
            this.lbDelete.TabIndex = 17;
            this.lbDelete.Click += new System.EventHandler(this.LbDelete_Click);
            // 
            // ucConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lvConfig);
            this.Name = "ucConfig";
            this.Size = new System.Drawing.Size(520, 380);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvConfig;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbModify;
        private System.Windows.Forms.Label lbAdd;
        private System.Windows.Forms.Label lbDelete;
    }
}
