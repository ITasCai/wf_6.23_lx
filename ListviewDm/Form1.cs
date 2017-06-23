using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListviewDm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //设置listview的视图类型为列表显示
            lvshow.View = View.Details; 
            
            lvshow.LargeImageList = imgda;
            lvshow.SmallImageList = imgxiao;

            lvshow.Columns.Add("名称");
            lvshow.Columns.Add("类型");
            lvshow.Columns.Add("总大小");
            lvshow.Columns.Add("可用空间");
            //向项中添加子项
            ListViewItem itemc = new ListViewItem("C盘",0);
            itemc.SubItems.Add("本地磁盘");
            itemc.SubItems.Add("40G");
            itemc.SubItems.Add("17G");
            //将添加子项添加到listview中
            lvshow.Items.Add(itemc);

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

        private void btnshow_Click(object sender, EventArgs e)
        {
            //显示列表
            lvshow.View = View.Details;
        }
    }
}
