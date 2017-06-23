namespace ProgressBarDeam
{
    partial class frmdeam
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pgrtime = new System.Windows.Forms.ProgressBar();
            this.tmrtime = new System.Windows.Forms.Timer(this.components);
            this.lblsz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pgrtime
            // 
            this.pgrtime.Location = new System.Drawing.Point(46, 36);
            this.pgrtime.Name = "pgrtime";
            this.pgrtime.Size = new System.Drawing.Size(194, 23);
            this.pgrtime.Step = 25;
            this.pgrtime.TabIndex = 0;
            // 
            // tmrtime
            // 
            this.tmrtime.Interval = 1000;
            this.tmrtime.Tick += new System.EventHandler(this.tmrtime_Tick);
            // 
            // lblsz
            // 
            this.lblsz.AutoSize = true;
            this.lblsz.Font = new System.Drawing.Font("宋体", 24F);
            this.lblsz.Location = new System.Drawing.Point(129, 121);
            this.lblsz.Name = "lblsz";
            this.lblsz.Size = new System.Drawing.Size(31, 33);
            this.lblsz.TabIndex = 1;
            this.lblsz.Text = "5";
            // 
            // frmdeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblsz);
            this.Controls.Add(this.pgrtime);
            this.Name = "frmdeam";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmdeam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgrtime;
        private System.Windows.Forms.Timer tmrtime;
        protected System.Windows.Forms.Label lblsz;
    }
}

