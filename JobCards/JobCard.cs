using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Job.Surveys;

namespace Job.JobCards
{
    public class JobCard
    {
        public int JobCardID { get; set; }
        public string JobCardNumber { get; set; }
        public string JPartner { get; set; }
        public string StandNo { get; set; }
        public string SGStand { get; set; }
        public string Alt_Stand { get; set; }
        public string Ward { get; set; }
        public string HouseAddress { get; set; }
        public string Consortium { get; set; }
        public string BlockSub { get; set; }
        public bool MetroAuthChecked { get; set; }
        public string SMME { get; set; }
        public string MeterSerialNo { get; set; }
        public bool VariationOrder { get; set; }
        public bool MeterOrder { get; set; }
        public DateTime CompletionCert_DateCompleted { get; set; }
        public bool CompletionCert_SignedByCustomer { get; set; }

        public string SurveytoBeDone { get; set; }
        public bool GateLock1 { get; set; }
        public bool GateLock2 { get; set; }
        public bool GateLock3 { get; set; }
        public bool SMMESig1 { get; set; }
        public bool SMMESig2 { get; set; }
        public bool SMMESig3 { get; set; }

        public bool CLOSig1 { get; set; }
        public bool CLOSig2 { get; set; }
        public bool CLOSig3 { get; set; }
        public string WorkPerformedPrint { get; set; }

        public string QC_TechnicianName { get; set; }
        public bool QC_Signed { get; set; }
        public string SubContractor_TechnicianName { get; set; }
        public bool SubContractor_Signed { get; set; }

        public DateTime OrderDate { get; set; }
        public DateTime JobCardDate { get; set; }
        public DateTime SurveyDate { get; set; }
        public List<SurveyItem> JobCardItems { get; set; }

        

        public JobCard()
        {
            IntializeDependencies();
        }

        public void IntializeDependencies()
        {
            JobCardItems = new List<SurveyItem>();
            OrderDate = DateTime.Today;
            JobCardDate = DateTime.Today;
            SurveyDate = DateTime.Today;
        }


    }

    public class JobCardDisplay
    {
        public string JobCardNumber  { get; set; }
        public string SMME { get; set; }
        public string Ward { get; set; }
        public string HouseAddress { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime AssessmentDate { get; set; }
    }
}
