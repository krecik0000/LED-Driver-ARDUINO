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

namespace serialTest2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "LED Driver";
            Icon icon = Icon.ExtractAssociatedIcon("Resources/MIcon.ico");

            this.Icon = icon;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                button1.BackColor = Color.DarkGray;
                button2.BackColor = Color.Gainsboro;
                SerialPort sp = new SerialPort("COM4", 9600); 
                sp.Open(); 
                sp.Write("1"); 
                sp.Close(); } 
            catch (Exception ex) {
                MessageBox.Show(ex.Message); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                button2.BackColor = Color.DarkGray;
                button1.BackColor = Color.Gainsboro;
                SerialPort sp = new SerialPort("COM4", 9600);
                sp.Open();
                sp.Write("0");
                sp.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
