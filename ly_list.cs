using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 小区物业管理系统
{
    public partial class ly_list : Form
    {
        public ly_list()
        {
            InitializeComponent();
        }

        private void ly_list_Load(object sender, EventArgs e)
        {
            mx.Items.Add("东");
            mx.Items.Add("南");
            mx.Items.Add("西");
            mx.Items.Add("北");
            mx.Items.Add("东南");
            mx.Items.Add("东北");
            mx.Items.Add("西南");
            mx.Items.Add("西北");
            string sql;
            sql = "select * from louyu order by id desc";
            getdata(sql);  //调用函数getdata
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
            dataGridView1.Columns[1].HeaderCell.Value = "编号";
            dataGridView1.Columns[2].HeaderCell.Value = "层数";
            dataGridView1.Columns[3].HeaderCell.Value = "面向";
            dataGridView1.Columns[4].HeaderCell.Value = "负责人";
            dataGridView1.Columns[5].HeaderCell.Value = "电话";
            dataGridView1.Columns[6].HeaderCell.Value = "备注";
            dataGridView1.Columns[7].HeaderCell.Value = "添加时间";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            //查询当前鼠标选中的行
            string sql;
            sql = "select * from louyu where id=" + dataGridView1.SelectedCells[0].Value.ToString().Trim();
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
                cs.Text = hsgds.Tables[0].Rows[0]["cs"].ToString().Trim();
                mx.Text = hsgds.Tables[0].Rows[0]["mx"].ToString().Trim();
                fzr.Text = hsgds.Tables[0].Rows[0]["fzr"].ToString().Trim();
                tel.Text = hsgds.Tables[0].Rows[0]["tel"].ToString().Trim();
                memo.Text = hsgds.Tables[0].Rows[0]["memo"].ToString().Trim();
              
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ly_add newform = new ly_add();
            newform.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql;
            // 修改语句

            sql = "update louyu set bh='" + bh.Text.ToString().Trim() + "',cs='" + cs.Text.ToString().Trim() + "',mx='" + mx.Text.ToString().Trim() + "',fzr='" + fzr.Text.ToString().Trim() + "',tel='" + tel.Text.ToString().Trim() + "',memo='" + memo.Text.ToString().Trim() + "' where id=" + dataGridView1.SelectedCells[0].Value.ToString().Trim();
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
                sql = "delete from louyu where id=" + dataGridView1.SelectedCells[0].Value.ToString().Trim();
                int dd = 0;
                dd = new Class1().hsgexucute(sql);
                if (dd == 1)
                {
                    //如果删除成功,则清空所有文本框
                    bh.Text = "";
                    cs.Text = "";
                    mx.Text = "";
                    fzr.Text = "";
                    tel.Text = "";
                    memo.Text = "";
              
                    //重新查询一次
                    sql = "select * from louyu order by id desc";
                    getdata(sql);

                    MessageBox.Show("删除成功");
                }
                else
                {
                    MessageBox.Show("对不起，系统错误，请先选择要删除的数据行");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sql;
            //查询
            sql = "select * from louyu where 1=1";
            if (textBox5.Text.ToString().Trim() != "") //如果条件不为空,则依次添加所需条件
            {
                sql = sql + " and bh like '%" + textBox5.Text.ToString().Trim() + "%'";
            }
            if (textBox1.Text.ToString().Trim() != "")
            {
                sql = sql + " and fzr like '%" + textBox1.Text.ToString().Trim() + "%'";
            }

            sql = sql + " order by id desc";
            getdata(sql);  //调用自定义函数getdata,与上同理
        }

    }
}