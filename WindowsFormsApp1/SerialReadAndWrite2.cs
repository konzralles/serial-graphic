using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace WindowsFormsApp1
{
    public partial class SerialReadAndWrite2 : Form
    {
        private readonly string portName;
        private readonly int baundRate;
        private readonly string splitString;
        private readonly string[] chartName;
        private readonly ChartTypeEnum[] chartTypeEnums = new ChartTypeEnum[10];
        private readonly Color[] dataColor;
        private readonly string ChartText;
        SerialPort sp;
        List<string> serial_list = new List<string>();
        private int maxDataCount = 360000;

        public SerialReadAndWrite2(string portName, int baundRate, string splitString, string[] chartName, ChartTypeEnum[] chartTypeEnums, Color[] dataColor, string ChartText)
        {
            InitializeComponent();
            this.portName = portName;
            this.baundRate = baundRate;
            this.splitString = splitString;
            this.chartName = chartName;
            this.chartTypeEnums = chartTypeEnums;
            this.dataColor = dataColor;
            this.ChartText = ChartText;
            sp = new SerialPort(portName, baundRate, Parity.None, 8, StopBits.One);
        }

        private void SerialReadAndWrite2_Load(object sender, EventArgs e)
        {
            this.Text = ChartText;
            lbl_baundrate.Text = "Baundrate" + baundRate + "";
            lbl_portname.Text = portName;
            sp.Open();
            sp.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
        }

        private void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string veri = sp.ReadExisting();
            Console.WriteLine(veri);
            serial_list.Add(veri);

            //Listeyi belirli bir max değer altında tutmak.
            while (serial_list.Count > maxDataCount) serial_list.RemoveAt(0);
        }

        private void btn_applyMaxDataCount_Click(object sender, EventArgs e)
        {
            string maxDataCountString = tb_maxDataCount.Text;
            foreach(char maxDataCountChars in maxDataCountString)
            {
                if (maxDataCountChars > 57 || maxDataCountChars < 48)
                {
                    tb_maxDataCount.Text = Convert.ToString(maxDataCount);
                    MessageBox.Show("Lütfen sadece sayı giriniz.");
                    return;
                }
            }
            maxDataCount = Convert.ToInt32(maxDataCountString);
        }
    }
}
