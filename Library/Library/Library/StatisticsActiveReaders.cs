
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
    public partial class StatisticsActiveReaders : Form
    {
        public StatisticsActiveReaders()
        {
            InitializeComponent();
        }
        string connString = @"Data Source=.;Initial Catalog=Library;User ID =sa;Pwd=123456";
        SqlConnection conn;
        SqlCommand comm;
        private void botton1_Click(object sender, EventArgs e)
        {
            string m = "", m1;
            bool fale = true;
            try
            {
                string sql = "select count(*) from BookLendList";
                conn = new SqlConnection(connString);
                comm = new SqlCommand(sql, conn);
                conn.Open();
                m1 = comm.ExecuteScalar().ToString().Trim();
                if (textBox1.Text.Trim() != "")
                    m = textBox1.Text.Trim();
                else if (textBox1.Text.Trim() == "")
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
                    string category = comboBox1.Text;
                    string date1 = Convert.ToString(dateTimePicker1.Value.ToString("yyyy/MM/dd"));
                    string date2 = Convert.ToString(dateTimePicker2.Value.ToString("yyyy/MM/dd"));
                    if (comboBox1.Text.Trim() != "")
                        sql = String.Format("select TOP {0} a.rid as 身份证号,Reader.rname as 姓名,a.b as 借书量 from Reader, ReaderCategory,"
                            + "(select rid,count(*) as b from booklendlist  where booklendlist.LendTime>= '{1}' and  booklendlist.LendTime<= '{2}'  group by rid ) as a "
                            + "where ReaderCategory.Rcategoryname='{3}' and ReaderCategory.Rcategoryid=reader.Rcategoryid  and a.Rid=reader.Rid "
                            + "order by a.b desc", m, date1, date2, category);
                    else
                        sql = String.Format("select TOP {0} a.rid as 身份证号,Reader.rname as 姓名,a.b as 借书量 from Reader, ReaderCategory,"
                            + "(select rid,count(*) as b from booklendlist  where booklendlist.LendTime>= '{1}' and  booklendlist.LendTime<= '{2}'  group by rid ) as a "
                            + "where ReaderCategory.Rcategoryid=reader.Rcategoryid  and a.Rid=reader.Rid "
                            + "order by a.b desc", m, date1, date2);
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
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

        private void StatisticsActiveReaders_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            string sql = "select * from ReaderCategory";
            try
            {
                conn = new SqlConnection(connString);
                comm = new SqlCommand(sql, conn);
                SqlDataReader dr;
                conn.Open();
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    string name = dr["Rcategoryname"].ToString().Trim();
                    comboBox1.Items.Add(name);
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
