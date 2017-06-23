namespace QQDeam
{
    partial class imgda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(imgda));
            this.lvshow = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.imgdt = new System.Windows.Forms.ImageList(this.components);
            this.imgxt = new System.Windows.Forms.ImageList(this.components);
            this.btnxiang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvshow
            // 
            this.lvshow.Location = new System.Drawing.Point(33, 12);
            this.lvshow.Name = "lvshow";
            this.lvshow.Size = new System.Drawing.Size(280, 97);
            this.lvshow.TabIndex = 0;
            this.lvshow.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "大头像";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "小头像";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imgdt
            // 
            this.imgdt.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgdt.ImageStream")));
            this.imgdt.TransparentColor = System.Drawing.Color.Transparent;
            this.imgdt.Images.SetKeyName(0, "大图1.png");
            this.imgdt.Images.SetKeyName(1, "大图2.png");
            this.imgdt.Images.SetKeyName(2, "大图3.png");
            // 
            // imgxt
            // 
            this.imgxt.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgxt.ImageStream")));
            this.imgxt.TransparentColor = System.Drawing.Color.Transparent;
            this.imgxt.Images.SetKeyName(0, "图1.png");
            this.imgxt.Images.SetKeyName(1, "图2.png");
            this.imgxt.Images.SetKeyName(2, "图3.png");
            // 
            // btnxiang
            // 
            this.btnxiang.Location = new System.Drawing.Point(221, 171);
            this.btnxiang.Name = "btnxiang";
            this.btnxiang.Size = new System.Drawing.Size(75, 23);
            this.btnxiang.TabIndex = 3;
            this.btnxiang.Text = "详细信息";
            this.btnxiang.UseVisualStyleBackColor = true;
            // 
            // imgda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 262);
            this.Controls.Add(this.btnxiang);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvshow);
            this.Name = "imgda";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.imgda_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvshow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imgdt;
        private System.Windows.Forms.ImageList imgxt;
        private System.Windows.Forms.Button btnxiang;
    }
}

