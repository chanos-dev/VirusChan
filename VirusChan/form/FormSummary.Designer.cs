namespace VirusChan.form
{
    partial class FormSummary
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
            this.pnl_Undetected = new System.Windows.Forms.Panel();
            this.lb_sha256 = new System.Windows.Forms.Label();
            this.lb_fileInfo = new System.Windows.Forms.Label();
            this.lb_scanDate = new System.Windows.Forms.Label();
            this.lb_count = new System.Windows.Forms.Label();
            this.pnl_Detected = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnl_Undetected
            // 
            this.pnl_Undetected.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnl_Undetected.Location = new System.Drawing.Point(3, 176);
            this.pnl_Undetected.Name = "pnl_Undetected";
            this.pnl_Undetected.Size = new System.Drawing.Size(579, 20);
            this.pnl_Undetected.TabIndex = 0;
            // 
            // lb_sha256
            // 
            this.lb_sha256.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.lb_sha256.Location = new System.Drawing.Point(3, 210);
            this.lb_sha256.Name = "lb_sha256";
            this.lb_sha256.Size = new System.Drawing.Size(579, 44);
            this.lb_sha256.TabIndex = 1;
            this.lb_sha256.Text = "sha256";
            this.lb_sha256.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_fileInfo
            // 
            this.lb_fileInfo.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.lb_fileInfo.Location = new System.Drawing.Point(3, 265);
            this.lb_fileInfo.Name = "lb_fileInfo";
            this.lb_fileInfo.Size = new System.Drawing.Size(579, 25);
            this.lb_fileInfo.TabIndex = 2;
            this.lb_fileInfo.Text = "file_name";
            this.lb_fileInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_scanDate
            // 
            this.lb_scanDate.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.lb_scanDate.Location = new System.Drawing.Point(3, 303);
            this.lb_scanDate.Name = "lb_scanDate";
            this.lb_scanDate.Size = new System.Drawing.Size(579, 25);
            this.lb_scanDate.TabIndex = 3;
            this.lb_scanDate.Text = "scan date";
            this.lb_scanDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_count
            // 
            this.lb_count.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.lb_count.Location = new System.Drawing.Point(251, 87);
            this.lb_count.Name = "lb_count";
            this.lb_count.Size = new System.Drawing.Size(80, 20);
            this.lb_count.TabIndex = 4;
            this.lb_count.Text = "000 / 600";
            this.lb_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_Detected
            // 
            this.pnl_Detected.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnl_Detected.Location = new System.Drawing.Point(3, 162);
            this.pnl_Detected.Name = "pnl_Detected";
            this.pnl_Detected.Size = new System.Drawing.Size(259, 20);
            this.pnl_Detected.TabIndex = 5;
            // 
            // FormSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_Detected);
            this.Controls.Add(this.lb_count);
            this.Controls.Add(this.lb_scanDate);
            this.Controls.Add(this.lb_fileInfo);
            this.Controls.Add(this.lb_sha256);
            this.Controls.Add(this.pnl_Undetected);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(130)))), ((int)(((byte)(242)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormSummary";
            this.Size = new System.Drawing.Size(585, 345);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormSummary_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Undetected;
        private System.Windows.Forms.Label lb_sha256;
        private System.Windows.Forms.Label lb_fileInfo;
        private System.Windows.Forms.Label lb_scanDate;
        private System.Windows.Forms.Label lb_count;
        private System.Windows.Forms.Panel pnl_Detected;
    }
}
