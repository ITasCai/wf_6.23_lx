namespace wf_6._23_lx
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "C盘", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.InactiveBorder, new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "本地磁盘", System.Drawing.Color.Yellow, System.Drawing.SystemColors.Window, new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "100G"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "1G")}, "大图1.png");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "D盘",
            "本地磁盘",
            "66G",
            "32G"}, "大图1.png");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "F盘",
            "本地磁盘",
            "10G",
            "500mb"}, "大图1.png");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lvList = new System.Windows.Forms.ListView();
            this.imaDt = new System.Windows.Forms.ImageList(this.components);
            this.imaXT = new System.Windows.Forms.ImageList(this.components);
            this.btnda = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnxiao = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvList
            // 
            this.lvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lvList.LargeImageList = this.imaDt;
            this.lvList.Location = new System.Drawing.Point(12, 12);
            this.lvList.Name = "lvList";
            this.lvList.Size = new System.Drawing.Size(357, 149);
            this.lvList.SmallImageList = this.imaXT;
            this.lvList.TabIndex = 0;
            this.lvList.UseCompatibleStateImageBehavior = false;
            // 
            // imaDt
            // 
            this.imaDt.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imaDt.ImageStream")));
            this.imaDt.TransparentColor = System.Drawing.Color.Transparent;
            this.imaDt.Images.SetKeyName(0, "大图1.png");
            this.imaDt.Images.SetKeyName(1, "大图2.png");
            this.imaDt.Images.SetKeyName(2, "大图3.png");
            // 
            // imaXT
            // 
            this.imaXT.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imaXT.ImageStream")));
            this.imaXT.TransparentColor = System.Drawing.Color.Transparent;
            this.imaXT.Images.SetKeyName(0, "图1.png");
            this.imaXT.Images.SetKeyName(1, "图2.png");
            this.imaXT.Images.SetKeyName(2, "图3.png");
            // 
            // btnda
            // 
            this.btnda.Location = new System.Drawing.Point(40, 194);
            this.btnda.Name = "btnda";
            this.btnda.Size = new System.Drawing.Size(75, 23);
            this.btnda.TabIndex = 1;
            this.btnda.Text = "大图标";
            this.btnda.UseVisualStyleBackColor = true;
            this.btnda.Click += new System.EventHandler(this.btnda_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "名称";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "类型";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "总大小";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "可用空间";
            // 
            // btnxiao
            // 
            this.btnxiao.Location = new System.Drawing.Point(146, 194);
            this.btnxiao.Name = "btnxiao";
            this.btnxiao.Size = new System.Drawing.Size(75, 23);
            this.btnxiao.TabIndex = 2;
            this.btnxiao.Text = "小图标";
            this.btnxiao.UseVisualStyleBackColor = true;
            this.btnxiao.Click += new System.EventHandler(this.btnxiao_Click);
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(253, 194);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(75, 23);
            this.btnshow.TabIndex = 3;
            this.btnshow.Text = "显示列表";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 262);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.btnxiao);
            this.Controls.Add(this.btnda);
            this.Controls.Add(this.lvList);
            this.Name = "Form1";
            this.Text = "我的电脑";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvList;
        private System.Windows.Forms.ImageList imaDt;
        private System.Windows.Forms.ImageList imaXT;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnda;
        private System.Windows.Forms.Button btnxiao;
        private System.Windows.Forms.Button btnshow;
    }
}

