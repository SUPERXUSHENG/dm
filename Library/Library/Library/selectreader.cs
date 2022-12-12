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
    public partial class selectreader : Form
    {
        public selectreader()
        {
            InitializeComponent();
        }
        int t = 1;
        string connString = @"Data Source=.;Initial Catalog=Library;User ID =sa;Pwd=123456";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataReader dr;
        public string num;
        public int q = 0;
        public string w = "";
        private void button1_Click(object sender, EventArgs e)
        {
            q = 0;
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("内容不能为空！！！");
            }
            else
            {
                string id = textBox1.Text.Trim();
                w = id;
                string condition = "";
                condition = String.Format("and a.Rid like %'{0}'%", id);
                string sql = " select * from Reader ";
                try
                {
                    conn.Open();
                    comm.CommandText = sql;
                    dr = comm.ExecuteReader();

                    while (dr.Read())
                    {
                        string name = dr[1].ToString().Trim();
                        string category = dr["Rcategoryid"].ToString().Trim();
                        string ID = dr["Rid"].ToString().Trim();
                        string phone = dr["Phone"].ToString().Trim();
                        string Lnum = dr["Rblnum"].ToString().Trim();
                        num = Lnum;
                        if (id == ID)
                        {
                            richTextBox1.Text = "姓名：" + name + "\n身份证号：" + ID + "\n电话：" + phone + "\n已借书数目：" + Lnum;
                            q = q + 1;
                        }
                    }
                    if (q == 0)
                    {
                        MessageBox.Show("未查找到!");
                        richTextBox1.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "操作数    据库出错", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    dr.Close();
                    conn.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t = 1;
            if (comboBox1.Text.Trim() == "" || textBox2.Text.Trim() == "")
            {
                MessageBox.Show("信息不完整！");
                textBox2.Clear();
                comboBox1.Text = "";
            }
            else
            {
                string neirong = textBox2.Text.Trim();
                string key = comboBox1.Text.Trim();
                string condition = "";
                if (comboBox1.Text.Trim() == "电话")
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
                //if (comboBox1.Text.Trim() == "身份证号")
                //{
                //    int nei = 0;
                //    try
                //    {
                //        nei = Convert.ToInt32(neirong);
                //    }
                //    catch (Exception EX) { MessageBox.Show("数据出错！"); }
                //    if (nei <= 0)
                //    {
                //        MessageBox.Show("只能为正整数");
                //        t = 0;
                //    }
                //    textBox2.Clear();
                //}
                if (t != 0)
                {
                    switch (key)
                    {
                        case "姓名":
                            condition = String.Format("update Reader set Rname = '{0}' where Rid='{1}'", neirong, w); break;
                        case "身份证号":
                            condition = String.Format("update Reader set Rid = '{0}' where Rid='{1}'", neirong, w); break;
                        case "电话":
                            condition = String.Format("update Reader set Phone = '{0}' where Rid='{1}'", neirong, w); break;
                        //case "借书数":
                        // condition = String.Format("update Reader set RbLnum = '{0}' where Rid='{1}'", neirong, w); break;
                    }
                    string sql = condition;
                    SqlCommand comm = new SqlCommand(sql, conn);
                    try
                    {
                        conn.Open();
                        comm.CommandText = sql;
                        int count = comm.ExecuteNonQuery();
                        if (count > 0)
                            MessageBox.Show("修改成功！", "修改成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("修改失败！", "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("该身份证号已存在！", "操作数据出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        //MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    finally
                    {
                        conn.Close();
                    }
                    textBox1.Clear();
                    richTextBox1.Clear();
                    textBox2.Clear();
                    comboBox1.Text = "";
                }
            }
        }

        private void selectreader_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString);
            comm = new SqlCommand();
            comm.Connection = conn;
        }
    }
}
