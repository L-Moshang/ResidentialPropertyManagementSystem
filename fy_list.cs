using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 小区物业管理系统
{
    public partial class fy_list : Form
    {
        public fy_list()
        {
            InitializeComponent();
        }

        private void fy_list_Load(object sender, EventArgs e)
        {
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
            sql = "select * from fangjian order by id desc";
            getdata(sql);
        }
        private void getdata(string sql)   //自定义函数getdata
        {
            DataSet hsgds = new DataSet();
            hsgds = new Class1().hsggetdata(sql);
            if (hsgds != null)
            {
                //如果查询结果不为空,将结果显示在datagridview1中,绑定
                dataGridView1.DataSource = hsgds.Tables[0];
            }
            dataGridView1.Columns[0].HeaderCell.Value = "序号";
            dataGridView1.Columns[1].HeaderCell.Value = "业主编号";
            dataGridView1.Columns[2].HeaderCell.Value = "业主姓名";
            dataGridView1.Columns[3].HeaderCell.Value = "费用名称";
            dataGridView1.Columns[4].HeaderCell.Value = "费用";
            dataGridView1.Columns[5].HeaderCell.Value = "添加时间";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fy_add newform = new fy_add();
            newform.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql;
            // 修改语句

            sql = "update feiyong set bh='" + bh.Text.ToString().Trim() + "',xm='" + xm.Text.ToString().Trim() + "',mc='" + mc.Text.ToString().Trim() + "',fee=" + fee.Text.ToString().Trim() + " where id=" + dataGridView1.SelectedCells[0].Value.ToString().Trim();
            int dd = 0;
            dd = new Class1().hsgexucute(sql);
            if (dd == 1)
            {
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("对不起，系统错误");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells[0].Value.ToString().Trim() != "")
            {
                //如果鼠标有选中列表中的行,则执行删除操作
                string sql;
                sql = "delete from feiyong where id=" + dataGridView1.SelectedCells[0].Value.ToString().Trim();
                int dd = 0;
                dd = new Class1().hsgexucute(sql);
                if (dd == 1)
                {
                    //如果删除成功,则清空所有文本框
                    bh.Text = "";
                    xm.Text = "";
                    mc.Text = "";
                    fee.Text = "";
                    //重新查询一次
                    sql = "select * from feiyong order by id desc";
                    getdata(sql);

                    MessageBox.Show("删除成功");
                }
                else
                {
                    MessageBox.Show("对不起，系统错误，请先选择要删除的数据行");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sql;
            //查询
            sql = "select * from feiyong where 1=1";
            if (textBox5.Text.ToString().Trim() != "") //如果条件不为空,则依次添加所需条件
            {
                sql = sql + " and bh like '%" + textBox5.Text.ToString().Trim() + "%'";
            }
            if (textBox1.Text.ToString().Trim() != "") //如果条件不为空,则依次添加所需条件
            {
                sql = sql + " and xm like '%" + textBox1.Text.ToString().Trim() + "%'";
            }

            sql = sql + " order by id desc";
            getdata(sql);  //调用自定义函数getdata,与上同理
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            //查询当前鼠标选中的行
            string sql;
            sql = "select * from feiyong where id=" + dataGridView1.SelectedCells[0].Value.ToString().Trim();
            showdata(sql);  //调用函数showdata
        }
        private void showdata(string sql)  //自定义函数showdata
        {
            DataSet hsgds = new DataSet();
            hsgds = new Class1().hsggetdata(sql);
            if (hsgds != null)
            {
                //如果查询结果不为空,给各个文本框赋值
                bh.Text = hsgds.Tables[0].Rows[0]["bh"].ToString().Trim();
                mc.Text = hsgds.Tables[0].Rows[0]["mc"].ToString().Trim();
                xm.Text = hsgds.Tables[0].Rows[0]["xm"].ToString().Trim();
                fee.Text = hsgds.Tables[0].Rows[0]["fee"].ToString().Trim();
                //memo.Text = hsgds.Tables[0].Rows[0]["memo"].ToString().Trim();

            }
        }
    }
}