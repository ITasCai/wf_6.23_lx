namespace TabComDeam
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
            this.tabStudent = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.tab3 = new System.Windows.Forms.TabPage();
            this.lblname = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblage = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.btnnext = new System.Windows.Forms.Button();
            this.dtptime = new System.Windows.Forms.DateTimePicker();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblshow = new System.Windows.Forms.Label();
            this.txtshow = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.btndate = new System.Windows.Forms.Button();
            this.tabStudent.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tab2.SuspendLayout();
            this.tab3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabStudent
            // 
            this.tabStudent.Controls.Add(this.tab1);
            this.tabStudent.Controls.Add(this.tab2);
            this.tabStudent.Controls.Add(this.tab3);
            this.tabStudent.Location = new System.Drawing.Point(52, 12);
            this.tabStudent.Name = "tabStudent";
            this.tabStudent.SelectedIndex = 0;
            this.tabStudent.Size = new System.Drawing.Size(472, 258);
            this.tabStudent.TabIndex = 0;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.btnnext);
            this.tab1.Controls.Add(this.txtage);
            this.tab1.Controls.Add(this.lblage);
            this.tab1.Controls.Add(this.txtname);
            this.tab1.Controls.Add(this.lblname);
            this.tab1.Location = new System.Drawing.Point(4, 22);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(464, 232);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "添加学生的基本信息";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.btndate);
            this.tab2.Controls.Add(this.lbldate);
            this.tab2.Controls.Add(this.dtptime);
            this.tab2.Location = new System.Drawing.Point(4, 22);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(464, 232);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "学生的出生日期";
            this.tab2.UseVisualStyleBackColor = true;
            this.tab2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tab3
            // 
            this.tab3.Controls.Add(this.btnok);
            this.tab3.Controls.Add(this.txtshow);
            this.tab3.Controls.Add(this.lblshow);
            this.tab3.Location = new System.Drawing.Point(4, 22);
            this.tab3.Name = "tab3";
            this.tab3.Padding = new System.Windows.Forms.Padding(3);
            this.tab3.Size = new System.Drawing.Size(464, 232);
            this.tab3.TabIndex = 2;
            this.tab3.Text = "学生信息展示";
            this.tab3.UseVisualStyleBackColor = true;
            this.tab3.Click += new System.EventHandler(this.tab3_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(54, 31);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(53, 12);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "学生姓名";
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(166, 31);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 21);
            this.txtname.TabIndex = 3;
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblage.Location = new System.Drawing.Point(54, 78);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(53, 12);
            this.lblage.TabIndex = 4;
            this.lblage.Text = "学生年龄";
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(166, 78);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(100, 21);
            this.txtage.TabIndex = 5;
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(319, 119);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(75, 23);
            this.btnnext.TabIndex = 6;
            this.btnnext.Text = "下一步";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // dtptime
            // 
            this.dtptime.Location = new System.Drawing.Point(94, 77);
            this.dtptime.Name = "dtptime";
            this.dtptime.Size = new System.Drawing.Size(200, 21);
            this.dtptime.TabIndex = 0;
            this.dtptime.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(94, 32);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(77, 12);
            this.lbldate.TabIndex = 1;
            this.lbldate.Text = "学生出生日期";
            // 
            // lblshow
            // 
            this.lblshow.AutoSize = true;
            this.lblshow.Location = new System.Drawing.Point(168, 33);
            this.lblshow.Name = "lblshow";
            this.lblshow.Size = new System.Drawing.Size(77, 12);
            this.lblshow.TabIndex = 0;
            this.lblshow.Text = "学生信息展示";
            // 
            // txtshow
            // 
            this.txtshow.Location = new System.Drawing.Point(98, 48);
            this.txtshow.Multiline = true;
            this.txtshow.Name = "txtshow";
            this.txtshow.Size = new System.Drawing.Size(239, 99);
            this.txtshow.TabIndex = 1;
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(298, 192);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 2;
            this.btnok.Text = "ok";
            this.btnok.UseVisualStyleBackColor = true;
            // 
            // btndate
            // 
            this.btndate.Location = new System.Drawing.Point(297, 171);
            this.btndate.Name = "btndate";
            this.btndate.Size = new System.Drawing.Size(75, 23);
            this.btndate.TabIndex = 2;
            this.btndate.Text = "下一步";
            this.btndate.UseVisualStyleBackColor = true;
            this.btndate.Click += new System.EventHandler(this.btndate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 282);
            this.Controls.Add(this.tabStudent);
            this.Name = "Form1";
            this.Text = "选项卡的使用";
            this.tabStudent.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            this.tab3.ResumeLayout(false);
            this.tab3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabStudent;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.TabPage tab3;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.DateTimePicker dtptime;
        private System.Windows.Forms.Label lblshow;
        private System.Windows.Forms.Button btndate;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.TextBox txtshow;
    }
}

