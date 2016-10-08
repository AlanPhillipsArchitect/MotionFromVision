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

namespace WindowsFormsSerialPort
{
    public partial class MotorForm : Form
    {
        private SerialPort openedport;
        int enablevar = 0;
        int speedvar = 0;
        int dirvar = 0;

        public MotorForm()
        {
            InitializeComponent();
            init();
        }


        private void init()
        {

            
            //openedport.Write("slow");
            

            try
            {
                openedport = new SerialPort();
                openedport.BaudRate = 9600;
                openedport.PortName = "COM3";
                openedport.Open();


            }
            catch
            {
                MessageBox.Show("Error opening Serial Port");
                //Application.Exit();
            }

        }

        

        private void enabled_button_Click(object sender, EventArgs e)
        {
            if (enablevar == 1)
            {
                openedport.Write("on");
                enablevar = 0;
                enabled_textBox.Text = "Enabled";
            }
            else
            {
                openedport.Write("off");
                enablevar = 1;
                enabled_textBox.Text = "Disabled";
            }
        }

        private void speed_button_Click(object sender, EventArgs e)
        {
            if (speedvar == 1)
            {
                openedport.Write("fast");
                speedvar = 0;
                speed_textBox.Text = "Motor Fast";
            }
            else
            {
                openedport.Write("slow");
                speedvar = 1;
                speed_textBox.Text = "Motor Slow";
            }
            
            
        }

        private void direction_button_Click(object sender, EventArgs e)
        {
            if (dirvar == 1)
            {
                openedport.Write("arot");
                dirvar = 0;
                direction_textBox.Text = "Clockwise";
            }
            else
            {
                openedport.Write("rot");
                dirvar = 1;
                direction_textBox.Text = "Anti-Clockwise";
            }
        }

        private void distance_button_Click(object sender, EventArgs e)
        {

        }

       

        




    }
}
