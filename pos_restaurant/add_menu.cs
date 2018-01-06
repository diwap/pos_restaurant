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
    }
}
