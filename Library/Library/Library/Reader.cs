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
using System.Text.RegularExpressions;

namespace Library
{
    public partial class Reader : Form
    {
        public Reader()
        {
            InitializeComponent();
        }
        string connString = @"Data Source =.;Initial Catalog = Library ; User ID= sa;Pwd = 123456";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataReader dr;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private bool check(string s)
        {
            if (s.Length != 18)
                return false;
            int flag = 1;
            for (int i = 0; i < 17; i++)
            {
                if (!(s[i] >= '0' && s[i] <= '9'))
                {
                    flag = 0;
                    break;
                }    
            }
            if (flag == 0)
                return false;
            if ((s[17] >= '0' && s[17] <= '9') || s[17] == 'X')
                return true;
            return false;
        }
        private bool checkk(string s)
        {
            if (s.Length != 18)
                return false;
            int flag = 1;
            for (int i = 0; i < 17; i++)
            {
                if (!(s[i] >= '0' && s[i] <= '9'))
                {
                    flag = 0;
                    break;
                }
            }
            if (flag == 0)
                return false;
            if ((s[17] >= '0' && s[17] <= '9') || s[17] == 'X')
                return true;
            return false;
        }
        public int caid;
        private void button1_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex("^[0-9]*$");
            if (textBox1.Text.Trim() == string.Empty || textBox2.Text.Trim() == string.Empty || comboBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("信息不完整", "信息不完整", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!check(textBox2.Text.ToString().Trim()))
                MessageBox.Show("身份证号格式错误", "信息格式错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (!reg.IsMatch(textBox3.Text.Trim()) && textBox3.Text.Trim() != "")
                MessageBox.Show("电话号必须为数字", "信息格式错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                string category = comboBox1.Text.Trim();
                string sql = String.Format("select Rcategoryid from ReaderCategory where Rcategoryname='{0}'", category);
                try
                {
                    conn.Open();
                    comm.CommandText = sql;
                    dr = comm.ExecuteReader();
                    while (dr.Read())
                    {
                        int cid = (int)dr[0];
                        caid = cid;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "操作数据库出错", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    dr.Close();
                    conn.Close();
                }
                string name = textBox1.Text.Trim();
                string id = textBox2.Text.Trim();
                string lnum = label9.Text;
                string bsum = label8.Text;
                string phone = textBox3.Text.Trim();
                sql = String.Format("INSERT INTO Reader(Rname,Rcategoryid,Rid,Phone,RbLnum)VALUES" + "('{0}',{1},'{2}','{3}',0)", name, caid, id, phone);
                try
                {
                    conn.Open();
                    comm.CommandText = sql;
                    int count = comm.ExecuteNonQuery();
                    if (count > 0)
                        MessageBox.Show("添加成功", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("添加成功", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "操作数据库出错", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    conn.Close();
                }
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                label9.Text = "";
                label8.Text = "";
                comboBox1.SelectedIndex = 0;
            }
        }

        private void Reader_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString);
            comm = new SqlCommand();
            comm.Connection = conn;
            int cId = 0;
            Category category = comboBox1.SelectedItem as Category;
            if (category != null) cId = category.CId;
            string sql = String.Format("select * from ReaderCategory ");
            try                              
            {
                conn.Open();
                comm.CommandText = sql;
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    int iId = (int)dr[0];
                    string name = dr["Rcategoryname"].ToString().Trim();
                    comboBox1.Items.Add(new Item(iId, name));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                dr.Close();
                conn.Close();
                comboBox1.SelectedIndex = 0;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoryname = comboBox1.Text.Trim();
            string sql = String.Format("select Rbnum, Rday from ReaderCategory where Rcategoryname='{0}'",categoryname);
            try
            {
                conn.Open();
                comm.CommandText = sql;
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    int iId = (int)dr[0];
                    label8.Text = dr["Rbnum"].ToString().Trim();
                    label9.Text = dr["Rday"].ToString().Trim();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                dr.Close();
                conn.Close();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
    class Item
    {
        public int IId;
        public string IName;
        public Item(int id, string name)
        {
            IId = id;
            IName = name;
        }
        public override string ToString()
        {
            return IName;
        }
    }
    class Category
    {
        public int CId;
        public string CName;
        public Category(int id, string name)
        {
            CId = id;
            CName = name;
        }
        public override string ToString()
        {
            return CName;
        }
    }
}
