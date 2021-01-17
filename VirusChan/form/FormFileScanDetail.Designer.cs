namespace VirusChan.form
{
    partial class FormFileScanDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFileScanDetail));
            this.panel_top = new System.Windows.Forms.Panel();
            this.lb_title = new System.Windows.Forms.Label();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.panel_main = new System.Windows.Forms.Panel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Summary = new System.Windows.Forms.Button();
            this.btn_Detection = new System.Windows.Forms.Button();
            this.btn_Details = new System.Windows.Forms.Button();
            this.panel_selected = new System.Windows.Forms.Panel();
            this.panel_forms = new System.Windows.Forms.Panel();
            this.pb_title = new System.Windows.Forms.PictureBox();
            this.pb_minimum = new System.Windows.Forms.PictureBox();
            this.pb_close = new System.Windows.Forms.PictureBox();
            this.panel_top.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).BeginInit();
            this.SuspendLayout();
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
            this.panel_top.Size = new System.Drawing.Size(585, 30);
            this.panel_top.TabIndex = 2;
            this.panel_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseDown);
            this.panel_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseMove);
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_title.Location = new System.Drawing.Point(29, 8);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(115, 15);
            this.lb_title.TabIndex = 1;
            this.lb_title.Text = "파일 스캔 정보";
            this.lb_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseDown);
            this.lb_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseMove);
            // 
            // panel_bottom
            // 
            this.panel_bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(130)))), ((int)(((byte)(242)))));
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel_bottom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panel_bottom.Location = new System.Drawing.Point(0, 420);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(585, 30);
            this.panel_bottom.TabIndex = 3;
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.panel_forms);
            this.panel_main.Controls.Add(this.panel_selected);
            this.panel_main.Controls.Add(this.flowLayoutPanel);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.panel_main.Location = new System.Drawing.Point(0, 30);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(585, 390);
            this.panel_main.TabIndex = 4;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Controls.Add(this.btn_Summary);
            this.flowLayoutPanel.Controls.Add(this.btn_Detection);
            this.flowLayoutPanel.Controls.Add(this.btn_Details);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(130)))), ((int)(((byte)(242)))));
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(585, 35);
            this.flowLayoutPanel.TabIndex = 1;
            // 
            // btn_Summary
            // 
            this.btn_Summary.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Summary.FlatAppearance.BorderSize = 0;
            this.btn_Summary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Summary.Location = new System.Drawing.Point(3, 3);
            this.btn_Summary.Margin = new System.Windows.Forms.Padding(3, 3, 4, 3);
            this.btn_Summary.Name = "btn_Summary";
            this.btn_Summary.Size = new System.Drawing.Size(188, 30);
            this.btn_Summary.TabIndex = 2;
            this.btn_Summary.Text = "요약";
            this.btn_Summary.UseVisualStyleBackColor = false;
            this.btn_Summary.Click += new System.EventHandler(this.btn_Summary_Click);
            // 
            // btn_Detection
            // 
            this.btn_Detection.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Detection.FlatAppearance.BorderSize = 0;
            this.btn_Detection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Detection.Location = new System.Drawing.Point(198, 3);
            this.btn_Detection.Margin = new System.Windows.Forms.Padding(3, 3, 4, 3);
            this.btn_Detection.Name = "btn_Detection";
            this.btn_Detection.Size = new System.Drawing.Size(188, 30);
            this.btn_Detection.TabIndex = 3;
            this.btn_Detection.Text = "탐지";
            this.btn_Detection.UseVisualStyleBackColor = false;
            this.btn_Detection.Click += new System.EventHandler(this.btn_Detection_Click);
            // 
            // btn_Details
            // 
            this.btn_Details.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Details.FlatAppearance.BorderSize = 0;
            this.btn_Details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Details.Location = new System.Drawing.Point(393, 3);
            this.btn_Details.Name = "btn_Details";
            this.btn_Details.Size = new System.Drawing.Size(188, 30);
            this.btn_Details.TabIndex = 4;
            this.btn_Details.Text = "상세정보";
            this.btn_Details.UseVisualStyleBackColor = false;
            this.btn_Details.Click += new System.EventHandler(this.btn_Details_Click);
            // 
            // panel_selected
            // 
            this.panel_selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(130)))), ((int)(((byte)(242)))));
            this.panel_selected.Location = new System.Drawing.Point(3, 36);
            this.panel_selected.Name = "panel_selected";
            this.panel_selected.Size = new System.Drawing.Size(188, 6);
            this.panel_selected.TabIndex = 2;
            // 
            // panel_forms
            // 
            this.panel_forms.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_forms.Location = new System.Drawing.Point(0, 45);
            this.panel_forms.Name = "panel_forms";
            this.panel_forms.Size = new System.Drawing.Size(585, 345);
            this.panel_forms.TabIndex = 3;
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
            this.pb_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseDown);
            this.pb_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseMove);
            // 
            // pb_minimum
            // 
            this.pb_minimum.Image = global::VirusChan.Properties.Resources.minus;
            this.pb_minimum.Location = new System.Drawing.Point(538, 7);
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
            this.pb_close.Location = new System.Drawing.Point(559, 7);
            this.pb_close.Name = "pb_close";
            this.pb_close.Size = new System.Drawing.Size(18, 18);
            this.pb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_close.TabIndex = 2;
            this.pb_close.TabStop = false;
            this.pb_close.Click += new System.EventHandler(this.pb_close_Click);
            // 
            // FormFileScanDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFileScanDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VirusChan";
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.flowLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.PictureBox pb_title;
        private System.Windows.Forms.PictureBox pb_minimum;
        private System.Windows.Forms.PictureBox pb_close;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Panel panel_bottom;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button btn_Summary;
        private System.Windows.Forms.Button btn_Detection;
        private System.Windows.Forms.Button btn_Details;
        private System.Windows.Forms.Panel panel_selected;
        private System.Windows.Forms.Panel panel_forms;
    }
}