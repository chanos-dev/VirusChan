namespace VirusChan.form
{
    partial class FormDetails
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
            this.panel_top = new System.Windows.Forms.Panel();
            this.lb_title = new System.Windows.Forms.Label();
            this.pnl_md5 = new System.Windows.Forms.Panel();
            this.lb_md5 = new System.Windows.Forms.Label();
            this.pnl_sha1 = new System.Windows.Forms.Panel();
            this.lb_sha1 = new System.Windows.Forms.Label();
            this.pnl_sha256 = new System.Windows.Forms.Panel();
            this.lb_sha256 = new System.Windows.Forms.Label();
            this.pnl_permalink = new System.Windows.Forms.Panel();
            this.lb_permalink = new System.Windows.Forms.Label();
            this.pnl_md5result = new System.Windows.Forms.Panel();
            this.lb_md5Result = new System.Windows.Forms.Label();
            this.pnl_sha1result = new System.Windows.Forms.Panel();
            this.lb_sha1Result = new System.Windows.Forms.Label();
            this.pnl_sha256result = new System.Windows.Forms.Panel();
            this.lb_sha256Result = new System.Windows.Forms.Label();
            this.pnl_permalinkresult = new System.Windows.Forms.Panel();
            this.llb_permalinkResult = new System.Windows.Forms.LinkLabel();
            this.panel_top.SuspendLayout();
            this.pnl_md5.SuspendLayout();
            this.pnl_sha1.SuspendLayout();
            this.pnl_sha256.SuspendLayout();
            this.pnl_permalink.SuspendLayout();
            this.pnl_md5result.SuspendLayout();
            this.pnl_sha1result.SuspendLayout();
            this.pnl_sha256result.SuspendLayout();
            this.pnl_permalinkresult.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.SystemColors.Control;
            this.panel_top.Controls.Add(this.lb_title);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(585, 33);
            this.panel_top.TabIndex = 1;
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.lb_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(130)))), ((int)(((byte)(242)))));
            this.lb_title.Location = new System.Drawing.Point(3, 7);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(116, 19);
            this.lb_title.TabIndex = 0;
            this.lb_title.Text = "Basic Properties";
            // 
            // pnl_md5
            // 
            this.pnl_md5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(130)))), ((int)(((byte)(242)))));
            this.pnl_md5.Controls.Add(this.lb_md5);
            this.pnl_md5.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_md5.Location = new System.Drawing.Point(0, 33);
            this.pnl_md5.Name = "pnl_md5";
            this.pnl_md5.Size = new System.Drawing.Size(585, 33);
            this.pnl_md5.TabIndex = 2;
            // 
            // lb_md5
            // 
            this.lb_md5.AutoSize = true;
            this.lb_md5.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.lb_md5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.lb_md5.Location = new System.Drawing.Point(3, 7);
            this.lb_md5.Name = "lb_md5";
            this.lb_md5.Size = new System.Drawing.Size(40, 19);
            this.lb_md5.TabIndex = 0;
            this.lb_md5.Text = "MD5";
            // 
            // pnl_sha1
            // 
            this.pnl_sha1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(130)))), ((int)(((byte)(242)))));
            this.pnl_sha1.Controls.Add(this.lb_sha1);
            this.pnl_sha1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_sha1.Location = new System.Drawing.Point(0, 99);
            this.pnl_sha1.Name = "pnl_sha1";
            this.pnl_sha1.Size = new System.Drawing.Size(585, 33);
            this.pnl_sha1.TabIndex = 3;
            // 
            // lb_sha1
            // 
            this.lb_sha1.AutoSize = true;
            this.lb_sha1.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.lb_sha1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.lb_sha1.Location = new System.Drawing.Point(3, 7);
            this.lb_sha1.Name = "lb_sha1";
            this.lb_sha1.Size = new System.Drawing.Size(45, 19);
            this.lb_sha1.TabIndex = 0;
            this.lb_sha1.Text = "SHA1";
            // 
            // pnl_sha256
            // 
            this.pnl_sha256.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(130)))), ((int)(((byte)(242)))));
            this.pnl_sha256.Controls.Add(this.lb_sha256);
            this.pnl_sha256.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_sha256.Location = new System.Drawing.Point(0, 165);
            this.pnl_sha256.Name = "pnl_sha256";
            this.pnl_sha256.Size = new System.Drawing.Size(585, 33);
            this.pnl_sha256.TabIndex = 4;
            // 
            // lb_sha256
            // 
            this.lb_sha256.AutoSize = true;
            this.lb_sha256.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.lb_sha256.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.lb_sha256.Location = new System.Drawing.Point(3, 7);
            this.lb_sha256.Name = "lb_sha256";
            this.lb_sha256.Size = new System.Drawing.Size(66, 19);
            this.lb_sha256.TabIndex = 0;
            this.lb_sha256.Text = "SHA256";
            // 
            // pnl_permalink
            // 
            this.pnl_permalink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(130)))), ((int)(((byte)(242)))));
            this.pnl_permalink.Controls.Add(this.lb_permalink);
            this.pnl_permalink.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_permalink.Location = new System.Drawing.Point(0, 231);
            this.pnl_permalink.Name = "pnl_permalink";
            this.pnl_permalink.Size = new System.Drawing.Size(585, 33);
            this.pnl_permalink.TabIndex = 5;
            // 
            // lb_permalink
            // 
            this.lb_permalink.AutoSize = true;
            this.lb_permalink.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.lb_permalink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.lb_permalink.Location = new System.Drawing.Point(3, 7);
            this.lb_permalink.Name = "lb_permalink";
            this.lb_permalink.Size = new System.Drawing.Size(91, 19);
            this.lb_permalink.TabIndex = 0;
            this.lb_permalink.Text = "PERMALINK";
            // 
            // pnl_md5result
            // 
            this.pnl_md5result.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_md5result.Controls.Add(this.lb_md5Result);
            this.pnl_md5result.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_md5result.Location = new System.Drawing.Point(0, 66);
            this.pnl_md5result.Name = "pnl_md5result";
            this.pnl_md5result.Size = new System.Drawing.Size(585, 33);
            this.pnl_md5result.TabIndex = 6;
            // 
            // lb_md5Result
            // 
            this.lb_md5Result.AutoSize = true;
            this.lb_md5Result.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.lb_md5Result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(130)))), ((int)(((byte)(242)))));
            this.lb_md5Result.Location = new System.Drawing.Point(3, 7);
            this.lb_md5Result.Name = "lb_md5Result";
            this.lb_md5Result.Size = new System.Drawing.Size(40, 19);
            this.lb_md5Result.TabIndex = 0;
            this.lb_md5Result.Text = "MD5";
            this.lb_md5Result.DoubleClick += new System.EventHandler(this.label_DoubleClick);
            // 
            // pnl_sha1result
            // 
            this.pnl_sha1result.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_sha1result.Controls.Add(this.lb_sha1Result);
            this.pnl_sha1result.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_sha1result.Location = new System.Drawing.Point(0, 132);
            this.pnl_sha1result.Name = "pnl_sha1result";
            this.pnl_sha1result.Size = new System.Drawing.Size(585, 33);
            this.pnl_sha1result.TabIndex = 7;
            // 
            // lb_sha1Result
            // 
            this.lb_sha1Result.AutoSize = true;
            this.lb_sha1Result.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.lb_sha1Result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(130)))), ((int)(((byte)(242)))));
            this.lb_sha1Result.Location = new System.Drawing.Point(3, 7);
            this.lb_sha1Result.Name = "lb_sha1Result";
            this.lb_sha1Result.Size = new System.Drawing.Size(40, 19);
            this.lb_sha1Result.TabIndex = 0;
            this.lb_sha1Result.Text = "MD5";
            this.lb_sha1Result.DoubleClick += new System.EventHandler(this.label_DoubleClick);
            // 
            // pnl_sha256result
            // 
            this.pnl_sha256result.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_sha256result.Controls.Add(this.lb_sha256Result);
            this.pnl_sha256result.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_sha256result.Location = new System.Drawing.Point(0, 198);
            this.pnl_sha256result.Name = "pnl_sha256result";
            this.pnl_sha256result.Size = new System.Drawing.Size(585, 33);
            this.pnl_sha256result.TabIndex = 8;
            // 
            // lb_sha256Result
            // 
            this.lb_sha256Result.AutoSize = true;
            this.lb_sha256Result.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.lb_sha256Result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(130)))), ((int)(((byte)(242)))));
            this.lb_sha256Result.Location = new System.Drawing.Point(3, 7);
            this.lb_sha256Result.Name = "lb_sha256Result";
            this.lb_sha256Result.Size = new System.Drawing.Size(40, 19);
            this.lb_sha256Result.TabIndex = 0;
            this.lb_sha256Result.Text = "MD5";
            this.lb_sha256Result.DoubleClick += new System.EventHandler(this.label_DoubleClick);
            // 
            // pnl_permalinkresult
            // 
            this.pnl_permalinkresult.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_permalinkresult.Controls.Add(this.llb_permalinkResult);
            this.pnl_permalinkresult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_permalinkresult.Location = new System.Drawing.Point(0, 264);
            this.pnl_permalinkresult.Name = "pnl_permalinkresult";
            this.pnl_permalinkresult.Size = new System.Drawing.Size(585, 81);
            this.pnl_permalinkresult.TabIndex = 9;
            // 
            // llb_permalinkResult
            // 
            this.llb_permalinkResult.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.llb_permalinkResult.Location = new System.Drawing.Point(3, 3);
            this.llb_permalinkResult.Name = "llb_permalinkResult";
            this.llb_permalinkResult.Size = new System.Drawing.Size(579, 63);
            this.llb_permalinkResult.TabIndex = 1;
            this.llb_permalinkResult.TabStop = true;
            this.llb_permalinkResult.Text = "linkLabel1";
            this.llb_permalinkResult.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_permalinkResult_LinkClicked);
            // 
            // FormDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_permalinkresult);
            this.Controls.Add(this.pnl_permalink);
            this.Controls.Add(this.pnl_sha256result);
            this.Controls.Add(this.pnl_sha256);
            this.Controls.Add(this.pnl_sha1result);
            this.Controls.Add(this.pnl_sha1);
            this.Controls.Add(this.pnl_md5result);
            this.Controls.Add(this.pnl_md5);
            this.Controls.Add(this.panel_top);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(130)))), ((int)(((byte)(242)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormDetails";
            this.Size = new System.Drawing.Size(585, 345);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.pnl_md5.ResumeLayout(false);
            this.pnl_md5.PerformLayout();
            this.pnl_sha1.ResumeLayout(false);
            this.pnl_sha1.PerformLayout();
            this.pnl_sha256.ResumeLayout(false);
            this.pnl_sha256.PerformLayout();
            this.pnl_permalink.ResumeLayout(false);
            this.pnl_permalink.PerformLayout();
            this.pnl_md5result.ResumeLayout(false);
            this.pnl_md5result.PerformLayout();
            this.pnl_sha1result.ResumeLayout(false);
            this.pnl_sha1result.PerformLayout();
            this.pnl_sha256result.ResumeLayout(false);
            this.pnl_sha256result.PerformLayout();
            this.pnl_permalinkresult.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Panel pnl_md5;
        private System.Windows.Forms.Label lb_md5;
        private System.Windows.Forms.Panel pnl_sha1;
        private System.Windows.Forms.Label lb_sha1;
        private System.Windows.Forms.Panel pnl_sha256;
        private System.Windows.Forms.Label lb_sha256;
        private System.Windows.Forms.Panel pnl_permalink;
        private System.Windows.Forms.Label lb_permalink;
        private System.Windows.Forms.Panel pnl_md5result;
        private System.Windows.Forms.Label lb_md5Result;
        private System.Windows.Forms.Panel pnl_sha1result;
        private System.Windows.Forms.Label lb_sha1Result;
        private System.Windows.Forms.Panel pnl_sha256result;
        private System.Windows.Forms.Label lb_sha256Result;
        private System.Windows.Forms.Panel pnl_permalinkresult;
        private System.Windows.Forms.LinkLabel llb_permalinkResult;
    }
}
