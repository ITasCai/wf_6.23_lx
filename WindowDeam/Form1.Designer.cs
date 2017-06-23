namespace WindowDeam
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lvshow = new System.Windows.Forms.ListView();
            this.btnda = new System.Windows.Forms.Button();
            this.btnxiao = new System.Windows.Forms.Button();
            this.btnlb = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.lbllx = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.lblzdx = new System.Windows.Forms.Label();
            this.lblky = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtlx = new System.Windows.Forms.TextBox();
            this.txtzdx = new System.Windows.Forms.TextBox();
            this.txtky = new System.Windows.Forms.TextBox();
            this.imgda = new System.Windows.Forms.ImageList(this.components);
            this.imgxiao = new System.Windows.Forms.ImageList(this.components);
            this.cmsview = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.大图标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.小图标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsview.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvshow
            // 
            this.lvshow.Location = new System.Drawing.Point(36, 24);
            this.lvshow.Name = "lvshow";
            this.lvshow.Size = new System.Drawing.Size(314, 151);
            this.lvshow.TabIndex = 0;
            this.lvshow.UseCompatibleStateImageBehavior = false;
            // 
            // btnda
            // 
            this.btnda.Location = new System.Drawing.Point(36, 234);
            this.btnda.Name = "btnda";
            this.btnda.Size = new System.Drawing.Size(75, 23);
            this.btnda.TabIndex = 1;
            this.btnda.Text = "大图标";
            this.btnda.UseVisualStyleBackColor = true;
            this.btnda.Click += new System.EventHandler(this.btnda_Click);
            // 
            // btnxiao
            // 
            this.btnxiao.Location = new System.Drawing.Point(163, 234);
            this.btnxiao.Name = "btnxiao";
            this.btnxiao.Size = new System.Drawing.Size(75, 23);
            this.btnxiao.TabIndex = 2;
            this.btnxiao.Text = "小图标";
            this.btnxiao.UseVisualStyleBackColor = true;
            this.btnxiao.Click += new System.EventHandler(this.btnxiao_Click);
            // 
            // btnlb
            // 
            this.btnlb.Location = new System.Drawing.Point(297, 234);
            this.btnlb.Name = "btnlb";
            this.btnlb.Size = new System.Drawing.Size(75, 23);
            this.btnlb.TabIndex = 3;
            this.btnlb.Text = "显示列表";
            this.btnlb.UseVisualStyleBackColor = true;
            this.btnlb.Click += new System.EventHandler(this.btnlb_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(380, 24);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(29, 12);
            this.lblname.TabIndex = 4;
            this.lblname.Text = "名称";
            // 
            // lbllx
            // 
            this.lbllx.AutoSize = true;
            this.lbllx.Location = new System.Drawing.Point(380, 70);
            this.lbllx.Name = "lbllx";
            this.lbllx.Size = new System.Drawing.Size(29, 12);
            this.lbllx.TabIndex = 5;
            this.lbllx.Text = "类型";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(419, 233);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "添加";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(523, 234);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 7;
            this.btndelete.Text = "删除";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // lblzdx
            // 
            this.lblzdx.AutoSize = true;
            this.lblzdx.Location = new System.Drawing.Point(382, 112);
            this.lblzdx.Name = "lblzdx";
            this.lblzdx.Size = new System.Drawing.Size(41, 12);
            this.lblzdx.TabIndex = 8;
            this.lblzdx.Text = "总大小";
            // 
            // lblky
            // 
            this.lblky.AutoSize = true;
            this.lblky.Location = new System.Drawing.Point(382, 162);
            this.lblky.Name = "lblky";
            this.lblky.Size = new System.Drawing.Size(53, 12);
            this.lblky.TabIndex = 9;
            this.lblky.Text = "可用空间";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(445, 24);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(129, 21);
            this.txtname.TabIndex = 10;
            // 
            // txtlx
            // 
            this.txtlx.Location = new System.Drawing.Point(445, 60);
            this.txtlx.Name = "txtlx";
            this.txtlx.Size = new System.Drawing.Size(129, 21);
            this.txtlx.TabIndex = 11;
            // 
            // txtzdx
            // 
            this.txtzdx.Location = new System.Drawing.Point(445, 102);
            this.txtzdx.Name = "txtzdx";
            this.txtzdx.Size = new System.Drawing.Size(129, 21);
            this.txtzdx.TabIndex = 12;
            // 
            // txtky
            // 
            this.txtky.Location = new System.Drawing.Point(445, 153);
            this.txtky.Name = "txtky";
            this.txtky.Size = new System.Drawing.Size(129, 21);
            this.txtky.TabIndex = 13;
            // 
            // imgda
            // 
            this.imgda.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgda.ImageStream")));
            this.imgda.TransparentColor = System.Drawing.Color.Transparent;
            this.imgda.Images.SetKeyName(0, "大图1.png");
            this.imgda.Images.SetKeyName(1, "大图2.png");
            this.imgda.Images.SetKeyName(2, "大图3.png");
            // 
            // imgxiao
            // 
            this.imgxiao.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgxiao.ImageStream")));
            this.imgxiao.TransparentColor = System.Drawing.Color.Transparent;
            this.imgxiao.Images.SetKeyName(0, "图1.png");
            this.imgxiao.Images.SetKeyName(1, "图2.png");
            this.imgxiao.Images.SetKeyName(2, "图3.png");
            // 
            // cmsview
            // 
            this.cmsview.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.大图标ToolStripMenuItem,
            this.小图标ToolStripMenuItem,
            this.显示列表ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.cmsview.Name = "cmsview";
            this.cmsview.Size = new System.Drawing.Size(153, 114);
            // 
            // 大图标ToolStripMenuItem
            // 
            this.大图标ToolStripMenuItem.Name = "大图标ToolStripMenuItem";
            this.大图标ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.大图标ToolStripMenuItem.Text = "大图标";
            this.大图标ToolStripMenuItem.Click += new System.EventHandler(this.大图标ToolStripMenuItem_Click);
            // 
            // 小图标ToolStripMenuItem
            // 
            this.小图标ToolStripMenuItem.Name = "小图标ToolStripMenuItem";
            this.小图标ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.小图标ToolStripMenuItem.Text = "小图标";
            this.小图标ToolStripMenuItem.Click += new System.EventHandler(this.小图标ToolStripMenuItem_Click);
            // 
            // 显示列表ToolStripMenuItem
            // 
            this.显示列表ToolStripMenuItem.Name = "显示列表ToolStripMenuItem";
            this.显示列表ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.显示列表ToolStripMenuItem.Text = "显示列表";
            this.显示列表ToolStripMenuItem.Click += new System.EventHandler(this.显示列表ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 287);
            this.Controls.Add(this.txtky);
            this.Controls.Add(this.txtzdx);
            this.Controls.Add(this.txtlx);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblky);
            this.Controls.Add(this.lblzdx);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.lbllx);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.btnlb);
            this.Controls.Add(this.btnxiao);
            this.Controls.Add(this.btnda);
            this.Controls.Add(this.lvshow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cmsview.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvshow;
        private System.Windows.Forms.Button btnda;
        private System.Windows.Forms.Button btnxiao;
        private System.Windows.Forms.Button btnlb;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbllx;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label lblzdx;
        private System.Windows.Forms.Label lblky;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtlx;
        private System.Windows.Forms.TextBox txtzdx;
        protected System.Windows.Forms.TextBox txtky;
        private System.Windows.Forms.ImageList imgda;
        private System.Windows.Forms.ImageList imgxiao;
        private System.Windows.Forms.ContextMenuStrip cmsview;
        private System.Windows.Forms.ToolStripMenuItem 大图标ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 小图标ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显示列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
    }
}

