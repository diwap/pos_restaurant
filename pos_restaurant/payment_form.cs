using Microsoft.VisualBasic;
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
    public partial class payment_form : Form
    {
        public payment_form()
        {
            InitializeComponent();
        }

        public List<menu_name> Values { get; set; }

        public void AddToGrid(List<menu_name> val)
        {

            if (val != null)
            {
                foreach (menu_name item in val)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item.name;
                    dataGridView1.Rows[n].Cells[1].Value = item.category;
                    dataGridView1.Rows[n].Cells[2].Value = item.price;
                    //dataGridView1.Rows[n].Cells[2].Value = item.quantity;
                }
            }
        }

        private void payment_form_Load(object sender, EventArgs e)
        {
            AddToGrid(Values);
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                int n = item.Index;
                dataGridView1.Rows[n].Cells[3].Value = "1";
                string value1 = dataGridView1.Rows[n].Cells[2].Value.ToString();
                string value2 = dataGridView1.Rows[n].Cells[3].Value.ToString();
                dataGridView1.Rows[n].Cells[4].Value = (Int32.Parse(value1) * Int32.Parse(value2)).ToString();
                all_total.Text = (from DataGridViewRow row in dataGridView1.Rows
                                  where row.Cells[4].FormattedValue.ToString() != string.Empty
                                  select Convert.ToInt32(row.Cells[4].FormattedValue)).Sum().ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                int n = item.Index;
                string value1 = dataGridView1.Rows[n].Cells[2].Value.ToString();
                string value2 = dataGridView1.Rows[n].Cells[3].Value.ToString();
                dataGridView1.Rows[n].Cells[4].Value = (Int32.Parse(value1) * Int32.Parse(value2)).ToString();
                all_total.Text = (from DataGridViewRow row in dataGridView1.Rows
                                  where row.Cells[4].FormattedValue.ToString() != string.Empty
                                  select Convert.ToInt32(row.Cells[4].FormattedValue)).Sum().ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void save_Click(object sender, EventArgs e)
        {
            save.Text = "ORDER SUCCESSFUL";
            
        }

        private void discard_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
