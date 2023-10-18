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

namespace Arduino__ApagarEncender_
{
    public partial class Form1 : Form
    {
        public SerialPort ArduinoPort { get;  } 
        public Form1()
        {
            InitializeComponent();
            //CREACION "SERIAL PORT"
            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM3"; //DEPENDIENDO DEL ARDUIDO
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.Open();

            //VINCULACION DE EVENTOS
            this.FormClosing += CerrandoForm1;
            this.botonApagar.Click += botonApagar_Click;
            this.botonEncender.Click += botonEncender_Click;
        }


        private void botonApagar_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("a");
        }

        private void botonEncender_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("b");
        }

        private void CerrandoForm1 (object sender, FormClosingEventArgs e)
        {
            if (ArduinoPort.IsOpen) ArduinoPort.Close();
        }
    }
}
