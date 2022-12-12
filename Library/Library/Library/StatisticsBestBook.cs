
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
    public partial class StatisticsBestBook : Form
    {
        public StatisticsBestBook()
        {
            InitializeComponent();
        }
        string connString = @"Data Source=.;Initial Catalog=Library;User ID =sa;Pwd=123456";
        SqlConnection conn;
        SqlCommand comm;
        private void button1_Click(object sender, EventArgs e)
        {
            string m = textBox1.Text.Trim(), m1 = "";
            bool fale = true;
            try
            {

                string sql = "select count(*) from BookCategory";
                conn = new SqlConnection(connString);
                comm = new SqlCommand(sql, conn);
                conn.Open();
                m1 = comm.ExecuteScalar().ToString().Trim();
                if (textBox1.Text.Trim() == "")
                    m = m1;
                for (int i = 0; i < m.Length; i++)
                    if (m[i] > '9' || m[i] < '0')
                    {
                        fale = false;
                    }
                if (fale == false)
                {
                    MessageBox.Show("请重新输入数字！", "只能输入数字", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBox1.Text = "";
                }
                else
                {
                    conn = new SqlConnection(connString);
                    string date1 = Convert.ToString(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    string date2 = Convert.ToString(dateTimePicker2.Value.ToString("yyyy-MM-dd"));
                    sql = String.Format("select TOP {0} c.bCategoryname as 图书类型,sum(d.数) as 借书人次 from booklist as b,BookCategory as c,(select ISBN,count(*) as 数 from booklendlist where LendTime>= '{1}' and  LendTime<='{2}' group by ISBN ) as d  where b.ISBN=d.ISBN and c.bCategoryid=b.bCategoryid   group by c.bCategoryname order by 借书人次   desc", m, date1, date2);
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    if (ds.Tables.Count == 1 && ds.Tables[0].Rows.Count == 0)
                        MessageBox.Show("没有符合条件的记录", "请选择合适的条件！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
