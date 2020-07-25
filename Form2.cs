using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Job.ProccessingNS;
using Job.Surveys;

namespace Job
{
    public partial class frmCaptureItems : Form
    {
        Proccessing proccessing;

        public frmCaptureItems()
        {
            proccessing = new Proccessing();
            InitializeComponent();
        }



        private void btnSaveItem_Click(object sender, EventArgs e)
        {
            SurveyItem surveyItem = new SurveyItem();


            surveyItem.ItemDescription = txtCaptureItem.Text;


            if(double.TryParse(txtCaptureMaterialPrice.Text,out double materialPrice))
            {
                surveyItem.MaterialPrice = materialPrice;
            }

            if (double.TryParse(txtCaptureLabourRate.Text, out double labourRate))
            {
                surveyItem.LabourPrice = labourRate;
            }


            proccessing.AddItemDatabase(surveyItem);

        }

        private void frmCaptureItems_Load(object sender, EventArgs e)
        {

        }
    }
}
