namespace Job
{
    partial class frmCaptureItems
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCaptureLabourRate = new System.Windows.Forms.TextBox();
            this.txtCaptureMaterialPrice = new System.Windows.Forms.TextBox();
            this.txtCaptureItem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveItem = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.surveysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.captureSurveyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSurveysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewJobCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateJobCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.captureItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sMMESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewSMMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSMMESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateSMMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.surveyReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobCardReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sMMEReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCaptureLabourRate);
            this.groupBox1.Controls.Add(this.txtCaptureMaterialPrice);
            this.groupBox1.Controls.Add(this.txtCaptureItem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(625, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 323);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtCaptureLabourRate
            // 
            this.txtCaptureLabourRate.Location = new System.Drawing.Point(238, 182);
            this.txtCaptureLabourRate.Name = "txtCaptureLabourRate";
            this.txtCaptureLabourRate.Size = new System.Drawing.Size(166, 27);
            this.txtCaptureLabourRate.TabIndex = 2;
            // 
            // txtCaptureMaterialPrice
            // 
            this.txtCaptureMaterialPrice.Location = new System.Drawing.Point(238, 124);
            this.txtCaptureMaterialPrice.Name = "txtCaptureMaterialPrice";
            this.txtCaptureMaterialPrice.Size = new System.Drawing.Size(166, 27);
            this.txtCaptureMaterialPrice.TabIndex = 2;
            // 
            // txtCaptureItem
            // 
            this.txtCaptureItem.Location = new System.Drawing.Point(238, 66);
            this.txtCaptureItem.Name = "txtCaptureItem";
            this.txtCaptureItem.Size = new System.Drawing.Size(166, 27);
            this.txtCaptureItem.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Material price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Labour Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Description";
            // 
            // btnSaveItem
            // 
            this.btnSaveItem.Location = new System.Drawing.Point(1108, 592);
            this.btnSaveItem.Name = "btnSaveItem";
            this.btnSaveItem.Size = new System.Drawing.Size(202, 51);
            this.btnSaveItem.TabIndex = 1;
            this.btnSaveItem.Text = "Save Item";
            this.btnSaveItem.UseVisualStyleBackColor = true;
            this.btnSaveItem.Click += new System.EventHandler(this.btnSaveItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Job.Properties.Resources.logo_otec;
            this.pictureBox1.Location = new System.Drawing.Point(1090, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(28, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1282, 133);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Capture Item Details";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.surveysToolStripMenuItem,
            this.jobsToolStripMenuItem,
            this.itemsToolStripMenuItem,
            this.sMMESToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1322, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // surveysToolStripMenuItem
            // 
            this.surveysToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.captureSurveyToolStripMenuItem,
            this.viewSurveysToolStripMenuItem});
            this.surveysToolStripMenuItem.Name = "surveysToolStripMenuItem";
            this.surveysToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.surveysToolStripMenuItem.Text = "Surveys ";
            // 
            // captureSurveyToolStripMenuItem
            // 
            this.captureSurveyToolStripMenuItem.Name = "captureSurveyToolStripMenuItem";
            this.captureSurveyToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.captureSurveyToolStripMenuItem.Text = "Survey Sheet";
            // 
            // viewSurveysToolStripMenuItem
            // 
            this.viewSurveysToolStripMenuItem.Name = "viewSurveysToolStripMenuItem";
            this.viewSurveysToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.viewSurveysToolStripMenuItem.Text = "View Surveys";
            // 
            // jobsToolStripMenuItem
            // 
            this.jobsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewJobCardsToolStripMenuItem,
            this.updateJobCardToolStripMenuItem});
            this.jobsToolStripMenuItem.Name = "jobsToolStripMenuItem";
            this.jobsToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.jobsToolStripMenuItem.Text = "Jobs ";
            // 
            // viewJobCardsToolStripMenuItem
            // 
            this.viewJobCardsToolStripMenuItem.Name = "viewJobCardsToolStripMenuItem";
            this.viewJobCardsToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.viewJobCardsToolStripMenuItem.Text = "View Job Cards";
            // 
            // updateJobCardToolStripMenuItem
            // 
            this.updateJobCardToolStripMenuItem.Name = "updateJobCardToolStripMenuItem";
            this.updateJobCardToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.updateJobCardToolStripMenuItem.Text = "Update Job Card";
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.captureItemsToolStripMenuItem});
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.itemsToolStripMenuItem.Text = "Items";
            // 
            // captureItemsToolStripMenuItem
            // 
            this.captureItemsToolStripMenuItem.Name = "captureItemsToolStripMenuItem";
            this.captureItemsToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.captureItemsToolStripMenuItem.Text = "Capture Items";
            // 
            // sMMESToolStripMenuItem
            // 
            this.sMMESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewSMMEToolStripMenuItem,
            this.viewSMMESToolStripMenuItem,
            this.updateSMMEToolStripMenuItem});
            this.sMMESToolStripMenuItem.Name = "sMMESToolStripMenuItem";
            this.sMMESToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.sMMESToolStripMenuItem.Text = "SMME\'S";
            // 
            // addNewSMMEToolStripMenuItem
            // 
            this.addNewSMMEToolStripMenuItem.Name = "addNewSMMEToolStripMenuItem";
            this.addNewSMMEToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.addNewSMMEToolStripMenuItem.Text = "Add New SMME";
            // 
            // viewSMMESToolStripMenuItem
            // 
            this.viewSMMESToolStripMenuItem.Name = "viewSMMESToolStripMenuItem";
            this.viewSMMESToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.viewSMMESToolStripMenuItem.Text = "View SMME\'S";
            // 
            // updateSMMEToolStripMenuItem
            // 
            this.updateSMMEToolStripMenuItem.Name = "updateSMMEToolStripMenuItem";
            this.updateSMMEToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.updateSMMEToolStripMenuItem.Text = "Update SMME ";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.surveyReportsToolStripMenuItem,
            this.jobCardReportsToolStripMenuItem,
            this.sMMEReportsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // surveyReportsToolStripMenuItem
            // 
            this.surveyReportsToolStripMenuItem.Name = "surveyReportsToolStripMenuItem";
            this.surveyReportsToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.surveyReportsToolStripMenuItem.Text = "Survey Reports";
            // 
            // jobCardReportsToolStripMenuItem
            // 
            this.jobCardReportsToolStripMenuItem.Name = "jobCardReportsToolStripMenuItem";
            this.jobCardReportsToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.jobCardReportsToolStripMenuItem.Text = "Job Card Reports";
            // 
            // sMMEReportsToolStripMenuItem
            // 
            this.sMMEReportsToolStripMenuItem.Name = "sMMEReportsToolStripMenuItem";
            this.sMMEReportsToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.sMMEReportsToolStripMenuItem.Text = "SMME Reports";
            // 
            // frmCaptureItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 704);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSaveItem);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCaptureItems";
            this.Text = "Capture Items";
            this.Load += new System.EventHandler(this.frmCaptureItems_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveItem;
        private System.Windows.Forms.TextBox txtCaptureLabourRate;
        private System.Windows.Forms.TextBox txtCaptureMaterialPrice;
        private System.Windows.Forms.TextBox txtCaptureItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem surveysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem captureSurveyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSurveysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jobsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewJobCardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateJobCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem captureItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sMMESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewSMMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSMMESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateSMMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem surveyReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jobCardReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sMMEReportsToolStripMenuItem;
    }
}