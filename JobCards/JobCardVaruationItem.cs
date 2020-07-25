using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.JobCards
{
    public class JobCardVaruationItem
    {
        public int ItemID { get; set; }
        public int JobCardID { get; set; }
        public string ItemDescription { get; set; }
        public double ItemPrice { get; set; }
        public int Quantity { get; set; }
    }
}
