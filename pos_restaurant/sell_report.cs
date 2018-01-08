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
    public partial class sell_report : Form
    {
        public sell_report(string name, string category, string price, string quantity)
        {
            InitializeComponent();

            dataGridView1.Rows.Add();
            dataGridView1.Rows[0].Cells[0].Value = name;
            dataGridView1.Rows[0].Cells[1].Value = category;
            dataGridView1.Rows[0].Cells[2].Value = price;
            dataGridView1.Rows[0].Cells[3].Value = quantity;
        }

    }
}
