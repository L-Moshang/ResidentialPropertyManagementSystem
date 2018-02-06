using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 小区物业管理系统
{
    public partial class fy_add : Form
    {
        public fy_add()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fy_add_Load(object sender, EventArgs e)
        {
            label8.Text = DateTime.Now.ToString().Trim();
            string sql;
            sql = "select bh from yezhu order by id desc";
            DataSet hsgds = new DataSet();
            hsgds = new Class1().hsggetdata(sql);
            if (hsgds != null)
            {
                if (hsgds.Tables[0].Rows.Count > 0)
                {
                    int i;
                    for (i = 0; i < hsgds.Tables[0].Rows.Count; i++)
                    {
                        bh.Items.Add(hsgds.Tables[0].Rows[i]["bh"].ToString().Trim());
                    }
                }

            }
        }

        private void bh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql;
            sql = "select xm from yezhu where bh='"+bh.Text.ToString().Trim()+"'";
            DataSet hsgds = new DataSet();
            hsgds = new Class1().hsggetdata(sql);
            if (hsgds != null)
            {
                if (hsgds.Tables[0].Rows.Count > 0)
                {
                    xm.Text = hsgds.Tables[0].Rows[0][0].ToString().Trim();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "insert into feiyong(bh,xm,mc,fee) values('"+bh.Text.ToString().Trim()+"','"+xm.Text.ToString().Trim()+"','"+mc.Text.ToString().Trim()+"',"+fee.Text.ToString().Trim()+")";
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