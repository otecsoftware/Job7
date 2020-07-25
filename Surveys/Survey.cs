using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.Surveys
{
    public class SurveyDisplay
    {
        public string JobCardNumber { get; set; }
        public string Township { get; set; }
        public string Ward { get; set; }
        public string Consortium { get; set; }
        public string SMME { get; set; }
   
    }

    public class Survey
    {
        Database.DatabaseContext databaseContext = new Database.DatabaseContext();
        public Survey()
        {
            databaseContext = new Database.DatabaseContext();
        }
        public int SurveyID { get; set; }
        #region Shared
        public string JobCardNumber { get; set; }

        public bool SLASigned { get; set; }
        public bool ProvidedMaterial { get; set; }

        public string Township { get; set; }
        public string Ward { get; set; }
        public string Consortium { get; set; }
        public string SMME { get; set; }
        public bool JWApprove { get; set; }
        public bool ConractSigned { get; set; }
        public DateTime AssessmentDate { get; set; }
        public string Section1_ExistingYardConnection_PipeRequired { get; set; }
        public string Section3_MeterDetails_Make { get; set; }
        public string Section3_MeterDetails_SerialNo { get; set; }
        public DateTime Section3_ABC_date { get; set; }
        public string Section3_DST_nameSurname { get; set; }
        public DateTime Section3_GFL_date { get; set; }
        public bool Section3_GateLocked { get; set; }
        public bool Section3_DST_Signiture { get; set; }
        public bool Section3_ABC_signature { get; set; }
        public string Section3_DST_ConsordiamIDno { get; set; }
        public int Reducer { get; set; }
        public string Comments { get; set; }

        public List<SurveyItem> CurrentSurveyItems;

        #endregion
        #region Section 1
        #region Section1-YardConnection
        public bool ExistingMeter { get; set; }
        public bool ExistingGate { get; set; }
        public bool Earthing { get; set; }
        public int DistanceFromBoundry { get; set; }
        #endregion
  

        #endregion

        #region Get methods
        public Survey GetsurveyByID(string surveyId)
        {
            Survey survey = new Survey();
            //databaseContext.GetSurveyFromDatabase(surveyId);
            return survey;
        }
        public Survey GetsurveyByJobCardId(int jobcardId)
        {
            Survey survey = new Survey();
            databaseContext.GetSurveyFromDatabase(jobcardId);
            return survey;
        }
        #endregion

        #region Set methods
        public void SetSurveyProperty(int surveyId, string propertyName, dynamic propertyValue)
        {
            string sqlString;

            if (propertyName == "ID Number ")
            {
                sqlString = "Table Name Set IdNumber = " + propertyValue;
            }
            if (propertyName == "Date Of Birth")
            {
                sqlString = "Table Name Set DOB = " + (DateTime)propertyValue;
            }
        }
        #endregion


    }
}
