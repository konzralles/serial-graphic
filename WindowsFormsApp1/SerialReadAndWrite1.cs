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

        private void SerialReadAndWrite_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {

        }

        private void cB_dataCount_SelectedValueChanged(object sender, EventArgs e)
        {
            if (checkbox_chart2.Checked)
            {
                lbl_chart2.Show();
                SerialReadAndWrite1.ActiveForm.Width = 526;
            }
            else
            {
                lbl_chart2.Hide();
                SerialReadAndWrite1.ActiveForm.Width = 405;
            }

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

                    if (checkbox_chart2.Checked)
                    {
                        lbl_chart2.Show();
                        btn_connect.Location = new Point(217, 130);
                        cB_firstG2.Show();
                        cB_secondG2.Hide();
                        cB_thirdG2.Hide();
                        cB_fourthG2.Hide();
                        cB_fifthG2.Hide();
                        cB_sixthG2.Hide();
                        cB_seventhG2.Hide();
                        cB_eighthG2.Hide();
                        cB_ninthG2.Hide();
                        cB_tenthG2.Hide();
                    }
                    else
                    {
                        lbl_chart2.Hide();
                        btn_connect.Location = new Point(147, 130);
                        cB_firstG2.Hide();
                        cB_secondG2.Hide();
                        cB_thirdG2.Hide();
                        cB_fourthG2.Hide();
                        cB_fifthG2.Hide();
                        cB_sixthG2.Hide();
                        cB_seventhG2.Hide();
                        cB_eighthG2.Hide();
                        cB_ninthG2.Hide();
                        cB_tenthG2.Hide();
                    }


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

                    if (checkbox_chart2.Checked)
                    {
                        btn_connect.Location = new Point(217, 155);
                        cB_firstG2.Show();
                        cB_secondG2.Show();
                        cB_thirdG2.Hide();
                        cB_fourthG2.Hide();
                        cB_fifthG2.Hide();
                        cB_sixthG2.Hide();
                        cB_seventhG2.Hide();
                        cB_eighthG2.Hide();
                        cB_ninthG2.Hide();
                        cB_tenthG2.Hide();
                    }
                    else
                    {
                        btn_connect.Location = new Point(147, 155);
                        cB_firstG2.Hide();
                        cB_secondG2.Hide();
                        cB_thirdG2.Hide();
                        cB_fourthG2.Hide();
                        cB_fifthG2.Hide();
                        cB_sixthG2.Hide();
                        cB_seventhG2.Hide();
                        cB_eighthG2.Hide();
                        cB_ninthG2.Hide();
                        cB_tenthG2.Hide();
                    }

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

                    if (checkbox_chart2.Checked)
                    {
                        btn_connect.Location = new Point(217, 180);
                        cB_firstG2.Show();
                        cB_secondG2.Show();
                        cB_thirdG2.Show();
                        cB_fourthG2.Hide();
                        cB_fifthG2.Hide();
                        cB_sixthG2.Hide();
                        cB_seventhG2.Hide();
                        cB_eighthG2.Hide();
                        cB_ninthG2.Hide();
                        cB_tenthG2.Hide();
                    }
                    else
                    {
                        btn_connect.Location = new Point(147, 180);
                        cB_firstG2.Hide();
                        cB_secondG2.Hide();
                        cB_thirdG2.Hide();
                        cB_fourthG2.Hide();
                        cB_fifthG2.Hide();
                        cB_sixthG2.Hide();
                        cB_seventhG2.Hide();
                        cB_eighthG2.Hide();
                        cB_ninthG2.Hide();
                        cB_tenthG2.Hide();
                    }

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

                    if (checkbox_chart2.Checked)
                    {
                        btn_connect.Location = new Point(217, 205);
                        cB_firstG2.Show();
                        cB_secondG2.Show();
                        cB_thirdG2.Show();
                        cB_fourthG2.Show();
                        cB_fifthG2.Hide();
                        cB_sixthG2.Hide();
                        cB_seventhG2.Hide();
                        cB_eighthG2.Hide();
                        cB_ninthG2.Hide();
                        cB_tenthG2.Hide();
                    }
                    else
                    {
                        btn_connect.Location = new Point(147, 205);
                        cB_firstG2.Hide();
                        cB_secondG2.Hide();
                        cB_thirdG2.Hide();
                        cB_fourthG2.Hide();
                        cB_fifthG2.Hide();
                        cB_sixthG2.Hide();
                        cB_seventhG2.Hide();
                        cB_eighthG2.Hide();
                        cB_ninthG2.Hide();
                        cB_tenthG2.Hide();
                    }

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

                    if (checkbox_chart2.Checked)
                    {
                        btn_connect.Location = new Point(217, 230);
                        cB_firstG2.Show();
                        cB_secondG2.Show();
                        cB_thirdG2.Show();
                        cB_fourthG2.Show();
                        cB_fifthG2.Show();
                        cB_sixthG2.Hide();
                        cB_seventhG2.Hide();
                        cB_eighthG2.Hide();
                        cB_ninthG2.Hide();
                        cB_tenthG2.Hide();
                    }
                    else
                    {
                        btn_connect.Location = new Point(147, 230);
                        cB_firstG2.Hide();
                        cB_secondG2.Hide();
                        cB_thirdG2.Hide();
                        cB_fourthG2.Hide();
                        cB_fifthG2.Hide();
                        cB_sixthG2.Hide();
                        cB_seventhG2.Hide();
                        cB_eighthG2.Hide();
                        cB_ninthG2.Hide();
                        cB_tenthG2.Hide();
                    }

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

                    if (checkbox_chart2.Checked)
                    {
                        btn_connect.Location = new Point(217, 255);
                        cB_firstG2.Show();
                        cB_secondG2.Show();
                        cB_thirdG2.Show();
                        cB_fourthG2.Show();
                        cB_fifthG2.Show();
                        cB_sixthG2.Show();
                        cB_seventhG2.Hide();
                        cB_eighthG2.Hide();
                        cB_ninthG2.Hide();
                        cB_tenthG2.Hide();
                    }
                    else
                    {
                        btn_connect.Location = new Point(147, 255);
                        cB_firstG2.Hide();
                        cB_secondG2.Hide();
                        cB_thirdG2.Hide();
                        cB_fourthG2.Hide();
                        cB_fifthG2.Hide();
                        cB_sixthG2.Hide();
                        cB_seventhG2.Hide();
                        cB_eighthG2.Hide();
                        cB_ninthG2.Hide();
                        cB_tenthG2.Hide();
                    }

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

                    if (checkbox_chart2.Checked)
                    {
                        btn_connect.Location = new Point(217, 280);
                        cB_firstG2.Show();
                        cB_secondG2.Show();
                        cB_thirdG2.Show();
                        cB_fourthG2.Show();
                        cB_fifthG2.Show();
                        cB_sixthG2.Show();
                        cB_seventhG2.Show();
                        cB_eighthG2.Hide();
                        cB_ninthG2.Hide();
                        cB_tenthG2.Hide();
                    }
                    else
                    {
                        btn_connect.Location = new Point(147, 280);
                        cB_firstG2.Hide();
                        cB_secondG2.Hide();
                        cB_thirdG2.Hide();
                        cB_fourthG2.Hide();
                        cB_fifthG2.Hide();
                        cB_sixthG2.Hide();
                        cB_seventhG2.Hide();
                        cB_eighthG2.Hide();
                        cB_ninthG2.Hide();
                        cB_tenthG2.Hide();
                    }

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

                    if (checkbox_chart2.Checked)
                    {
                        btn_connect.Location = new Point(217, 305);
                        cB_firstG2.Show();
                        cB_secondG2.Show();
                        cB_thirdG2.Show();
                        cB_fourthG2.Show();
                        cB_fifthG2.Show();
                        cB_sixthG2.Show();
                        cB_seventhG2.Show();
                        cB_eighthG2.Show();
                        cB_ninthG2.Hide();
                        cB_tenthG2.Hide();
                    }
                    else
                    {
                        btn_connect.Location = new Point(147, 305);
                        cB_firstG2.Hide();
                        cB_secondG2.Hide();
                        cB_thirdG2.Hide();
                        cB_fourthG2.Hide();
                        cB_fifthG2.Hide();
                        cB_sixthG2.Hide();
                        cB_seventhG2.Hide();
                        cB_eighthG2.Hide();
                        cB_ninthG2.Hide();
                        cB_tenthG2.Hide();
                    }

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

                    if (checkbox_chart2.Checked)
                    {
                        btn_connect.Location = new Point(217, 330);
                        cB_firstG2.Show();
                        cB_secondG2.Show();
                        cB_thirdG2.Show();
                        cB_fourthG2.Show();
                        cB_fifthG2.Show();
                        cB_sixthG2.Show();
                        cB_seventhG2.Show();
                        cB_eighthG2.Show();
                        cB_ninthG2.Show();
                        cB_tenthG2.Hide();
                    }
                    else
                    {
                        btn_connect.Location = new Point(147, 330);
                        cB_firstG2.Hide();
                        cB_secondG2.Hide();
                        cB_thirdG2.Hide();
                        cB_fourthG2.Hide();
                        cB_fifthG2.Hide();
                        cB_sixthG2.Hide();
                        cB_seventhG2.Hide();
                        cB_eighthG2.Hide();
                        cB_ninthG2.Hide();
                        cB_tenthG2.Hide();
                    }

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

                    if (checkbox_chart2.Checked)
                    {
                        btn_connect.Location = new Point(217, 355);
                        cB_firstG2.Show();
                        cB_secondG2.Show();
                        cB_thirdG2.Show();
                        cB_fourthG2.Show();
                        cB_fifthG2.Show();
                        cB_sixthG2.Show();
                        cB_seventhG2.Show();
                        cB_eighthG2.Show();
                        cB_ninthG2.Show();
                        cB_tenthG2.Show();
                    }
                    else
                    {
                        btn_connect.Location = new Point(147, 355);
                        cB_firstG2.Hide();
                        cB_secondG2.Hide();
                        cB_thirdG2.Hide();
                        cB_fourthG2.Hide();
                        cB_fifthG2.Hide();
                        cB_sixthG2.Hide();
                        cB_seventhG2.Hide();
                        cB_eighthG2.Hide();
                        cB_ninthG2.Hide();
                        cB_tenthG2.Hide();
                    }

                    SerialReadAndWrite1.ActiveForm.Height = 440;
                    break;

                default:
                    break;

            }
        }

        private void SerialReadAndWrite1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SerialReadAndWrite serialReadAndWrite = new SerialReadAndWrite();
            serialReadAndWrite.Show();
        }

        private void SerialReadAndWrite1_Load(object sender, EventArgs e)
        {
            lbl_chart2.Hide();

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
            
            cB_firstG2.Hide();
            cB_secondG2.Hide();
            cB_thirdG2.Hide();
            cB_fourthG2.Hide();
            cB_fifthG2.Hide();
            cB_sixthG2.Hide();
            cB_seventhG2.Hide();
            cB_eighthG2.Hide();
            cB_ninthG2.Hide();
            cB_tenthG2.Hide();

            btn_connect.Location = new Point(147, 130);

            //Grafik Türlerinin ComboBoxlara Yerleştirilmesi
            string[] chartTypes = { "Grafik Türü Seçin","Çizgi","Sutun","Oluşturma"};

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

            cB_firstG2.Items.AddRange(chartTypes); 
            cB_secondG2.Items.AddRange(chartTypes); 
            cB_thirdG2.Items.AddRange(chartTypes);
            cB_fourthG2.Items.AddRange(chartTypes); 
            cB_fifthG2.Items.AddRange(chartTypes); 
            cB_sixthG2.Items.AddRange(chartTypes); 
            cB_seventhG2.Items.AddRange(chartTypes); 
            cB_eighthG2.Items.AddRange(chartTypes); 
            cB_ninthG2.Items.AddRange(chartTypes); 
            cB_tenthG2.Items.AddRange(chartTypes);

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

            cB_firstG2.SelectedIndex = 0;
            cB_secondG2.SelectedIndex = 0;
            cB_thirdG2.SelectedIndex = 0;
            cB_fourthG2.SelectedIndex = 0;
            cB_fifthG2.SelectedIndex = 0;
            cB_sixthG2.SelectedIndex = 0;
            cB_seventhG2.SelectedIndex = 0;
            cB_eighthG2.SelectedIndex = 0;
            cB_ninthG2.SelectedIndex = 0;
            cB_tenthG2.SelectedIndex = 0;
        }

        private void SerialReadAndWrite1_Shown(object sender, EventArgs e)
        {
            SerialReadAndWrite1.ActiveForm.Height = 215;
            SerialReadAndWrite1.ActiveForm.Width = 405;
        }

        private void btn_clr1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            btn_clr1.BackColor = colorDialog1.Color;
        }
    }
}
