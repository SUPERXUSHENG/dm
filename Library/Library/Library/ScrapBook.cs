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

namespace Library
{
    public partial class ScrapBook : Form
    {
        public ScrapBook()
        {
            InitializeComponent();
        }
        string connString = @"Data Source = .;Initial Catalog = Library; User ID = sa; Pwd = 123456";
        SqlConnection conn; //声明连接对象
        SqlCommand comm; //声明命令对象
        string sql;
        string isbn;
        SqlDataReader dr;
        string state;
        int nm = 0;
        string sss;
        string st;
        int n;
        private void ScrapBook_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString); //创建Connection对象
            comm = new SqlCommand(); //创建Commmand对象
            comm.Connection = conn; //设置command使用的Connection对象
            button1.Enabled = false;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            isbn = txtISBN.Text.ToString().Trim();
            sql = String.Format("Select * from BookList, BookCategory where ISBN = '{0}' and BookCategory.bCategoryid =  BookList.bCategoryid", isbn);
            try
            {
                conn.Open();
                comm.CommandText = sql;
                dr = comm.ExecuteReader();
                int k = 0;
                while (dr.Read())
                {
                    k++;
                    richTextBox1.Text = "书名：" + dr[1] + "\n第一作者：" + dr["author"] + "\n图书类别：" + dr["bCategoryname"]
                        + "\n第一出版社：" + dr["publisher"] + "\n出版年份：" + dr["publishTime"];
                    state = dr["bookstate"].ToString();
                    n = int.Parse(dr["num"].ToString());
                    st = "库存数目：" + dr["num"];
                    sss = "\n借出数目：" + dr["lendnum"] + "\n图书状态：";
                    if (state == "True")
                        richTextBox2.Text = st + sss + "正常";
                    else
                        richTextBox2.Text = st + sss + "报废";
                    nm = int.Parse(dr["num"].ToString()) - int.Parse(dr["lendnum"].ToString());
                }
                if (k == 0)
                    MessageBox.Show("ISBN查找失败！\n   请查对", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    button1.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                conn.Close();
                dr.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql = String.Format("Update BookList set bookstate = 0 where ISBN = '{0}'", isbn);
            try
            {
                conn.Open();
                comm.CommandText = sql;
                int k = (int)comm.ExecuteNonQuery();
                if (k > 0)
                {
                    MessageBox.Show("操作成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    richTextBox2.Text = st + sss + "报废";
                }
                else
                    MessageBox.Show("操作失败！", "失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
