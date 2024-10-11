using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace Brahler_Serial_Tester
{
    public partial class fclsRS232Tester : Form
    {
        public fclsRS232Tester()
        {
            InitializeComponent();

            // Nice methods to browse all available ports:
            string[] ports = SerialPort.GetPortNames();


            // Add all port names to the combo box:
            foreach (string port in ports)
            {
                comboBox3.Items.Add(port);
            }
        }

       

        private void btnSend_Click(object sender, EventArgs e)
        {
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            toolStripStatusLabel1.Text = "Please import Serial Port Settings";
            statusStrip1.BackColor = Color.Orange;




            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");
            comboBox1.Items.Add("4");
            comboBox1.Items.Add("5");
            comboBox1.Items.Add("6");
            comboBox1.Items.Add("7");
            comboBox1.Items.Add("8");
            comboBox1.Items.Add("9");
            comboBox1.Items.Add("10");
            comboBox1.Items.Add("11");
            comboBox1.Items.Add("12");
            comboBox1.Items.Add("13");
            comboBox1.Items.Add("14");
            comboBox1.Items.Add("15");
            comboBox1.Items.Add("16");
            comboBox1.Items.Add("17");
            comboBox1.Items.Add("18");
            comboBox1.Items.Add("19");
            comboBox1.Items.Add("20");
            comboBox1.Items.Add("21");
            comboBox1.Items.Add("22");
            comboBox1.Items.Add("23");
            comboBox1.Items.Add("24");
            comboBox1.Items.Add("25");
            comboBox1.Items.Add("26");
            comboBox1.Items.Add("27");
            comboBox1.Items.Add("28");
            comboBox1.Items.Add("29");
            comboBox1.Items.Add("30");
            comboBox1.Items.Add("31");
            comboBox1.Items.Add("32");
            comboBox1.Items.Add("33");
            comboBox1.Items.Add("34");
            comboBox1.Items.Add("35");
            comboBox1.Items.Add("36");
            comboBox1.Items.Add("37");
            comboBox1.Items.Add("38");
            comboBox1.Items.Add("39");
            comboBox1.Items.Add("40");
            comboBox1.Items.Add("41");
            comboBox1.Items.Add("42");
            comboBox1.Items.Add("43");
            comboBox1.Items.Add("44");
            comboBox1.Items.Add("45");
            comboBox1.Items.Add("46");
            comboBox1.Items.Add("47");
            comboBox1.Items.Add("48");
            comboBox1.Items.Add("49");
            comboBox1.Items.Add("50");

            comboBox1.Items.Add("51");
            comboBox1.Items.Add("52");
            comboBox1.Items.Add("53");
            comboBox1.Items.Add("54");
            comboBox1.Items.Add("55");
            comboBox1.Items.Add("56");
            comboBox1.Items.Add("57");
            comboBox1.Items.Add("58");
            comboBox1.Items.Add("59");
            comboBox1.Items.Add("60");
            comboBox1.Items.Add("61");
            comboBox1.Items.Add("62");
            comboBox1.Items.Add("63");
            comboBox1.Items.Add("64");
            comboBox1.Items.Add("65");
            comboBox1.Items.Add("66");
            comboBox1.Items.Add("67");
            comboBox1.Items.Add("68");
            comboBox1.Items.Add("69");
            comboBox1.Items.Add("70");
            comboBox1.Items.Add("71");
            comboBox1.Items.Add("72");
            comboBox1.Items.Add("73");
            comboBox1.Items.Add("74");
            comboBox1.Items.Add("75");
            comboBox1.Items.Add("76");
            comboBox1.Items.Add("77");
            comboBox1.Items.Add("78");
            comboBox1.Items.Add("79");
            comboBox1.Items.Add("80");
            comboBox1.Items.Add("81");
            comboBox1.Items.Add("82");
            comboBox1.Items.Add("83");
            comboBox1.Items.Add("84");
            comboBox1.Items.Add("85");
            comboBox1.Items.Add("86");
            comboBox1.Items.Add("87");
            comboBox1.Items.Add("88");
            comboBox1.Items.Add("89");
            comboBox1.Items.Add("90");
            comboBox1.Items.Add("91");
            comboBox1.Items.Add("92");
            comboBox1.Items.Add("93");
            comboBox1.Items.Add("94");
            comboBox1.Items.Add("95");
            comboBox1.Items.Add("96");
            comboBox1.Items.Add("97");
            comboBox1.Items.Add("98");
            comboBox1.Items.Add("99");
            comboBox1.Items.Add("100");


            comboBox2.Items.Add("600");
            comboBox2.Items.Add("1200");
            comboBox2.Items.Add("2400");
            comboBox2.Items.Add("4800");
            comboBox2.Items.Add("9600");
            comboBox2.Items.Add("14400");
            comboBox2.Items.Add("19200");
            comboBox2.Items.Add("57600");
            comboBox2.Items.Add("115200");

            comboBox4.Items.Add("None");
            comboBox4.Items.Add("Even");
            comboBox4.Items.Add("Odd");
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (port.IsOpen) port.Close();
            port.PortName = comboBox3.SelectedItem.ToString();



            if (comboBox2.Text == "600")
                port.BaudRate = 600;
            else if (comboBox2.Text == "1200")
                port.BaudRate = 1200;
            else if (comboBox2.Text == "2400")
                port.BaudRate = 2400;
            else if (comboBox2.Text == "4800")
                port.BaudRate = 4800;
            else if (comboBox2.Text == "9600")
                port.BaudRate = 9600;
            else if (comboBox2.Text == "14400")
                port.BaudRate = 14400;
            else if (comboBox2.Text == "19200")
                port.BaudRate = 19200;
            else if (comboBox2.Text == "38400")
                port.BaudRate = 38400;
            else if (comboBox2.Text == "57600")
                port.BaudRate = 57600;
            else if (comboBox2.Text == "115200")
                port.BaudRate = 115200;


            if (comboBox4.Text == "None")
                port.Parity = Parity.None;
            else if (comboBox4.Text == "Even")
                port.Parity = Parity.Even;
            else if (comboBox4.Text == "Odd")
                port.Parity = Parity.Odd;



            // try to open the selected port:
            try
            {
                port.Open();
                toolStripStatusLabel1.Text = "Connected";
                statusStrip1.BackColor = Color.Green;
            }
            // give a message, if the port is not available:
            catch
            {
                toolStripStatusLabel1.Text = "Serial port " + port.PortName + " cannot be opened!";
                statusStrip1.BackColor = Color.Red;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] bytestosend1 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend2 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X30, 0X32, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend3 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X30, 0X33, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend4 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X30, 0X34, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend5 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X30, 0X35, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend6 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X30, 0X36, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend7 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X30, 0X37, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend8 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X30, 0X38, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend9 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X30, 0X39, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend10 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X31, 0X30, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };

            byte[] bytestosend11 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X31, 0X31, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend12 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X31, 0X32, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend13 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X31, 0X33, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend14 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X31, 0X34, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend15 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X31, 0X35, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend16 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X31, 0X36, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend17 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X31, 0X37, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend18 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X31, 0X38, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend19 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X31, 0X39, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend20 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X32, 0X30, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };

            byte[] bytestosend21 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X32, 0X31, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend22 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X32, 0X32, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend23 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X32, 0X33, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend24 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X32, 0X34, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend25 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X32, 0X35, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend26 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X32, 0X36, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend27 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X32, 0X37, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend28 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X32, 0X38, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend29 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X32, 0X39, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend30 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X33, 0X30, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };

            byte[] bytestosend31 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X33, 0X31, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend32 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X33, 0X32, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend33 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X33, 0X33, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend34 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X33, 0X34, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend35 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X33, 0X35, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend36 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X33, 0X36, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend37 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X33, 0X37, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend38 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X33, 0X38, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend39 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X33, 0X39, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend40 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X34, 0X30, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };

            byte[] bytestosend41 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X34, 0X31, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend42 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X34, 0X32, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend43 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X34, 0X33, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend44 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X34, 0X34, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend45 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X34, 0X35, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend46 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X34, 0X36, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend47 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X34, 0X37, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend48 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X34, 0X38, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend49 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X34, 0X39, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend50 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X35, 0X30, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };

            byte[] bytestosend51 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X35, 0X31, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend52 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X35, 0X32, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend53 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X35, 0X33, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend54 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X35, 0X34, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend55 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X35, 0X35, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend56 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X35, 0X36, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend57 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X35, 0X37, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend58 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X35, 0X38, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend59 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X35, 0X39, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend60 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X36, 0X30, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };

            byte[] bytestosend61 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X36, 0X31, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend62 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X36, 0X32, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend63 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X36, 0X33, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend64 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X36, 0X34, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend65 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X36, 0X35, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend66 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X36, 0X36, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend67 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X36, 0X37, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend68 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X36, 0X38, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend69 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X36, 0X39, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend70 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X37, 0X30, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };

            byte[] bytestosend71 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X37, 0X31, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend72 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X37, 0X32, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend73 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X37, 0X33, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend74 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X37, 0X34, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend75 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X37, 0X35, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend76 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X37, 0X36, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend77 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X37, 0X37, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend78 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X37, 0X38, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend79 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X37, 0X39, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend80 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X38, 0X30, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };

            byte[] bytestosend81 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X38, 0X31, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend82 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X38, 0X32, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend83 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X38, 0X33, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend84 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X38, 0X34, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend85 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X38, 0X35, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend86 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X38, 0X36, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend87 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X38, 0X37, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend88 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X38, 0X38, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend89 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X38, 0X39, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend90 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X39, 0X30, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };

            byte[] bytestosend91 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X39, 0X31, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend92 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X39, 0X32, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend93 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X39, 0X33, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend94 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X39, 0X34, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend95 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X39, 0X35, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend96 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X39, 0X36, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend97 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X39, 0X37, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend98 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X39, 0X38, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend99 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X30, 0X39, 0X39, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };
            byte[] bytestosend100 = { 0x0A, 0x4D, 0x49, 0x43, 0x2D, 0x4F, 0x4E, 0X20, 0X3B, 0X30, 0X31, 0X30, 0X30, 0X3B, 0X30, 0X30, 0X30, 0X31, 0X0D };



            if (port.IsOpen)

                if (comboBox1.Text == "1")
                    port.Write(bytestosend1, 0, bytestosend1.Length);
                else if (comboBox1.Text == "2")
                    port.Write(bytestosend2, 0, bytestosend2.Length);
                else if (comboBox1.Text == "3")
                    port.Write(bytestosend3, 0, bytestosend3.Length);
                else if (comboBox1.Text == "4")
                    port.Write(bytestosend4, 0, bytestosend4.Length);
                else if (comboBox1.Text == "5")
                    port.Write(bytestosend5, 0, bytestosend5.Length);
                else if (comboBox1.Text == "6")
                    port.Write(bytestosend6, 0, bytestosend6.Length);
                else if (comboBox1.Text == "7")
                    port.Write(bytestosend7, 0, bytestosend7.Length);
                else if (comboBox1.Text == "8")
                    port.Write(bytestosend8, 0, bytestosend8.Length);
                else if (comboBox1.Text == "9")
                    port.Write(bytestosend9, 0, bytestosend9.Length);
                else if (comboBox1.Text == "10")
                    port.Write(bytestosend10, 0, bytestosend10.Length);
                else if (comboBox1.Text == "11")
                    port.Write(bytestosend11, 0, bytestosend11.Length);
                else if (comboBox1.Text == "12")
                    port.Write(bytestosend12, 0, bytestosend12.Length);
                else if (comboBox1.Text == "13")
                    port.Write(bytestosend13, 0, bytestosend13.Length);
                else if (comboBox1.Text == "14")
                    port.Write(bytestosend14, 0, bytestosend14.Length);
                else if (comboBox1.Text == "15")
                    port.Write(bytestosend15, 0, bytestosend15.Length);
                else if (comboBox1.Text == "16")
                    port.Write(bytestosend16, 0, bytestosend16.Length);
                else if (comboBox1.Text == "17")
                    port.Write(bytestosend17, 0, bytestosend17.Length);
                else if (comboBox1.Text == "18")
                    port.Write(bytestosend18, 0, bytestosend18.Length);
                else if (comboBox1.Text == "19")
                    port.Write(bytestosend19, 0, bytestosend19.Length);
                else if (comboBox1.Text == "20")
                    port.Write(bytestosend20, 0, bytestosend20.Length);

            if (comboBox1.Text == "21")
                port.Write(bytestosend21, 0, bytestosend21.Length);
            else if (comboBox1.Text == "22")
                port.Write(bytestosend22, 0, bytestosend22.Length);
            else if (comboBox1.Text == "23")
                port.Write(bytestosend23, 0, bytestosend23.Length);
            else if (comboBox1.Text == "24")
                port.Write(bytestosend24, 0, bytestosend24.Length);
            else if (comboBox1.Text == "25")
                port.Write(bytestosend25, 0, bytestosend25.Length);
            else if (comboBox1.Text == "26")
                port.Write(bytestosend26, 0, bytestosend26.Length);
            else if (comboBox1.Text == "27")
                port.Write(bytestosend27, 0, bytestosend27.Length);
            else if (comboBox1.Text == "28")
                port.Write(bytestosend28, 0, bytestosend28.Length);
            else if (comboBox1.Text == "29")
                port.Write(bytestosend29, 0, bytestosend29.Length);
            else if (comboBox1.Text == "30")
                port.Write(bytestosend30, 0, bytestosend30.Length);
            else if (comboBox1.Text == "31")
                port.Write(bytestosend31, 0, bytestosend31.Length);
            else if (comboBox1.Text == "32")
                port.Write(bytestosend32, 0, bytestosend32.Length);
            else if (comboBox1.Text == "33")
                port.Write(bytestosend33, 0, bytestosend33.Length);
            else if (comboBox1.Text == "34")
                port.Write(bytestosend34, 0, bytestosend34.Length);
            else if (comboBox1.Text == "35")
                port.Write(bytestosend35, 0, bytestosend35.Length);
            else if (comboBox1.Text == "36")
                port.Write(bytestosend36, 0, bytestosend36.Length);
            else if (comboBox1.Text == "37")
                port.Write(bytestosend37, 0, bytestosend37.Length);
            else if (comboBox1.Text == "38")
                port.Write(bytestosend38, 0, bytestosend38.Length);
            else if (comboBox1.Text == "39")
                port.Write(bytestosend39, 0, bytestosend39.Length);
            else if (comboBox1.Text == "40")
                port.Write(bytestosend40, 0, bytestosend40.Length);


            if (comboBox1.Text == "41")
                port.Write(bytestosend41, 0, bytestosend41.Length);
            else if (comboBox1.Text == "42")
                port.Write(bytestosend42, 0, bytestosend42.Length);
            else if (comboBox1.Text == "43")
                port.Write(bytestosend43, 0, bytestosend43.Length);
            else if (comboBox1.Text == "44")
                port.Write(bytestosend44, 0, bytestosend44.Length);
            else if (comboBox1.Text == "45")
                port.Write(bytestosend45, 0, bytestosend45.Length);
            else if (comboBox1.Text == "46")
                port.Write(bytestosend46, 0, bytestosend46.Length);
            else if (comboBox1.Text == "47")
                port.Write(bytestosend47, 0, bytestosend47.Length);
            else if (comboBox1.Text == "48")
                port.Write(bytestosend48, 0, bytestosend48.Length);
            else if (comboBox1.Text == "49")
                port.Write(bytestosend49, 0, bytestosend49.Length);
            else if (comboBox1.Text == "50")
                port.Write(bytestosend50, 0, bytestosend50.Length);
            else if (comboBox1.Text == "51")
                port.Write(bytestosend51, 0, bytestosend51.Length);
            else if (comboBox1.Text == "52")
                port.Write(bytestosend52, 0, bytestosend52.Length);
            else if (comboBox1.Text == "53")
                port.Write(bytestosend53, 0, bytestosend53.Length);
            else if (comboBox1.Text == "54")
                port.Write(bytestosend54, 0, bytestosend54.Length);
            else if (comboBox1.Text == "55")
                port.Write(bytestosend55, 0, bytestosend55.Length);
            else if (comboBox1.Text == "56")
                port.Write(bytestosend56, 0, bytestosend56.Length);
            else if (comboBox1.Text == "57")
                port.Write(bytestosend57, 0, bytestosend57.Length);
            else if (comboBox1.Text == "58")
                port.Write(bytestosend58, 0, bytestosend58.Length);
            else if (comboBox1.Text == "59")
                port.Write(bytestosend59, 0, bytestosend59.Length);
            else if (comboBox1.Text == "60")
                port.Write(bytestosend60, 0, bytestosend60.Length);

            if (comboBox1.Text == "61")
                port.Write(bytestosend61, 0, bytestosend61.Length);
            else if (comboBox1.Text == "62")
                port.Write(bytestosend62, 0, bytestosend62.Length);
            else if (comboBox1.Text == "63")
                port.Write(bytestosend63, 0, bytestosend63.Length);
            else if (comboBox1.Text == "64")
                port.Write(bytestosend64, 0, bytestosend64.Length);
            else if (comboBox1.Text == "65")
                port.Write(bytestosend65, 0, bytestosend65.Length);
            else if (comboBox1.Text == "66")
                port.Write(bytestosend66, 0, bytestosend66.Length);
            else if (comboBox1.Text == "67")
                port.Write(bytestosend67, 0, bytestosend67.Length);
            else if (comboBox1.Text == "68")
                port.Write(bytestosend68, 0, bytestosend68.Length);
            else if (comboBox1.Text == "69")
                port.Write(bytestosend69, 0, bytestosend69.Length);
            else if (comboBox1.Text == "70")
                port.Write(bytestosend70, 0, bytestosend70.Length);
            else if (comboBox1.Text == "71")
                port.Write(bytestosend71, 0, bytestosend71.Length);
            else if (comboBox1.Text == "72")
                port.Write(bytestosend72, 0, bytestosend72.Length);
            else if (comboBox1.Text == "73")
                port.Write(bytestosend73, 0, bytestosend73.Length);
            else if (comboBox1.Text == "74")
                port.Write(bytestosend74, 0, bytestosend74.Length);
            else if (comboBox1.Text == "75")
                port.Write(bytestosend75, 0, bytestosend75.Length);
            else if (comboBox1.Text == "76")
                port.Write(bytestosend76, 0, bytestosend76.Length);
            else if (comboBox1.Text == "77")
                port.Write(bytestosend77, 0, bytestosend77.Length);
            else if (comboBox1.Text == "78")
                port.Write(bytestosend78, 0, bytestosend78.Length);
            else if (comboBox1.Text == "79")
                port.Write(bytestosend79, 0, bytestosend79.Length);
            else if (comboBox1.Text == "80")
                port.Write(bytestosend80, 0, bytestosend80.Length);

            if (comboBox1.Text == "81")
                port.Write(bytestosend81, 0, bytestosend81.Length);
            else if (comboBox1.Text == "82")
                port.Write(bytestosend82, 0, bytestosend82.Length);
            else if (comboBox1.Text == "83")
                port.Write(bytestosend83, 0, bytestosend83.Length);
            else if (comboBox1.Text == "84")
                port.Write(bytestosend84, 0, bytestosend84.Length);
            else if (comboBox1.Text == "85")
                port.Write(bytestosend85, 0, bytestosend85.Length);
            else if (comboBox1.Text == "86")
                port.Write(bytestosend86, 0, bytestosend86.Length);
            else if (comboBox1.Text == "87")
                port.Write(bytestosend87, 0, bytestosend87.Length);
            else if (comboBox1.Text == "88")
                port.Write(bytestosend88, 0, bytestosend88.Length);
            else if (comboBox1.Text == "89")
                port.Write(bytestosend89, 0, bytestosend89.Length);
            else if (comboBox1.Text == "90")
                port.Write(bytestosend90, 0, bytestosend90.Length);
            else if (comboBox1.Text == "91")
                port.Write(bytestosend91, 0, bytestosend91.Length);
            else if (comboBox1.Text == "92")
                port.Write(bytestosend92, 0, bytestosend92.Length);
            else if (comboBox1.Text == "93")
                port.Write(bytestosend93, 0, bytestosend93.Length);
            else if (comboBox1.Text == "94")
                port.Write(bytestosend94, 0, bytestosend94.Length);
            else if (comboBox1.Text == "95")
                port.Write(bytestosend95, 0, bytestosend95.Length);
            else if (comboBox1.Text == "96")
                port.Write(bytestosend96, 0, bytestosend96.Length);
            else if (comboBox1.Text == "97")
                port.Write(bytestosend97, 0, bytestosend97.Length);
            else if (comboBox1.Text == "98")
                port.Write(bytestosend98, 0, bytestosend98.Length);
            else if (comboBox1.Text == "99")
                port.Write(bytestosend99, 0, bytestosend99.Length);
            else if (comboBox1.Text == "100")
                port.Write(bytestosend100, 0, bytestosend100.Length);

        }
    }
}
