using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.JobCards
{
    public class JobCard_QA_DrawOffs
    {
        public int JobCardID { get; set; }
        public bool Outside_Taps_Leaking { get; set; }
        public bool Bathroom_Taps_Leaking { get; set; }
        public bool Mixer_Leaking { get; set; }
        public bool Concrete { get; set; }
    }
}
