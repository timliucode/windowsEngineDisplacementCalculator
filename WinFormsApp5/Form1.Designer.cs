namespace WinFormsApp5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bore = new System.Windows.Forms.TextBox();
            this.length = new System.Windows.Forms.TextBox();
            this.newbore = new System.Windows.Forms.TextBox();
            this.addlength = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.cap = new System.Windows.Forms.TextBox();
            this.newcap = new System.Windows.Forms.TextBox();
            this.lb5 = new System.Windows.Forms.Label();
            this.cygnus = new System.Windows.Forms.RadioButton();
            this.gryphus = new System.Windows.Forms.RadioButton();
            this.jets = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.drg = new System.Windows.Forms.RadioButton();
            this.krv = new System.Windows.Forms.RadioButton();
            this.rcs150 = new System.Windows.Forms.RadioButton();
            this.smax = new System.Windows.Forms.RadioButton();
            this.rcs125 = new System.Windows.Forms.RadioButton();
            this.sl = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.multiplier = new System.Windows.Forms.TextBox();
            this.multiplierCC = new System.Windows.Forms.TextBox();
            this.lb7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clearbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bore
            // 
            this.bore.Location = new System.Drawing.Point(77, 6);
            this.bore.MaxLength = 5;
            this.bore.Name = "bore";
            this.bore.Size = new System.Drawing.Size(81, 23);
            this.bore.TabIndex = 0;
            this.bore.TextChanged += new System.EventHandler(this.TextChanged);
            this.bore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(77, 35);
            this.length.MaxLength = 5;
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(81, 23);
            this.length.TabIndex = 1;
            this.length.TextChanged += new System.EventHandler(this.TextChanged);
            this.length.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // newbore
            // 
            this.newbore.Location = new System.Drawing.Point(258, 6);
            this.newbore.MaxLength = 5;
            this.newbore.Name = "newbore";
            this.newbore.Size = new System.Drawing.Size(77, 23);
            this.newbore.TabIndex = 2;
            this.newbore.TextChanged += new System.EventHandler(this.TextChanged);
            this.newbore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // addlength
            // 
            this.addlength.Location = new System.Drawing.Point(258, 35);
            this.addlength.MaxLength = 5;
            this.addlength.Name = "addlength";
            this.addlength.Size = new System.Drawing.Size(77, 23);
            this.addlength.TabIndex = 3;
            this.addlength.TextChanged += new System.EventHandler(this.TextChanged);
            this.addlength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "缸徑";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(16, 38);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(55, 15);
            this.lb2.TabIndex = 5;
            this.lb2.Text = "曲軸行程";
            // 
            // cap
            // 
            this.cap.Location = new System.Drawing.Point(111, 64);
            this.cap.MaxLength = 5;
            this.cap.Name = "cap";
            this.cap.Size = new System.Drawing.Size(47, 23);
            this.cap.TabIndex = 8;
            this.cap.TextChanged += new System.EventHandler(this.TextChanged);
            this.cap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // newcap
            // 
            this.newcap.Location = new System.Drawing.Point(258, 64);
            this.newcap.MaxLength = 5;
            this.newcap.Name = "newcap";
            this.newcap.Size = new System.Drawing.Size(77, 23);
            this.newcap.TabIndex = 9;
            this.newcap.TextChanged += new System.EventHandler(this.TextChanged);
            this.newcap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Location = new System.Drawing.Point(185, 67);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(67, 15);
            this.lb5.TabIndex = 11;
            this.lb5.Text = "改後排氣量";
            // 
            // cygnus
            // 
            this.cygnus.AutoSize = true;
            this.cygnus.Location = new System.Drawing.Point(15, 22);
            this.cygnus.Name = "cygnus";
            this.cygnus.Size = new System.Drawing.Size(49, 19);
            this.cygnus.TabIndex = 12;
            this.cygnus.TabStop = true;
            this.cygnus.Text = "勁戰";
            this.cygnus.UseVisualStyleBackColor = true;
            this.cygnus.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // gryphus
            // 
            this.gryphus.AutoSize = true;
            this.gryphus.Location = new System.Drawing.Point(15, 47);
            this.gryphus.Name = "gryphus";
            this.gryphus.Size = new System.Drawing.Size(97, 19);
            this.gryphus.TabIndex = 13;
            this.gryphus.TabStop = true;
            this.gryphus.Text = "六代/BWS2.0";
            this.gryphus.UseVisualStyleBackColor = true;
            this.gryphus.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // jets
            // 
            this.jets.AutoSize = true;
            this.jets.Location = new System.Drawing.Point(119, 22);
            this.jets.Name = "jets";
            this.jets.Size = new System.Drawing.Size(74, 19);
            this.jets.TabIndex = 14;
            this.jets.TabStop = true;
            this.jets.Text = "JET S/SR";
            this.jets.UseVisualStyleBackColor = true;
            this.jets.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.drg);
            this.groupBox1.Controls.Add(this.krv);
            this.groupBox1.Controls.Add(this.rcs150);
            this.groupBox1.Controls.Add(this.smax);
            this.groupBox1.Controls.Add(this.rcs125);
            this.groupBox1.Controls.Add(this.sl);
            this.groupBox1.Controls.Add(this.cygnus);
            this.groupBox1.Controls.Add(this.jets);
            this.groupBox1.Controls.Add(this.gryphus);
            this.groupBox1.Location = new System.Drawing.Point(4, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 130);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "快速選項";
            // 
            // drg
            // 
            this.drg.AutoSize = true;
            this.drg.Location = new System.Drawing.Point(119, 72);
            this.drg.Name = "drg";
            this.drg.Size = new System.Drawing.Size(104, 19);
            this.drg.TabIndex = 20;
            this.drg.TabStop = true;
            this.drg.Text = "DRG/MMBCU";
            this.drg.UseVisualStyleBackColor = true;
            this.drg.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // krv
            // 
            this.krv.AutoSize = true;
            this.krv.Location = new System.Drawing.Point(236, 72);
            this.krv.Name = "krv";
            this.krv.Size = new System.Drawing.Size(107, 19);
            this.krv.TabIndex = 19;
            this.krv.TabStop = true;
            this.krv.Text = "KRV/KRVmoto";
            this.krv.UseVisualStyleBackColor = true;
            this.krv.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rcs150
            // 
            this.rcs150.AutoSize = true;
            this.rcs150.Location = new System.Drawing.Point(236, 47);
            this.rcs150.Name = "rcs150";
            this.rcs150.Size = new System.Drawing.Size(95, 19);
            this.rcs150.TabIndex = 18;
            this.rcs150.TabStop = true;
            this.rcs150.Text = "RacingS 150";
            this.rcs150.UseVisualStyleBackColor = true;
            this.rcs150.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // smax
            // 
            this.smax.AutoSize = true;
            this.smax.Location = new System.Drawing.Point(15, 97);
            this.smax.Name = "smax";
            this.smax.Size = new System.Drawing.Size(303, 19);
            this.smax.TabIndex = 17;
            this.smax.TabStop = true;
            this.smax.Text = "Smax/Force/Force2.0/AUGUR/NAMX/R15v3、V4";
            this.smax.UseVisualStyleBackColor = true;
            this.smax.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rcs125
            // 
            this.rcs125.AutoSize = true;
            this.rcs125.Location = new System.Drawing.Point(236, 22);
            this.rcs125.Name = "rcs125";
            this.rcs125.Size = new System.Drawing.Size(95, 19);
            this.rcs125.TabIndex = 16;
            this.rcs125.TabStop = true;
            this.rcs125.Text = "RacingS 125";
            this.rcs125.UseVisualStyleBackColor = true;
            this.rcs125.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // sl
            // 
            this.sl.AutoSize = true;
            this.sl.Location = new System.Drawing.Point(119, 47);
            this.sl.Name = "sl";
            this.sl.Size = new System.Drawing.Size(60, 19);
            this.sl.TabIndex = 15;
            this.sl.TabStop = true;
            this.sl.Text = "JET SL";
            this.sl.UseVisualStyleBackColor = true;
            this.sl.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "相差倍率";
            // 
            // multiplier
            // 
            this.multiplier.Location = new System.Drawing.Point(73, 18);
            this.multiplier.Name = "multiplier";
            this.multiplier.ReadOnly = true;
            this.multiplier.Size = new System.Drawing.Size(81, 23);
            this.multiplier.TabIndex = 18;
            // 
            // multiplierCC
            // 
            this.multiplierCC.Location = new System.Drawing.Point(254, 18);
            this.multiplierCC.Name = "multiplierCC";
            this.multiplierCC.ReadOnly = true;
            this.multiplierCC.Size = new System.Drawing.Size(77, 23);
            this.multiplierCC.TabIndex = 19;
            // 
            // lb7
            // 
            this.lb7.AutoSize = true;
            this.lb7.Location = new System.Drawing.Point(193, 21);
            this.lb7.Name = "lb7";
            this.lb7.Size = new System.Drawing.Size(55, 15);
            this.lb7.TabIndex = 20;
            this.lb7.Text = "相差排量";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.multiplierCC);
            this.groupBox2.Controls.Add(this.lb7);
            this.groupBox2.Controls.Add(this.multiplier);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(4, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 51);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "差值";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(156, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 15);
            this.label10.TabIndex = 35;
            this.label10.Text = "倍";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(331, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 15);
            this.label9.TabIndex = 34;
            this.label9.Text = "cc";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "拉條",
            "行程"});
            this.comboBox1.Location = new System.Drawing.Point(185, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(67, 23);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.TextChanged);
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(283, 284);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(75, 23);
            this.clearbutton.TabIndex = 23;
            this.clearbutton.Text = "全部清除";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "排量";
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("12");
            this.domainUpDown1.Items.Add("10");
            this.domainUpDown1.Items.Add("8");
            this.domainUpDown1.Items.Add("6");
            this.domainUpDown1.Items.Add("5");
            this.domainUpDown1.Items.Add("4");
            this.domainUpDown1.Items.Add("3");
            this.domainUpDown1.Items.Add("2");
            this.domainUpDown1.Items.Add("1");
            this.domainUpDown1.Location = new System.Drawing.Point(33, 64);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(38, 23);
            this.domainUpDown1.TabIndex = 25;
            this.domainUpDown1.Text = "1";
            this.domainUpDown1.Wrap = true;
            this.domainUpDown1.SelectedItemChanged += new System.EventHandler(this.TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "缸=";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(4, 286);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 19);
            this.radioButton1.TabIndex = 27;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "計算排量";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.clearbutton_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(77, 286);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 19);
            this.radioButton2.TabIndex = 28;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "計算缸徑";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.clearbutton_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(154, 286);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(73, 19);
            this.radioButton3.TabIndex = 29;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "計算行程";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.clearbutton_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "缸徑",
            "搪缸量"});
            this.comboBox2.Location = new System.Drawing.Point(185, 6);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(67, 23);
            this.comboBox2.TabIndex = 30;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "mm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 15);
            this.label7.TabIndex = 32;
            this.label7.Text = "mm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(160, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 15);
            this.label8.TabIndex = 33;
            this.label8.Text = "cc";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(335, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 15);
            this.label11.TabIndex = 34;
            this.label11.Text = "mm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(335, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 15);
            this.label12.TabIndex = 35;
            this.label12.Text = "條";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(335, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 15);
            this.label13.TabIndex = 36;
            this.label13.Text = "cc";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(4, 308);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(87, 15);
            this.linkLabel1.TabIndex = 37;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "TimLiu GitHub";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 325);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.newcap);
            this.Controls.Add(this.cap);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addlength);
            this.Controls.Add(this.newbore);
            this.Controls.Add(this.length);
            this.Controls.Add(this.bore);
            this.Name = "Form1";
            this.Text = "排氣量計算機";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox bore;
        private TextBox length;
        private TextBox newbore;
        private TextBox addlength;
        private Label label1;
        private Label lb2;
        private TextBox cap;
        private TextBox newcap;
        private Label lb5;
        private RadioButton cygnus;
        private RadioButton gryphus;
        private RadioButton jets;
        private GroupBox groupBox1;
        private RadioButton drg;
        private RadioButton krv;
        private RadioButton rcs150;
        private RadioButton smax;
        private RadioButton rcs125;
        private RadioButton sl;
        private Label label4;
        private TextBox multiplier;
        private TextBox multiplierCC;
        private Label lb7;
        private GroupBox groupBox2;
        private ComboBox comboBox1;
        private Button clearbutton;
        private Label label5;
        private DomainUpDown domainUpDown1;
        private Label label6;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private ComboBox comboBox2;
        private Label label10;
        private Label label9;
        private Label label3;
        private Label label7;
        private Label label8;
        private Label label11;
        private Label label12;
        private Label label13;
        private LinkLabel linkLabel1;
    }
}