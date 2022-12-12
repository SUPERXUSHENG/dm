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
    public partial class selsectcategory : Form
    {
        public selsectcategory()
        {
            InitializeComponent();
        }
        int t = 1;
        string connString = @"Data Source=.;Initial Catalog=Library;User ID =sa;Pwd=123456";
        SqlConnection conn;
        private void selsectcategory_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString);
            string sql = "select a.Rcategoryid as 身份类型编号,a.Rcategoryname as 类型名,a.Rbnum as 最大借书数,a.Rday as 最大借书天数"
                + " from ReaderCategory as a";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            comboBox1.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || comboBox1.Text.Trim() == "" || textBox2.Text.Trim() == "")
            {
                MessageBox.Show("信息不完整!");
            }
            else
            {
                conn = new SqlConnection(connString);
                string leibie = comboBox1.Text.Trim();
                string neirong = textBox2.Text.Trim();
                string id = textBox1.Text.Trim();
                string condition = "";
                if (comboBox1.Text.Trim() == "最大借书数")
                {
                    int nei = 0;
                    try
                    {
                        nei = Convert.ToInt32(neirong);
                    }
                    catch (Exception EX) { MessageBox.Show("数据出错！"); }
                    if (nei <= 0)
                    {
                        MessageBox.Show("只能为正整数");
                        t = 0;
                    }
                    textBox2.Clear();
                }
                if (comboBox1.Text.Trim() == "最大借书天数")
                {
                    int nei1 = 0;
                    try
                    {
                        nei1 = Convert.ToInt32(neirong);
                    }
                    catch (Exception EX) { MessageBox.Show("数据出错！"); }
                    if (nei1 < 0)
                    {
                        MessageBox.Show("只能为正整数");
                        t = 0;
                    }
                    textBox2.Clear();
                }
                if (t != 0)
                {
                    switch (leibie)
                    {
                        case "类型名":
                            condition = String.Format("update ReaderCategory set Rcategoryname = '{0}' where Rcategoryid='{1}'", neirong, id); break;
                        case "最大借书数":
                            condition = String.Format("update ReaderCategory set Rbnum = '{0}' where Rcategoryid='{1}' ", neirong, id); break;
                        case "最大借书天数":
                            condition = String.Format("update ReaderCategory set Rday = '{0}' where Rcategoryid='{1}'", neirong, id); break;
                    }
                    string sql = condition;
                    SqlCommand comm = new SqlCommand(sql, conn);
                    try
                    {
                        conn.Open();
                        comm.CommandText = sql;
                        int count = comm.ExecuteNonQuery();
                        if (count > 0)
                        {
                            MessageBox.Show("修改成功！", "修改成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            comboBox1.SelectedIndex = 1;
                        }
                        else
                        {
                            MessageBox.Show("修改失败！", "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            comboBox1.SelectedIndex = 1;
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
                    sql = "select a.Rcategoryid as 身份类型编号,a.Rcategoryname as 类型名,a.Rbnum as 最大借书数,a.Rday as 最大借书天数"
        + " from ReaderCategory as a";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    textBox1.Clear();
                    textBox2.Clear();
                }
            }
        }
    }
}
