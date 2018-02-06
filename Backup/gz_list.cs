using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 小区物业管理系统
{
    public partial class gz_list : Form
    {
        public gz_list()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gz_add newform = new gz_add();
            newform.Show();
            this.Close();
        }

        private void gz_list_Load(object sender, EventArgs e)
        {
            string sql;
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

            sql = "select * from gongzi order by id desc";
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
            dataGridView1.Columns[2].HeaderCell.Value = "姓名";
            dataGridView1.Columns[3].HeaderCell.Value = "年份";
            dataGridView1.Columns[4].HeaderCell.Value = "月份";
            dataGridView1.Columns[5].HeaderCell.Value = "工资";
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            //查询当前鼠标选中的行
            string sql;
            sql = "select * from gongzi where id=" + dataGridView1.SelectedCells[0].Value.ToString().Trim();
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
                xm.Text = hsgds.Tables[0].Rows[0]["xm"].ToString().Trim();
                nian.Text = hsgds.Tables[0].Rows[0]["nian"].ToString().Trim();
                yue.Text = hsgds.Tables[0].Rows[0]["yue"].ToString().Trim();
                gz.Text = hsgds.Tables[0].Rows[0]["gz"].ToString().Trim();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql;
            // 修改语句

            sql = "update gongzi set bh='" + bh.Text.ToString().Trim() + "',xm='" + xm.Text.ToString().Trim() + "',nian=" + nian.Text.ToString().Trim() + ",yue=" + yue.Text.ToString().Trim() + ",gz=" + gz.Text.ToString().Trim() + " where id=" + dataGridView1.SelectedCells[0].Value.ToString().Trim();
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
                sql = "delete from gongzi where id=" + dataGridView1.SelectedCells[0].Value.ToString().Trim();
                int dd = 0;
                dd = new Class1().hsgexucute(sql);
                if (dd == 1)
                {
                    //如果删除成功,则清空所有文本框
                    bh.Text = "";
                    xm.Text = "";
                   

                    gz.Text = "";
                    //重新查询一次
                    sql = "select * from gongzi order by id desc";
                    getdata(sql);

                    MessageBox.Show("删除成功");
                }
                else
                {
                    MessageBox.Show("对不起，系统错误，请先选择要删除的数据行");
                }
            }
        }

        private void bh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql;
            sql = "select xm from yuangong where bh='" + bh.Text.ToString().Trim() + "'";
            DataSet hsgds = new DataSet();
            hsgds = new Class1().hsggetdata(sql);
            if (hsgds != null)
            {
                if (hsgds.Tables[0].Rows.Count > 0)
                {


                    xm.Text = hsgds.Tables[0].Rows[0]["xm"].ToString().Trim();

                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sql;
            //查询
            sql = "select * from gongzi where 1=1";
            if (textBox5.Text.ToString().Trim() != "") //如果条件不为空,则依次添加所需条件
            {
                sql = sql + " and bh like '%" + textBox5.Text.ToString().Trim() + "%'";
            }
            if (textBox1.Text.ToString().Trim() != "")
            {
                sql = sql + " and xm like '%" + textBox1.Text.ToString().Trim() + "%'";
            }

            sql = sql + " order by id desc";
            getdata(sql);  //调用自定义函数getdata,与上同理
        }
    }
}