using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 小区物业管理系统
{
    public partial class fj_add : Form
    {
        public fj_add()
        {
            InitializeComponent();
        }

        private void fj_add_Load(object sender, EventArgs e)
        {
            label8.Text = DateTime.Now.ToString().Trim();
            mx.Items.Add("东");
            mx.Items.Add("南");
            mx.Items.Add("西");
            mx.Items.Add("北");
            mx.Items.Add("东南");
            mx.Items.Add("东北");
            mx.Items.Add("西南");
            mx.Items.Add("西北");

            string sql;
            sql = "select bh from louyu order by id desc";
            DataSet hsgds = new DataSet();
            hsgds = new Class1().hsggetdata(sql);
            if (hsgds != null)
            {
                if (hsgds.Tables[0].Rows.Count > 0)
                {
                    int i;
                    for (i = 0; i < hsgds.Tables[0].Rows.Count; i++)
                    {
                        ly.Items.Add(hsgds.Tables[0].Rows[i]["bh"].ToString().Trim());
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "insert into fangjian(bh,lc,mx,ly,memo) values('"+bh.Text.ToString().Trim()+"','"+lc.Text.ToString().Trim()+"','"+mx.Text.ToString().Trim()+"','"+ly.Text.ToString().Trim()+"','"+memo.Text.ToString().Trim()+"')";
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}