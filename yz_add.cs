using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 小区物业管理系统
{
    public partial class yz_add : Form
    {
        public yz_add()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yz_add_Load(object sender, EventArgs e)
        {
            label8.Text = DateTime.Now.ToString().Trim();
            gender.Items.Add("男");
            gender.Items.Add("女");
            string sql;
            sql = "select bh from fangjian order by id desc";
            DataSet hsgds = new DataSet();
            hsgds = new Class1().hsggetdata(sql);
            if (hsgds != null)
            {
                if (hsgds.Tables[0].Rows.Count > 0)
                {
                    int i;
                    for (i = 0; i < hsgds.Tables[0].Rows.Count; i++)
                    {
                        fj.Items.Add(hsgds.Tables[0].Rows[i]["bh"].ToString().Trim());
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "insert into yezhu(bh,xm,gender,tel,sfz,email,fj,rzsj,addr,memo) values('"+bh.Text.ToString().Trim()+"','"+xm.Text.ToString().Trim()+"','"+gender.Text.ToString().Trim()+"','"+tel.Text.ToString().Trim()+"','"+sfz.Text.ToString().Trim()+"','"+email.Text.ToString().Trim()+"','"+fj.Text.ToString().Trim()+"','"+rzsj.Value.ToString().Trim()+"','"+addr.Text.ToString().Trim()+"','"+memo.Text.ToString().Trim()+"')";
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
    }
}