using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Job.Surveys;
using Job.Proccessing;
using Job.SMMES;

namespace Job
{
    public partial class HomeForm : Form
    {
        public bool ShowMessageBox { get; set; }
        List<SurveyItem> CurrentSurveyItems;


        Proccessing.Proccessing proccessing;

        public HomeForm()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        public void ReLoad()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            DoLoad();
        }
        public void DoLoad()
        {
            proccessing = new Proccessing.Proccessing();

            List<SurveyItem> allSurveyItems = new List<SurveyItem>();
            allSurveyItems = proccessing.GetAllSurveyItems();

            //Create Job Card 
            Survey Lastsurvey = new Survey();
            // Lastsurvey = proccessing.GetMostRecentSurvey();

            string timeValue = DateTime.Now.Hour.ToString();
            string jobCardNumber = "JC" + DateTime.Now.ToString() + timeValue;
            jobCardNumber = jobCardNumber.Replace("/", "");
            jobCardNumber = jobCardNumber.Replace(":", "");
            jobCardNumber = jobCardNumber.Replace(" ", "");
            txt_SA_jobcardNo.Text = jobCardNumber;
            txt_SA_jobcardNo.Enabled = false;
            //End of Job Card Number 



            foreach (SurveyItem surveyItem in allSurveyItems)
            {
                cbo_SurveyItems.Items.Add(surveyItem.ItemDescription);
            }

            CurrentSurveyItems = new List<SurveyItem>();

            dgv_SurveyItems.DataSource = CurrentSurveyItems;


            List<SMME> sMMEs = new List<SMME>();
            sMMEs = proccessing.GetAllSMMES();

            foreach (SMME sMMEItem in sMMEs)
            {
                cbx_SA_SMME.Items.Add(sMMEItem.SMMEName + "-" + sMMEItem.Ward);
            }

        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            DoLoad();
        }


        private void Btn_AddSurveyItem_Click(object sender, EventArgs e)
        {
            SurveyItem surveyItem = new SurveyItem();
            string description = String.Empty;
            description = cbo_SurveyItems.SelectedItem.ToString();
            surveyItem = proccessing.SearchItemsByDescription(description);

            if (int.TryParse(txt_SurveyItemQuantity.Text, out int surveyItemQuantity) == true)
            {
                surveyItem.Quantity = surveyItemQuantity;
            }

            if (surveyItem.Quantity > 0)
            {
                CurrentSurveyItems.Add(surveyItem);
                dgv_SurveyItems.DataSource = new List<SurveyItem>();
                dgv_SurveyItems.DataSource = CurrentSurveyItems;
            }
            else
            {
                MessageBox.Show("Please Enter a valid Quantity");
            }


        }

        private void viewSurveysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Surveyform = new SurveyView();
            Surveyform.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            openFileDialog1.ShowDialog();
        }

        private void viewJobCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form JobCardform = new JobCardView();
            //JobCardform.ShowDialog();
            //this.Close();
        }

        private void updateJobCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form jobCardUpdate = new Job_Update();
            jobCardUpdate.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)// btnSaveAssesment
        {
            Survey survey = new Survey();
            survey = SetSurveyAssessmentSharedProperties(survey);
            survey = SetSurveyAssessmentSection1Properties(survey);
            survey.JobCardNumber = txt_SA_jobcardNo.Text;
            survey.CurrentSurveyItems = CurrentSurveyItems;


            if (ShowMessageBox)
            {
                MessageBox.Show("Please double check your input.");
            }
            else
            {
                try
                {
                    proccessing.AddSurveyToDatabase(survey);
                    proccessing.AddSurveyItemsToDatabase(survey);

                    string message = "Survey Created.Do you want to create Job Card?";
                    string title = "Survey Success";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        proccessing.GenerateJobCard(survey.JobCardNumber);
                        Form jobCardUpdate = new Job_Update();
                        jobCardUpdate.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        ReLoad();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Survey Creation Failed :" + ex.ToString());
                }
            }


        }

       
        public Survey SetSurveyAssessmentSharedProperties(Survey survey)
        {
            survey.JobCardNumber = txt_SA_jobcardNo.Text;
            survey.JWApprove = chk_SA_JwApprove.Checked;
            survey.Township = txt_SA_townShip.Text;
            survey.Ward = txt_SA_ward.Text;
            survey.Consortium = txt_SA_consortium.Text;
            survey.SMME = cbx_SA_SMME.Text;
            survey.AssessmentDate = dtp_SA_assesment.Value;
            survey.ConractSigned = chk_SA_contractSigned.Checked;
            survey.SLASigned = chk_SA_SLA_Signed.Checked;
            survey.ProvidedMaterial = chk_SA_Material.Checked;



            return survey;
        }

        public Survey SetSurveyAssessmentSection1Properties(Survey survey)
        {

            survey.Section1_ExistingYardConnection_PipeRequired = txt_SA_pipeRequired.Text;
            survey.Comments = txt_SA_FR_Comments.Text;
            survey.Section3_MeterDetails_SerialNo = txt_SA_S3_MeterDetails_SerialNo.Text;
            survey.Section3_MeterDetails_Make = txt_SA_S3_MeterDetails_Make.Text;
            survey.Section3_ABC_date = dtp_SA_S3_AcceptedByCust_date.Value;
            survey.Section3_DST_ConsordiamIDno = txt_SA_S3_DetailsOfST_ConIDnumber.Text;
            survey.Section3_DST_nameSurname = txt_SA_S3_DetailsOfST_NameSname.Text;
            survey.Section3_GFL_date = dtp_Section3_GateLockedDate.Value;

            if (rad_SA_GateLockedY.Checked)
            {
                survey.Section3_GateLocked = true;
            }
            else
            {
                survey.Section3_GateLocked = false;
            }

            if (rad_SA_S3_DetailsOfST_SignatureY.Checked)
            {
                survey.Section3_DST_Signiture = true;
            }
            else
            {
                survey.Section3_DST_Signiture = false;
            }
            if (rad_SA_S3_AcceptedByCust_SignatureY.Checked)
            {
                survey.Section3_ABC_signature = true;
            }
            else
            {
                survey.Section3_ABC_signature = false;
            }
            if (rad_SA_ExistingMeterAndMeterB_Y.Checked == true)
            {

                survey.ExistingMeter = true;
            }
            else
            {
                survey.ExistingMeter = false;
            }

            if (int.TryParse(txt_SA_Reducer.Text, out int reducer) == true)
            {
                survey.Reducer = reducer;
            }
            else
            {
                ShowMessageBox = true;
            }

            if (int.TryParse(txt_SA_DistanceFromBoundry.Text, out int distanceFromBoundry) == true)
            {
                survey.DistanceFromBoundry = distanceFromBoundry;
                ShowMessageBox = false;
            }
            else
            {
                ShowMessageBox = true;
            }
            return survey;
        }

        private void captureSurveyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sMMESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}































