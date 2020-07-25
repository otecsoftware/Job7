using Job.JobCards;
using Job.Proccessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Job.Surveys;

namespace Job
{
    public partial class Job_Update : Form
    {
        Proccessing.Proccessing jobCardProccessing;
        string GobaljobCardNumber = String.Empty;

        public Job_Update()
        {
            InitializeComponent();
        }
        private void Job_Update_Load(object sender, EventArgs e)
        {
            DoLoad();
        }
        private void button1_Click(object sender, EventArgs e) // Search Job Card
        {
            JobCard jobCard = new JobCard();
            string jobCardNumber = String.Empty;
            jobCardNumber = cbx_JV_JobCardNumber.SelectedItem.ToString();
            jobCard = jobCardProccessing.SearchJobCardByJobCardNumber(jobCardNumber);
            JobCard_SetPopulateShareProperties(jobCard);
            JobCard_SetItemsProperties(jobCard);
            GobaljobCardNumber = jobCardNumber;
        }

        private void Btn_UpdateJobCard_Click(object sender, EventArgs e)
        {
            JobCard jobCard = new JobCard();
            jobCard = JobCard_GetPopulateShareProperties(jobCard);
            jobCard = JobCard_GetCompletionCertificate_Properties(jobCard);
            jobCard = JobCard_GetQA2_Properties(jobCard);
            jobCard = JobCard_GetSignitures(jobCard);

            jobCardProccessing.UpdateJobCard(jobCard);

            ReLoad();
        }

        public void DoLoad()
        {
            jobCardProccessing = new Proccessing.Proccessing();
            List<JobCard> allJobCards = new List<JobCard>();
            allJobCards = jobCardProccessing.GetAllJobCards();

            foreach (JobCard jobCard in allJobCards)
            {
                cbx_JV_JobCardNumber.Items.Add(jobCard.JobCardNumber);
            }
        }
        public void ReLoad()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            DoLoad();
        }

        #region Set Control Values 



        public void JobCard_SetItemsProperties(JobCard jobCard)
        {
            dgv_Material_tbp_JV_ScheduleMaterials.DataSource = jobCard.JobCardItems.ToList();
        }


        public void JobCard_SetPopulateShareProperties(JobCard jobCard)
        {
            txt_JV_Partner.Text = jobCard.JPartner;
            txt_JV_StandNo.Text = jobCard.StandNo;
            txt_JV_SGStand.Text = jobCard.SGStand;
            txt_JV_Address.Text = jobCard.HouseAddress;
            txt_JV_Surburb.Text = jobCard.Ward;
            txt_JV_AltStand.Text = jobCard.Alt_Stand;
            txt_JV_Block.Text = jobCard.BlockSub;
            chk_JV_MetroAucthChecked.Checked = jobCard.MetroAuthChecked;
            dtp_JV_SurveyDate.Value = jobCard.SurveyDate;
            dtp_JV_JobCardDate.Value = jobCard.JobCardDate;
            txt_JV_Subconractor.Text = jobCard.SMME;
            txt_JV_MeterSerialNo.Text = jobCard.MeterSerialNo;

            if (jobCard.CompletionCert_SignedByCustomer)
            {
                rad_JV_CompletionCert_SignedByCustomer_Y.Checked = true;
            }
            else
            {
                rad_JV_CompletionCert_SignedByCustomer_N.Checked = true;
            }
            txt_JV_CompletionCert_WorkPerformedBy.Text = jobCard.WorkPerformedPrint;
            dtp_JV_CompletionCert_DateCompleted.Value = DateTime.Today;

            txt_JV_Signitures_QCT_Name.Text = jobCard.QC_TechnicianName;
            txt_JV_Signitures_SubContructor_Name.Text = jobCard.SubContractor_TechnicianName;

            if (jobCard.QC_Signed)
            {
                rad_JV_Signitures_QCT_SignedY.Checked = true;
            }
            else
            {
                rad_JV_Signitures_QCT_SignedN.Checked = true;
            }

            if (jobCard.SubContractor_Signed)
            {
                rad_JV_Signitures_SubContructor_SignedY.Checked = true;
            }
            else
            {
                rad_JV_Signitures_QCT_SignedN.Checked = true;
            }
        }


