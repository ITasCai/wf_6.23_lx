using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace treeviewDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //定义一个根节点
            TreeNode tn = new TreeNode("慧与实训");
            //定义子节点
            TreeNode t1 = new TreeNode("众阳定制班");
            TreeNode t2 = new TreeNode("开发一班");
            TreeNode t3 = new TreeNode("开发二班");
            //添加三个班级
            tn.Nodes.Add(t1);
            tn.Nodes.Add(t2);
            tn.Nodes.Add(t3);
            //添加到TreeView控件上
            tvwStu.Nodes.Add(tn);
        }

        private void tvwSubject_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void tvwStu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //清除原有信息
            listStudent.Items.Clear();
            tvwSubject.Nodes.Clear();
            TreeNode tr = null;
            TreeNode a1 = null;
            TreeNode a2 = null;
            TreeNode a3 = null;
            switch (e.Node.Text)
            {
                case "众阳定制班":
                    tr = new TreeNode("软件基础开发");
                    a1 = new TreeNode("C#基础");
                    a2 = new TreeNode("sqlserver");
                    a3 = new TreeNode("winfrom");

                    tr.Nodes.Add(a1);
                    tr.Nodes.Add(a2);
                    tr.Nodes.Add(a3);
                    tvwSubject.Nodes.Add(tr);
                    //添加学生

                    listStudent.Items.Add("狗蛋");
                    listStudent.Items.Add("张三");
                    listStudent.Items.Add("李四");
                    break;
                case "开发一班":
                    tr = new TreeNode("软件基础开发");
                    a1 = new TreeNode("java");
                    a2 = new TreeNode("js");
                    a3 = new TreeNode("vb");

                    tr.Nodes.Add(a1);
                    tr.Nodes.Add(a2);
                    tr.Nodes.Add(a3);
                    tvwSubject.Nodes.Add(tr);
                    //添加学生

                    listStudent.Items.Add("蛋仔");
                    listStudent.Items.Add("张三");
                    listStudent.Items.Add("赵六");
                    break;
                case "开发二班":
                    tr = new TreeNode("软件基础开发");
                    a1 = new TreeNode("C#基础");
                    a2 = new TreeNode("sqlserver");
                    a3 = new TreeNode("winfrom");

                    tr.Nodes.Add(a1);
                    tr.Nodes.Add(a2);
                    tr.Nodes.Add(a3);
                    tvwSubject.Nodes.Add(tr);
                    //添加学生

                    listStudent.Items.Add("网吧");
                    listStudent.Items.Add("蔬菜");
                    listStudent.Items.Add("嘎嘎龙");
                    break;


            }
        }
    }
}
