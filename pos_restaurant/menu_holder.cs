﻿using System;
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
    public partial class menu_holder : UserControl
    {
        public menu_holder()
        {
            InitializeComponent();
            menu1.BringToFront();
        }

        private void menu1_Load(object sender, EventArgs e)
        {

        }
    }
}
