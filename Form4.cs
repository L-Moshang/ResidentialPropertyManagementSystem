using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 小区物业管理系统
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e) //窗体初始化
        {
            //判断是否有该权限
            if (Form1.ncx.ToString().Trim() != "超级管理员")
            {
                MessageBox.Show("对不起，您没有权限");
                this.Close();
            }
            string sql;
            //读取数据库中所有用户数据
            sql = "select * from allusers order by id desc";
            DataSet result = new DataSet();
            result = new Class1().hsggetdata(sql);
            //绑定数据
            dataGridView1.DataSource = result.Tables[0];
            dataGridView1.Columns[0].HeaderCell.Value = "序号";
            dataGridView1.Columns[1].HeaderCell.Value = "用户名";
            dataGridView1.Columns[2].HeaderCell.Value = "密码";
            dataGridView1.Columns[3].HeaderCell.Value = "权限";
            dataGridView1.Columns[4].HeaderCell.Value = "添加时间";
        }

        private void button3_Click(object sender, EventArgs e)  //单击删除按钮
        {
            string sql;
            //删除
            if (dataGridView1.SelectedCells[3].Value.ToString().Trim() == "超级管理员")
            {
                MessageBox.Show("对不起，超级管理员不能删除");
            }
            else
            {
                sql = "delete from allusers where id=" + dataGridView1.SelectedCells[0].Value.ToString().Trim();
                int dd = 0;
                dd = new Class1().hsgexucute(sql);
                if (dd == 1)
                {
                    //如果删除成功，再次执行查询操作，即刷新
                    sql = "select * from allusers order by id desc";
                    DataSet result = new DataSet();
                    result = new Class1().hsggetdata(sql);
                    dataGridView1.DataSource = result.Tables[0];
                    //给出提示
                    MessageBox.Show("删除成功");
                }
                else
                {
                    MessageBox.Show("对不起，系统错误");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) //新增模块
        {
            string sql;
            if (textBox1.Text.ToString().Trim() == "" || textBox2.Text.ToString().Trim() == "")
            {
                MessageBox.Show("对不起，用户名和密码不能为空");
            }
            else
            {
                //插入新数据，即添加新用户
                sql = "select * from allusers where username='" + textBox1.Text.ToString().Trim() + "'";
                DataSet result = new DataSet();
                result = new Class1().hsggetdata(sql);
                if (result != null)
                {
                    if (result.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("对不起，该用户名已经存在，请换其他用户名");
                    }
                    else
                    {
                        sql = "insert into allusers(username,pwd) values('" + textBox1.Text.ToString().Trim() + "','" + textBox2.Text.ToString().Trim() + "')";
                        int dd = 0;
                        dd = new Class1().hsgexucute(sql);
                        if (dd == 1)
                        {
                            //如插入成功，再次查询，即刷新
                            sql = "select * from allusers order by id desc";
                            DataSet result2 = new DataSet();
                            result2 = new Class1().hsggetdata(sql);
                            dataGridView1.DataSource = result2.Tables[0];
                            //执行成功,给出提示
                            MessageBox.Show("添加成功");
                        }
                        else
                        {
                            MessageBox.Show("对不起，系统错误");
                        }
                    }
                }
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); //关闭本窗口
        }
    }
}