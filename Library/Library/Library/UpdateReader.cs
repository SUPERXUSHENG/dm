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
    public partial class UpdateReader : Form
    {
        public UpdateReader()
        {
            InitializeComponent();
        }
        string connString = @"Data Source =.;Initial Catalog = Library ; User ID= sa;Pwd = 123456";
        SqlConnection conn;
        SqlCommand comm;
        bool midentity = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == string.Empty || textBox2.Text.Trim() == string.Empty || textBox3.Text.Trim() == string.Empty)
            {
                MessageBox.Show("信息不完整", "信息不完整", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string username = textBox1.Text.Trim();
                string password1 = textBox2.Text.Trim();
                string password2 = textBox3.Text.Trim();
                if (radioButton1.Checked == true)
                    midentity = true;
                else
                    midentity = false;
                if (password1 != password2)
                {
                    MessageBox.Show("两次密码不一致", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox3.Clear();
                }
                else
                {
                    string sql = String.Format("update Manager set managerPassword='{0}',mIdentity='{1}' where managerid='{2}' ", password1, midentity, username);
                    try
                    {
                        conn.Open();
                        comm.CommandText = sql;
                        int count = comm.ExecuteNonQuery();
                        if (count > 0)
                            MessageBox.Show("修改成功", "修改成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("修改失败", "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                }
            }
        }

        private void UpdateReader_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString);
            comm = new SqlCommand();
            comm.Connection = conn;
            radioButton2.Checked = true;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                midentity = true;
            else
                midentity = false;
            string username = textBox1.Text.Trim();
            string sql = String.Format("Select count(*) from Manager where managerid = '{0}' and mIdentity='{1}'", username, midentity);
            conn.Open();
            comm.CommandText = sql;
            int k = (int)comm.ExecuteScalar();
            if (k <= 0)
            {
                MessageBox.Show("该用户不存在", "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
            }
            conn.Close();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                midentity = true;
            else
                midentity = false;
            string username = textBox1.Text.Trim();
            string sql = String.Format("Select count(*) from Manager where managerid = '{0}' and mIdentity='{1}'", username, midentity);
            conn.Open();
            comm.CommandText = sql;
            int k = (int)comm.ExecuteScalar();
            if (k <= 0)
            {
                MessageBox.Show("该用户不存在", "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
            }
            conn.Close();
        }


    }
}
