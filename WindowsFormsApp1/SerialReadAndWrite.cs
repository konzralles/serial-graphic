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
    public partial class SerialReadAndWrite : Form
    {
        string[] ports;

        public SerialReadAndWrite()
        {
            InitializeComponent();
        }

        private void Baglanti_Load(object sender, EventArgs e)
        {
            ports = SerialPort.GetPortNames();
            cB_serialPort.Items.AddRange(ports);
            if (cB_serialPort.Items.Count != 0) cB_serialPort.SelectedIndex = 0;

            cB_baundRate.SelectedIndex = 4;
        }

        private void btn_reflesh_Click(object sender, EventArgs e)
        {
            ports = null;
            cB_serialPort.Text = String.Empty;
            cB_serialPort.Items.Clear();

            ports = SerialPort.GetPortNames();
            cB_serialPort.Items.AddRange(ports);
            if (cB_serialPort.Items.Count != 0) cB_serialPort.SelectedIndex = 0;
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if((cB_serialPort.Items.Count != 0) && (cB_baundRate.Items.Count != 0))
            {
                SerialReadAndWrite1 serialReadAndWrite = new SerialReadAndWrite1(Convert.ToInt32(cB_baundRate.SelectedItem),Convert.ToString(cB_serialPort.SelectedItem));
                serialReadAndWrite.Show();
                this.Hide();
            }
        }
    }
}
