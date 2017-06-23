using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QQDeam
{
    public partial class imgda : Form
    {
        public imgda()
        {
            InitializeComponent();
        }

        private void imgda_Load(object sender, EventArgs e)
        {
            //设置listview的视图类型为列表显示
            lvshow.View = View.Details;

            lvshow.LargeImageList = imgdt;
            lvshow.SmallImageList = imgxt;

            lvshow.Columns.Add("名称");
            lvshow.Columns.Add("类型");
            lvshow.Columns.Add("总大小");
            lvshow.Columns.Add("可用空间");
            lvshow.LargeImageList = imgdt;
            lvshow.SmallImageList = imgxt;
            ListViewItem itemc = new ListViewItem("小强", 0);
            ListViewItem itemc2 = new ListViewItem("狗蛋", 1);
            ListViewItem itemc3 = new ListViewItem("战三", 2);
            lvshow.Items.Add(itemc);
            lvshow.Items.Add(itemc2);
            lvshow.Items.Add(itemc3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lvshow.View = View.LargeIcon;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lvshow.View = View.SmallIcon;
        }
    }
}
