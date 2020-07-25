using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.JobCards
{
    public class JobCard_QA_Cistern
    {
        public int JobCardID { get; set; }
        public bool CorrectlyMounted { get; set; }
        public bool ProperlyAligned { get; set; }
        public bool Overflowing { get; set; }
        public bool Cistern_Flexi_Pipe_Leaking { get; set; }
        public bool Ball_Valve_Leaking_15mm { get; set; }
        public bool Other { get; set; }

    }
}
