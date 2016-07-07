namespace WindowsFormsApplication1
{
    partial class MainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.浏览ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.薪资信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.薪资管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.薪资计算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.教师数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.教师数据查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.综合信息输出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem,
            this.菜单ToolStripMenuItem,
            this.薪资信息ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(811, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 菜单ToolStripMenuItem
            // 
            this.菜单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.录入ToolStripMenuItem,
            this.修改ToolStripMenuItem,
            this.浏览ToolStripMenuItem});
            this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            this.菜单ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.菜单ToolStripMenuItem.Text = "信息处理";
            // 
            // 录入ToolStripMenuItem
            // 
            this.录入ToolStripMenuItem.Name = "录入ToolStripMenuItem";
            this.录入ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.录入ToolStripMenuItem.Text = "录入";
            this.录入ToolStripMenuItem.Click += new System.EventHandler(this.录入ToolStripMenuItem_Click);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改ToolStripMenuItem.Text = "修改/删除";
            this.修改ToolStripMenuItem.Click += new System.EventHandler(this.修改ToolStripMenuItem_Click);
            // 
            // 浏览ToolStripMenuItem
            // 
            this.浏览ToolStripMenuItem.Name = "浏览ToolStripMenuItem";
            this.浏览ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.浏览ToolStripMenuItem.Text = "浏览";
            this.浏览ToolStripMenuItem.Click += new System.EventHandler(this.浏览ToolStripMenuItem_Click);
            // 
            // 薪资信息ToolStripMenuItem
            // 
            this.薪资信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.薪资管理ToolStripMenuItem,
            this.薪资计算ToolStripMenuItem,
            this.教师数据ToolStripMenuItem});
            this.薪资信息ToolStripMenuItem.Name = "薪资信息ToolStripMenuItem";
            this.薪资信息ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.薪资信息ToolStripMenuItem.Text = "数据处理";
            // 
            // 薪资管理ToolStripMenuItem
            // 
            this.薪资管理ToolStripMenuItem.Name = "薪资管理ToolStripMenuItem";
            this.薪资管理ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.薪资管理ToolStripMenuItem.Text = "录入";
            this.薪资管理ToolStripMenuItem.Click += new System.EventHandler(this.薪资管理ToolStripMenuItem_Click);
            // 
            // 薪资计算ToolStripMenuItem
            // 
            this.薪资计算ToolStripMenuItem.Name = "薪资计算ToolStripMenuItem";
            this.薪资计算ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.薪资计算ToolStripMenuItem.Text = "薪资计算";
            this.薪资计算ToolStripMenuItem.Click += new System.EventHandler(this.薪资计算ToolStripMenuItem_Click);
            // 
            // 教师数据ToolStripMenuItem
            // 
            this.教师数据ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.教师数据查询ToolStripMenuItem,
            this.综合信息输出ToolStripMenuItem});
            this.教师数据ToolStripMenuItem.Name = "教师数据ToolStripMenuItem";
            this.教师数据ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.教师数据ToolStripMenuItem.Text = "教师数据";
            // 
            // 教师数据查询ToolStripMenuItem
            // 
            this.教师数据查询ToolStripMenuItem.Name = "教师数据查询ToolStripMenuItem";
            this.教师数据查询ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.教师数据查询ToolStripMenuItem.Text = "数据查询/修改";
            this.教师数据查询ToolStripMenuItem.Click += new System.EventHandler(this.教师数据查询ToolStripMenuItem_Click);
            // 
            // 综合信息输出ToolStripMenuItem
            // 
            this.综合信息输出ToolStripMenuItem.Name = "综合信息输出ToolStripMenuItem";
            this.综合信息输出ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.综合信息输出ToolStripMenuItem.Text = "综合信息输出";
            this.综合信息输出ToolStripMenuItem.Click += new System.EventHandler(this.综合信息输出ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem1});
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.退出ToolStripMenuItem.Text = "菜单";
            // 
            // 退出ToolStripMenuItem1
            // 
            this.退出ToolStripMenuItem1.Name = "退出ToolStripMenuItem1";
            this.退出ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.退出ToolStripMenuItem1.Text = "退出";
            this.退出ToolStripMenuItem1.Click += new System.EventHandler(this.退出ToolStripMenuItem1_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(811, 536);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrm";
            this.Text = "教师薪资管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 录入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 浏览ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 薪资信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 薪资管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 薪资计算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 教师数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 教师数据查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 综合信息输出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem1;
    }
}