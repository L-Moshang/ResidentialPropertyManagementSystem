using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 小区物业管理系统
{
    public partial class bm_add : Form
    {
        public bm_add()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "insert into bumen(bh,mc,zgr,tel,memo) values('"+bh.Text.ToString().Trim()+"','"+mc.Text.ToString().Trim()+"','"+zgr.Text.ToString().Trim()+"','"+tel.Text.ToString().Trim()+"','"+memo.Text.ToString().Trim()+"')";
            int dd = 0;
            dd = new Class1().hsgexucute(sql);
            if (dd == 1)
            {
                //如果语句执行成功
                MessageBox.Show("操作成功");
            }
            else
            {
                //如果语句执行不成功
                MessageBox.Show("对不起，系统错误，请检查您的输入是否完全正确！");
            }

        }

        private void bm_add_Load(object sender, EventArgs e)
        {
            label8.Text = DateTime.Now.ToString().Trim();
        }
    }
}