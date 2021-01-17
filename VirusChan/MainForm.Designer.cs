namespace VirusChan
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_center = new System.Windows.Forms.Panel();
            this.panel_forms = new System.Windows.Forms.Panel();
            this.panel_selected = new System.Windows.Forms.Panel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_files = new System.Windows.Forms.Button();
            this.btn_urls = new System.Windows.Forms.Button();
            this.panel_top = new System.Windows.Forms.Panel();
            this.lb_title = new System.Windows.Forms.Label();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.VirusChanMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.FileScanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UrlScanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pb_title = new System.Windows.Forms.PictureBox();
            this.pb_minimum = new System.Windows.Forms.PictureBox();
            this.pb_close = new System.Windows.Forms.PictureBox();
            this.panel_main.SuspendLayout();
            this.panel_center.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            this.panel_top.SuspendLayout();
            this.VirusChanMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.panel_center);
            this.panel_main.Controls.Add(this.panel_top);
            this.panel_main.Controls.Add(this.panel_bottom);
            this.panel_main.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(350, 450);
            this.panel_main.TabIndex = 0;
            // 
            // panel_center
            // 
            this.panel_center.Controls.Add(this.panel_forms);
            this.panel_center.Controls.Add(this.panel_selected);
            this.panel_center.Controls.Add(this.flowLayoutPanel);
            this.panel_center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_center.Location = new System.Drawing.Point(0, 30);
            this.panel_center.Name = "panel_center";
            this.panel_center.Size = new System.Drawing.Size(350, 390);
            this.panel_center.TabIndex = 2;
            // 
            // panel_forms
            // 
            this.panel_forms.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_forms.Location = new System.Drawing.Point(0, 42);
            this.panel_forms.Name = "panel_forms";
            this.panel_forms.Size = new System.Drawing.Size(350, 348);
            this.panel_forms.TabIndex = 2;
            // 
            // panel_selected
            // 
            this.panel_selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(130)))), ((int)(((byte)(242)))));
            this.panel_selected.Location = new System.Drawing.Point(3, 36);
            this.panel_selected.Name = "panel_selected";
            this.panel_selected.Size = new System.Drawing.Size(165, 6);
            this.panel_selected.TabIndex = 1;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Controls.Add(this.btn_files);
            this.flowLayoutPanel.Controls.Add(this.btn_urls);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.flowLayoutPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(130)))), ((int)(((byte)(242)))));
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(350, 37);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // btn_files
            // 
            this.btn_files.BackColor = System.Drawing.SystemColors.Control;
            this.btn_files.FlatAppearance.BorderSize = 0;
            this.btn_files.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_files.Location = new System.Drawing.Point(3, 3);
            this.btn_files.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btn_files.Name = "btn_files";
            this.btn_files.Size = new System.Drawing.Size(165, 30);
            this.btn_files.TabIndex = 0;
            this.btn_files.Text = "파일";
            this.btn_files.UseVisualStyleBackColor = false;
            this.btn_files.Click += new System.EventHandler(this.btn_files_Click);
            this.btn_files.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btn_files.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btn_urls
            // 
            this.btn_urls.FlatAppearance.BorderSize = 0;
            this.btn_urls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_urls.Location = new System.Drawing.Point(181, 3);
            this.btn_urls.Name = "btn_urls";
            this.btn_urls.Size = new System.Drawing.Size(165, 30);
            this.btn_urls.TabIndex = 1;
            this.btn_urls.Text = "URL";
            this.btn_urls.UseVisualStyleBackColor = true;
            this.btn_urls.Click += new System.EventHandler(this.btn_urls_Click);
            this.btn_urls.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btn_urls.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(130)))), ((int)(((byte)(242)))));
            this.panel_top.Controls.Add(this.pb_title);
            this.panel_top.Controls.Add(this.pb_minimum);
            this.panel_top.Controls.Add(this.pb_close);
            this.panel_top.Controls.Add(this.lb_title);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.panel_top.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(350, 30);
            this.panel_top.TabIndex = 1;
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_title.Location = new System.Drawing.Point(29, 8);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(81, 15);
            this.lb_title.TabIndex = 1;
            this.lb_title.Text = "VirusChan";
            // 
            // panel_bottom
            // 
            this.panel_bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(130)))), ((int)(((byte)(242)))));
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel_bottom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panel_bottom.Location = new System.Drawing.Point(0, 420);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(350, 30);
            this.panel_bottom.TabIndex = 0;
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.VirusChanMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "VirusChan";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // VirusChanMenuStrip
            // 
            this.VirusChanMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileScanToolStripMenuItem,
            this.UrlScanToolStripMenuItem,
            this.toolStripMenuItem1,
            this.CloseToolStripMenuItem});
            this.VirusChanMenuStrip.Name = "contextMenuStrip1";
            this.VirusChanMenuStrip.Size = new System.Drawing.Size(135, 76);
            // 
            // FileScanToolStripMenuItem
            // 
            this.FileScanToolStripMenuItem.Name = "FileScanToolStripMenuItem";
            this.FileScanToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.FileScanToolStripMenuItem.Text = "파일스캔";
            this.FileScanToolStripMenuItem.Click += new System.EventHandler(this.FileScanToolStripMenuItem_Click);
            // 
            // UrlScanToolStripMenuItem
            // 
            this.UrlScanToolStripMenuItem.Name = "UrlScanToolStripMenuItem";
            this.UrlScanToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.UrlScanToolStripMenuItem.Text = "사이트스캔";
            this.UrlScanToolStripMenuItem.Click += new System.EventHandler(this.UrlScanToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(131, 6);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.CloseToolStripMenuItem.Text = "닫기";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // pb_title
            // 
            this.pb_title.Image = global::VirusChan.Properties.Resources.title;
            this.pb_title.Location = new System.Drawing.Point(6, 6);
            this.pb_title.Name = "pb_title";
            this.pb_title.Size = new System.Drawing.Size(20, 20);
            this.pb_title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_title.TabIndex = 4;
            this.pb_title.TabStop = false;
            // 
            // pb_minimum
            // 
            this.pb_minimum.Image = global::VirusChan.Properties.Resources.minus;
            this.pb_minimum.Location = new System.Drawing.Point(304, 7);
            this.pb_minimum.Name = "pb_minimum";
            this.pb_minimum.Size = new System.Drawing.Size(18, 18);
            this.pb_minimum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_minimum.TabIndex = 3;
            this.pb_minimum.TabStop = false;
            this.pb_minimum.Click += new System.EventHandler(this.pb_minimum_Click);
            // 
            // pb_close
            // 
            this.pb_close.Image = global::VirusChan.Properties.Resources.cancel;
            this.pb_close.Location = new System.Drawing.Point(325, 7);
            this.pb_close.Name = "pb_close";
            this.pb_close.Size = new System.Drawing.Size(18, 18);
            this.pb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_close.TabIndex = 2;
            this.pb_close.TabStop = false;
            this.pb_close.Click += new System.EventHandler(this.pb_close_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.panel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel_main.ResumeLayout(false);
            this.panel_center.ResumeLayout(false);
            this.flowLayoutPanel.ResumeLayout(false);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.VirusChanMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_bottom;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip VirusChanMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.PictureBox pb_close;
        private System.Windows.Forms.Panel panel_center;
        private System.Windows.Forms.PictureBox pb_minimum;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button btn_files;
        private System.Windows.Forms.Button btn_urls;
        private System.Windows.Forms.Panel panel_selected;
        private System.Windows.Forms.PictureBox pb_title;
        private System.Windows.Forms.Panel panel_forms;
        private System.Windows.Forms.ToolStripMenuItem FileScanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UrlScanToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    }
}

