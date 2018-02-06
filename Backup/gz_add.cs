using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 小区物业管理系统
{
    public partial class gz_add : Form
    {
        public gz_add()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void gz_add_Load(object sender, EventArgs e)
        {
            label8.Text = DateTime.Now.ToString().Trim();
            int i = 1;
            for (i = 1; i <= 12; i++)
            {
                yue.Items.Add(i.ToString().Trim());
            }
            nian.Items.Add("2010");
            nian.Items.Add("2009");
            nian.Items.Add("2008");
            nian.Items.Add("2007");
            nian.Items.Add("2006");
            nian.Items.Add("2005");
            string sql;
            sql = "select bh from yuangong order by id desc";
            DataSet hsgds = new DataSet();
            hsgds = new Class1().hsggetdata(sql);
            if (hsgds != null)
            {
                if (hsgds.Tables[0].Rows.Count > 0)
                {
                    
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
            sql = "select xm from yuangong where bh='"+bh.Text.ToString().Trim()+"'";
            DataSet hsgds = new DataSet();
            hsgds = new Class1().hsggetdata(sql);
            if (hsgds != null)
            {
                if (hsgds.Tables[0].Rows.Count > 0)
                {

                   
                        xm.Text=hsgds.Tables[0].Rows[0]["xm"].ToString().Trim();
                   
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "insert into gongzi(bh,xm,nian,yue,gz) values('"+bh.Text.ToString().Trim()+"','"+xm.Text.ToString().Trim()+"',"+nian.Text.ToString().Trim()+","+yue.Text.ToString().Trim()+","+gz.Text.ToString().Trim()+")";
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