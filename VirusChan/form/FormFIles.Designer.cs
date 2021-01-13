namespace VirusChan.form
{
    partial class FormFiles
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
            this.panel_main = new System.Windows.Forms.Panel();
            this.btn_start = new System.Windows.Forms.Button();
            this.FileListView = new BrightIdeasSoftware.ObjectListView();
            this.pb_files = new System.Windows.Forms.PictureBox();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_files)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.AllowDrop = true;
            this.panel_main.Controls.Add(this.btn_start);
            this.panel_main.Controls.Add(this.FileListView);
            this.panel_main.Controls.Add(this.pb_files);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(350, 348);
            this.panel_main.TabIndex = 0;
            this.panel_main.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_main_DragDrop);
            this.panel_main.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_main_DragEnter);
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
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "스캔 시작";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // FileListView
            // 
            this.FileListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(130)))), ((int)(((byte)(242)))));
            this.FileListView.HideSelection = false;
            this.FileListView.Location = new System.Drawing.Point(14, 141);
            this.FileListView.Name = "FileListView";
            this.FileListView.Size = new System.Drawing.Size(320, 166);
            this.FileListView.TabIndex = 1;
            this.FileListView.UseCompatibleStateImageBehavior = false;
            this.FileListView.View = System.Windows.Forms.View.Details;
            this.FileListView.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.FileListView_FormatRow);
            this.FileListView.DoubleClick += new System.EventHandler(this.FileListView_DoubleClick);
            // 
            // pb_files
            // 
            this.pb_files.Image = global::VirusChan.Properties.Resources.files;
            this.pb_files.Location = new System.Drawing.Point(133, 22);
            this.pb_files.Name = "pb_files";
            this.pb_files.Size = new System.Drawing.Size(85, 100);
            this.pb_files.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_files.TabIndex = 0;
            this.pb_files.TabStop = false;
            // 
            // FormFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_main);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormFiles";
            this.Size = new System.Drawing.Size(350, 348);
            this.panel_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FileListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_files)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.PictureBox pb_files;
        private BrightIdeasSoftware.ObjectListView FileListView;
        private System.Windows.Forms.Button btn_start;
    }
}
