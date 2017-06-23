using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIDemo
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void munshow_Click(object sender, EventArgs e)
        {
            //实例化子窗体
            frmChil fr = new frmChil();
            //让子窗体的父窗体指向当前窗体
            fr.MdiParent = this;
            //显示子窗体
            fr.Show();
        }

        private void munmax_Click(object sender, EventArgs e)
        {
            //遍历当前父窗体的所有子窗体
            foreach (Form frm in this.MdiChildren)
            {
                //最大化子窗体
                frm.WindowState = FormWindowState.Maximized;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           
        }

        private void munmin_Click(object sender, EventArgs e)
        {
            //遍历当前父窗体的所有子窗体
            foreach (Form frm in this.MdiChildren)
            {
                //最小化子窗体
                frm.WindowState = FormWindowState.Minimized;
            }
        }

        private void munclose_Click(object sender, EventArgs e)
        {
            //遍历当前父窗体的所有子窗体
            foreach (Form frm in this.MdiChildren)
            {
                //关闭子窗体
                frm.Close(); ;
            }
        }

        private void muncd_Click(object sender, EventArgs e)
        {
            //子窗体层叠
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void munsp_Click(object sender, EventArgs e)
        {
            //子窗体水平
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void muncz_Click(object sender, EventArgs e)
        {
            // 子窗体垂直
            LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
