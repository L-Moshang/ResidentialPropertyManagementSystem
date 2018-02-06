using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 小区物业管理系统
{
    public partial class Form1 : Form
    {
        public static string nuser, ncx;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();  //关闭当前窗体
        }

        private void button1_Click(object sender, EventArgs e)  //单击登陆按钮
        {
            //定义变量
            string sql;
            //给sql赋值,查询用户表中是否有匹配用户名和密码
            sql = "select * from allusers where username='"+textBox1.Text.ToString().Trim()+"' and pwd='"+textBox2.Text.ToString().Trim()+"'";
            DataSet result = new DataSet();  //定义变量result为数据集型
            result = new Class1().hsggetdata(sql);  //将查询到的结果放入数据集result中
            if (result != null)
            {
                if (result.Tables[0].Rows.Count > 0)  //如果查询结果不为空
                {
                    nuser = result.Tables[0].Rows[0]["username"].ToString().Trim(); //给全局变量当前用户nuser赋值
                    ncx = result.Tables[0].Rows[0]["cx"].ToString().Trim(); //给全局变量当前权限ncx赋值
                    this.Hide();   //隐藏当前窗口
                    Form2 newform = new Form2();  //弹出新窗口form2
                    newform.Show();
                }
                else
                {
                    //如果查询结果为空
                    MessageBox.Show("用户名或密码不正确");
                }
            }
            else
            {
                //出现异常,给出提示
                MessageBox.Show("数据库连接错误，请检查连接！");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}