        #endregion


        #region Get Control Values

        public JobCard JobCard_GetPopulateShareProperties(JobCard jobCard)
        {
            jobCard.JPartner = txt_JV_Partner.Text;
            jobCard.StandNo = txt_JV_StandNo.Text;
            jobCard.SGStand = txt_JV_SGStand.Text;
            jobCard.HouseAddress = txt_JV_Address.Text;
            jobCard.Ward = txt_JV_Surburb.Text;
            jobCard.Alt_Stand = txt_JV_AltStand.Text;
            jobCard.BlockSub = txt_JV_Block.Text;
            jobCard.MetroAuthChecked = chk_JV_MetroAucthChecked.Checked;
            jobCard.SurveyDate = dtp_JV_SurveyDate.Value;
            jobCard.JobCardDate = dtp_JV_JobCardDate.Value;
            jobCard.SMME = txt_JV_Subconractor.Text;
            jobCard.MeterSerialNo = txt_JV_MeterSerialNo.Text;
            jobCard.OrderDate = dtp_JV_Mtr_OrderDate.Value;
            jobCard.JobCardNumber = GobaljobCardNumber;

            if (rad_JV_StandNo_VariationOrdeY.Checked)
            {
                jobCard.VariationOrder = true;
            }

            jobCard.MeterOrder = chk_JV_MeterOrder.Checked;


            return jobCard;

        }








        public JobCard JobCard_GetCompletionCertificate_Properties(JobCard jobCard)
        {
            if (rad_JV_CompletionCert_SignedByCustomer_Y.Checked)
            {
                jobCard.CompletionCert_SignedByCustomer = true;
            }

            jobCard.WorkPerformedPrint = txt_JV_CompletionCert_WorkPerformedBy.Text;
            jobCard.CompletionCert_DateCompleted = dtp_JV_CompletionCert_DateCompleted.Value;
            return jobCard;
        }

        public JobCard JobCard_GetQA2_Properties(JobCard jobCard)
        {
            jobCard.SurveytoBeDone = txt_JV_QA2_SurveyToBeDone.Text;
            jobCard.GateLock1 = chk_JV_QA2_GateLock1.Checked;
            jobCard.GateLock2 = chk_JV_QA2_GateLock2.Checked;
            jobCard.GateLock3 = chk_JV_QA2_GateLock3.Checked;

            jobCard.CLOSig1 = chk_JV_QA2_CLOConfirmSigned1.Checked;
            jobCard.CLOSig2 = chk_JV_QA2_CLOConfirmSigned2.Checked;
            jobCard.CLOSig3 = chk_JV_QA2_CLOConfirmSigned3.Checked;

            jobCard.SMMESig1 = chk_JV_QA2_Smme1.Checked;
            jobCard.SMMESig2 = chk_JV_QA2_Smme2.Checked;
            jobCard.SMMESig3 = chk_JV_QA2_Smme3.Checked;

            return jobCard;
        }

        public JobCard JobCard_GetSignitures(JobCard jobCard)
        {
            jobCard.QC_TechnicianName = txt_JV_Signitures_QCT_Name.Text;
            jobCard.SubContractor_TechnicianName = txt_JV_Signitures_SubContructor_Name.Text;

            if (rad_JV_Signitures_QCT_SignedY.Checked)
            {
                jobCard.QC_Signed = true;
            }


            if (rad_JV_Signitures_SubContructor_SignedY.Checked)
            {
                jobCard.SubContractor_Signed = true;
            }

            return jobCard;

        }


        #endregion

        private void cbx_JV_JobCardNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addNewSMMEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void surveysToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void captureSurveyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form homeF = new HomeForm();
            homeF.ShowDialog();
            this.Close();
        }

        private void viewSurveysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Surveyform = new SurveyView();
            Surveyform.ShowDialog();
            this.Close();
        }
    }

}
