using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 小区物业管理系统
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //弹出新窗体,下同不赘述
            
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 newform = new Form4();
            newform.Show();
           
        }

        private void 添加管理员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ly_add newform = new ly_add();
            newform.Show();
        }




        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form8 newform = new Form8();
            newform.Show();
           
        }





        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form3 newform = new Form3();
            newform.Show();
        }

        private void 客户资料模块ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ly_list newform = new ly_list();
            newform.Show();
        }







        private void 重新登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
            

        }

        private void 退出ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void 商品类别管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 档案添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yz_add newform = new yz_add();
            newform.Show();
        }

        private void 档案管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yz_list newform = new yz_list();
            newform.Show();
        }

        private void 关于ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fy_add newform = new fy_add();
            newform.Show();
        }

        private void 销售添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void 销售记录查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 修改密码ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form3 newform = new Form3();
            newform.Show();
        }

        private void 利润查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 工资查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fy_list newform = new fy_list();
            newform.Show();
        }

        private void 房间添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fj_add newform = new fj_add();
            newform.Show();
        }

        private void 房间查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fj_list newform = new fj_list();
            newform.Show();
        }
    }
}