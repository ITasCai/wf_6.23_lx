namespace ListviewDm
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
            this.btnshow = new System.Windows.Forms.Button();
            this.imgda = new System.Windows.Forms.ImageList(this.components);
            this.imgxiao = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // lvshow
            // 
            this.lvshow.Location = new System.Drawing.Point(30, 22);
            this.lvshow.Name = "lvshow";
            this.lvshow.Size = new System.Drawing.Size(327, 112);
            this.lvshow.TabIndex = 0;
            this.lvshow.UseCompatibleStateImageBehavior = false;
            // 
            // btnda
            // 
            this.btnda.Location = new System.Drawing.Point(39, 199);
            this.btnda.Name = "btnda";
            this.btnda.Size = new System.Drawing.Size(75, 23);
            this.btnda.TabIndex = 1;
            this.btnda.Text = "大图标";
            this.btnda.UseVisualStyleBackColor = true;
            this.btnda.Click += new System.EventHandler(this.btnda_Click);
            // 
            // btnxiao
            // 
            this.btnxiao.Location = new System.Drawing.Point(161, 198);
            this.btnxiao.Name = "btnxiao";
            this.btnxiao.Size = new System.Drawing.Size(75, 23);
            this.btnxiao.TabIndex = 2;
            this.btnxiao.Text = "小图标";
            this.btnxiao.UseVisualStyleBackColor = true;
            this.btnxiao.Click += new System.EventHandler(this.btnxiao_Click);
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(271, 198);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(75, 23);
            this.btnshow.TabIndex = 3;
            this.btnshow.Text = "显示列表";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 279);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.btnxiao);
            this.Controls.Add(this.btnda);
            this.Controls.Add(this.lvshow);
            this.Name = "Form1";
            this.Text = "我的电脑";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvshow;
        private System.Windows.Forms.Button btnda;
        private System.Windows.Forms.Button btnxiao;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.ImageList imgda;
        private System.Windows.Forms.ImageList imgxiao;
    }
}

