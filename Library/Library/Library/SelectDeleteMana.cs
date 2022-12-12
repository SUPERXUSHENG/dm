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
    public partial class SelectDeleteMana : Form
    {
        public SelectDeleteMana()
        {
            InitializeComponent();
        }

        string connString = @"Data Source =.;Initial Catalog = Library ; User ID= sa;Pwd = 123456";
        SqlConnection conn;
        SqlCommand comm;
        DataSet ds;
        SqlDataAdapter da;

        private void SelectDeleteMana_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString);
            comm = new SqlCommand();
            comm.Connection = conn;
            string sql = "Select managerid as 账号 from Manager where mIdentity = 0";
            try
            {
                ds = new DataSet("MyData");
                conn.Open();
                da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "MyData");
                DataColumn column = new DataColumn("删除", typeof(bool));
                ds.Tables["MyData"].Columns.Add(column);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].ReadOnly = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("\t确定删除该账号？", "删除", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                try
                {
                    string[] id = new string[20];
                    int[] row = new int[20];
                    int cnt = 0;
                    int count = dataGridView1.Rows.Count - 1;
                    for (int i = 0; i < count; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[1].Value.ToString() == "True")
                        {
                            id[cnt] = dataGridView1.Rows[i].Cells[0].Value.ToString();
                            row[cnt++] = i;
                        }
                    }
                    string sql;
                
                    conn.Open();
                    int k;
                    int flag = 1;
                    for (int i = cnt - 1; i >= 0; i--)
                    {
                        sql = String.Format("DELETE from Manager where managerid = '{0}'", id[i]);
                        comm.CommandText = sql;
                        k = (int)comm.ExecuteNonQuery();
                        if (k <= 0)
                        {
                            MessageBox.Show("删除用户失败", "删除失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            flag = 0;
                            break;
                        }
                        dataGridView1.Rows.RemoveAt(row[i]);
                    }
                    if (flag == 1 && cnt > 0)
                    {
                        MessageBox.Show("删除记录成功", "删除成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.Rows.Count - 1;
            for (int i = 0; i < count; i++)
            {
                dataGridView1.Rows[i].Cells[1].Value = false;
            }
        }
    }
}
