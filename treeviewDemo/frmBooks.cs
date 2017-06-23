using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace treeviewDemo
{
    public partial class frmBooks : Form
    {
        SqlConnection sqlcon = null;
        string strcon = "Data Source=HP201-1;Initial Catalog=Book;Integrated Security=True";
        //定义一个变量表示选中节点
        string categpry;
        public frmBooks()
        {
            InitializeComponent();
           
        }

        private void frmBooks_Load(object sender, EventArgs e)
        {
            //设置为平铺
            lvwbooks.View = View.Details;
            BookList();
        }

        private void BookList() {
            //先清空listview中的数据
            lvwbooks.Items.Clear();
            sqlcon = new SqlConnection(strcon);
            try
            {
                sqlcon.Open();
                string strsql = string.Format(" SELECT BNo,BName,Author,Press,Price FROM dbo.Books WHERE Category LIKE '%C%'");
                SqlCommand cmd = new SqlCommand(strsql,sqlcon);
                SqlDataReader re = cmd.ExecuteReader();

                while (re.Read())
                {
                    //获得查询上的数据
                    string bookno =re["BNO"].ToString();
                    string bookname = re["BName"].ToString();
                    string bookauthor = re["Author"].ToString();
                    string bookpress = re["Press"].ToString();
                    double price = Convert.ToDouble(re["Price"]);
                    //创建listviewitem
                    ListViewItem item = new ListViewItem(bookno);
                    //添加子项
                    item.SubItems.Add(bookname);
                    item.SubItems.Add(bookauthor);
                    item.SubItems.Add(bookpress);
                    item.SubItems.Add(Convert.ToString( price));

                    lvwbooks.Items.Add(item);
                    re.Close();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void tvwbooks_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvwbooks.SelectedNode.Level==1)
            {

            }
        }
    }
}
