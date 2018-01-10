using Microsoft.VisualBasic.FileIO;
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
    [Serializable]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ActivePanel.Height = btnDashboard.Height;
            ActivePanel.Top = btnDashboard.Top;
            panel5.Visible = true;
            add_menu.Visible = true;
            dataGridView1.Visible = true;
            btnImport.Visible = true;
            csv_path.Visible = true;
            report_grid_view.Visible = false;
            report_cash_received.Visible = false;
            report_total_sales.Visible = false;
            report_chart.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            total_cash.Text = "Total Revenue";
            //LoadDataInReportGridView();
            generateChart();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will close down the whole application. Confirm? \n Last Tried time: " + DateTime.Now.ToShortTimeString(), "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
            ActivePanel.Height = btnDashboard.Height;
            ActivePanel.Top = btnDashboard.Top;
            panel5.Visible = true;
            add_menu.Visible = true;
            dataGridView1.Visible = true;
            btnImport.Visible = true;
            csv_path.Visible = true;
            report_grid_view.Visible = false;
            report_cash_received.Visible = false;
            report_total_sales.Visible = false;
            report_chart.Visible = false;
            panel6.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ActivePanel.Height = btnReport.Height;
            ActivePanel.Top = btnReport.Top;
            add_menu.Visible = false;
            dataGridView1.Visible = false;
            btnImport.Visible = false;
            csv_path.Visible = false;
            report_grid_view.Visible = true;
            report_cash_received.Visible = true;
            report_total_sales.Visible = true;
            report_chart.Visible = true;
            panel6.Visible = true;
            panel7.Visible = false;

            report_cash_received.Text = (from DataGridViewRow row in report_grid_view.Rows
                                    where row.Cells[4].FormattedValue.ToString() != string.Empty
                                    select Convert.ToInt32(row.Cells[4].FormattedValue)).Sum().ToString();

            report_total_sales.Text = (from DataGridViewRow row in report_grid_view.Rows
                                       where row.Cells[4].FormattedValue.ToString() != string.Empty
                                       select Convert.ToInt32(row.Cells[4].FormattedValue)).Count().ToString();

            generateChart();
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
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Files(*.txt, *.csv)|*.txt;*.csv|All Files (*.*) |*.*"; /**used for .csv format */
            dialog.ShowDialog();
            if (dialog.FileName != "")
            {
                TextFieldParser csvParser = new TextFieldParser(dialog.FileName);
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;

                // Skip the row with the column names
                csvParser.ReadLine();

                while (!csvParser.EndOfData)
                {
                    csv_path.Text = dialog.FileName;
                    // Read current line fields, pointer moves to the next line.
                    string[] fields = csvParser.ReadFields();

                    int count = dataGridView1.Rows.Count;
                    dataGridView1.Rows.Add();
                    for (int i = 0; i < fields.Length; i++)
                    {
                        dataGridView1.Rows[count].Cells[i].Value = fields[i];
                    }
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
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells[3].Value))
                {
                    int n = paymentGridView.Rows.Add();
                    paymentGridView.Rows[n].Cells[0].Value = row.Cells[0].Value.ToString();
                    paymentGridView.Rows[n].Cells[1].Value = row.Cells[1].Value.ToString();
                    paymentGridView.Rows[n].Cells[2].Value = row.Cells[2].Value.ToString();
                    paymentGridView.Rows[n].Cells[3].Value = "1";
                    paymentGridView.Rows[n].Cells[4].Value = (Int32.Parse(paymentGridView.Rows[n].Cells[2].Value.ToString()) * 1);
                }
            }

            //List<menu_name> CV = new List<menu_name>();
            //foreach (DataGridViewRow item in dataGridView1.Rows)
            //{
            //    if (Convert.ToBoolean(item.Cells[3].Value))
            //    {
            //        CV.Add(new menu_name
            //        {
            //            name = item.Cells[0].Value.ToString(),
            //            category = item.Cells[1].Value.ToString(),
            //            price = item.Cells[2].Value.ToString()
            //        });
            //    }
            //}
            //payment_form pmt = new payment_form();
            //data = CV;
            //pmt.Show();
            report_grid_view.Visible = false;
            report_cash_received.Visible = false;
            report_total_sales.Visible = true;
            report_chart.Visible = false;
            panel6.Visible = false;
            panel7.Visible = true;
            csv_path.Visible = false;
            btnImport.Visible = false;
            panel7.BringToFront();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.IsCurrentRowDirty)
            {
                payment.Visible = true;
            }
        }

        //private void LoadDataInReportGridView()
        //{
        //    report_grid_view.Rows.Add();
        //    report_grid_view.Rows[0].Cells[0].Value = "Apple";
        //    report_grid_view.Rows[0].Cells[1].Value = "Fruit";
        //    report_grid_view.Rows[0].Cells[2].Value = "100";
        //    report_grid_view.Rows[0].Cells[3].Value = "5";
        //    report_grid_view.Rows[0].Cells[4].Value = "500";

        //    report_grid_view.Rows.Add();
        //    report_grid_view.Rows[1].Cells[0].Value = "Mango";
        //    report_grid_view.Rows[1].Cells[1].Value = "Fruit";
        //    report_grid_view.Rows[1].Cells[2].Value = "150";
        //    report_grid_view.Rows[1].Cells[3].Value = "4";
        //    report_grid_view.Rows[1].Cells[4].Value = "600";

        //    report_grid_view.Rows.Add();
        //    report_grid_view.Rows[2].Cells[0].Value = "Carrot";
        //    report_grid_view.Rows[2].Cells[1].Value = "Vegetable";
        //    report_grid_view.Rows[2].Cells[2].Value = "60";
        //    report_grid_view.Rows[2].Cells[3].Value = "1";
        //    report_grid_view.Rows[2].Cells[4].Value = "60";

        //    report_grid_view.Rows.Add();
        //    report_grid_view.Rows[3].Cells[0].Value = "Tomato";
        //    report_grid_view.Rows[3].Cells[1].Value = "Vegetable";
        //    report_grid_view.Rows[3].Cells[2].Value = "200";
        //    report_grid_view.Rows[3].Cells[3].Value = "2";
        //    report_grid_view.Rows[3].Cells[4].Value = "400";

        //    report_grid_view.Rows.Add();
        //    report_grid_view.Rows[4].Cells[0].Value = "Radish";
        //    report_grid_view.Rows[4].Cells[1].Value = "Vegetable";
        //    report_grid_view.Rows[4].Cells[2].Value = "60";
        //    report_grid_view.Rows[4].Cells[3].Value = "4";
        //    report_grid_view.Rows[4].Cells[4].Value = "240";

        //    report_grid_view.Rows.Add();
        //    report_grid_view.Rows[5].Cells[0].Value = "Fruit Cake";
        //    report_grid_view.Rows[5].Cells[1].Value = "Breakfast";
        //    report_grid_view.Rows[5].Cells[2].Value = "90";
        //    report_grid_view.Rows[5].Cells[3].Value = "2";
        //    report_grid_view.Rows[5].Cells[4].Value = "180";

        //    report_grid_view.Rows.Add();
        //    report_grid_view.Rows[6].Cells[0].Value = "Bread Toast";
        //    report_grid_view.Rows[6].Cells[1].Value = "Breakfast";
        //    report_grid_view.Rows[6].Cells[2].Value = "200";
        //    report_grid_view.Rows[6].Cells[3].Value = "3";
        //    report_grid_view.Rows[6].Cells[4].Value = "600";

        //    report_grid_view.Rows.Add();
        //    report_grid_view.Rows[7].Cells[0].Value = "Fry Rice";
        //    report_grid_view.Rows[7].Cells[1].Value = "Lunch";
        //    report_grid_view.Rows[7].Cells[2].Value = "150";
        //    report_grid_view.Rows[7].Cells[3].Value = "2";
        //    report_grid_view.Rows[7].Cells[4].Value = "300";

        //    report_grid_view.Rows.Add();
        //    report_grid_view.Rows[8].Cells[0].Value = "Chicken Susi";
        //    report_grid_view.Rows[8].Cells[1].Value = "Lunch";
        //    report_grid_view.Rows[8].Cells[2].Value = "200";
        //    report_grid_view.Rows[8].Cells[3].Value = "8";
        //    report_grid_view.Rows[8].Cells[4].Value = "1600";

        //    report_grid_view.Rows.Add();
        //    report_grid_view.Rows[9].Cells[0].Value = "Dhido";
        //    report_grid_view.Rows[9].Cells[1].Value = "Lunch";
        //    report_grid_view.Rows[9].Cells[2].Value = "1000";
        //    report_grid_view.Rows[9].Cells[3].Value = "3";
        //    report_grid_view.Rows[9].Cells[4].Value = "3000";
        //}

        private void generateChart()
        {
            List<string> item = new List<string>();
            List<int> total = new List<int>();

            for (int i = 0; i < report_grid_view.Rows.Count; i++)
            {
                item.Add(report_grid_view.Rows[i].Cells[1].Value.ToString());
                total.Add(Int32.Parse(report_grid_view.Rows[i].Cells[4].Value.ToString()));
            }

            List<string> distinct = item.Distinct().ToList();

            for (int i = 0; i < item.Count; i++)
            {
                report_chart.Series["total"].Points.AddXY(item[i], total[i]);
            }

            report_chart.DataManipulator.GroupByAxisLabel("SUM", "*");
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (cash_received.Text != "0")
            {
                foreach (DataGridViewRow row in paymentGridView.Rows)
                {
                    int n = report_grid_view.Rows.Add();
                    report_grid_view.Rows[n].Cells[0].Value = row.Cells[0].Value.ToString();
                    report_grid_view.Rows[n].Cells[1].Value = row.Cells[1].Value.ToString();
                    report_grid_view.Rows[n].Cells[2].Value = row.Cells[2].Value.ToString();
                    report_grid_view.Rows[n].Cells[3].Value = row.Cells[3].Value.ToString();
                    report_grid_view.Rows[n].Cells[4].Value = (Int32.Parse(report_grid_view.Rows[n].Cells[2].Value.ToString()) * Int32.Parse(report_grid_view.Rows[n].Cells[3].Value.ToString()));
                }

                panel7.Visible = false;
                paymentGridView.Rows.Clear();
                cash_received.Text = "0";
                cash_return.Clear();
            }
            else
            {
                MessageBox.Show("Insert amount you received for your order!");
            }
            
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
            paymentGridView.Rows.Clear();
            cash_received.Text = "0";
            cash_return.Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            change_Value();
        }

        private void change_Value()
        {
            foreach (DataGridViewRow item in paymentGridView.Rows)
            {
                int n = item.Index;
                string value1 = paymentGridView.Rows[n].Cells[2].Value.ToString();
                string value2 = paymentGridView.Rows[n].Cells[3].Value.ToString();
                paymentGridView.Rows[n].Cells[4].Value = (Int32.Parse(value1) * Int32.Parse(value2)).ToString();
                all_total.Text = (from DataGridViewRow row in paymentGridView.Rows
                                  where row.Cells[4].FormattedValue.ToString() != string.Empty
                                  select Convert.ToInt32(row.Cells[4].FormattedValue)).Sum().ToString();
            }
        }

        private void cash_received_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int int_cash_received = Int32.Parse(cash_received.Text);
                int int_all_total = Int32.Parse(all_total.Text);
                if (int_cash_received >= int_all_total)
                {
                    cash_return.Text = (int_cash_received - int_all_total).ToString();
                }
                else
                {
                    cash_return.Text = "Less than total";
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Field is empty");
            }
        }

        private void cash_received_Click(object sender, EventArgs e)
        {
            change_Value();
        }
    }
}
