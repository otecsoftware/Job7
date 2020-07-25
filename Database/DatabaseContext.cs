using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Job.JobCards;
using Job.Surveys;
using Job.SMMES;


namespace Job.Database
{
    public class DatabaseContext
    {

        public static string connStr = "Data Source=PHIWOKUHLEN-PC\\SQLEXPRESS;Initial Catalog=JoburgWter;Integrated Security=SSPI;";

        public Survey GetSurveyFromDatabase(int surveyId = 0, int jobcardId = 0)
        {
            Survey survey = new Survey();
            //Get Survey data from database
            return survey;
        }


        public JobCard GetJobCardByJobCardNumber(string jobCardNumber)
        {
            JobCard jobCard = new JobCard();
            DynamicParameters dataParams = new DynamicParameters();
            dataParams.Add("@jobCardNumber", jobCardNumber);
            jobCard = DBContext.ExecuteReturnScalar<JobCard>("sp_GetJobCardByJobCardNumber", dataParams);



            jobCard.JobCardItems = DBContext.ReturnList<SurveyItem>("sp_GetJobCardItemsByJobCardNumber", dataParams).ToList();
  

            return jobCard;
        }

        public List<JobCard> GetAllJobCardByJobCards()
        {
            List<JobCard> jobCards = new List<JobCard>();
            DynamicParameters dataParams = new DynamicParameters();
            jobCards = DBContext.ReturnList<JobCard>("sp_GetJobCards", null).ToList();
            return jobCards;

        }

        public List<JobCardDisplay> GetAllJobCardByJobCardDisplay()
        {
            List<JobCardDisplay> jobCards = new List<JobCardDisplay>();
            DynamicParameters dataParams = new DynamicParameters();
            jobCards = DBContext.ReturnList<JobCardDisplay>("sp_GetJobCards", null).ToList();
            return jobCards;

        }
        public List<SurveyItem> GetAllSurveyItems()
        {
            List<SurveyItem> items = new List<SurveyItem>();
            DynamicParameters dataParams = new DynamicParameters();
            items = DBContext.ReturnList<SurveyItem>("sp_GetAllItems", null).ToList();
            return items;
        }

        public List<SurveyDisplay> GetAllSurvey()
        {
            List<SurveyDisplay> surveys = new List<SurveyDisplay>();
            DynamicParameters dataParams = new DynamicParameters();
            surveys = DBContext.ReturnList<SurveyDisplay>("sp_GetAllSurvey", null).ToList();
            return surveys;
        }


        public SurveyItem GetSurveyItemByDescription(string description)
        {
            SurveyItem item = new SurveyItem();
            DynamicParameters dataParams = new DynamicParameters();
            dataParams.Add("@description", description);
            item = DBContext.ExecuteReturnScalar<SurveyItem>("sp_GetItemByDescription", dataParams);
            return item;
        }

        public void AddSurveyToDatabase(Survey survey)
        {
            List<SurveyItem> items = new List<SurveyItem>();
            DynamicParameters dataParams = new DynamicParameters();

            dataParams.Add("@JobCardNumber ", survey.JobCardNumber);
            dataParams.Add("@SLASigned", survey.SLASigned);
            dataParams.Add("@ProvidedMaterial", survey.ProvidedMaterial);
            dataParams.Add("@JW_Approve ", survey.JWApprove);
            dataParams.Add("@Township ", survey.Township);
            dataParams.Add("@Ward ", survey.Ward);
            dataParams.Add("@Consortium ", survey.Consortium);
            dataParams.Add("@SMME ", survey.SMME);
            dataParams.Add("@AssessmentDate ", survey.AssessmentDate);
            dataParams.Add("@ContractSigned ", survey.ConractSigned);
            dataParams.Add("@SignedByCustomer ", survey.Section3_ABC_signature);
            dataParams.Add("@DateSignedByCustomer ", survey.Section3_ABC_date);
            dataParams.Add("@GateLocked", survey.Section3_GateLocked);
            dataParams.Add("@DateGateLocked ", survey.Section3_GFL_date);
            dataParams.Add("@NameOfTechnician ", survey.Section3_DST_nameSurname);
            dataParams.Add("@ConsortiumIDNumber ", survey.Section3_DST_ConsordiamIDno);
            dataParams.Add("@TechnicianSigned ", survey.Section3_DST_Signiture);
            dataParams.Add("@SerialNo", survey.Section3_MeterDetails_SerialNo);
            dataParams.Add("@SerialMake ", survey.Section3_MeterDetails_Make);
            dataParams.Add("@PipeSizeMM ", 0);
            dataParams.Add("@YardConnectionM", survey.Section1_ExistingYardConnection_PipeRequired);
            dataParams.Add("@ExistingMeter ", survey.ExistingMeter);
            dataParams.Add("@ExistingGateValve ", survey.ExistingGate);
            dataParams.Add("@Earthing ", survey.Earthing);
            dataParams.Add("@DistanceFromBoundry ", survey.DistanceFromBoundry);
            dataParams.Add("@Reducer", survey.Reducer);
            dataParams.Add("@PipeRequired ", survey.Section1_ExistingYardConnection_PipeRequired);
            dataParams.Add("@Comments ", survey.Comments);


            DBContext.ExecuteWithoutReturn("sp_AddSurveyDetails", dataParams);
        }

