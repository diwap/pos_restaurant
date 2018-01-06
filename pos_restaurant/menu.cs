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
    public partial class menu : UserControl
    {
        public menu()
        {
            InitializeComponent();
            add_menu1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            add_menu1.Visible = true;
        }
    }
}
