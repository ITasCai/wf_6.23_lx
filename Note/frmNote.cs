using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Note
{
    public partial class frmNote : Form
    {
        public frmNote()
        {
            InitializeComponent();
        }

        private void 帮组ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //显示字体对话框
            fdgfont.ShowDialog();
            //设置字体样式
            txtshow.Font = fdgfont.Font;
        }

        private void 设置字体颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //显示颜色对话框
            cdgcolor.ShowDialog();
            //设置字体颜色
            txtshow.ForeColor = cdgcolor.Color;
        }

        private void 设置字体背景ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //显示颜色对话框
            cdgcolor.ShowDialog();
            //设置字体背景颜色
            txtshow.BackColor = cdgcolor.Color;
        }

        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //将所选的文字内容放入剪切板
            Clipboard.SetText(txtshow.SelectedText);
            //清空所选内容
            txtshow.SelectedText = "";
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //将对象内容放入光标内容
            txtshow.SelectedText = Clipboard.GetText();
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //将所选内容放入光标内容
            Clipboard.SetText(txtshow.SelectedText);
            
        }
    }
}
