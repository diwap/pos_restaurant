﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pos_restaurant
{
    public class menu_name
    {
        public string name { get; set; }
        public string category { get; set; }
        public string price { get; set; }
        public float quantity { get; set; }
        public string Total { get { return string.Format("{0}", float.Parse(price, System.Globalization.CultureInfo.InvariantCulture.NumberFormat) * quantity);  } }
    }
}