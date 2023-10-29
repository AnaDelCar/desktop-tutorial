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

namespace SensorTemperatura
{
    public partial class Form1 : Form
    {
        delegate void SetTextDelegate(string value);
        public SerialPort ArduinoPort
        {
            get;
        }
        public Form1()
        {
            InitializeComponent();
            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM4";
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.DataBits = 8;
            ArduinoPort.ReadTimeout = 500;
            ArduinoPort.WriteTimeout = 500;
            ArduinoPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            this.botConectar.Click += botConectar_Click;
        }
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string dato = ArduinoPort.ReadLine();
            EscribirTXT(dato);
        }
        private void EscribirTXT(string dato)
        {
            if (InvokeRequired)
                try
                {
                    Invoke(new SetTextDelegate(EscribirTXT), dato);
                }
                catch { }
            else
                labTemperatura.Text = dato;
        }
        private void botConectar_Click(object sender, EventArgs e)
        {
            botDesconec.Enabled = true;
            try
            {
                if (!ArduinoPort.IsOpen)
                    ArduinoPort.Open();
                if(int.TryParse(txtLimTem.Text, out int temperatureLimit))
                {
                    string limitString = temperatureLimit.ToString();
                    ArduinoPort.Write(limitString);
                }
                else
                {
                    MessageBox.Show("Ingrese un valor valido ene el LIMITE DE TEMPERATURA");
                }
                labConexion.Text = "CONEXION OKE";
                labConexion.ForeColor = System.Drawing.Color.Aquamarine;
            }
            catch
            {
                MessageBox.Show("Configure el puerto de comunicacion correcto o Desconecte");
            }
        }
        private void botDesconec_Click(object sender, EventArgs e)
        {
            botConectar.Enabled = true;
            botConectar.Enabled = false;
            if (ArduinoPort.IsOpen)
                ArduinoPort.Close();
            labConexion.Text = "DESCONECTADO";
            labConexion.ForeColor = System.Drawing.Color.Purple;
            labTemperatura.Text = "00.0";
        }
    }
    }