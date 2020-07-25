using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.JobCards
{
    public class JobCard_QA_GeyserCondition
    {
        public int JobCardID { get; set; }
        public bool Geyser_IsWorkingCorrectly { get; set; }
        public string VerifiedByTechnician_Name { get; set; }
        public bool CustomerSigned { get; set; }
    }
}
