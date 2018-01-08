using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            //dashboard1.BringToFront
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
            //dashboard1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActivePanel.Height = button3.Height;
            ActivePanel.Top = button3.Top;
            //sell1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ActivePanel.Height = button5.Height;
            ActivePanel.Top = button5.Top;
            //report1.BringToFront();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (name.Text != "Name" | category.Text != "Category" | price.Text != "Price")
            {
                int n = dataGridView1.Rows.Add();
                int m_price;

                dataGridView1.Rows[n].Cells[0].Value = name.Text;
                dataGridView1.Rows[n].Cells[1].Value = category.Text;
                if (int.TryParse(price.Text, out m_price))
                {
                    dataGridView1.Rows[n].Cells[2].Value = price.Text;
                }

                //MessageBox.Show(string.Format("Your food details:\n\nName: {0} \nCategory: {1} \nPrice: {2}", name.Text, category.Text, price.Text));
            }
            else
            {
                MessageBox.Show("Please change field value to insert your new menu");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();/**Opens New Dialog Box */
            dialog.Filter = "Files(*.txt, *.csv)|*.txt;*.csv|All Files (*.*) |*.*"; /**used for .csv format */
            DialogResult result = dialog.ShowDialog();

            /**If csv file is chosen */
            if (result == DialogResult.OK)
            {
                csv_path.Text = dialog.FileName;
                StreamReader stream_data = new StreamReader(dialog.FileName);
                while (!stream_data.EndOfStream)
                {
                    /** Spliting the Excel data into Colomns */
                    var columns = stream_data.ReadLine().Split(',');
                    Console.WriteLine(columns);

                    /** Adding Columns in datagrid view*/
                    dataGridView1.Rows.Add(columns);
                }
            }
        }

        private void discard_Click(object sender, EventArgs e)
        {
            name.Text = "Name";
            category.Text = "Category";
            price.Text = "Price";
        }

        private void sort_price_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Ascending);
        }

        private void sort_name_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void payment_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Payment Slip");
            List<menu_name> CV = new List<menu_name>();
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(item.Cells[3].Value))
                {
                    CV.Add(new menu_name
                    {
                        name = item.Cells[0].Value.ToString(),
                        category = item.Cells[1].Value.ToString(),
                        price = item.Cells[2].Value.ToString()
                    });
                }
            }

            payment_form pmt = new payment_form();
            pmt.Values = CV;
            pmt.Show();
        }
    }
}