        public void AddSurveyItemsToDatabase(string jobCardNumber, List<SurveyItem> items,bool ProvidedMaterial)
        {
            foreach (SurveyItem item in items)
            {
                DynamicParameters dataParams = new DynamicParameters();

                SurveyItem newsurveyItem = GetSurveyItemByDescription(item.ItemDescription);
 
                if (ProvidedMaterial)
                {
                    newsurveyItem.MaterialPrice = 0;
                }

                double charge = newsurveyItem.LabourPrice + newsurveyItem.MaterialPrice;

                dataParams.Add("@ItemDescription", item.ItemDescription);
                dataParams.Add("@JobCardNumber", jobCardNumber);
                dataParams.Add("@Quantity", item.Quantity);
                dataParams.Add("@LabourPrice", newsurveyItem.LabourPrice);
                dataParams.Add("@MaterialPrice", newsurveyItem.MaterialPrice);
                dataParams.Add("@Total", item.Quantity * charge);
                DBContext.ExecuteWithoutReturn("sp_AddSurveyItem", dataParams);
            }
        }
        public Survey GetMostRecentSurvey()
        {
            Survey survey = new Survey();
            DynamicParameters dataParams = new DynamicParameters();
            survey = DBContext.ExecuteReturnScalar<Survey>("sp_GetMostRecentSurvey", null);
            return survey;
        }

        public Survey GetSurveyByJobCardNumber(string jobCardNumber)
        {
            Survey survey = new Survey();
            DynamicParameters dataParams = new DynamicParameters();
            dataParams.Add("@JobCardNumber", jobCardNumber);
            survey = DBContext.ExecuteReturnScalar<Survey>("sp_GetSurveyByJobCardNumber", dataParams);
            return survey;
        }

        


        public Survey GetItemByDescription()
        {
            Survey survey = new Survey();
            DynamicParameters dataParams = new DynamicParameters();
            survey = DBContext.ExecuteReturnScalar<Survey>("sp_GetMostRecentSurvey", null);
            return survey;
        }

        public void AddJobCardToDatabase(JobCard jobCard)
        {
            DynamicParameters dataParams = new DynamicParameters();

            dataParams.Add("@JobCardNumber", jobCard.JobCardNumber);
            dataParams.Add("@JobCardDate", jobCard.JobCardDate);
            dataParams.Add("@SurveyDate", jobCard.SurveyDate);
            dataParams.Add("@SMME", jobCard.SMME);
            dataParams.Add("@Ward", jobCard.Ward);
            dataParams.Add("@HouseAddress", jobCard.HouseAddress);
            dataParams.Add("@Consortium", jobCard.Consortium);
            DBContext.ExecuteWithoutReturn("sp_GenerateNewJobCard", dataParams);
        }

        public List<SMME> GetAllSMMES()
        {
            List<SMME> sMMEs = new List<SMME>();
            DynamicParameters dataParams = new DynamicParameters();
            sMMEs = DBContext.ReturnList<SMME>("sp_GetSMMES", null).ToList();
            return sMMEs;

        }

        public void UpdateJobCard(JobCard jobCard)
        {
            DynamicParameters dataParams = new DynamicParameters();

            dataParams.Add("@JobCardNumber", jobCard.JobCardNumber);
    

            dataParams.Add("@Partner", jobCard.JPartner);
            dataParams.Add("@StandNo", jobCard.StandNo);
            dataParams.Add("@SGStand", jobCard.SGStand);
            dataParams.Add("@Alt_Stand", jobCard.Alt_Stand);
            dataParams.Add("@BlockSub", jobCard.BlockSub);
            dataParams.Add("@HouseAddress", jobCard.HouseAddress);
            dataParams.Add("@MetroAuthChecked", jobCard.MetroAuthChecked);
            dataParams.Add("@MeterSerialNo", jobCard.MeterSerialNo);
            dataParams.Add("@MterterOrderDate", jobCard.OrderDate);
            dataParams.Add("@VariationOrder", jobCard.VariationOrder);
            dataParams.Add("@SMME", jobCard.SMME);
 
            DBContext.ExecuteWithoutReturn("sp_UpdateJobCard", dataParams);
        }

    }

}
