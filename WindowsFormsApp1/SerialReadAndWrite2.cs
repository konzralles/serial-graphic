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
        private readonly char splitString;
        private readonly int dataCount;
        private readonly string[] chartName;
        private readonly ChartTypeEnum[] chartTypeEnums = new ChartTypeEnum[10];
        private readonly Color[] dataColor;
        private readonly string ChartText;
        SerialPort sp;
        List<string> serial_list = new List<string>();
        private int maxDataCount = 360000;

        int splitSecond=0;
        int second=0;
        int minute=0;
        int hour=0;

        public SerialReadAndWrite2(string portName, int baundRate, char splitString, int dataCount, string[] chartName, ChartTypeEnum[] chartTypeEnums, Color[] dataColor, string ChartText)
        {
            InitializeComponent();
            this.portName = portName;
            this.baundRate = baundRate;
            this.splitString = splitString;
            this.dataCount = dataCount;
            this.chartName = chartName;
            this.chartTypeEnums = chartTypeEnums;
            this.dataColor = dataColor;
            this.ChartText = ChartText;
            sp = new SerialPort(portName, baundRate, Parity.None, 8, StopBits.One);
            
            //Serilerin oluşturulması
            for (int x = dataCount, y = 0; x>0; x--,y++)
            {
                chart1.Series.Add(chartName[y]);
                chart1.Series[y].Color = dataColor[y];
                if (chartTypeEnums[y] == ChartTypeEnum.LINE)
                    chart1.Series[y].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                if (chartTypeEnums[y] == ChartTypeEnum.COLUMN)
                        chart1.Series[y].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            }
        }

        private void SerialReadAndWrite2_Load(object sender, EventArgs e)
        {
            this.Text = ChartText;
            lbl_baundrate.Text = "Baundrate" + baundRate + "";
            lbl_portname.Text = portName;
            sp.Open();
            sp.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);

            //Gerek kalmadıkça kullanma bilgisayara zarar verebilir!
            //Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (sp.IsOpen == false) return;
            string data = sp.ReadExisting();

            sp.DiscardInBuffer();
            sp.DiscardOutBuffer();

            string[] fragmentedData;
            string time;

            if (hour == 0) time = "  M:" + minute + " S:" + second + "";
            else time = "H:" + hour + "  M:" + minute + " S:" + second + "";

            Console.WriteLine(data);
            serial_list.Add(data);

            //Listeyi belirli bir max değer altında tutmak.
            while (serial_list.Count > maxDataCount) serial_list.RemoveAt(0);

            //Gelen veriyi bölücü işaret ile bölme
            fragmentedData = data.Split(splitString);

            //Gelen veri seçilen veri sayısına eşit değilse
            if ((fragmentedData.Length != dataCount + 1)||(fragmentedData[0] != "$")) return;

            //Grafiğin çizilmesi
            for (int x=1; x < fragmentedData.Length; x++)
            {
                if (label1.InvokeRequired)//Label'a gelen talebin farklı bir iş parçacığından gelip gelmediği kontrol ediliyor.
                    label1.Invoke(new Action(delegate ()
                    {
                        //Eğer Label'a başka bir iş parçacığından talep gelmişse Invoke metodu ile gerekli işlem gerçekleştiriliyor.
                        this.chart1.Series[x - 1].Points.AddXY(time, fragmentedData[x]);
                    }));
                //this.chart1.Series[x - 1].Points.AddXY(time,fragmentedData[x]);
            }
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

        private void SerialReadAndWrite2_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //The number 1000 must be fully divisible by Timer Interval!
            splitSecond += timer1.Interval;
            if (splitSecond == 1000)
            {
                splitSecond = 0;
                second += 1;
            }
            if (second == 60)
            {
                second = 0;
                minute += 1;
            }
            if (minute == 60)
            {
                minute = 0;
                hour += 1;
            }
        }

        private void SerialReadAndWrite2_FormClosed(object sender, FormClosedEventArgs e)
        {
            sp.Close();
            Application.Exit();
            //Environment.Exit(0);
        }
    }
}
