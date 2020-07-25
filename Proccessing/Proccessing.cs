using Job.JobCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Job.Database;
using Job.Surveys;
using Job.SMMES;

namespace Job.Proccessing
{
    public class Proccessing
    {
        DatabaseContext databaseContext;
        public Proccessing()
        {
            databaseContext = new DatabaseContext();
        }

        #region Job Card Methods
        public JobCard SearchJobCardByJobCardNumber(string jobCardNumber)
        {
            JobCard jobCard = new JobCard();
            jobCard= databaseContext.GetJobCardByJobCardNumber(jobCardNumber);
            return jobCard;
        }

        public List<JobCard>  GetAllJobCards()
        {
            return databaseContext.GetAllJobCardByJobCards();
        }

        public List<JobCardDisplay> GetAllJobCardDisplay()
        {
            return databaseContext.GetAllJobCardByJobCardDisplay();
        }

        #endregion


        #region Survey Methods 
        public List<SurveyItem> GetAllSurveyItems()
        {
            return databaseContext.GetAllSurveyItems();
        }
        public List<SurveyDisplay> GetAllSurveys()
        {
            return databaseContext.GetAllSurvey();
        }
        public void AddSurveyToDatabase(Survey survey)
        {
             databaseContext.AddSurveyToDatabase(survey);
        }
        public void AddSurveyItemsToDatabase(Survey survey)
        {
            databaseContext.AddSurveyItemsToDatabase(survey.JobCardNumber, survey.CurrentSurveyItems,survey.ProvidedMaterial);
        }

        public SurveyItem SearchItemsByDescription(string itemDescription)
        {
            SurveyItem surveyItem = new SurveyItem();
            surveyItem = databaseContext.GetSurveyItemByDescription(itemDescription);
            return surveyItem;
        }
        public Survey GetMostRecentSurvey()
        {
            Survey survey = new Survey();
            survey = databaseContext.GetMostRecentSurvey();
            return survey;
        }

        public Survey GetSurveyByJobCardNumber(string jobCardNumber)
        {
            Survey survey = new Survey();
            survey = databaseContext.GetSurveyByJobCardNumber(jobCardNumber);
            return survey;
        }


        public void GenerateJobCard(string jobcardNumber)
        {
            Survey survey = new Survey();
            survey = GetSurveyByJobCardNumber(jobcardNumber);
            

            //Create Job Card

            JobCard jobCard = new JobCard();

            jobCard.JobCardNumber = jobcardNumber;
            jobCard.JobCardDate = DateTime.Today;
            jobCard.SurveyDate = survey.AssessmentDate;
            jobCard.SMME = survey.SMME;
            jobCard.Ward = survey.Ward;
            jobCard.HouseAddress = survey.Township;
            jobCard.Consortium = survey.Consortium;


            databaseContext.AddJobCardToDatabase(jobCard);
        }

        #endregion

        public List<SMME> GetAllSMMES()
        {
            List<SMME> sMMEs = new List<SMME>();
            sMMEs = databaseContext.GetAllSMMES();

            return sMMEs;
        }

        public bool DoesJobCardExists(string jobCardNumber)
        {
            JobCard jobCard = new JobCard();
            try
            {
                jobCard = databaseContext.GetJobCardByJobCardNumber(jobCardNumber);
            }
            catch (Exception ex)
            {
                return false;
            }

           

            if(jobCard!=null)
            {
                return true;
            }
            return false;
        }

        public void UpdateJobCard(JobCard jobCard)
        {
            databaseContext.UpdateJobCard(jobCard);
        }

    }
}
