﻿namespace treeviewDemo
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tvwStu = new System.Windows.Forms.TreeView();
            this.tvwSubject = new System.Windows.Forms.TreeView();
            this.listStudent = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listStudent);
            this.splitContainer1.Size = new System.Drawing.Size(445, 262);
            this.splitContainer1.SplitterDistance = 148;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tvwStu);
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tvwSubject);
            this.splitContainer2.Size = new System.Drawing.Size(148, 262);
            this.splitContainer2.SplitterDistance = 76;
            this.splitContainer2.TabIndex = 0;
            // 
            // tvwStu
            // 
            this.tvwStu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwStu.Location = new System.Drawing.Point(0, 0);
            this.tvwStu.Name = "tvwStu";
            this.tvwStu.Size = new System.Drawing.Size(148, 76);
            this.tvwStu.TabIndex = 0;
            this.tvwStu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwStu_AfterSelect);
            // 
            // tvwSubject
            // 
            this.tvwSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwSubject.Location = new System.Drawing.Point(0, 0);
            this.tvwSubject.Name = "tvwSubject";
            this.tvwSubject.Size = new System.Drawing.Size(148, 182);
            this.tvwSubject.TabIndex = 0;
            this.tvwSubject.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwSubject_AfterSelect);
            // 
            // listStudent
            // 
            this.listStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listStudent.FormattingEnabled = true;
            this.listStudent.ItemHeight = 12;
            this.listStudent.Location = new System.Drawing.Point(0, 0);
            this.listStudent.Name = "listStudent";
            this.listStudent.Size = new System.Drawing.Size(293, 262);
            this.listStudent.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 262);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "树形菜单";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView tvwStu;
        private System.Windows.Forms.TreeView tvwSubject;
        private System.Windows.Forms.ListBox listStudent;
    }
}

