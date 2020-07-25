namespace Job
{
    partial class SurveyView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SurveyView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgv_SV_Surveys = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.surveysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.captureSurveyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSurveysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateJobCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sMMESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewSMMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SV_Surveys)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.dgv_SV_Surveys);
            this.groupBox1.Location = new System.Drawing.Point(0, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(2106, 1281);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 32);
            this.label9.TabIndex = 11;
            this.label9.Text = "Surveys View";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Job.Properties.Resources.logo_otec;
            this.pictureBox1.Location = new System.Drawing.Point(803, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // dgv_SV_Surveys
            // 
            this.dgv_SV_Surveys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SV_Surveys.Location = new System.Drawing.Point(397, 154);
            this.dgv_SV_Surveys.Name = "dgv_SV_Surveys";
            this.dgv_SV_Surveys.RowHeadersWidth = 51;
            this.dgv_SV_Surveys.RowTemplate.Height = 24;
            this.dgv_SV_Surveys.Size = new System.Drawing.Size(1024, 405);
            this.dgv_SV_Surveys.TabIndex = 1;
            this.dgv_SV_Surveys.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SV_Surveys_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.surveysToolStripMenuItem,
            this.jobsToolStripMenuItem,
            this.sMMESToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1869, 28);
            this.menuStrip1.TabIndex = 5;
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
            this.captureSurveyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.captureSurveyToolStripMenuItem.Text = "Survey Sheet";
            this.captureSurveyToolStripMenuItem.Click += new System.EventHandler(this.captureSurveyToolStripMenuItem_Click_1);
            // 
            // viewSurveysToolStripMenuItem
            // 
            this.viewSurveysToolStripMenuItem.Name = "viewSurveysToolStripMenuItem";
            this.viewSurveysToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.viewSurveysToolStripMenuItem.Text = "View Surveys";
            this.viewSurveysToolStripMenuItem.Click += new System.EventHandler(this.viewSurveysToolStripMenuItem_Click);
            // 
            // jobsToolStripMenuItem
            // 
            this.jobsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateJobCardToolStripMenuItem});
            this.jobsToolStripMenuItem.Name = "jobsToolStripMenuItem";
            this.jobsToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.jobsToolStripMenuItem.Text = "Jobs ";
            // 
            // updateJobCardToolStripMenuItem
            // 
            this.updateJobCardToolStripMenuItem.Name = "updateJobCardToolStripMenuItem";
            this.updateJobCardToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.updateJobCardToolStripMenuItem.Text = "Update Job Card";
            this.updateJobCardToolStripMenuItem.Click += new System.EventHandler(this.updateJobCardToolStripMenuItem_Click);
            // 
            // sMMESToolStripMenuItem
            // 
            this.sMMESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewSMMEToolStripMenuItem,
            this.addItemToolStripMenuItem});
            this.sMMESToolStripMenuItem.Name = "sMMESToolStripMenuItem";
            this.sMMESToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.sMMESToolStripMenuItem.Text = "Data";
            this.sMMESToolStripMenuItem.Click += new System.EventHandler(this.sMMESToolStripMenuItem_Click);
            // 
            // addNewSMMEToolStripMenuItem
            // 
            this.addNewSMMEToolStripMenuItem.Name = "addNewSMMEToolStripMenuItem";
            this.addNewSMMEToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addNewSMMEToolStripMenuItem.Text = "Add SMME";
            // 
            // addItemToolStripMenuItem
            // 
            this.addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            this.addItemToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addItemToolStripMenuItem.Text = "Add Item";
            // 
            // SurveyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1869, 879);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SurveyView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OTEC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SurveyView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SV_Surveys)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_SV_Surveys;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem surveysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem captureSurveyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSurveysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jobsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateJobCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sMMESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewSMMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addItemToolStripMenuItem;
    }
}