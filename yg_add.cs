using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 小区物业管理系统
{
    public partial class yg_add : Form
    {
        public yg_add()
        {
            InitializeComponent();
        }

        private void yg_add_Load(object sender, EventArgs e)
        {
            gender.Items.Add("男");
            gender.Items.Add("女");
            label8.Text = DateTime.Now.ToString().Trim();
            string sql;
            sql = "select bh from bumen order by id desc";
            DataSet hsgds = new DataSet();
            hsgds = new Class1().hsggetdata(sql);
            if (hsgds != null)
            {
                if (hsgds.Tables[0].Rows.Count > 0)
                {
                    int i;
                    for (i = 0; i < hsgds.Tables[0].Rows.Count; i++)
                    {
                        bm.Items.Add(hsgds.Tables[0].Rows[i]["bh"].ToString().Trim());
                    }
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "insert into yuangong(bh,xm,gender,tel,sfz,email,gw,bm,addr,memo) values('"+bh.Text.ToString().Trim()+"','"+xm.Text.ToString().Trim()+"','"+gender.Text.ToString().Trim()+"','"+tel.Text.ToString().Trim()+"','"+sfz.Text.ToString().Trim()+"','"+email.Text.ToString().Trim()+"','"+gw.Text.ToString().Trim()+"','"+bm.Text.ToString().Trim()+"','"+addr.Text.ToString().Trim()+"','"+memo.Text.ToString().Trim()+"')";
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void bh_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tel_TextChanged(object sender, EventArgs e)
        {

        }

        private void memo_TextChanged(object sender, EventArgs e)
        {

        }

        private void bm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addr_TextChanged(object sender, EventArgs e)
        {

        }

        private void gw_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void sfz_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void xm_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}