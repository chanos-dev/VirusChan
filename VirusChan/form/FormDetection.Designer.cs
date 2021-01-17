namespace VirusChan.form
{
    partial class FormDetection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetection));
            this.DetectionListView = new BrightIdeasSoftware.ObjectListView();
            this.pb_process = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DetectionListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_process)).BeginInit();
            this.SuspendLayout();
            // 
            // DetectionListView
            // 
            this.DetectionListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetectionListView.HideSelection = false;
            this.DetectionListView.Location = new System.Drawing.Point(0, 0);
            this.DetectionListView.Name = "DetectionListView";
            this.DetectionListView.Size = new System.Drawing.Size(585, 345);
            this.DetectionListView.TabIndex = 0;
            this.DetectionListView.UseCompatibleStateImageBehavior = false;
            this.DetectionListView.View = System.Windows.Forms.View.Details;
            this.DetectionListView.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.DetectionListView_FormatCell);
            // 
            // pb_process
            // 
            this.pb_process.BackColor = System.Drawing.SystemColors.Window;
            this.pb_process.Image = ((System.Drawing.Image)(resources.GetObject("pb_process.Image")));
            this.pb_process.Location = new System.Drawing.Point(267, 147);
            this.pb_process.Name = "pb_process";
            this.pb_process.Size = new System.Drawing.Size(50, 50);
            this.pb_process.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_process.TabIndex = 4;
            this.pb_process.TabStop = false;
            // 
            // FormDetection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pb_process);
            this.Controls.Add(this.DetectionListView);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(130)))), ((int)(((byte)(242)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormDetection";
            this.Size = new System.Drawing.Size(585, 345);
            ((System.ComponentModel.ISupportInitialize)(this.DetectionListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_process)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView DetectionListView;
        private System.Windows.Forms.PictureBox pb_process;
    }
}
