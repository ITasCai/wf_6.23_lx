namespace treeviewDemo
{
    partial class frmBooks
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
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("C#");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("所有书籍", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvwbooks = new System.Windows.Forms.TreeView();
            this.lvwbooks = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.tvwbooks);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvwbooks);
            this.splitContainer1.Size = new System.Drawing.Size(465, 312);
            this.splitContainer1.SplitterDistance = 155;
            this.splitContainer1.TabIndex = 0;
            // 
            // tvwbooks
            // 
            this.tvwbooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwbooks.Location = new System.Drawing.Point(0, 0);
            this.tvwbooks.Name = "tvwbooks";
            treeNode3.Name = "节点1";
            treeNode3.Text = "C#";
            treeNode4.Name = "节点0";
            treeNode4.Text = "所有书籍";
            this.tvwbooks.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.tvwbooks.PathSeparator = "";
            this.tvwbooks.Size = new System.Drawing.Size(155, 312);
            this.tvwbooks.TabIndex = 0;
            this.tvwbooks.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwbooks_AfterSelect);
            // 
            // lvwbooks
            // 
            this.lvwbooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwbooks.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.lvwbooks.Location = new System.Drawing.Point(0, 0);
            this.lvwbooks.Name = "lvwbooks";
            this.lvwbooks.Size = new System.Drawing.Size(306, 312);
            this.lvwbooks.TabIndex = 0;
            this.lvwbooks.UseCompatibleStateImageBehavior = false;
            // 
            // frmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 312);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmBooks";
            this.Text = "图书管理系统";
            this.Load += new System.EventHandler(this.frmBooks_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvwbooks;
        private System.Windows.Forms.ListView lvwbooks;
    }
}