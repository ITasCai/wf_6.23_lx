using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_6._23_lx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnda_Click(object sender, EventArgs e)
        {
            //大图标
            lvList.View = View.LargeIcon;
        }

        //小图标
        private void btnxiao_Click(object sender, EventArgs e)
        {
            lvList.View = View.SmallIcon;
        }

        //显示列表
        private void btnshow_Click(object sender, EventArgs e)
        {
            lvList.View = View.Details;
        }
    }
}
