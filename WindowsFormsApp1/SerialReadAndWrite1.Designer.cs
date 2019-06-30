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
            this.SuspendLayout();
            // 
            // cB_dataCount
            // 
            this.cB_dataCount.FormattingEnabled = true;
            this.cB_dataCount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cB_dataCount.Location = new System.Drawing.Point(121, 35);
            this.cB_dataCount.Name = "cB_dataCount";
            this.cB_dataCount.Size = new System.Drawing.Size(121, 21);
            this.cB_dataCount.TabIndex = 0;
            this.cB_dataCount.Text = "1";
            this.cB_dataCount.SelectedValueChanged += new System.EventHandler(this.cB_dataCount_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bilgi Sayısı";
            // 
            // cB_splitChar
            // 
            this.cB_splitChar.FormattingEnabled = true;
            this.cB_splitChar.Items.AddRange(new object[] {
            "*",
            "_",
            "-",
            "+",
            "/",
            "\\",
            "|",
            "<",
            ">",
            "<<",
            ">>",
            "||",
            "**",
            "__",
            "--",
            "//",
            "\\\\",
            "++"});
            this.cB_splitChar.Location = new System.Drawing.Point(121, 62);
            this.cB_splitChar.Name = "cB_splitChar";
            this.cB_splitChar.Size = new System.Drawing.Size(121, 21);
            this.cB_splitChar.TabIndex = 0;
            this.cB_splitChar.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bilgi Bölücü Karakter";
            // 
            // lbl_com
            // 
            this.lbl_com.AutoSize = true;
            this.lbl_com.Location = new System.Drawing.Point(5, 0);
            this.lbl_com.Name = "lbl_com";
            this.lbl_com.Size = new System.Drawing.Size(37, 13);
            this.lbl_com.TabIndex = 3;
            this.lbl_com.Text = "COM?";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(56, 100);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(59, 13);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "1. Bilgi İsmi";
            // 
            // tB_firstDataName
            // 
            this.tB_firstDataName.Location = new System.Drawing.Point(121, 97);
            this.tB_firstDataName.Name = "tB_firstDataName";
            this.tB_firstDataName.Size = new System.Drawing.Size(121, 20);
            this.tB_firstDataName.TabIndex = 5;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(56, 126);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(59, 13);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "2. Bilgi İsmi";
            this.lbl2.Visible = false;
            // 
            // tB_secondDataName
            // 
            this.tB_secondDataName.Location = new System.Drawing.Point(121, 123);
            this.tB_secondDataName.Name = "tB_secondDataName";
            this.tB_secondDataName.Size = new System.Drawing.Size(121, 20);
            this.tB_secondDataName.TabIndex = 5;
            this.tB_secondDataName.Visible = false;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(56, 152);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(59, 13);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "3. Bilgi İsmi";
            this.lbl3.Visible = false;
            // 
            // tB_thirdDataName
            // 
            this.tB_thirdDataName.Location = new System.Drawing.Point(121, 149);
            this.tB_thirdDataName.Name = "tB_thirdDataName";
            this.tB_thirdDataName.Size = new System.Drawing.Size(121, 20);
            this.tB_thirdDataName.TabIndex = 5;
            this.tB_thirdDataName.Visible = false;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(56, 178);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(59, 13);
            this.lbl4.TabIndex = 4;
            this.lbl4.Text = "4. Bilgi İsmi";
            this.lbl4.Visible = false;
            // 
            // tB_fourthDataName
            // 
            this.tB_fourthDataName.Location = new System.Drawing.Point(121, 175);
            this.tB_fourthDataName.Name = "tB_fourthDataName";
            this.tB_fourthDataName.Size = new System.Drawing.Size(121, 20);
            this.tB_fourthDataName.TabIndex = 5;
            this.tB_fourthDataName.Visible = false;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(56, 204);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(59, 13);
            this.lbl5.TabIndex = 4;
            this.lbl5.Text = "5. Bilgi İsmi";
            this.lbl5.Visible = false;
            // 
            // tB_fifthDataName
            // 
            this.tB_fifthDataName.Location = new System.Drawing.Point(121, 201);
            this.tB_fifthDataName.Name = "tB_fifthDataName";
            this.tB_fifthDataName.Size = new System.Drawing.Size(121, 20);
            this.tB_fifthDataName.TabIndex = 5;
            this.tB_fifthDataName.Visible = false;
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(56, 230);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(59, 13);
            this.lbl6.TabIndex = 4;
            this.lbl6.Text = "6. Bilgi İsmi";
            this.lbl6.Visible = false;
            // 
            // tB_sixthDataName
            // 
            this.tB_sixthDataName.Location = new System.Drawing.Point(121, 227);
            this.tB_sixthDataName.Name = "tB_sixthDataName";
            this.tB_sixthDataName.Size = new System.Drawing.Size(121, 20);
            this.tB_sixthDataName.TabIndex = 5;
            this.tB_sixthDataName.Visible = false;
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(56, 256);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(59, 13);
            this.lbl7.TabIndex = 4;
            this.lbl7.Text = "7. Bilgi İsmi";
            this.lbl7.Visible = false;
            // 
            // tB_seventhDataName
            // 
            this.tB_seventhDataName.Location = new System.Drawing.Point(121, 253);
            this.tB_seventhDataName.Name = "tB_seventhDataName";
            this.tB_seventhDataName.Size = new System.Drawing.Size(121, 20);
            this.tB_seventhDataName.TabIndex = 5;
            this.tB_seventhDataName.Visible = false;
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Location = new System.Drawing.Point(56, 282);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(59, 13);
            this.lbl8.TabIndex = 4;
            this.lbl8.Text = "8. Bilgi İsmi";
            this.lbl8.Visible = false;
            // 
            // tB_eighthDataName
            // 
            this.tB_eighthDataName.Location = new System.Drawing.Point(121, 279);
            this.tB_eighthDataName.Name = "tB_eighthDataName";
            this.tB_eighthDataName.Size = new System.Drawing.Size(121, 20);
            this.tB_eighthDataName.TabIndex = 5;
            this.tB_eighthDataName.Visible = false;
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Location = new System.Drawing.Point(56, 308);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(59, 13);
            this.lbl9.TabIndex = 4;
            this.lbl9.Text = "9. Bilgi İsmi";
            this.lbl9.Visible = false;
            // 
            // tB_ninthDataName
            // 
            this.tB_ninthDataName.Location = new System.Drawing.Point(121, 305);
            this.tB_ninthDataName.Name = "tB_ninthDataName";
            this.tB_ninthDataName.Size = new System.Drawing.Size(121, 20);
            this.tB_ninthDataName.TabIndex = 5;
            this.tB_ninthDataName.Visible = false;
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Location = new System.Drawing.Point(56, 334);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(65, 13);
            this.lbl10.TabIndex = 4;
            this.lbl10.Text = "10. Bilgi İsmi";
            this.lbl10.Visible = false;
            // 
            // tB_tenthDataName
            // 
            this.tB_tenthDataName.Location = new System.Drawing.Point(121, 331);
            this.tB_tenthDataName.Name = "tB_tenthDataName";
            this.tB_tenthDataName.Size = new System.Drawing.Size(121, 20);
            this.tB_tenthDataName.TabIndex = 5;
            this.tB_tenthDataName.Visible = false;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(217, 130);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(183, 23);
            this.btn_connect.TabIndex = 6;
            this.btn_connect.Text = "İletişimi Başlat";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // lbl_baundrate
            // 
            this.lbl_baundrate.AutoSize = true;
            this.lbl_baundrate.Location = new System.Drawing.Point(48, 0);
            this.lbl_baundrate.Name = "lbl_baundrate";
            this.lbl_baundrate.Size = new System.Drawing.Size(67, 13);
            this.lbl_baundrate.TabIndex = 7;
            this.lbl_baundrate.Text = "BaundRate?";
            // 
            // cB_firstG1
            // 
            this.cB_firstG1.FormattingEnabled = true;
            this.cB_firstG1.Location = new System.Drawing.Point(248, 97);
            this.cB_firstG1.Name = "cB_firstG1";
            this.cB_firstG1.Size = new System.Drawing.Size(121, 21);
            this.cB_firstG1.TabIndex = 8;
            // 
            // cB_secondG1
            // 
            this.cB_secondG1.FormattingEnabled = true;
            this.cB_secondG1.Location = new System.Drawing.Point(248, 123);
            this.cB_secondG1.Name = "cB_secondG1";
            this.cB_secondG1.Size = new System.Drawing.Size(121, 21);
            this.cB_secondG1.TabIndex = 8;
            // 
            // cB_thirdG1
            // 
            this.cB_thirdG1.FormattingEnabled = true;
            this.cB_thirdG1.Location = new System.Drawing.Point(248, 149);
            this.cB_thirdG1.Name = "cB_thirdG1";
            this.cB_thirdG1.Size = new System.Drawing.Size(121, 21);
            this.cB_thirdG1.TabIndex = 8;
            // 
            // cB_fourthG1
            // 
            this.cB_fourthG1.FormattingEnabled = true;
            this.cB_fourthG1.Location = new System.Drawing.Point(248, 175);
            this.cB_fourthG1.Name = "cB_fourthG1";
            this.cB_fourthG1.Size = new System.Drawing.Size(121, 21);
            this.cB_fourthG1.TabIndex = 8;
            // 
            // cB_fifthG1
            // 
            this.cB_fifthG1.FormattingEnabled = true;
            this.cB_fifthG1.Location = new System.Drawing.Point(248, 201);
            this.cB_fifthG1.Name = "cB_fifthG1";
            this.cB_fifthG1.Size = new System.Drawing.Size(121, 21);
            this.cB_fifthG1.TabIndex = 8;
            // 
            // cB_sixthG1
            // 
            this.cB_sixthG1.FormattingEnabled = true;
            this.cB_sixthG1.Location = new System.Drawing.Point(248, 227);
            this.cB_sixthG1.Name = "cB_sixthG1";
            this.cB_sixthG1.Size = new System.Drawing.Size(121, 21);
            this.cB_sixthG1.TabIndex = 8;
            // 
            // cB_seventhG1
            // 
            this.cB_seventhG1.FormattingEnabled = true;
            this.cB_seventhG1.Location = new System.Drawing.Point(248, 253);
            this.cB_seventhG1.Name = "cB_seventhG1";
            this.cB_seventhG1.Size = new System.Drawing.Size(121, 21);
            this.cB_seventhG1.TabIndex = 8;
            // 
            // cB_eighthG1
            // 
            this.cB_eighthG1.FormattingEnabled = true;
            this.cB_eighthG1.Location = new System.Drawing.Point(248, 279);
            this.cB_eighthG1.Name = "cB_eighthG1";
            this.cB_eighthG1.Size = new System.Drawing.Size(121, 21);
            this.cB_eighthG1.TabIndex = 8;
            // 
            // cB_ninthG1
            // 
            this.cB_ninthG1.FormattingEnabled = true;
            this.cB_ninthG1.Location = new System.Drawing.Point(248, 305);
            this.cB_ninthG1.Name = "cB_ninthG1";
            this.cB_ninthG1.Size = new System.Drawing.Size(121, 21);
            this.cB_ninthG1.TabIndex = 8;
            // 
            // cB_tenthG1
            // 
            this.cB_tenthG1.FormattingEnabled = true;
            this.cB_tenthG1.Location = new System.Drawing.Point(248, 331);
            this.cB_tenthG1.Name = "cB_tenthG1";
            this.cB_tenthG1.Size = new System.Drawing.Size(121, 21);
            this.cB_tenthG1.TabIndex = 8;
            // 
            // cB_firstG2
            // 
            this.cB_firstG2.FormattingEnabled = true;
            this.cB_firstG2.Location = new System.Drawing.Point(375, 97);
            this.cB_firstG2.Name = "cB_firstG2";
            this.cB_firstG2.Size = new System.Drawing.Size(121, 21);
            this.cB_firstG2.TabIndex = 8;
            // 
            // cB_secondG2
            // 
            this.cB_secondG2.FormattingEnabled = true;
            this.cB_secondG2.Location = new System.Drawing.Point(375, 123);
            this.cB_secondG2.Name = "cB_secondG2";
            this.cB_secondG2.Size = new System.Drawing.Size(121, 21);
            this.cB_secondG2.TabIndex = 8;
            // 
            // cB_thirdG2
            // 
            this.cB_thirdG2.FormattingEnabled = true;
            this.cB_thirdG2.Location = new System.Drawing.Point(375, 149);
            this.cB_thirdG2.Name = "cB_thirdG2";
            this.cB_thirdG2.Size = new System.Drawing.Size(121, 21);
            this.cB_thirdG2.TabIndex = 8;
            // 
            // cB_fourthG2
            // 
            this.cB_fourthG2.FormattingEnabled = true;
            this.cB_fourthG2.Location = new System.Drawing.Point(375, 175);
            this.cB_fourthG2.Name = "cB_fourthG2";
            this.cB_fourthG2.Size = new System.Drawing.Size(121, 21);
            this.cB_fourthG2.TabIndex = 8;
            // 
            // cB_fifthG2
            // 
            this.cB_fifthG2.FormattingEnabled = true;
            this.cB_fifthG2.Location = new System.Drawing.Point(375, 201);
            this.cB_fifthG2.Name = "cB_fifthG2";
            this.cB_fifthG2.Size = new System.Drawing.Size(121, 21);
            this.cB_fifthG2.TabIndex = 8;
            // 
            // cB_sixthG2
            // 
            this.cB_sixthG2.FormattingEnabled = true;
            this.cB_sixthG2.Location = new System.Drawing.Point(375, 227);
            this.cB_sixthG2.Name = "cB_sixthG2";
            this.cB_sixthG2.Size = new System.Drawing.Size(121, 21);
            this.cB_sixthG2.TabIndex = 8;
            // 
            // cB_seventhG2
            // 
            this.cB_seventhG2.FormattingEnabled = true;
            this.cB_seventhG2.Location = new System.Drawing.Point(375, 253);
            this.cB_seventhG2.Name = "cB_seventhG2";
            this.cB_seventhG2.Size = new System.Drawing.Size(121, 21);
            this.cB_seventhG2.TabIndex = 8;
            // 
            // cB_eighthG2
            // 
            this.cB_eighthG2.FormattingEnabled = true;
            this.cB_eighthG2.Location = new System.Drawing.Point(375, 279);
            this.cB_eighthG2.Name = "cB_eighthG2";
            this.cB_eighthG2.Size = new System.Drawing.Size(121, 21);
            this.cB_eighthG2.TabIndex = 8;
            // 
            // cB_ninthG2
            // 
            this.cB_ninthG2.FormattingEnabled = true;
            this.cB_ninthG2.Location = new System.Drawing.Point(375, 305);
            this.cB_ninthG2.Name = "cB_ninthG2";
            this.cB_ninthG2.Size = new System.Drawing.Size(121, 21);
            this.cB_ninthG2.TabIndex = 8;
            // 
            // cB_tenthG2
            // 
            this.cB_tenthG2.FormattingEnabled = true;
            this.cB_tenthG2.Location = new System.Drawing.Point(375, 331);
            this.cB_tenthG2.Name = "cB_tenthG2";
            this.cB_tenthG2.Size = new System.Drawing.Size(121, 21);
            this.cB_tenthG2.TabIndex = 8;
            // 
            // lbl_chart2
            // 
            this.lbl_chart2.AutoSize = true;
            this.lbl_chart2.Location = new System.Drawing.Point(410, 81);
            this.lbl_chart2.Name = "lbl_chart2";
            this.lbl_chart2.Size = new System.Drawing.Size(44, 13);
            this.lbl_chart2.TabIndex = 4;
            this.lbl_chart2.Text = "Grafik 2";
            // 
            // lbl_chart1
            // 
            this.lbl_chart1.AutoSize = true;
            this.lbl_chart1.Location = new System.Drawing.Point(287, 81);
            this.lbl_chart1.Name = "lbl_chart1";
            this.lbl_chart1.Size = new System.Drawing.Size(44, 13);
            this.lbl_chart1.TabIndex = 4;
            this.lbl_chart1.Text = "Grafik 1";
            // 
            // checkbox_chart2
            // 
            this.checkbox_chart2.AutoSize = true;
            this.checkbox_chart2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkbox_chart2.Location = new System.Drawing.Point(248, 37);
            this.checkbox_chart2.Name = "checkbox_chart2";
            this.checkbox_chart2.Size = new System.Drawing.Size(63, 17);
            this.checkbox_chart2.TabIndex = 10;
            this.checkbox_chart2.Text = "Grafik 2";
            this.checkbox_chart2.UseVisualStyleBackColor = true;
            this.checkbox_chart2.CheckedChanged += new System.EventHandler(this.cB_dataCount_SelectedValueChanged);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            // 
            // btn_clr1
            // 
            this.btn_clr1.BackColor = System.Drawing.Color.Red;
            this.btn_clr1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clr1.Location = new System.Drawing.Point(35, 99);
            this.btn_clr1.Name = "btn_clr1";
            this.btn_clr1.Size = new System.Drawing.Size(15, 15);
            this.btn_clr1.TabIndex = 11;
            this.btn_clr1.UseVisualStyleBackColor = false;
            this.btn_clr1.Click += new System.EventHandler(this.btn_clr1_Click);
            // 
            // btn_clr2
            // 
            this.btn_clr2.BackColor = System.Drawing.Color.Blue;
            this.btn_clr2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clr2.Location = new System.Drawing.Point(35, 125);
            this.btn_clr2.Name = "btn_clr2";
            this.btn_clr2.Size = new System.Drawing.Size(15, 15);
            this.btn_clr2.TabIndex = 11;
            this.btn_clr2.UseVisualStyleBackColor = false;
            this.btn_clr2.Click += new System.EventHandler(this.btn_clr1_Click);
            // 
            // btn_clr3
            // 
            this.btn_clr3.BackColor = System.Drawing.Color.Lime;
            this.btn_clr3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clr3.Location = new System.Drawing.Point(35, 151);
            this.btn_clr3.Name = "btn_clr3";
            this.btn_clr3.Size = new System.Drawing.Size(15, 15);
            this.btn_clr3.TabIndex = 11;
            this.btn_clr3.UseVisualStyleBackColor = false;
            this.btn_clr3.Click += new System.EventHandler(this.btn_clr1_Click);
            // 
            // btn_clr4
            // 
            this.btn_clr4.BackColor = System.Drawing.Color.Yellow;
            this.btn_clr4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clr4.Location = new System.Drawing.Point(35, 177);
            this.btn_clr4.Name = "btn_clr4";
            this.btn_clr4.Size = new System.Drawing.Size(15, 15);
            this.btn_clr4.TabIndex = 11;
            this.btn_clr4.UseVisualStyleBackColor = false;
            this.btn_clr4.Click += new System.EventHandler(this.btn_clr1_Click);
            // 
            // btn_clr5
            // 
            this.btn_clr5.BackColor = System.Drawing.Color.Fuchsia;
            this.btn_clr5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clr5.Location = new System.Drawing.Point(35, 203);
            this.btn_clr5.Name = "btn_clr5";
            this.btn_clr5.Size = new System.Drawing.Size(15, 15);
            this.btn_clr5.TabIndex = 11;
            this.btn_clr5.UseVisualStyleBackColor = false;
            this.btn_clr5.Click += new System.EventHandler(this.btn_clr1_Click);
            // 
            // btn_clr6
            // 
            this.btn_clr6.BackColor = System.Drawing.Color.Aqua;
            this.btn_clr6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clr6.Location = new System.Drawing.Point(35, 229);
            this.btn_clr6.Name = "btn_clr6";
            this.btn_clr6.Size = new System.Drawing.Size(15, 15);
            this.btn_clr6.TabIndex = 11;
            this.btn_clr6.UseVisualStyleBackColor = false;
            this.btn_clr6.Click += new System.EventHandler(this.btn_clr1_Click);
            // 
            // btn_clr7
            // 
            this.btn_clr7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_clr7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clr7.Location = new System.Drawing.Point(35, 255);
            this.btn_clr7.Name = "btn_clr7";
            this.btn_clr7.Size = new System.Drawing.Size(15, 15);
            this.btn_clr7.TabIndex = 11;
            this.btn_clr7.UseVisualStyleBackColor = false;
            this.btn_clr7.Click += new System.EventHandler(this.btn_clr1_Click);
            // 
            // btn_clr8
            // 
            this.btn_clr8.BackColor = System.Drawing.Color.Silver;
            this.btn_clr8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clr8.Location = new System.Drawing.Point(35, 281);
            this.btn_clr8.Name = "btn_clr8";
            this.btn_clr8.Size = new System.Drawing.Size(15, 15);
            this.btn_clr8.TabIndex = 11;
            this.btn_clr8.UseVisualStyleBackColor = false;
            this.btn_clr8.Click += new System.EventHandler(this.btn_clr1_Click);
            // 
            // btn_clr9
            // 
            this.btn_clr9.BackColor = System.Drawing.Color.Black;
            this.btn_clr9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clr9.Location = new System.Drawing.Point(35, 307);
            this.btn_clr9.Name = "btn_clr9";
            this.btn_clr9.Size = new System.Drawing.Size(15, 15);
            this.btn_clr9.TabIndex = 11;
            this.btn_clr9.UseVisualStyleBackColor = false;
            this.btn_clr9.Click += new System.EventHandler(this.btn_clr1_Click);
            // 
            // btn_clr10
            // 
            this.btn_clr10.BackColor = System.Drawing.Color.Gold;
            this.btn_clr10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clr10.Location = new System.Drawing.Point(35, 333);
            this.btn_clr10.Name = "btn_clr10";
            this.btn_clr10.Size = new System.Drawing.Size(15, 15);
            this.btn_clr10.TabIndex = 11;
            this.btn_clr10.UseVisualStyleBackColor = false;
            this.btn_clr10.Click += new System.EventHandler(this.btn_clr1_Click);
            // 
            // SerialReadAndWrite1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 401);
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
            this.Text = "SerialReadAndWrite";
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
    }
}