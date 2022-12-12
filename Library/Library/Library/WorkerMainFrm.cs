using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class WorkerMainFrm : Form
    {
        public WorkerMainFrm()
        {
            InitializeComponent();
        }

        public event ChildClose closeFather;
        bool flag = false;

        private bool showChildrenForm(string p_ChildrenFormName)
        {
            int i;
            //依次检测当前窗体的子窗体  
            for (i = 0; i < this.MdiChildren.Length; i++)
            {
                //判断当前子窗体的name属性值是否与传入的字符串值相同  
                if (this.MdiChildren[i].Name == p_ChildrenFormName)
                {
                    //此子窗体是目标子窗体，激活之  
                    //this.MdiChildren[i].Activate();
                    this.MdiChildren[i].WindowState = FormWindowState.Normal;
                    return true;
                }
            }
            return false;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定退出？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
                Application.Exit();
        }

        private void 注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flag = true;
            DialogResult dr = MessageBox.Show("确定注销？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
                this.Close();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!showChildrenForm("ChangePassword"))
            {
                ChangePassword a = new ChangePassword();
                this.IsMdiContainer = true;
                a.MdiParent = this;
                a.Show();
            }
        }

        private void 查询读者借阅情况ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!showChildrenForm("ReaderSelectBorrowing"))
            {
                ReaderSelectBorrowing a = new ReaderSelectBorrowing();
                this.IsMdiContainer = true;
                a.MdiParent = this;
                a.Show();
            }
        }

        private void 查询图书借阅情况ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!showChildrenForm("BookSelectBorrowing"))
            {
                BookSelectBorrowing a = new BookSelectBorrowing();
                this.IsMdiContainer = true;
                a.MdiParent = this;
                a.Show();
            }
        }

        private void 为读者借书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!showChildrenForm("LendBook"))
            {
                LendBook a = new LendBook();
                this.IsMdiContainer = true;
                a.MdiParent = this;
                a.Show();
            }
        }

        private void 为读者还书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!showChildrenForm("BackBook"))
            {
                BackBook a = new BackBook();
                this.IsMdiContainer = true;
                a.MdiParent = this;
                a.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now; // 声明一个DateTime的对象；  
            //获取当前的日期；  
            //string strDate = dt.ToLongDateString().ToString();  
            // 获取当前的时间；  
            string strTime = dt.ToLongTimeString().ToString();
            // 用控件显示出来；  
            label1.Text = strTime; 
        }

        private void WorkerMainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            int k = 0;
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].WindowState == FormWindowState.Maximized || this.MdiChildren[i].WindowState == FormWindowState.Minimized || this.MdiChildren[i].WindowState == FormWindowState.Normal)
                {
                    k++;
                }
            }
            if (k > 1)
            {
                DialogResult result = MessageBox.Show("当前窗口以打开多个页面，确定要全部关闭？", "关闭", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    closeFather();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else if (flag == false)
            {
                closeFather();
            }
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("开发者：马超     张含松\n            宋富路   赵中奇\n\n系统版本：1.0.0");
        }
    }
}
