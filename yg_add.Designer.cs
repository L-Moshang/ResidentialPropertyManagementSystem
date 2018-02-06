namespace 小区物业管理系统
{
    partial class yg_add
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.memo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bm = new System.Windows.Forms.ComboBox();
            this.gender = new System.Windows.Forms.ComboBox();
            this.addr = new System.Windows.Forms.TextBox();
            this.gw = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.sfz = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.xm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // memo
            // 
            this.memo.Location = new System.Drawing.Point(102, 258);
            this.memo.Multiline = true;
            this.memo.Name = "memo";
            this.memo.Size = new System.Drawing.Size(405, 117);
            this.memo.TabIndex = 33;
            this.memo.TextChanged += new System.EventHandler(this.memo_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 32;
            this.label9.Text = "备注";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // bh
            // 
            this.bh.Location = new System.Drawing.Point(102, 33);
            this.bh.Name = "bh";
            this.bh.Size = new System.Drawing.Size(157, 21);
            this.bh.TabIndex = 34;
            this.bh.TextChanged += new System.EventHandler(this.bh_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(229, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "添加员工";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 30;
            this.label6.Text = "电话";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(348, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 29;
            this.label8.Text = "当前日期";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(350, 81);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(157, 21);
            this.tel.TabIndex = 27;
            this.tel.TextChanged += new System.EventHandler(this.tel_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bm);
            this.groupBox1.Controls.Add(this.gender);
            this.groupBox1.Controls.Add(this.addr);
            this.groupBox1.Controls.Add(this.gw);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.sfz);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.bh);
            this.groupBox1.Controls.Add(this.memo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tel);
            this.groupBox1.Controls.Add(this.xm);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(44, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 418);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "添加员工";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bm
            // 
            this.bm.FormattingEnabled = true;
            this.bm.Location = new System.Drawing.Point(350, 174);
            this.bm.Name = "bm";
            this.bm.Size = new System.Drawing.Size(121, 20);
            this.bm.TabIndex = 46;
            this.bm.SelectedIndexChanged += new System.EventHandler(this.bm_SelectedIndexChanged);
            // 
            // gender
            // 
            this.gender.FormattingEnabled = true;
            this.gender.Location = new System.Drawing.Point(102, 81);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(121, 20);
            this.gender.TabIndex = 45;
            this.gender.SelectedIndexChanged += new System.EventHandler(this.gender_SelectedIndexChanged);
            // 
            // addr
            // 
            this.addr.Location = new System.Drawing.Point(102, 216);
            this.addr.Name = "addr";
            this.addr.Size = new System.Drawing.Size(405, 21);
            this.addr.TabIndex = 44;
            this.addr.TextChanged += new System.EventHandler(this.addr_TextChanged);
            // 
            // gw
            // 
            this.gw.Location = new System.Drawing.Point(102, 174);
            this.gw.Name = "gw";
            this.gw.Size = new System.Drawing.Size(157, 21);
            this.gw.TabIndex = 42;
            this.gw.TextChanged += new System.EventHandler(this.gw_TextChanged);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(350, 127);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(157, 21);
            this.email.TabIndex = 41;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // sfz
            // 
            this.sfz.Location = new System.Drawing.Point(102, 127);
            this.sfz.Name = "sfz";
            this.sfz.Size = new System.Drawing.Size(157, 21);
            this.sfz.TabIndex = 40;
            this.sfz.TextChanged += new System.EventHandler(this.sfz_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 177);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 39;
            this.label13.Text = "岗位名称";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(276, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 38;
            this.label12.Text = "所在部门";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 37;
            this.label11.Text = "联系地址";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(276, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 36;
            this.label10.Text = "邮箱";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 35;
            this.label5.Text = "身份证";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 28;
            this.label7.Text = "当前日期";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // xm
            // 
            this.xm.Location = new System.Drawing.Point(350, 33);
            this.xm.Name = "xm";
            this.xm.Size = new System.Drawing.Size(157, 21);
            this.xm.TabIndex = 21;
            this.xm.TextChanged += new System.EventHandler(this.xm_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "性别";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "姓名";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "员工编号";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(492, 471);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // yg_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Name = "yg_add";
            this.Text = "添加员工";
            this.Load += new System.EventHandler(this.yg_add_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox memo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox bh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox xm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.TextBox addr;
        private System.Windows.Forms.TextBox gw;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox sfz;
        private System.Windows.Forms.ComboBox bm;
    }
}