using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SerialTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCOM.DataSource=SerialPort.GetPortNames();

            
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(SerialRecieved));
        }

        float[] fData = new float[8];
        int ProcessID = 0;


        private void SerialRecieved(object s, EventArgs e)
        {

                string data = serialPort1.ReadLine();
            
                string[] realtimedata= data.Split(',','T');

            tbx_realtimedata.Text = data;

            label_WindDirection.Text = realtimedata[1];
            label_WindSpeed.Text = realtimedata[2];
            label_CorrectedDirection.Text = realtimedata[3];
            label_Pressure.Text = realtimedata[4];
            label_RelativeHumidity.Text = realtimedata[5];
            label_Temperature.Text = realtimedata[6];
            label_Dewpoint.Text = realtimedata[7];
            label_Date.Text = realtimedata[8];
            label_Time.Text = realtimedata[9];
            label_SupplyVoltage.Text = realtimedata[10];
            label_Status.Text = realtimedata[11];


        }


        private void btnConn_Click(object sender, EventArgs e)
        {
            try
            {
                

                if (!serialPort1.IsOpen)
                {
                    serialPort1.PortName = cmbCOM.Text;
                    serialPort1.Open();

                    lblStatus.Text = cmbCOM.Text + " is open";
                    btnConn.Text = "Disconnect";
                }
                else if(btnConn.Text == "Disconnect")
                {
                    serialPort1.Close();
                    if (!serialPort1.IsOpen) {
                        lblStatus.Text = cmbCOM.Text + " is closed";
                        btnConn.Text = "Connect";
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void cmbCOM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
