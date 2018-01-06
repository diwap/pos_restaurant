using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace pos_restaurant
{
    public partial class menu : UserControl
    {
        public menu()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (name.Text != "Name" | category.Text != "Category" | price.Text != "Price")
            {
                int n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = name.Text;
                dataGridView1.Rows[n].Cells[1].Value = category.Text;
                dataGridView1.Rows[n].Cells[2].Value = price.Text;

                //MessageBox.Show(string.Format("Your food details:\n\nName: {0} \nCategory: {1} \nPrice: {2}", name.Text, category.Text, price.Text));
            }
            else
            {
                MessageBox.Show("Please change field value to insert your new menu");
            }
        }

        private void discard_Click(object sender, EventArgs e)
        {
            name.Text = "Name";
            category.Text = "Category";
            price.Text = "Price";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "CSV|*.csv";
                dialog.ValidateNames = true;
                dialog.Multiselect = false;

                DialogResult result = dialog.ShowDialog();
                if(result == DialogResult.OK)
                {
                    csv_path.Text = dialog.FileName;
                    string val = csv_path.Text;
                    importCSVFile(val);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Your file successfully loaded", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void importCSVFile(string filepath)
        {
            try
            {
                TextFieldParser csvreader = new TextFieldParser(filepath);

                csvreader.SetDelimiters(new string[] { "," });

                while (!csvreader.EndOfData)
                {
                    string[] fielddata = csvreader.ReadFields();

                    for (int i = 0; i < fielddata.Length; i++)
                    {
                        Console.WriteLine(fielddata[i] + "\t");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Import CSV File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
