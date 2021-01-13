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
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 142);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 24);
            this.textBox1.TabIndex = 2;
            // 
            // FormUrls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
    }
}
