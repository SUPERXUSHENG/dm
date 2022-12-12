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
    public delegate void ChildClose();
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string passworld = textBox2.Text.Trim();
            bool midentity = false;
            if(radioButton1.Checked == true )
                midentity = true;
            else
                midentity = false;
            string connstring = "Data Source = .;Initial Catalog = Library;User ID=sa;Pwd=123456";
            SqlConnection conn = new SqlConnection(connstring);
            string sql = String.Format("select count(*) from [Manager] where managerid='{0}' and managerPassword='{1}' and mIdentity='{2}'", username, passworld,midentity );
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                int num = (int)comm.ExecuteScalar();
                if (num == 1)
                {
                    MessageBox.Show("欢迎使用", "登录成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (radioButton1.Checked == true)
                    {
                        ManagerMenu mm = new ManagerMenu();
                        this.Visible = false; //隐藏登录
                        mm.closeFather += new ChildClose(this.Close);
                        mm.ShowDialog();
                        textBox1.Clear();
                        textBox2.Clear();
                        this.Visible = true;
                    }
                    else
                    {
                        WorkerMainFrm mm = new WorkerMainFrm();
                        this.Visible = false; //隐藏登录
                        mm.closeFather += new ChildClose(this.Close);
                        mm.ShowDialog();
                        textBox1.Clear();
                        textBox2.Clear();
                        this.Visible = true;
                    }
                }
                else
                {
                    textBox2.Text = "";
                    MessageBox.Show("用户名或密码错误,如忘记密码请到教务处重置密码！！！", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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

        private void Login_Load(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
        }
    }
}
