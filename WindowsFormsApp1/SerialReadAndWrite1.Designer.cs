namespace WindowsFormsApp1
{
    partial class SerialReadAndWrite1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerialReadAndWrite1));
            this.cB_dataCount = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cB_splitChar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_com = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.tB_firstDataName = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.tB_secondDataName = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.tB_thirdDataName = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.tB_fourthDataName = new System.Windows.Forms.TextBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.tB_fifthDataName = new System.Windows.Forms.TextBox();
            this.lbl6 = new System.Windows.Forms.Label();
            this.tB_sixthDataName = new System.Windows.Forms.TextBox();
            this.lbl7 = new System.Windows.Forms.Label();
            this.tB_seventhDataName = new System.Windows.Forms.TextBox();
            this.lbl8 = new System.Windows.Forms.Label();
            this.tB_eighthDataName = new System.Windows.Forms.TextBox();
            this.lbl9 = new System.Windows.Forms.Label();
            this.tB_ninthDataName = new System.Windows.Forms.TextBox();
            this.lbl10 = new System.Windows.Forms.Label();
            this.tB_tenthDataName = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.lbl_baundrate = new System.Windows.Forms.Label();
            this.cB_firstG1 = new System.Windows.Forms.ComboBox();
            this.cB_secondG1 = new System.Windows.Forms.ComboBox();
            this.cB_thirdG1 = new System.Windows.Forms.ComboBox();
            this.cB_fourthG1 = new System.Windows.Forms.ComboBox();
            this.cB_fifthG1 = new System.Windows.Forms.ComboBox();
            this.cB_sixthG1 = new System.Windows.Forms.ComboBox();
            this.cB_seventhG1 = new System.Windows.Forms.ComboBox();
            this.cB_eighthG1 = new System.Windows.Forms.ComboBox();
            this.cB_ninthG1 = new System.Windows.Forms.ComboBox();
            this.cB_tenthG1 = new System.Windows.Forms.ComboBox();
            this.cB_firstG2 = new System.Windows.Forms.ComboBox();
            this.cB_secondG2 = new System.Windows.Forms.ComboBox();
            this.cB_thirdG2 = new System.Windows.Forms.ComboBox();
            this.cB_fourthG2 = new System.Windows.Forms.ComboBox();
            this.cB_fifthG2 = new System.Windows.Forms.ComboBox();
            this.cB_sixthG2 = new System.Windows.Forms.ComboBox();
            this.cB_seventhG2 = new System.Windows.Forms.ComboBox();
            this.cB_eighthG2 = new System.Windows.Forms.ComboBox();
            this.cB_ninthG2 = new System.Windows.Forms.ComboBox();
            this.cB_tenthG2 = new System.Windows.Forms.ComboBox();
            this.lbl_chart2 = new System.Windows.Forms.Label();
            this.lbl_chart1 = new System.Windows.Forms.Label();
            this.checkbox_chart2 = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btn_clr1 = new System.Windows.Forms.Button();
            this.btn_clr2 = new System.Windows.Forms.Button();
            this.btn_clr3 = new System.Windows.Forms.Button();
            this.btn_clr4 = new System.Windows.Forms.Button();
            this.btn_clr5 = new System.Windows.Forms.Button();
            this.btn_clr6 = new System.Windows.Forms.Button();
            this.btn_clr7 = new System.Windows.Forms.Button();
            this.btn_clr8 = new System.Windows.Forms.Button();
            this.btn_clr9 = new System.Windows.Forms.Button();
            this.btn_clr10 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cB_dataCount
            // 
            resources.ApplyResources(this.cB_dataCount, "cB_dataCount");
            this.cB_dataCount.FormattingEnabled = true;
            this.cB_dataCount.Items.AddRange(new object[] {
            resources.GetString("cB_dataCount.Items"),
            resources.GetString("cB_dataCount.Items1"),
            resources.GetString("cB_dataCount.Items2"),
            resources.GetString("cB_dataCount.Items3"),
            resources.GetString("cB_dataCount.Items4"),
            resources.GetString("cB_dataCount.Items5"),
            resources.GetString("cB_dataCount.Items6"),
            resources.GetString("cB_dataCount.Items7"),
            resources.GetString("cB_dataCount.Items8"),
            resources.GetString("cB_dataCount.Items9")});
            this.cB_dataCount.Name = "cB_dataCount";
            this.cB_dataCount.SelectedValueChanged += new System.EventHandler(this.cB_dataCount_SelectedValueChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cB_splitChar
            // 
            resources.ApplyResources(this.cB_splitChar, "cB_splitChar");
            this.cB_splitChar.FormattingEnabled = true;
            this.cB_splitChar.Items.AddRange(new object[] {
            resources.GetString("cB_splitChar.Items"),
            resources.GetString("cB_splitChar.Items1"),
            resources.GetString("cB_splitChar.Items2"),
            resources.GetString("cB_splitChar.Items3"),
            resources.GetString("cB_splitChar.Items4"),
            resources.GetString("cB_splitChar.Items5"),
            resources.GetString("cB_splitChar.Items6"),
            resources.GetString("cB_splitChar.Items7"),
            resources.GetString("cB_splitChar.Items8"),
            resources.GetString("cB_splitChar.Items9"),
            resources.GetString("cB_splitChar.Items10"),
            resources.GetString("cB_splitChar.Items11"),
            resources.GetString("cB_splitChar.Items12"),
            resources.GetString("cB_splitChar.Items13"),
            resources.GetString("cB_splitChar.Items14"),
            resources.GetString("cB_splitChar.Items15"),
            resources.GetString("cB_splitChar.Items16"),
            resources.GetString("cB_splitChar.Items17")});
            this.cB_splitChar.Name = "cB_splitChar";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lbl_com
            // 
            resources.ApplyResources(this.lbl_com, "lbl_com");
            this.lbl_com.Name = "lbl_com";
            // 
            // lbl1
            // 
            resources.ApplyResources(this.lbl1, "lbl1");
            this.lbl1.Name = "lbl1";
            // 
            // tB_firstDataName
            // 
            resources.ApplyResources(this.tB_firstDataName, "tB_firstDataName");
            this.tB_firstDataName.Name = "tB_firstDataName";
            // 
            // lbl2
            // 
            resources.ApplyResources(this.lbl2, "lbl2");
            this.lbl2.Name = "lbl2";
            // 
            // tB_secondDataName
            // 
            resources.ApplyResources(this.tB_secondDataName, "tB_secondDataName");
            this.tB_secondDataName.Name = "tB_secondDataName";
            // 
            // lbl3
            // 
            resources.ApplyResources(this.lbl3, "lbl3");
            this.lbl3.Name = "lbl3";
            // 
            // tB_thirdDataName
            // 
            resources.ApplyResources(this.tB_thirdDataName, "tB_thirdDataName");
            this.tB_thirdDataName.Name = "tB_thirdDataName";
            // 
            // lbl4
            // 
            resources.ApplyResources(this.lbl4, "lbl4");
            this.lbl4.Name = "lbl4";
            // 
            // tB_fourthDataName
            // 
            resources.ApplyResources(this.tB_fourthDataName, "tB_fourthDataName");
            this.tB_fourthDataName.Name = "tB_fourthDataName";
            // 
            // lbl5
            // 
            resources.ApplyResources(this.lbl5, "lbl5");
            this.lbl5.Name = "lbl5";
            // 
            // tB_fifthDataName
            // 
            resources.ApplyResources(this.tB_fifthDataName, "tB_fifthDataName");
            this.tB_fifthDataName.Name = "tB_fifthDataName";
            // 
            // lbl6
            // 
            resources.ApplyResources(this.lbl6, "lbl6");
            this.lbl6.Name = "lbl6";
            // 
            // tB_sixthDataName
            // 
            resources.ApplyResources(this.tB_sixthDataName, "tB_sixthDataName");
            this.tB_sixthDataName.Name = "tB_sixthDataName";
            // 
            // lbl7
            // 
            resources.ApplyResources(this.lbl7, "lbl7");
            this.lbl7.Name = "lbl7";
            // 
            // tB_seventhDataName
            // 
            resources.ApplyResources(this.tB_seventhDataName, "tB_seventhDataName");
            this.tB_seventhDataName.Name = "tB_seventhDataName";
            // 
            // lbl8
            // 
            resources.ApplyResources(this.lbl8, "lbl8");
            this.lbl8.Name = "lbl8";
            // 
            // tB_eighthDataName
            // 
            resources.ApplyResources(this.tB_eighthDataName, "tB_eighthDataName");
            this.tB_eighthDataName.Name = "tB_eighthDataName";
            // 
            // lbl9
            // 
            resources.ApplyResources(this.lbl9, "lbl9");
            this.lbl9.Name = "lbl9";
            // 
            // tB_ninthDataName
            // 
            resources.ApplyResources(this.tB_ninthDataName, "tB_ninthDataName");
            this.tB_ninthDataName.Name = "tB_ninthDataName";
            // 
            // lbl10
            // 
            resources.ApplyResources(this.lbl10, "lbl10");
            this.lbl10.Name = "lbl10";
            // 
            // tB_tenthDataName
            // 
            resources.ApplyResources(this.tB_tenthDataName, "tB_tenthDataName");
            this.tB_tenthDataName.Name = "tB_tenthDataName";
            // 
            // btn_connect
            // 
            resources.ApplyResources(this.btn_connect, "btn_connect");
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // lbl_baundrate
            // 
            resources.ApplyResources(this.lbl_baundrate, "lbl_baundrate");
            this.lbl_baundrate.Name = "lbl_baundrate";
            // 
            // cB_firstG1
            // 
            resources.ApplyResources(this.cB_firstG1, "cB_firstG1");
            this.cB_firstG1.FormattingEnabled = true;
            this.cB_firstG1.Name = "cB_firstG1";
            // 
            // cB_secondG1
            // 
            resources.ApplyResources(this.cB_secondG1, "cB_secondG1");
            this.cB_secondG1.FormattingEnabled = true;
            this.cB_secondG1.Name = "cB_secondG1";
            // 
            // cB_thirdG1
            // 
            resources.ApplyResources(this.cB_thirdG1, "cB_thirdG1");
            this.cB_thirdG1.FormattingEnabled = true;
            this.cB_thirdG1.Name = "cB_thirdG1";
            // 
            // cB_fourthG1
            // 
            resources.ApplyResources(this.cB_fourthG1, "cB_fourthG1");
            this.cB_fourthG1.FormattingEnabled = true;
            this.cB_fourthG1.Name = "cB_fourthG1";
            // 
            // cB_fifthG1
            // 
            resources.ApplyResources(this.cB_fifthG1, "cB_fifthG1");
            this.cB_fifthG1.FormattingEnabled = true;
            this.cB_fifthG1.Name = "cB_fifthG1";
            // 
            // cB_sixthG1
            // 
            resources.ApplyResources(this.cB_sixthG1, "cB_sixthG1");
            this.cB_sixthG1.FormattingEnabled = true;
            this.cB_sixthG1.Name = "cB_sixthG1";
            // 
            // cB_seventhG1
            // 
            resources.ApplyResources(this.cB_seventhG1, "cB_seventhG1");
            this.cB_seventhG1.FormattingEnabled = true;
            this.cB_seventhG1.Name = "cB_seventhG1";
            // 
            // cB_eighthG1
            // 
            resources.ApplyResources(this.cB_eighthG1, "cB_eighthG1");
            this.cB_eighthG1.FormattingEnabled = true;
            this.cB_eighthG1.Name = "cB_eighthG1";
            // 
            // cB_ninthG1
            // 
            resources.ApplyResources(this.cB_ninthG1, "cB_ninthG1");
            this.cB_ninthG1.FormattingEnabled = true;
            this.cB_ninthG1.Name = "cB_ninthG1";
            // 
            // cB_tenthG1
            // 
            resources.ApplyResources(this.cB_tenthG1, "cB_tenthG1");
            this.cB_tenthG1.FormattingEnabled = true;
            this.cB_tenthG1.Name = "cB_tenthG1";
            // 
            // cB_firstG2
            // 
            resources.ApplyResources(this.cB_firstG2, "cB_firstG2");
            this.cB_firstG2.FormattingEnabled = true;
            this.cB_firstG2.Name = "cB_firstG2";
            // 
            // cB_secondG2
            // 
            resources.ApplyResources(this.cB_secondG2, "cB_secondG2");
            this.cB_secondG2.FormattingEnabled = true;
            this.cB_secondG2.Name = "cB_secondG2";
            // 
            // cB_thirdG2
            // 
            resources.ApplyResources(this.cB_thirdG2, "cB_thirdG2");
            this.cB_thirdG2.FormattingEnabled = true;
            this.cB_thirdG2.Name = "cB_thirdG2";
            // 
            // cB_fourthG2
            // 
            resources.ApplyResources(this.cB_fourthG2, "cB_fourthG2");
            this.cB_fourthG2.FormattingEnabled = true;
            this.cB_fourthG2.Name = "cB_fourthG2";
            // 
            // cB_fifthG2
            // 
            resources.ApplyResources(this.cB_fifthG2, "cB_fifthG2");
            this.cB_fifthG2.FormattingEnabled = true;
            this.cB_fifthG2.Name = "cB_fifthG2";
            // 
            // cB_sixthG2
            // 
            resources.ApplyResources(this.cB_sixthG2, "cB_sixthG2");
            this.cB_sixthG2.FormattingEnabled = true;
            this.cB_sixthG2.Name = "cB_sixthG2";
            // 
            // cB_seventhG2
            // 
            resources.ApplyResources(this.cB_seventhG2, "cB_seventhG2");
            this.cB_seventhG2.FormattingEnabled = true;
            this.cB_seventhG2.Name = "cB_seventhG2";
            // 
            // cB_eighthG2
            // 
            resources.ApplyResources(this.cB_eighthG2, "cB_eighthG2");
            this.cB_eighthG2.FormattingEnabled = true;
            this.cB_eighthG2.Name = "cB_eighthG2";
            // 
            // cB_ninthG2
            // 
            resources.ApplyResources(this.cB_ninthG2, "cB_ninthG2");
            this.cB_ninthG2.FormattingEnabled = true;
            this.cB_ninthG2.Name = "cB_ninthG2";
            // 
            // cB_tenthG2
            // 
            resources.ApplyResources(this.cB_tenthG2, "cB_tenthG2");
            this.cB_tenthG2.FormattingEnabled = true;
            this.cB_tenthG2.Name = "cB_tenthG2";
            // 
            // lbl_chart2
            // 
            resources.ApplyResources(this.lbl_chart2, "lbl_chart2");
            this.lbl_chart2.Name = "lbl_chart2";
            // 
            // lbl_chart1
            // 
            resources.ApplyResources(this.lbl_chart1, "lbl_chart1");
            this.lbl_chart1.Name = "lbl_chart1";
            // 
            // checkbox_chart2
            // 
            resources.ApplyResources(this.checkbox_chart2, "checkbox_chart2");
            this.checkbox_chart2.Name = "checkbox_chart2";
            this.checkbox_chart2.UseVisualStyleBackColor = true;
            this.checkbox_chart2.CheckedChanged += new System.EventHandler(this.cB_dataCount_SelectedValueChanged);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            // 
            // btn_clr1
            // 
            resources.ApplyResources(this.btn_clr1, "btn_clr1");
            this.btn_clr1.BackColor = System.Drawing.Color.Red;
            this.btn_clr1.Name = "btn_clr1";
            this.btn_clr1.UseVisualStyleBackColor = false;
            this.btn_clr1.Click += new System.EventHandler(this.btn_clr1_Click);
            // 
            // btn_clr2
            // 
            resources.ApplyResources(this.btn_clr2, "btn_clr2");
            this.btn_clr2.BackColor = System.Drawing.Color.Blue;
            this.btn_clr2.Name = "btn_clr2";
            this.btn_clr2.UseVisualStyleBackColor = false;
            this.btn_clr2.Click += new System.EventHandler(this.btn_clr2_Click);
            // 
            // btn_clr3
            // 
            resources.ApplyResources(this.btn_clr3, "btn_clr3");
            this.btn_clr3.BackColor = System.Drawing.Color.Lime;
            this.btn_clr3.Name = "btn_clr3";
            this.btn_clr3.UseVisualStyleBackColor = false;
            this.btn_clr3.Click += new System.EventHandler(this.btn_clr3_Click);
            // 
            // btn_clr4
            // 
            resources.ApplyResources(this.btn_clr4, "btn_clr4");
            this.btn_clr4.BackColor = System.Drawing.Color.Yellow;
            this.btn_clr4.Name = "btn_clr4";
            this.btn_clr4.UseVisualStyleBackColor = false;
            this.btn_clr4.Click += new System.EventHandler(this.btn_clr4_Click);
            // 
            // btn_clr5
            // 
            resources.ApplyResources(this.btn_clr5, "btn_clr5");
            this.btn_clr5.BackColor = System.Drawing.Color.Fuchsia;
            this.btn_clr5.Name = "btn_clr5";
            this.btn_clr5.UseVisualStyleBackColor = false;
            this.btn_clr5.Click += new System.EventHandler(this.btn_clr5_Click);
            // 
            // btn_clr6
            // 
            resources.ApplyResources(this.btn_clr6, "btn_clr6");
            this.btn_clr6.BackColor = System.Drawing.Color.Aqua;
            this.btn_clr6.Name = "btn_clr6";
            this.btn_clr6.UseVisualStyleBackColor = false;
            this.btn_clr6.Click += new System.EventHandler(this.btn_clr6_Click);
            // 
            // btn_clr7
            // 
            resources.ApplyResources(this.btn_clr7, "btn_clr7");
            this.btn_clr7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_clr7.Name = "btn_clr7";
            this.btn_clr7.UseVisualStyleBackColor = false;
            this.btn_clr7.Click += new System.EventHandler(this.btn_clr7_Click);
            // 
            // btn_clr8
            // 
            resources.ApplyResources(this.btn_clr8, "btn_clr8");
            this.btn_clr8.BackColor = System.Drawing.Color.Silver;
            this.btn_clr8.Name = "btn_clr8";
            this.btn_clr8.UseVisualStyleBackColor = false;
            this.btn_clr8.Click += new System.EventHandler(this.btn_clr8_Click);
            // 
            // btn_clr9
            // 
            resources.ApplyResources(this.btn_clr9, "btn_clr9");
            this.btn_clr9.BackColor = System.Drawing.Color.Black;
            this.btn_clr9.Name = "btn_clr9";
            this.btn_clr9.UseVisualStyleBackColor = false;
            this.btn_clr9.Click += new System.EventHandler(this.btn_clr9_Click);
            // 
            // btn_clr10
            // 
            resources.ApplyResources(this.btn_clr10, "btn_clr10");
            this.btn_clr10.BackColor = System.Drawing.Color.Gold;
            this.btn_clr10.Name = "btn_clr10";
            this.btn_clr10.UseVisualStyleBackColor = false;
            this.btn_clr10.Click += new System.EventHandler(this.btn_clr10_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Name = "label4";
            // 
            // SerialReadAndWrite1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_clr10);
            this.Controls.Add(this.btn_clr9);
            this.Controls.Add(this.btn_clr8);
            this.Controls.Add(this.btn_clr7);
            this.Controls.Add(this.btn_clr6);
            this.Controls.Add(this.btn_clr5);
            this.Controls.Add(this.btn_clr4);
            this.Controls.Add(this.btn_clr3);
            this.Controls.Add(this.btn_clr2);
            this.Controls.Add(this.btn_clr1);
            this.Controls.Add(this.checkbox_chart2);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.cB_tenthG2);
            this.Controls.Add(this.cB_tenthG1);
            this.Controls.Add(this.cB_ninthG2);
            this.Controls.Add(this.cB_ninthG1);
            this.Controls.Add(this.cB_eighthG2);
            this.Controls.Add(this.cB_eighthG1);
            this.Controls.Add(this.cB_seventhG2);
            this.Controls.Add(this.cB_seventhG1);
            this.Controls.Add(this.cB_sixthG2);
            this.Controls.Add(this.cB_sixthG1);
            this.Controls.Add(this.cB_fifthG2);
            this.Controls.Add(this.cB_fifthG1);
            this.Controls.Add(this.cB_fourthG2);
            this.Controls.Add(this.cB_fourthG1);
            this.Controls.Add(this.cB_thirdG2);
            this.Controls.Add(this.cB_thirdG1);
            this.Controls.Add(this.cB_secondG2);
            this.Controls.Add(this.cB_secondG1);
            this.Controls.Add(this.cB_firstG2);
            this.Controls.Add(this.cB_firstG1);
            this.Controls.Add(this.lbl_baundrate);
            this.Controls.Add(this.tB_tenthDataName);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.tB_ninthDataName);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.tB_eighthDataName);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.tB_seventhDataName);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.tB_sixthDataName);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.tB_fifthDataName);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.tB_fourthDataName);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.tB_thirdDataName);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.tB_secondDataName);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.tB_firstDataName);
            this.Controls.Add(this.lbl_chart2);
            this.Controls.Add(this.lbl_chart1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl_com);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cB_splitChar);
            this.Controls.Add(this.cB_dataCount);
            this.Name = "SerialReadAndWrite1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SerialReadAndWrite1_FormClosed);
            this.Load += new System.EventHandler(this.SerialReadAndWrite1_Load);
            this.Shown += new System.EventHandler(this.SerialReadAndWrite1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cB_dataCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cB_splitChar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_com;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox tB_firstDataName;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox tB_secondDataName;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox tB_thirdDataName;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox tB_fourthDataName;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.TextBox tB_fifthDataName;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.TextBox tB_sixthDataName;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.TextBox tB_seventhDataName;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.TextBox tB_eighthDataName;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.TextBox tB_ninthDataName;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.TextBox tB_tenthDataName;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label lbl_baundrate;
        private System.Windows.Forms.ComboBox cB_firstG1;
        private System.Windows.Forms.ComboBox cB_secondG1;
        private System.Windows.Forms.ComboBox cB_thirdG1;
        private System.Windows.Forms.ComboBox cB_fourthG1;
        private System.Windows.Forms.ComboBox cB_fifthG1;
        private System.Windows.Forms.ComboBox cB_sixthG1;
        private System.Windows.Forms.ComboBox cB_seventhG1;
        private System.Windows.Forms.ComboBox cB_eighthG1;
        private System.Windows.Forms.ComboBox cB_ninthG1;
        private System.Windows.Forms.ComboBox cB_tenthG1;
        private System.Windows.Forms.ComboBox cB_firstG2;
        private System.Windows.Forms.ComboBox cB_secondG2;
        private System.Windows.Forms.ComboBox cB_thirdG2;
        private System.Windows.Forms.ComboBox cB_fourthG2;
        private System.Windows.Forms.ComboBox cB_fifthG2;
        private System.Windows.Forms.ComboBox cB_sixthG2;
        private System.Windows.Forms.ComboBox cB_seventhG2;
        private System.Windows.Forms.ComboBox cB_eighthG2;
        private System.Windows.Forms.ComboBox cB_ninthG2;
        private System.Windows.Forms.ComboBox cB_tenthG2;
        private System.Windows.Forms.Label lbl_chart2;
        private System.Windows.Forms.Label lbl_chart1;
        private System.Windows.Forms.CheckBox checkbox_chart2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btn_clr1;
        private System.Windows.Forms.Button btn_clr2;
        private System.Windows.Forms.Button btn_clr3;
        private System.Windows.Forms.Button btn_clr4;
        private System.Windows.Forms.Button btn_clr5;
        private System.Windows.Forms.Button btn_clr6;
        private System.Windows.Forms.Button btn_clr7;
        private System.Windows.Forms.Button btn_clr8;
        private System.Windows.Forms.Button btn_clr9;
        private System.Windows.Forms.Button btn_clr10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}