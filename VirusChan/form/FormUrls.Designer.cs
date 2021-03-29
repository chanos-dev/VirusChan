namespace VirusChan.form
{
    partial class FormUrls
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
            this.pb_files = new System.Windows.Forms.PictureBox();
            this.txt_Urls = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.lb_msg = new System.Windows.Forms.Label();
            this.btn_detail = new System.Windows.Forms.Button();
            this.lb_scanDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_files)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_files
            // 
            this.pb_files.Image = global::VirusChan.Properties.Resources.urls;
            this.pb_files.Location = new System.Drawing.Point(126, 22);
            this.pb_files.Name = "pb_files";
            this.pb_files.Size = new System.Drawing.Size(100, 100);
            this.pb_files.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_files.TabIndex = 1;
            this.pb_files.TabStop = false;
            // 
            // txt_Urls
            // 
            this.txt_Urls.Location = new System.Drawing.Point(14, 142);
            this.txt_Urls.Name = "txt_Urls";
            this.txt_Urls.Size = new System.Drawing.Size(320, 24);
            this.txt_Urls.TabIndex = 2;
            // 
            // btn_start
            // 
            this.btn_start.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(130)))), ((int)(((byte)(242)))));
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.btn_start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(130)))), ((int)(((byte)(242)))));
            this.btn_start.Location = new System.Drawing.Point(14, 313);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(320, 27);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "스캔 시작";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // lb_msg
            // 
            this.lb_msg.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.lb_msg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(130)))), ((int)(((byte)(242)))));
            this.lb_msg.Location = new System.Drawing.Point(14, 173);
            this.lb_msg.Name = "lb_msg";
            this.lb_msg.Size = new System.Drawing.Size(320, 47);
            this.lb_msg.TabIndex = 4;
            this.lb_msg.Text = "Scan Result";
            this.lb_msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_detail
            // 
            this.btn_detail.Enabled = false;
            this.btn_detail.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(130)))), ((int)(((byte)(242)))));
            this.btn_detail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_detail.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.btn_detail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(130)))), ((int)(((byte)(242)))));
            this.btn_detail.Location = new System.Drawing.Point(124, 273);
            this.btn_detail.Name = "btn_detail";
            this.btn_detail.Size = new System.Drawing.Size(100, 27);
            this.btn_detail.TabIndex = 5;
            this.btn_detail.Text = "자세히 보기";
            this.btn_detail.UseVisualStyleBackColor = true;
            this.btn_detail.Click += new System.EventHandler(this.btn_detail_Click);
            // 
            // lb_scanDate
            // 
            this.lb_scanDate.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.lb_scanDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(130)))), ((int)(((byte)(242)))));
            this.lb_scanDate.Location = new System.Drawing.Point(14, 232);
            this.lb_scanDate.Name = "lb_scanDate";
            this.lb_scanDate.Size = new System.Drawing.Size(320, 29);
            this.lb_scanDate.TabIndex = 6;
            this.lb_scanDate.Text = "Scan Date";
            this.lb_scanDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormUrls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_scanDate);
            this.Controls.Add(this.btn_detail);
            this.Controls.Add(this.lb_msg);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.txt_Urls);
            this.Controls.Add(this.pb_files);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormUrls";
            this.Size = new System.Drawing.Size(350, 348);
            ((System.ComponentModel.ISupportInitialize)(this.pb_files)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_files;
        private System.Windows.Forms.TextBox txt_Urls;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lb_msg;
        private System.Windows.Forms.Button btn_detail;
        private System.Windows.Forms.Label lb_scanDate;
    }
}
