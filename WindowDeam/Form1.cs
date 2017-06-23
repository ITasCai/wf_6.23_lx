using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowDeam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            //添加
            int itemNum = lvshow.Items.Count;
            string[] subitem = { txtname.Text,txtlx.Text,txtzdx.Text,txtky.Text};
            lvshow.Items.Insert(itemNum, new ListViewItem(subitem));
            //设置图标坐标
            lvshow.Items[itemNum].ImageIndex = 0;

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (lvshow.SelectedItems.Count > 0)
            {
                lvshow.SelectedItems[0].Remove();
            }

        }

        private void btnda_Click(object sender, EventArgs e)
        {

            //显示大图标
            lvshow.View = View.LargeIcon;

        }
        private void btnxiao_Click(object sender, EventArgs e)
        {
            //显示小图标
            lvshow.View = View.SmallIcon;
        
    }

        private void btnlb_Click(object sender, EventArgs e)
        {

            //显示列表
            lvshow.View = View.Details;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //设置listview的视图类型为列表显示
            lvshow.View = View.Details;
            //设置listview关联的imagelist
            lvshow.LargeImageList = imgda;
            lvshow.SmallImageList = imgxiao;

            lvshow.Columns.Add("名称");
            lvshow.Columns.Add("类型");
            lvshow.Columns.Add("总大小");
            lvshow.Columns.Add("可用空间");
            //向项中添加子项
            ListViewItem itemc = new ListViewItem("C盘", 0);
            itemc.SubItems.Add("本地磁盘");
            itemc.SubItems.Add("40G");
            itemc.SubItems.Add("17G");
            //将添加子项添加到listview中
            lvshow.Items.Add(itemc);
            //绑定快捷菜单
            lvshow.ContextMenuStrip = cmsview;
        }

        private void 大图标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnda_Click(null,null);
        }

        private void 小图标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnxiao_Click(null,null);
        }

        private void 显示列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnlb_Click(null, null);
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
