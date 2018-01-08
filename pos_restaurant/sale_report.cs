using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pos_restaurant
{
    class sale_report
    {
        public string PName { get; set; }
        public string Category { get; set; }
        public string Price { get; set; }
        public string Quantity { get; set; }
        public string Total { get { return string.Format("{0}", Int32.Parse(Price) * Int32.Parse(Quantity)); } }
    }
}
