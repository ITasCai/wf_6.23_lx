using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBarDeam
{
    public partial class frmdeam : Form
    {
        //定义时间为5秒
        public int s = 5;
        public frmdeam()
        {
            InitializeComponent();
            //开启定时器
            tmrtime.Start();
        }

        private void frmdeam_Load(object sender, EventArgs e)
        {
          
        }

        private void tmrtime_Tick(object sender, EventArgs e)
        {
            //时间递减
            s--;
            //显示变化的时间
            lblsz.Text = s.ToString();
            //按增加的步长显示进度条
            pgrtime.PerformStep();
            if (s == 0)
            {
                //关闭定时器
                tmrtime.Stop();
                //显示主页面
                frmMain fr = new frmMain();
                fr.Show();
                //隐藏主窗体
                Hide();

            }
        }
    }
}
