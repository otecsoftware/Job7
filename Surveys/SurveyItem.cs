using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.Surveys
{
    public class SurveyItem
    {
        public string JobCardNumber { get; set; }
        public string ItemDescription { get; set; }
        public int Quantity { get; set; }
        public double LabourPrice { get; set; }
        public double MaterialPrice { get; set; }
        public double Total { get; set; }
    }


}
