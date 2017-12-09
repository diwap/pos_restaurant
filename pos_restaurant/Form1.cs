using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pos_restaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ActivePanel.Height = button1.Height;
            ActivePanel.Top = button1.Top;
            dashboard1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                this.Activate();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActivePanel.Height = button1.Height;
            ActivePanel.Top = button1.Top;
            dashboard1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActivePanel.Height = button3.Height;
            ActivePanel.Top = button3.Top;
            sell1.BringToFront();
        }
    }
}
