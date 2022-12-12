namespace Library
{
    partial class ManagerMenu
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerMenu));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsmStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddExp = new System.Windows.Forms.ToolStripMenuItem();
            this.收支管理EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查改普通用户UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.注销DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.图书管理MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书类别管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加图书类别AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改图书类别MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询图书类别SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加图书信息AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改图书信息MToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.查询图书信息SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.报废图书处理BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读者类别管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加读者类别AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加读者类别AToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.查改读者类别MToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.修改读者类别MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加读者信息AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查改读者信息MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询读者信息SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除读者信息DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.活跃读者统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最热图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最热图书统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.失信读者统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除借阅记录DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(511, 17);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Text = "请选择一个操作";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel1.Text = "就绪";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 318);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(558, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsmStatistics
            // 
            this.tsmStatistics.Name = "tsmStatistics";
            this.tsmStatistics.Size = new System.Drawing.Size(168, 22);
            this.tsmStatistics.Text = "重置用户密码(&M)";
            this.tsmStatistics.Click += new System.EventHandler(this.tsmStatistics_Click);
            // 
            // tsmAddExp
            // 
            this.tsmAddExp.Name = "tsmAddExp";
            this.tsmAddExp.Size = new System.Drawing.Size(168, 22);
            this.tsmAddExp.Text = "添加普通用户(&A)";
            this.tsmAddExp.Click += new System.EventHandler(this.tsmAddExp_Click);
            // 
            // 收支管理EToolStripMenuItem
            // 
            this.收支管理EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAddExp,
            this.查改普通用户UToolStripMenuItem,
            this.tsmStatistics});
            this.收支管理EToolStripMenuItem.Name = "收支管理EToolStripMenuItem";
            this.收支管理EToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.收支管理EToolStripMenuItem.Text = "用户管理";
            // 
            // 查改普通用户UToolStripMenuItem
            // 
            this.查改普通用户UToolStripMenuItem.Name = "查改普通用户UToolStripMenuItem";
            this.查改普通用户UToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.查改普通用户UToolStripMenuItem.Text = "查改普通用户(&U)";
            this.查改普通用户UToolStripMenuItem.Click += new System.EventHandler(this.查改普通用户UToolStripMenuItem_Click);
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(152, 22);
            this.tsmExit.Text = "退出(&X)";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // 注销DToolStripMenuItem
            // 
            this.注销DToolStripMenuItem.Name = "注销DToolStripMenuItem";
            this.注销DToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.注销DToolStripMenuItem.Text = "注销(&D)";
            this.注销DToolStripMenuItem.Click += new System.EventHandler(this.注销DToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.注销DToolStripMenuItem,
            this.tsmExit});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(83, 21);
            this.toolStripMenuItem1.Text = "系统管理(S)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(474, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.收支管理EToolStripMenuItem,
            this.图书管理MToolStripMenuItem,
            this.读者类别管理ToolStripMenuItem,
            this.数据统计ToolStripMenuItem,
            this.数据管理ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(558, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 图书管理MToolStripMenuItem
            // 
            this.图书管理MToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图书类别管理ToolStripMenuItem,
            this.图书管理ToolStripMenuItem});
            this.图书管理MToolStripMenuItem.Name = "图书管理MToolStripMenuItem";
            this.图书管理MToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.图书管理MToolStripMenuItem.Text = "图书管理";
            // 
            // 图书类别管理ToolStripMenuItem
            // 
            this.图书类别管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加图书类别AToolStripMenuItem,
            this.修改图书类别MToolStripMenuItem,
            this.查询图书类别SToolStripMenuItem});
            this.图书类别管理ToolStripMenuItem.Name = "图书类别管理ToolStripMenuItem";
            this.图书类别管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.图书类别管理ToolStripMenuItem.Text = "图书类别管理";
            // 
            // 添加图书类别AToolStripMenuItem
            // 
            this.添加图书类别AToolStripMenuItem.Name = "添加图书类别AToolStripMenuItem";
            this.添加图书类别AToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.添加图书类别AToolStripMenuItem.Text = "添加图书类别(A)";
            this.添加图书类别AToolStripMenuItem.Click += new System.EventHandler(this.添加图书类别AToolStripMenuItem_Click);
            // 
            // 修改图书类别MToolStripMenuItem
            // 
            this.修改图书类别MToolStripMenuItem.Name = "修改图书类别MToolStripMenuItem";
            this.修改图书类别MToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.修改图书类别MToolStripMenuItem.Text = "修改图书类别(M)";
            this.修改图书类别MToolStripMenuItem.Click += new System.EventHandler(this.修改图书类别MToolStripMenuItem_Click);
            // 
            // 查询图书类别SToolStripMenuItem
            // 
            this.查询图书类别SToolStripMenuItem.Name = "查询图书类别SToolStripMenuItem";
            this.查询图书类别SToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.查询图书类别SToolStripMenuItem.Text = "查询图书类别(S)";
            this.查询图书类别SToolStripMenuItem.Click += new System.EventHandler(this.查询图书类别SToolStripMenuItem_Click);
            // 
            // 图书管理ToolStripMenuItem
            // 
            this.图书管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加图书信息AToolStripMenuItem,
            this.修改图书信息MToolStripMenuItem1,
            this.查询图书信息SToolStripMenuItem,
            this.报废图书处理BToolStripMenuItem});
            this.图书管理ToolStripMenuItem.Name = "图书管理ToolStripMenuItem";
            this.图书管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.图书管理ToolStripMenuItem.Text = "图书信息管理";
            // 
            // 添加图书信息AToolStripMenuItem
            // 
            this.添加图书信息AToolStripMenuItem.Name = "添加图书信息AToolStripMenuItem";
            this.添加图书信息AToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.添加图书信息AToolStripMenuItem.Text = "添加图书信息(&A)";
            this.添加图书信息AToolStripMenuItem.Click += new System.EventHandler(this.添加图书信息AToolStripMenuItem_Click);
            // 
            // 修改图书信息MToolStripMenuItem1
            // 
            this.修改图书信息MToolStripMenuItem1.Name = "修改图书信息MToolStripMenuItem1";
            this.修改图书信息MToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.修改图书信息MToolStripMenuItem1.Text = "修改图书信息(&M)";
            this.修改图书信息MToolStripMenuItem1.Click += new System.EventHandler(this.修改图书信息MToolStripMenuItem1_Click);
            // 
            // 查询图书信息SToolStripMenuItem
            // 
            this.查询图书信息SToolStripMenuItem.Name = "查询图书信息SToolStripMenuItem";
            this.查询图书信息SToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.查询图书信息SToolStripMenuItem.Text = "查询图书信息(&S)";
            this.查询图书信息SToolStripMenuItem.Click += new System.EventHandler(this.查询图书信息SToolStripMenuItem_Click);
            // 
            // 报废图书处理BToolStripMenuItem
            // 
            this.报废图书处理BToolStripMenuItem.Name = "报废图书处理BToolStripMenuItem";
            this.报废图书处理BToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.报废图书处理BToolStripMenuItem.Text = "报废图书处理(&B)";
            this.报废图书处理BToolStripMenuItem.Click += new System.EventHandler(this.报废图书处理BToolStripMenuItem_Click);
            // 
            // 读者类别管理ToolStripMenuItem
            // 
            this.读者类别管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加读者类别AToolStripMenuItem,
            this.修改读者类别MToolStripMenuItem});
            this.读者类别管理ToolStripMenuItem.Name = "读者类别管理ToolStripMenuItem";
            this.读者类别管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.读者类别管理ToolStripMenuItem.Text = "读者管理";
            // 
            // 添加读者类别AToolStripMenuItem
            // 
            this.添加读者类别AToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加读者类别AToolStripMenuItem1,
            this.查改读者类别MToolStripMenuItem1});
            this.添加读者类别AToolStripMenuItem.Name = "添加读者类别AToolStripMenuItem";
            this.添加读者类别AToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.添加读者类别AToolStripMenuItem.Text = "读者类别管理";
            // 
            // 添加读者类别AToolStripMenuItem1
            // 
            this.添加读者类别AToolStripMenuItem1.Name = "添加读者类别AToolStripMenuItem1";
            this.添加读者类别AToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.添加读者类别AToolStripMenuItem1.Text = "添加读者类别(&A)";
            this.添加读者类别AToolStripMenuItem1.Click += new System.EventHandler(this.添加读者类别AToolStripMenuItem1_Click);
            // 
            // 查改读者类别MToolStripMenuItem1
            // 
            this.查改读者类别MToolStripMenuItem1.Name = "查改读者类别MToolStripMenuItem1";
            this.查改读者类别MToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.查改读者类别MToolStripMenuItem1.Text = "查改读者类别(&M)";
            this.查改读者类别MToolStripMenuItem1.Click += new System.EventHandler(this.查改读者类别MToolStripMenuItem1_Click);
            // 
            // 修改读者类别MToolStripMenuItem
            // 
            this.修改读者类别MToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加读者信息AToolStripMenuItem,
            this.查改读者信息MToolStripMenuItem,
            this.查询读者信息SToolStripMenuItem,
            this.删除读者信息DToolStripMenuItem});
            this.修改读者类别MToolStripMenuItem.Name = "修改读者类别MToolStripMenuItem";
            this.修改读者类别MToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.修改读者类别MToolStripMenuItem.Text = "读者信息管理";
            // 
            // 添加读者信息AToolStripMenuItem
            // 
            this.添加读者信息AToolStripMenuItem.Name = "添加读者信息AToolStripMenuItem";
            this.添加读者信息AToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.添加读者信息AToolStripMenuItem.Text = "添加读者信息(&A)";
            this.添加读者信息AToolStripMenuItem.Click += new System.EventHandler(this.添加读者信息AToolStripMenuItem_Click);
            // 
            // 查改读者信息MToolStripMenuItem
            // 
            this.查改读者信息MToolStripMenuItem.Name = "查改读者信息MToolStripMenuItem";
            this.查改读者信息MToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.查改读者信息MToolStripMenuItem.Text = "查看读者信息(&S)";
            this.查改读者信息MToolStripMenuItem.Click += new System.EventHandler(this.查改读者信息MToolStripMenuItem_Click);
            // 
            // 查询读者信息SToolStripMenuItem
            // 
            this.查询读者信息SToolStripMenuItem.Name = "查询读者信息SToolStripMenuItem";
            this.查询读者信息SToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.查询读者信息SToolStripMenuItem.Text = "查改读者信息(&M)";
            this.查询读者信息SToolStripMenuItem.Click += new System.EventHandler(this.查询读者信息SToolStripMenuItem_Click);
            // 
            // 删除读者信息DToolStripMenuItem
            // 
            this.删除读者信息DToolStripMenuItem.Name = "删除读者信息DToolStripMenuItem";
            this.删除读者信息DToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.删除读者信息DToolStripMenuItem.Text = "删除读者信息(&D)";
            this.删除读者信息DToolStripMenuItem.Click += new System.EventHandler(this.删除读者信息DToolStripMenuItem_Click);
            // 
            // 数据统计ToolStripMenuItem
            // 
            this.数据统计ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.活跃读者统计ToolStripMenuItem,
            this.最热图书ToolStripMenuItem,
            this.最热图书统计ToolStripMenuItem,
            this.失信读者统计ToolStripMenuItem});
            this.数据统计ToolStripMenuItem.Name = "数据统计ToolStripMenuItem";
            this.数据统计ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.数据统计ToolStripMenuItem.Text = "数据统计";
            // 
            // 活跃读者统计ToolStripMenuItem
            // 
            this.活跃读者统计ToolStripMenuItem.Name = "活跃读者统计ToolStripMenuItem";
            this.活跃读者统计ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.活跃读者统计ToolStripMenuItem.Text = "活跃读者统计";
            this.活跃读者统计ToolStripMenuItem.Click += new System.EventHandler(this.活跃读者统计ToolStripMenuItem_Click);
            // 
            // 最热图书ToolStripMenuItem
            // 
            this.最热图书ToolStripMenuItem.Name = "最热图书ToolStripMenuItem";
            this.最热图书ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.最热图书ToolStripMenuItem.Text = "最热图书类别";
            this.最热图书ToolStripMenuItem.Click += new System.EventHandler(this.最热图书ToolStripMenuItem_Click);
            // 
            // 最热图书统计ToolStripMenuItem
            // 
            this.最热图书统计ToolStripMenuItem.Name = "最热图书统计ToolStripMenuItem";
            this.最热图书统计ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.最热图书统计ToolStripMenuItem.Text = "最热图书统计";
            this.最热图书统计ToolStripMenuItem.Click += new System.EventHandler(this.最热图书统计ToolStripMenuItem_Click);
            // 
            // 失信读者统计ToolStripMenuItem
            // 
            this.失信读者统计ToolStripMenuItem.Name = "失信读者统计ToolStripMenuItem";
            this.失信读者统计ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.失信读者统计ToolStripMenuItem.Text = "失信读者统计";
            this.失信读者统计ToolStripMenuItem.Click += new System.EventHandler(this.失信读者统计ToolStripMenuItem_Click);
            // 
            // 数据管理ToolStripMenuItem
            // 
            this.数据管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除借阅记录DToolStripMenuItem});
            this.数据管理ToolStripMenuItem.Name = "数据管理ToolStripMenuItem";
            this.数据管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.数据管理ToolStripMenuItem.Text = "数据管理";
            // 
            // 删除借阅记录DToolStripMenuItem
            // 
            this.删除借阅记录DToolStripMenuItem.Name = "删除借阅记录DToolStripMenuItem";
            this.删除借阅记录DToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.删除借阅记录DToolStripMenuItem.Text = "删除借阅记录(&D)";
            this.删除借阅记录DToolStripMenuItem.Click += new System.EventHandler(this.删除借阅记录DToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 9;
            // 
            // ManagerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 340);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagerMenu";
            this.Text = "图书管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerMenu_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmStatistics;
        private System.Windows.Forms.ToolStripMenuItem tsmAddExp;
        private System.Windows.Forms.ToolStripMenuItem 收支管理EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripMenuItem 注销DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 图书管理MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书类别管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加图书类别AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改图书类别MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询图书类别SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加图书信息AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改图书信息MToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 查询图书信息SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读者类别管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加读者类别AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加读者类别AToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 查改读者类别MToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 修改读者类别MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加读者信息AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查改读者信息MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询读者信息SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 活跃读者统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最热图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除借阅记录DToolStripMenuItem;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem 查改普通用户UToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除读者信息DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 失信读者统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 报废图书处理BToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最热图书统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
    }
}

