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
    public partial class SurveyView : Form
    {

        Proccessing.Proccessing proccessing;
        public SurveyView()
        {
            InitializeComponent();
        }

        private void SurveyView_Load(object sender, EventArgs e)
        {
            List<SurveyDisplay> surveys = new List<SurveyDisplay>();
            proccessing = new Proccessing.Proccessing();
            surveys = proccessing.GetAllSurveys();
            dgv_SV_Surveys.DataSource = surveys;
        }

        private void captureSurveyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form CaptureStylesheetform = new HomeForm();
            CaptureStylesheetform.ShowDialog();
            this.Close();

        }

        private void viewJobCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void updateJobCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form jobCardUpdate = new Job_Update();
            jobCardUpdate.ShowDialog();
            this.Close();
        }

        private void dgv_SV_Surveys_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {        
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dgv_SV_Surveys.Rows[rowIndex];
            string jobCardNumber = row.Cells[0].Value.ToString();

            try
            {
       
                string message = "Do you want to generate Job Card?";
                string title = "Generate Job Card";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    if (proccessing.DoesJobCardExists(jobCardNumber) == true)
                    {
                        MessageBox.Show("Job Card Already Exists");
                    }
                    else
                    {
                        proccessing.GenerateJobCard(jobCardNumber);
                    }

                    
                }
                else
                {
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Survey Creation Failed :" + ex.ToString());
            }
        }

        private void sMMESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void captureSurveyToolStripMenuItem_Click_1(object sender, EventArgs e)
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
