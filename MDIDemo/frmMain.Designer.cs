namespace MDIDemo
{
    partial class frmMain
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
            this.munMDI = new System.Windows.Forms.MenuStrip();
            this.窗体操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.窗体布局ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.munlist = new System.Windows.Forms.ToolStripMenuItem();
            this.munmax = new System.Windows.Forms.ToolStripMenuItem();
            this.munmin = new System.Windows.Forms.ToolStripMenuItem();
            this.munclose = new System.Windows.Forms.ToolStripMenuItem();
            this.munshow = new System.Windows.Forms.ToolStripMenuItem();
            this.muncd = new System.Windows.Forms.ToolStripMenuItem();
            this.munsp = new System.Windows.Forms.ToolStripMenuItem();
            this.muncz = new System.Windows.Forms.ToolStripMenuItem();
            this.munMDI.SuspendLayout();
            this.SuspendLayout();
            // 
            // munMDI
            // 
            this.munMDI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.窗体操作ToolStripMenuItem,
            this.窗体布局ToolStripMenuItem,
            this.munlist});
            this.munMDI.Location = new System.Drawing.Point(0, 0);
            this.munMDI.MdiWindowListItem = this.munlist;
            this.munMDI.Name = "munMDI";
            this.munMDI.Size = new System.Drawing.Size(284, 25);
            this.munMDI.TabIndex = 0;
            this.munMDI.Text = "menuStrip1";
            // 
            // 窗体操作ToolStripMenuItem
            // 
            this.窗体操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.munmax,
            this.munmin,
            this.munclose,
            this.munshow});
            this.窗体操作ToolStripMenuItem.Name = "窗体操作ToolStripMenuItem";
            this.窗体操作ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.窗体操作ToolStripMenuItem.Text = "窗体操作";
            // 
            // 窗体布局ToolStripMenuItem
            // 
            this.窗体布局ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muncd,
            this.munsp,
            this.muncz});
            this.窗体布局ToolStripMenuItem.Name = "窗体布局ToolStripMenuItem";
            this.窗体布局ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.窗体布局ToolStripMenuItem.Text = "窗体布局";
            // 
            // munlist
            // 
            this.munlist.Name = "munlist";
            this.munlist.Size = new System.Drawing.Size(68, 21);
            this.munlist.Text = "窗体列表";
            // 
            // munmax
            // 
            this.munmax.Name = "munmax";
            this.munmax.Size = new System.Drawing.Size(172, 22);
            this.munmax.Text = "最大化所有子窗体";
            this.munmax.Click += new System.EventHandler(this.munmax_Click);
            // 
            // munmin
            // 
            this.munmin.Name = "munmin";
            this.munmin.Size = new System.Drawing.Size(172, 22);
            this.munmin.Text = "最小化所有子窗体";
            this.munmin.Click += new System.EventHandler(this.munmin_Click);
            // 
            // munclose
            // 
            this.munclose.Name = "munclose";
            this.munclose.Size = new System.Drawing.Size(172, 22);
            this.munclose.Text = "关闭所有子窗体";
            this.munclose.Click += new System.EventHandler(this.munclose_Click);
            // 
            // munshow
            // 
            this.munshow.Name = "munshow";
            this.munshow.Size = new System.Drawing.Size(172, 22);
            this.munshow.Text = "打开子窗体";
            this.munshow.Click += new System.EventHandler(this.munshow_Click);
            // 
            // muncd
            // 
            this.muncd.Name = "muncd";
            this.muncd.Size = new System.Drawing.Size(160, 22);
            this.muncd.Text = "所有子窗体层叠";
            this.muncd.Click += new System.EventHandler(this.muncd_Click);
            // 
            // munsp
            // 
            this.munsp.Name = "munsp";
            this.munsp.Size = new System.Drawing.Size(160, 22);
            this.munsp.Text = "所有子窗体水平";
            this.munsp.Click += new System.EventHandler(this.munsp_Click);
            // 
            // muncz
            // 
            this.muncz.Name = "muncz";
            this.muncz.Size = new System.Drawing.Size(160, 22);
            this.muncz.Text = "所有子窗体垂直";
            this.muncz.Click += new System.EventHandler(this.muncz_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.munMDI);
            this.MainMenuStrip = this.munMDI;
            this.Name = "frmMain";
            this.Text = "多文档父窗体";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.munMDI.ResumeLayout(false);
            this.munMDI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip munMDI;
        private System.Windows.Forms.ToolStripMenuItem 窗体操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem munmax;
        private System.Windows.Forms.ToolStripMenuItem munmin;
        private System.Windows.Forms.ToolStripMenuItem munclose;
        private System.Windows.Forms.ToolStripMenuItem munshow;
        private System.Windows.Forms.ToolStripMenuItem 窗体布局ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem munlist;
        private System.Windows.Forms.ToolStripMenuItem muncd;
        private System.Windows.Forms.ToolStripMenuItem munsp;
        private System.Windows.Forms.ToolStripMenuItem muncz;
    }
}

