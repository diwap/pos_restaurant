using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pos_restaurant
{
    public partial class add_menu : UserControl
    {
        public add_menu()
        {
            InitializeComponent();
        }

        private void discard_Click(object sender, EventArgs e)
        {
            name.Text = "Name";
            category.Text = "Category";
            price.Text = "Price";
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (name.Text != "Name" | category.Text != "Category" | price.Text != "Price")
            {
                MessageBox.Show(string.Format("Your food details:\n\nName: {0} \nCategory: {1} \nPrice: {2}", name.Text, category.Text, price.Text));
            }
            else
            {
                MessageBox.Show("Please change field value to insert your new menu");
            }
        }
    }
}
