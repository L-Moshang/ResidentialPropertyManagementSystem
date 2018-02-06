using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 小区物业管理系统
{
    public partial class yg_list : Form
    {
        public yg_list()
        {
            InitializeComponent();
        }

        private void yg_list_Load(object sender, EventArgs e)
        {
            string sql;
            gender.Items.Add("男");
            gender.Items.Add("女");

            
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
            sql = "select * from yuangong order by id desc";
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

            dataGridView1.Columns[3].HeaderCell.Value = "性别";
            dataGridView1.Columns[4].HeaderCell.Value = "电话";
            dataGridView1.Columns[5].HeaderCell.Value = "身份证";
            dataGridView1.Columns[6].HeaderCell.Value = "邮箱";
            dataGridView1.Columns[7].HeaderCell.Value = "岗位";
            dataGridView1.Columns[8].HeaderCell.Value = "部门";
            dataGridView1.Columns[9].HeaderCell.Value = "地址";
            dataGridView1.Columns[10].HeaderCell.Value = "备注";

            dataGridView1.Columns[11].HeaderCell.Value = "添加时间";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells[0].Value.ToString().Trim() != "")
            {
                //如果鼠标有选中列表中的行,则执行删除操作
                string sql;
                sql = "delete from yuangong where id=" + dataGridView1.SelectedCells[0].Value.ToString().Trim();
                int dd = 0;
                dd = new Class1().hsgexucute(sql);
                if (dd == 1)
                {
                    //如果删除成功,则清空所有文本框
                    bh.Text = "";
                    xm.Text = "";
                    tel.Text = "";
                    sfz.Text = "";
                    email.Text = "";
                    gw.Text = "";
                    addr.Text = "";
                    memo.Text = "";
                    //重新查询一次
                    sql = "select * from yuangong order by id desc";
                    getdata(sql);

                    MessageBox.Show("删除成功");
                }
                else
                {
                    MessageBox.Show("对不起，系统错误，请先选择要删除的数据行");
                }
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            //查询当前鼠标选中的行
            string sql;
            sql = "select * from yuangong where id=" + dataGridView1.SelectedCells[0].Value.ToString().Trim();
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
                tel.Text = hsgds.Tables[0].Rows[0]["tel"].ToString().Trim();
                sfz.Text = hsgds.Tables[0].Rows[0]["sfz"].ToString().Trim();
                email.Text = hsgds.Tables[0].Rows[0]["email"].ToString().Trim();
                gw.Text = hsgds.Tables[0].Rows[0]["gw"].ToString().Trim();
                addr.Text = hsgds.Tables[0].Rows[0]["addr"].ToString().Trim();
                memo.Text = hsgds.Tables[0].Rows[0]["memo"].ToString().Trim();
                gender.Text = hsgds.Tables[0].Rows[0]["gender"].ToString().Trim();
                bm.Text = hsgds.Tables[0].Rows[0]["bm"].ToString().Trim();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql;
            // 修改语句

            sql = "update yuangong set bh='"+bh.Text.ToString().Trim()+"',xm='"+xm.Text.ToString().Trim()+"',tel='"+tel.Text.ToString().Trim()+"',sfz='"+sfz.Text.ToString().Trim()+"',email='"+email.Text.ToString().Trim()+"',gw='"+gw.Text.ToString().Trim()+"',addr='"+addr.Text.ToString().Trim()+"',memo='"+memo.Text.ToString().Trim()+"',gender='"+gender.Text.ToString().Trim()+"',bm='"+bm.Text.ToString().Trim()+"' where id=" + dataGridView1.SelectedCells[0].Value.ToString().Trim();
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

        private void button5_Click(object sender, EventArgs e)
        {
            string sql;
            //查询
            sql = "select * from yuangong where 1=1";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
    
}