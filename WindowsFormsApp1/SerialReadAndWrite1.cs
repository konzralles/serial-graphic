using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SerialReadAndWrite1 : Form
    {
        int Baundrate;
        string PortName;
        public SerialReadAndWrite1(int Baundrate, string PortName)
        {
            InitializeComponent();
            this.PortName = PortName;
            this.Baundrate = Baundrate;
            lbl_com.Text = PortName;
            lbl_baundrate.Text = "BaundRate " + Baundrate.ToString();
        }
        
        private ChartTypeEnum Chart_Cb_to_enum (int index)
        {
            switch (index)
            {
                case 0:
                    return ChartTypeEnum.NOT_SELECTED;

                case 1:
                    return ChartTypeEnum.LINE;

                case 2:
                    return ChartTypeEnum.COLUMN;

                default:
                    return ChartTypeEnum.NOT_SELECTED;
            }

        }

        private bool ControlUINullNameOrChartType()
        {
            int dataCount = Convert.ToInt32(cB_dataCount.Items[cB_dataCount.SelectedIndex]);
            if ((tB_firstDataName.Text == "")||(cB_firstG1.SelectedIndex==0)) return true;
            if (dataCount >= 2) if ((tB_secondDataName.Text == "")|| (cB_secondG1.SelectedIndex == 0)) return true;
            if (dataCount >= 3) if ((tB_thirdDataName.Text == "")|| (cB_thirdG1.SelectedIndex == 0)) return true; 
            if (dataCount >= 4) if ((tB_fourthDataName.Text == "")|| (cB_fourthG1.SelectedIndex == 0)) return true; 
            if (dataCount >= 5) if ((tB_fifthDataName.Text == "")|| (cB_fifthG1.SelectedIndex == 0)) return true; 
            if (dataCount >= 6) if ((tB_sixthDataName.Text == "")|| (cB_sixthG1.SelectedIndex == 0)) return true; 
            if (dataCount >= 7) if ((tB_seventhDataName.Text == "")|| (cB_seventhG1.SelectedIndex == 0)) return true; 
            if (dataCount >= 8) if ((tB_eighthDataName.Text == "")|| (cB_eighthG1.SelectedIndex == 0)) return true; 
            if (dataCount >= 9) if ((tB_ninthDataName.Text == "")|| (cB_ninthG1.SelectedIndex == 0)) return true; 
            if (dataCount >= 10) if ((tB_tenthDataName.Text == "")|| (cB_tenthG1.SelectedIndex == 0)) return true;
            return false;

        }

        private bool ControlSameString(string[] StringList, int LastCheckIndex)
        {
            for (int x = 0; x < LastCheckIndex+1; x++)
            {
                for (int y = 0; y < LastCheckIndex+1; y++)
                {
                    if ((StringList[x] == StringList[y]) && (x != y)) return true;
                }
            }
            return false;
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (ControlUINullNameOrChartType()==true)
            {
                MessageBox.Show("Lütfen kullanacağınız tüm verilere isim veriniz ve grafik türünü belirtiniz!");
                return;
            }

            ChartTypeEnum[] chart1TypeEnum = new ChartTypeEnum[10];
            string[] chartName = new string[10];
            Color[] dataColor = new Color[10];
            char splitString = Convert.ToChar(cB_splitChar.Text);
            int dataCount = Convert.ToInt32(cB_dataCount.Items[cB_dataCount.SelectedIndex]);

            chart1TypeEnum[0] = Chart_Cb_to_enum(cB_firstG1.SelectedIndex);
            chart1TypeEnum[1] = Chart_Cb_to_enum(cB_secondG1.SelectedIndex);
            chart1TypeEnum[2] = Chart_Cb_to_enum(cB_thirdG1.SelectedIndex);
            chart1TypeEnum[3] = Chart_Cb_to_enum(cB_fourthG1.SelectedIndex);
            chart1TypeEnum[4] = Chart_Cb_to_enum(cB_fifthG1.SelectedIndex);
            chart1TypeEnum[5] = Chart_Cb_to_enum(cB_sixthG1.SelectedIndex);
            chart1TypeEnum[6] = Chart_Cb_to_enum(cB_seventhG1.SelectedIndex);
            chart1TypeEnum[7] = Chart_Cb_to_enum(cB_eighthG1.SelectedIndex);
            chart1TypeEnum[8] = Chart_Cb_to_enum(cB_ninthG1.SelectedIndex);
            chart1TypeEnum[9] = Chart_Cb_to_enum(cB_tenthG1.SelectedIndex);

            chartName[0] = tB_firstDataName.Text;
            chartName[1] = tB_secondDataName.Text;
            chartName[2] = tB_thirdDataName.Text;
            chartName[3] = tB_fourthDataName.Text;
            chartName[4] = tB_fifthDataName.Text;
            chartName[5] = tB_sixthDataName.Text;
            chartName[6] = tB_seventhDataName.Text;
            chartName[7] = tB_eighthDataName.Text;
            chartName[8] = tB_ninthDataName.Text;
            chartName[9] = tB_tenthDataName.Text;
            
            if (ControlSameString(chartName, dataCount-1) == true)
            {
                MessageBox.Show("Lütfen kullanacağınız tüm verilere farklı isim veriniz!");
                return;
            }



            dataColor[0] = btn_clr1.BackColor;
            dataColor[1] = btn_clr2.BackColor;
            dataColor[2] = btn_clr3.BackColor;
            dataColor[3] = btn_clr4.BackColor;
            dataColor[4] = btn_clr5.BackColor;
            dataColor[5] = btn_clr6.BackColor;
            dataColor[6] = btn_clr7.BackColor;
            dataColor[7] = btn_clr8.BackColor;
            dataColor[8] = btn_clr9.BackColor;
            dataColor[9] = btn_clr10.BackColor;

            SerialReadAndWrite2 Chart1 = new SerialReadAndWrite2(PortName, Baundrate, splitString, dataCount, chartName, chart1TypeEnum, dataColor, "Chart1");
            Chart1.Show();
            this.Hide();


        }

        private void cB_dataCount_SelectedValueChanged(object sender, EventArgs e)
        {
            switch(cB_dataCount.SelectedIndex)
            {
                case 0:
                    lbl1.Show();
                    lbl2.Hide();
                    lbl3.Hide();
                    lbl4.Hide();
                    lbl5.Hide();
                    lbl6.Hide();
                    lbl7.Hide();
                    lbl8.Hide();
                    lbl9.Hide();
                    lbl10.Hide();

                    btn_clr1.Show();
                    btn_clr2.Hide();
                    btn_clr3.Hide();
                    btn_clr4.Hide();
                    btn_clr5.Hide();
                    btn_clr6.Hide();
                    btn_clr7.Hide();
                    btn_clr8.Hide();
                    btn_clr9.Hide();
                    btn_clr10.Hide();

                    tB_firstDataName.Show();
                    tB_secondDataName.Hide();
                    tB_thirdDataName.Hide();
                    tB_fourthDataName.Hide();
                    tB_fifthDataName.Hide();
                    tB_sixthDataName.Hide();
                    tB_seventhDataName.Hide();
                    tB_eighthDataName.Hide();
                    tB_ninthDataName.Hide();
                    tB_tenthDataName.Hide();

                    cB_firstG1.Show();
                    cB_secondG1.Hide();
                    cB_thirdG1.Hide();
                    cB_fourthG1.Hide();
                    cB_fifthG1.Hide();
                    cB_sixthG1.Hide();
                    cB_seventhG1.Hide();
                    cB_eighthG1.Hide();
                    cB_ninthG1.Hide();
                    cB_tenthG1.Hide();

                    btn_connect.Location = new Point(148, 130);
                    SerialReadAndWrite1.ActiveForm.Height = 215;
                    break;

                case 1:
                    lbl1.Show();
                    lbl2.Show();
                    lbl3.Hide();
                    lbl4.Hide();
                    lbl5.Hide();
                    lbl6.Hide();
                    lbl7.Hide();
                    lbl8.Hide();
                    lbl9.Hide();
                    lbl10.Hide();

                    btn_clr1.Show();
                    btn_clr2.Show();
                    btn_clr3.Hide();
                    btn_clr4.Hide();
                    btn_clr5.Hide();
                    btn_clr6.Hide();
                    btn_clr7.Hide();
                    btn_clr8.Hide();
                    btn_clr9.Hide();
                    btn_clr10.Hide();

                    tB_firstDataName.Show();
                    tB_secondDataName.Show();
                    tB_thirdDataName.Hide();
                    tB_fourthDataName.Hide();
                    tB_fifthDataName.Hide();
                    tB_sixthDataName.Hide();
                    tB_seventhDataName.Hide();
                    tB_eighthDataName.Hide();
                    tB_ninthDataName.Hide();
                    tB_tenthDataName.Hide();

                    cB_firstG1.Show();
                    cB_secondG1.Show();
                    cB_thirdG1.Hide();
                    cB_fourthG1.Hide();
                    cB_fifthG1.Hide();
                    cB_sixthG1.Hide();
                    cB_seventhG1.Hide();
                    cB_eighthG1.Hide();
                    cB_ninthG1.Hide();
                    cB_tenthG1.Hide();

                    btn_connect.Location = new Point(148, 155);
                    SerialReadAndWrite1.ActiveForm.Height = 240;
                    break;

                case 2:
                    lbl1.Show();
                    lbl2.Show();
                    lbl3.Show();
                    lbl4.Hide();
                    lbl5.Hide();
                    lbl6.Hide();
                    lbl7.Hide();
                    lbl8.Hide();
                    lbl9.Hide();
                    lbl10.Hide();

                    btn_clr1.Show();
                    btn_clr2.Show();
                    btn_clr3.Show();
                    btn_clr4.Hide();
                    btn_clr5.Hide();
                    btn_clr6.Hide();
                    btn_clr7.Hide();
                    btn_clr8.Hide();
                    btn_clr9.Hide();
                    btn_clr10.Hide();

                    tB_firstDataName.Show();
                    tB_secondDataName.Show();
                    tB_thirdDataName.Show();
                    tB_fourthDataName.Hide();
                    tB_fifthDataName.Hide();
                    tB_sixthDataName.Hide();
                    tB_seventhDataName.Hide();
                    tB_eighthDataName.Hide();
                    tB_ninthDataName.Hide();
                    tB_tenthDataName.Hide();

                    cB_firstG1.Show();
                    cB_secondG1.Show();
                    cB_thirdG1.Show();
                    cB_fourthG1.Hide();
                    cB_fifthG1.Hide();
                    cB_sixthG1.Hide();
                    cB_seventhG1.Hide();
                    cB_eighthG1.Hide();
                    cB_ninthG1.Hide();
                    cB_tenthG1.Hide();

                    btn_connect.Location = new Point(148, 180);
                    SerialReadAndWrite1.ActiveForm.Height = 265;
                    break;

                case 3:
                    lbl1.Show();
                    lbl2.Show();
                    lbl3.Show();
                    lbl4.Show();
                    lbl5.Hide();
                    lbl6.Hide();
                    lbl7.Hide();
                    lbl8.Hide();
                    lbl9.Hide();
                    lbl10.Hide();

                    btn_clr1.Show();
                    btn_clr2.Show();
                    btn_clr3.Show();
                    btn_clr4.Show();
                    btn_clr5.Hide();
                    btn_clr6.Hide();
                    btn_clr7.Hide();
                    btn_clr8.Hide();
                    btn_clr9.Hide();
                    btn_clr10.Hide();

                    tB_firstDataName.Show();
                    tB_secondDataName.Show();
                    tB_thirdDataName.Show();
                    tB_fourthDataName.Show();
                    tB_fifthDataName.Hide();
                    tB_sixthDataName.Hide();
                    tB_seventhDataName.Hide();
                    tB_eighthDataName.Hide();
                    tB_ninthDataName.Hide();
                    tB_tenthDataName.Hide();

                    cB_firstG1.Show();
                    cB_secondG1.Show();
                    cB_thirdG1.Show();
                    cB_fourthG1.Show();
                    cB_fifthG1.Hide();
                    cB_sixthG1.Hide();
                    cB_seventhG1.Hide();
                    cB_eighthG1.Hide();
                    cB_ninthG1.Hide();
                    cB_tenthG1.Hide();

                    btn_connect.Location = new Point(148, 205);
                    SerialReadAndWrite1.ActiveForm.Height = 290;
                    break;

                case 4:
                    lbl1.Show();
                    lbl2.Show();
                    lbl3.Show();
                    lbl4.Show();
                    lbl5.Show();
                    lbl6.Hide();
                    lbl7.Hide();
                    lbl8.Hide();
                    lbl9.Hide();
                    lbl10.Hide();

                    btn_clr1.Show();
                    btn_clr2.Show();
                    btn_clr3.Show();
                    btn_clr4.Show();
                    btn_clr5.Show();
                    btn_clr6.Hide();
                    btn_clr7.Hide();
                    btn_clr8.Hide();
                    btn_clr9.Hide();
                    btn_clr10.Hide();

                    tB_firstDataName.Show();
                    tB_secondDataName.Show();
                    tB_thirdDataName.Show();
                    tB_fourthDataName.Show();
                    tB_fifthDataName.Show();
                    tB_sixthDataName.Hide();
                    tB_seventhDataName.Hide();
                    tB_eighthDataName.Hide();
                    tB_ninthDataName.Hide();
                    tB_tenthDataName.Hide();

                    cB_firstG1.Show();
                    cB_secondG1.Show();
                    cB_thirdG1.Show();
                    cB_fourthG1.Show();
                    cB_fifthG1.Show();
                    cB_sixthG1.Hide();
                    cB_seventhG1.Hide();
                    cB_eighthG1.Hide();
                    cB_ninthG1.Hide();
                    cB_tenthG1.Hide();

                    btn_connect.Location = new Point(148, 230);
                    SerialReadAndWrite1.ActiveForm.Height = 315;
                    break;

                case 5:
                    lbl1.Show();
                    lbl2.Show();
                    lbl3.Show();
                    lbl4.Show();
                    lbl5.Show();
                    lbl6.Show();
                    lbl7.Hide();
                    lbl8.Hide();
                    lbl9.Hide();
                    lbl10.Hide();

                    btn_clr1.Show();
                    btn_clr2.Show();
                    btn_clr3.Show();
                    btn_clr4.Show();
                    btn_clr5.Show();
                    btn_clr6.Show();
                    btn_clr7.Hide();
                    btn_clr8.Hide();
                    btn_clr9.Hide();
                    btn_clr10.Hide();

                    tB_firstDataName.Show();
                    tB_secondDataName.Show();
                    tB_thirdDataName.Show();
                    tB_fourthDataName.Show();
                    tB_fifthDataName.Show();
                    tB_sixthDataName.Show();
                    tB_seventhDataName.Hide();
                    tB_eighthDataName.Hide();
                    tB_ninthDataName.Hide();
                    tB_tenthDataName.Hide();

                    cB_firstG1.Show();
                    cB_secondG1.Show();
                    cB_thirdG1.Show();
                    cB_fourthG1.Show();
                    cB_fifthG1.Show();
                    cB_sixthG1.Show();
                    cB_seventhG1.Hide();
                    cB_eighthG1.Hide();
                    cB_ninthG1.Hide();
                    cB_tenthG1.Hide();

                    btn_connect.Location = new Point(148, 255);
                    SerialReadAndWrite1.ActiveForm.Height = 340;
                    break;

                case 6:
                    lbl1.Show();
                    lbl2.Show();
                    lbl3.Show();
                    lbl4.Show();
                    lbl5.Show();
                    lbl6.Show();
                    lbl7.Show();
                    lbl8.Hide();
                    lbl9.Hide();
                    lbl10.Hide();

                    btn_clr1.Show();
                    btn_clr2.Show();
                    btn_clr3.Show();
                    btn_clr4.Show();
                    btn_clr5.Show();
                    btn_clr6.Show();
                    btn_clr7.Show();
                    btn_clr8.Hide();
                    btn_clr9.Hide();
                    btn_clr10.Hide();

                    tB_firstDataName.Show();
                    tB_secondDataName.Show();
                    tB_thirdDataName.Show();
                    tB_fourthDataName.Show();
                    tB_fifthDataName.Show();
                    tB_sixthDataName.Show();
                    tB_seventhDataName.Show();
                    tB_eighthDataName.Hide();
                    tB_ninthDataName.Hide();
                    tB_tenthDataName.Hide();

                    cB_firstG1.Show();
                    cB_secondG1.Show();
                    cB_thirdG1.Show();
                    cB_fourthG1.Show();
                    cB_fifthG1.Show();
                    cB_sixthG1.Show();
                    cB_seventhG1.Show();
                    cB_eighthG1.Hide();
                    cB_ninthG1.Hide();
                    cB_tenthG1.Hide();

                    btn_connect.Location = new Point(148, 280);
                    SerialReadAndWrite1.ActiveForm.Height = 365;
                    break;

                case 7:
                    lbl1.Show();
                    lbl2.Show();
                    lbl3.Show();
                    lbl4.Show();
                    lbl5.Show();
                    lbl6.Show();
                    lbl7.Show();
                    lbl8.Show();
                    lbl9.Hide();
                    lbl10.Hide();

                    btn_clr1.Show();
                    btn_clr2.Show();
                    btn_clr3.Show();
                    btn_clr4.Show();
                    btn_clr5.Show();
                    btn_clr6.Show();
                    btn_clr7.Show();
                    btn_clr8.Show();
                    btn_clr9.Hide();
                    btn_clr10.Hide();

                    tB_firstDataName.Show();
                    tB_secondDataName.Show();
                    tB_thirdDataName.Show();
                    tB_fourthDataName.Show();
                    tB_fifthDataName.Show();
                    tB_sixthDataName.Show();
                    tB_seventhDataName.Show();
                    tB_eighthDataName.Show();
                    tB_ninthDataName.Hide();
                    tB_tenthDataName.Hide();

                    cB_firstG1.Show();
                    cB_secondG1.Show();
                    cB_thirdG1.Show();
                    cB_fourthG1.Show();
                    cB_fifthG1.Show();
                    cB_sixthG1.Show();
                    cB_seventhG1.Show();
                    cB_eighthG1.Show();
                    cB_ninthG1.Hide();
                    cB_tenthG1.Hide();

                    btn_connect.Location = new Point(148, 305);
                    SerialReadAndWrite1.ActiveForm.Height = 390;
                    break;

                case 8:
                    lbl1.Show();
                    lbl2.Show();
                    lbl3.Show();
                    lbl4.Show();
                    lbl5.Show();
                    lbl6.Show();
                    lbl7.Show();
                    lbl8.Show();
                    lbl9.Show();
                    lbl10.Hide();

                    btn_clr1.Show();
                    btn_clr2.Show();
                    btn_clr3.Show();
                    btn_clr4.Show();
                    btn_clr5.Show();
                    btn_clr6.Show();
                    btn_clr7.Show();
                    btn_clr8.Show();
                    btn_clr9.Show();
                    btn_clr10.Hide();

                    tB_firstDataName.Show();
                    tB_secondDataName.Show();
                    tB_thirdDataName.Show();
                    tB_fourthDataName.Show();
                    tB_fifthDataName.Show();
                    tB_sixthDataName.Show();
                    tB_seventhDataName.Show();
                    tB_eighthDataName.Show();
                    tB_ninthDataName.Show();
                    tB_tenthDataName.Hide();

                    cB_firstG1.Show();
                    cB_secondG1.Show();
                    cB_thirdG1.Show();
                    cB_fourthG1.Show();
                    cB_fifthG1.Show();
                    cB_sixthG1.Show();
                    cB_seventhG1.Show();
                    cB_eighthG1.Show();
                    cB_ninthG1.Show();
                    cB_tenthG1.Hide();

                    btn_connect.Location = new Point(148, 330);
                    SerialReadAndWrite1.ActiveForm.Height = 415;
                    break;

                case 9:
                    lbl1.Show();
                    lbl2.Show();
                    lbl3.Show();
                    lbl4.Show();
                    lbl5.Show();
                    lbl6.Show();
                    lbl7.Show();
                    lbl8.Show();
                    lbl9.Show();
                    lbl10.Show();

                    btn_clr1.Show();
                    btn_clr2.Show();
                    btn_clr3.Show();
                    btn_clr4.Show();
                    btn_clr5.Show();
                    btn_clr6.Show();
                    btn_clr7.Show();
                    btn_clr8.Show();
                    btn_clr9.Show();
                    btn_clr10.Show();

                    tB_firstDataName.Show();
                    tB_secondDataName.Show();
                    tB_thirdDataName.Show();
                    tB_fourthDataName.Show();
                    tB_fifthDataName.Show();
                    tB_sixthDataName.Show();
                    tB_seventhDataName.Show();
                    tB_eighthDataName.Show();
                    tB_ninthDataName.Show();
                    tB_tenthDataName.Show();

                    cB_firstG1.Show();
                    cB_secondG1.Show();
                    cB_thirdG1.Show();
                    cB_fourthG1.Show();
                    cB_fifthG1.Show();
                    cB_sixthG1.Show();
                    cB_seventhG1.Show();
                    cB_eighthG1.Show();
                    cB_ninthG1.Show();
                    cB_tenthG1.Show();

                    btn_connect.Location = new Point(148, 355);
                    SerialReadAndWrite1.ActiveForm.Height = 440;
                    break;

                default:
                    break;

            }
        }

        //Kapanırken önceki formu açmak

        private void SerialReadAndWrite1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SerialReadAndWrite serialReadAndWrite = new SerialReadAndWrite();
            serialReadAndWrite.Show();
        }




        private void SerialReadAndWrite1_Load(object sender, EventArgs e)
        {
            lbl1.Show();
            lbl2.Hide();
            lbl3.Hide();
            lbl4.Hide();
            lbl5.Hide();
            lbl6.Hide();
            lbl7.Hide();
            lbl8.Hide();
            lbl9.Hide();
            lbl10.Hide();

            btn_clr1.Show();
            btn_clr2.Hide();
            btn_clr3.Hide();
            btn_clr4.Hide();
            btn_clr5.Hide();
            btn_clr6.Hide();
            btn_clr7.Hide();
            btn_clr8.Hide();
            btn_clr9.Hide();
            btn_clr10.Hide();

            tB_firstDataName.Show();
            tB_secondDataName.Hide();
            tB_thirdDataName.Hide();
            tB_fourthDataName.Hide();
            tB_fifthDataName.Hide();
            tB_sixthDataName.Hide();
            tB_seventhDataName.Hide();
            tB_eighthDataName.Hide();
            tB_ninthDataName.Hide();
            tB_tenthDataName.Hide();

            cB_firstG1.Show();
            cB_secondG1.Hide();
            cB_thirdG1.Hide();
            cB_fourthG1.Hide();
            cB_fifthG1.Hide();
            cB_sixthG1.Hide();
            cB_seventhG1.Hide();
            cB_eighthG1.Hide();
            cB_ninthG1.Hide();
            cB_tenthG1.Hide();

            btn_connect.Location = new Point(148, 130);

            //Grafik Türlerinin ComboBoxlara Yerleştirilmesi
            string[] chartTypes = { "Grafik Türü Seçin","Çizgi","Sutun"};

            cB_firstG1.Items.AddRange(chartTypes);
            cB_secondG1.Items.AddRange(chartTypes);
            cB_thirdG1.Items.AddRange(chartTypes);
            cB_fourthG1.Items.AddRange(chartTypes);
            cB_fifthG1.Items.AddRange(chartTypes); 
            cB_sixthG1.Items.AddRange(chartTypes);
            cB_seventhG1.Items.AddRange(chartTypes); 
            cB_eighthG1.Items.AddRange(chartTypes); 
            cB_ninthG1.Items.AddRange(chartTypes); 
            cB_tenthG1.Items.AddRange(chartTypes);

            cB_dataCount.SelectedIndex = 0;
            cB_splitChar.SelectedIndex = 0;

            cB_firstG1.SelectedIndex = 0;
            cB_secondG1.SelectedIndex = 0;
            cB_thirdG1.SelectedIndex = 0;
            cB_fourthG1.SelectedIndex = 0;
            cB_fifthG1.SelectedIndex = 0;
            cB_sixthG1.SelectedIndex = 0;
            cB_seventhG1.SelectedIndex = 0;
            cB_eighthG1.SelectedIndex = 0;
            cB_ninthG1.SelectedIndex = 0;
            cB_tenthG1.SelectedIndex = 0;
        }

        private void SerialReadAndWrite1_Shown(object sender, EventArgs e)
        {
            SerialReadAndWrite1.ActiveForm.Height = 215;
            SerialReadAndWrite1.ActiveForm.Width = 405;
        }


        //Renk belirleme

        private void btn_clr1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            btn_clr1.BackColor = colorDialog1.Color;
        }

        private void btn_clr2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            btn_clr2.BackColor = colorDialog1.Color;
        }

        private void btn_clr3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            btn_clr3.BackColor = colorDialog1.Color;
        }

        private void btn_clr4_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            btn_clr4.BackColor = colorDialog1.Color;
        }

        private void btn_clr5_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            btn_clr5.BackColor = colorDialog1.Color;
        }

        private void btn_clr6_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            btn_clr6.BackColor = colorDialog1.Color;
        }

        private void btn_clr7_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            btn_clr7.BackColor = colorDialog1.Color;
        }

        private void btn_clr8_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            btn_clr8.BackColor = colorDialog1.Color;
        }

        private void btn_clr9_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            btn_clr9.BackColor = colorDialog1.Color;
        }

        private void btn_clr10_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            btn_clr10.BackColor = colorDialog1.Color;
        }
    }
}
