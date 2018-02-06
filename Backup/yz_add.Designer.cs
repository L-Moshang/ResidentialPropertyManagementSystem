namespace 小区物业管理系统
{
    partial class yz_add
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
            this.button1 = new System.Windows.Forms.Button();
            this.fj = new System.Windows.Forms.ComboBox();
            this.gender = new System.Windows.Forms.ComboBox();
            this.addr = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sfz = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bh = new System.Windows.Forms.TextBox();
            this.memo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.TextBox();
            this.xm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rzsj = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fj
            // 
            this.fj.FormattingEnabled = true;
            this.fj.Location = new System.Drawing.Point(102, 174);
            this.fj.Name = "fj";
            this.fj.Size = new System.Drawing.Size(121, 20);
            this.fj.TabIndex = 46;
            // 
            // gender
            // 
            this.gender.FormattingEnabled = true;
            this.gender.Location = new System.Drawing.Point(102, 81);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(121, 20);
            this.gender.TabIndex = 45;
            // 
            // addr
            // 
            this.addr.Location = new System.Drawing.Point(102, 216);
            this.addr.Name = "addr";
            this.addr.Size = new System.Drawing.Size(405, 21);
            this.addr.TabIndex = 44;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(350, 127);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(157, 21);
            this.email.TabIndex = 41;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rzsj);
            this.groupBox1.Controls.Add(this.fj);
            this.groupBox1.Controls.Add(this.gender);
            this.groupBox1.Controls.Add(this.addr);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 418);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "添加业主";
            // 
            // sfz
            // 
            this.sfz.Location = new System.Drawing.Point(102, 127);
            this.sfz.Name = "sfz";
            this.sfz.Size = new System.Drawing.Size(157, 21);
            this.sfz.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 177);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 39;
            this.label13.Text = "所在房间";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(276, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 38;
            this.label12.Text = "入住时间";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 37;
            this.label11.Text = "联系地址";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(276, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 36;
            this.label10.Text = "邮箱";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 35;
            this.label5.Text = "身份证";
            // 
            // bh
            // 
            this.bh.Location = new System.Drawing.Point(102, 33);
            this.bh.Name = "bh";
            this.bh.Size = new System.Drawing.Size(157, 21);
            this.bh.TabIndex = 34;
            // 
            // memo
            // 
            this.memo.Location = new System.Drawing.Point(102, 258);
            this.memo.Multiline = true;
            this.memo.Name = "memo";
            this.memo.Size = new System.Drawing.Size(405, 117);
            this.memo.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 32;
            this.label9.Text = "备注";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 30;
            this.label6.Text = "电话";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(348, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 29;
            this.label8.Text = "当前日期";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 28;
            this.label7.Text = "当前日期";
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(350, 81);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(157, 21);
            this.tel.TabIndex = 27;
            // 
            // xm
            // 
            this.xm.Location = new System.Drawing.Point(350, 33);
            this.xm.Name = "xm";
            this.xm.Size = new System.Drawing.Size(157, 21);
            this.xm.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "性别";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "业主编号";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(460, 466);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(222, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "业主添加";
            // 
            // rzsj
            // 
            this.rzsj.Location = new System.Drawing.Point(350, 174);
            this.rzsj.Name = "rzsj";
            this.rzsj.Size = new System.Drawing.Size(156, 21);
            this.rzsj.TabIndex = 47;
            // 
            // yz_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 495);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Name = "yz_add";
            this.Text = "业主添加";
            this.Load += new System.EventHandler(this.yz_add_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox fj;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.TextBox addr;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox sfz;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bh;
        private System.Windows.Forms.TextBox memo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.TextBox xm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker rzsj;
    }
}