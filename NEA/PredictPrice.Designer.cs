
namespace NEA
{
    partial class PredictPrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PredictPrice));
            this.lblRegionID = new System.Windows.Forms.Label();
            this.lblRooms = new System.Windows.Forms.Label();
            this.lblBathrooms = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblGarden = new System.Windows.Forms.Label();
            this.lblDriveway = new System.Windows.Forms.Label();
            this.lblSchoolDistance = new System.Windows.Forms.Label();
            this.lblTrainDistance = new System.Windows.Forms.Label();
            this.BtnPredictPrice = new System.Windows.Forms.Button();
            this.txtInstructions = new System.Windows.Forms.TextBox();
            this.BtnMainMenu = new System.Windows.Forms.Button();
            this.LblBedrooms = new System.Windows.Forms.Label();
            this.NUDRegionID = new System.Windows.Forms.NumericUpDown();
            this.NUDRooms = new System.Windows.Forms.NumericUpDown();
            this.NUDBedrooms = new System.Windows.Forms.NumericUpDown();
            this.NUDBathrooms = new System.Windows.Forms.NumericUpDown();
            this.NUDPropertySize = new System.Windows.Forms.NumericUpDown();
            this.NUDGarden = new System.Windows.Forms.NumericUpDown();
            this.NUDDriveway = new System.Windows.Forms.NumericUpDown();
            this.NUDSchoolDistance = new System.Windows.Forms.NumericUpDown();
            this.NUDTrainDistance = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NUDRegionID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDBedrooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDBathrooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPropertySize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDGarden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDDriveway)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSchoolDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTrainDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegionID
            // 
            this.lblRegionID.AutoSize = true;
            this.lblRegionID.Location = new System.Drawing.Point(30, 46);
            this.lblRegionID.Name = "lblRegionID";
            this.lblRegionID.Size = new System.Drawing.Size(112, 25);
            this.lblRegionID.TabIndex = 0;
            this.lblRegionID.Text = "Region ID:";
            // 
            // lblRooms
            // 
            this.lblRooms.AutoSize = true;
            this.lblRooms.Location = new System.Drawing.Point(30, 102);
            this.lblRooms.Name = "lblRooms";
            this.lblRooms.Size = new System.Drawing.Size(148, 25);
            this.lblRooms.TabIndex = 2;
            this.lblRooms.Text = "No. of Rooms:";
            // 
            // lblBathrooms
            // 
            this.lblBathrooms.AutoSize = true;
            this.lblBathrooms.Location = new System.Drawing.Point(30, 203);
            this.lblBathrooms.Name = "lblBathrooms";
            this.lblBathrooms.Size = new System.Drawing.Size(184, 25);
            this.lblBathrooms.TabIndex = 4;
            this.lblBathrooms.Text = "No. of Bathrooms:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(30, 262);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(203, 25);
            this.lblSize.TabIndex = 6;
            this.lblSize.Text = "Property size (m^2):";
            // 
            // lblGarden
            // 
            this.lblGarden.AutoSize = true;
            this.lblGarden.Location = new System.Drawing.Point(30, 327);
            this.lblGarden.Name = "lblGarden";
            this.lblGarden.Size = new System.Drawing.Size(89, 25);
            this.lblGarden.TabIndex = 8;
            this.lblGarden.Text = "Garden:";
            // 
            // lblDriveway
            // 
            this.lblDriveway.AutoSize = true;
            this.lblDriveway.Location = new System.Drawing.Point(30, 388);
            this.lblDriveway.Name = "lblDriveway";
            this.lblDriveway.Size = new System.Drawing.Size(106, 25);
            this.lblDriveway.TabIndex = 10;
            this.lblDriveway.Text = "Driveway:";
            // 
            // lblSchoolDistance
            // 
            this.lblSchoolDistance.AutoSize = true;
            this.lblSchoolDistance.Location = new System.Drawing.Point(30, 449);
            this.lblSchoolDistance.Name = "lblSchoolDistance";
            this.lblSchoolDistance.Size = new System.Drawing.Size(265, 25);
            this.lblSchoolDistance.TabIndex = 12;
            this.lblSchoolDistance.Text = "Distance to school (miles):";
            // 
            // lblTrainDistance
            // 
            this.lblTrainDistance.AutoSize = true;
            this.lblTrainDistance.Location = new System.Drawing.Point(30, 514);
            this.lblTrainDistance.Name = "lblTrainDistance";
            this.lblTrainDistance.Size = new System.Drawing.Size(238, 25);
            this.lblTrainDistance.TabIndex = 14;
            this.lblTrainDistance.Text = "Distance to train (miles)";
            // 
            // BtnPredictPrice
            // 
            this.BtnPredictPrice.Location = new System.Drawing.Point(34, 600);
            this.BtnPredictPrice.Name = "BtnPredictPrice";
            this.BtnPredictPrice.Size = new System.Drawing.Size(320, 38);
            this.BtnPredictPrice.TabIndex = 16;
            this.BtnPredictPrice.Text = "Predict Property Price";
            this.BtnPredictPrice.UseVisualStyleBackColor = true;
            this.BtnPredictPrice.Click += new System.EventHandler(this.BtnPredictPrice_Click);
            // 
            // txtInstructions
            // 
            this.txtInstructions.Location = new System.Drawing.Point(453, 40);
            this.txtInstructions.Multiline = true;
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.ReadOnly = true;
            this.txtInstructions.Size = new System.Drawing.Size(362, 500);
            this.txtInstructions.TabIndex = 17;
            this.txtInstructions.Text = resources.GetString("txtInstructions.Text");
            // 
            // BtnMainMenu
            // 
            this.BtnMainMenu.Location = new System.Drawing.Point(467, 600);
            this.BtnMainMenu.Name = "BtnMainMenu";
            this.BtnMainMenu.Size = new System.Drawing.Size(325, 38);
            this.BtnMainMenu.TabIndex = 18;
            this.BtnMainMenu.Text = "Main Menu";
            this.BtnMainMenu.UseVisualStyleBackColor = true;
            this.BtnMainMenu.Click += new System.EventHandler(this.BtnMainMenu_Click);
            // 
            // LblBedrooms
            // 
            this.LblBedrooms.AutoSize = true;
            this.LblBedrooms.Location = new System.Drawing.Point(30, 150);
            this.LblBedrooms.Name = "LblBedrooms";
            this.LblBedrooms.Size = new System.Drawing.Size(172, 25);
            this.LblBedrooms.TabIndex = 19;
            this.LblBedrooms.Text = "No. of Bedrooms";
            // 
            // NUDRegionID
            // 
            this.NUDRegionID.Location = new System.Drawing.Point(301, 40);
            this.NUDRegionID.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.NUDRegionID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDRegionID.Name = "NUDRegionID";
            this.NUDRegionID.Size = new System.Drawing.Size(120, 31);
            this.NUDRegionID.TabIndex = 21;
            this.NUDRegionID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NUDRooms
            // 
            this.NUDRooms.Location = new System.Drawing.Point(301, 100);
            this.NUDRooms.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NUDRooms.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDRooms.Name = "NUDRooms";
            this.NUDRooms.Size = new System.Drawing.Size(120, 31);
            this.NUDRooms.TabIndex = 22;
            this.NUDRooms.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NUDBedrooms
            // 
            this.NUDBedrooms.Location = new System.Drawing.Point(301, 150);
            this.NUDBedrooms.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NUDBedrooms.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDBedrooms.Name = "NUDBedrooms";
            this.NUDBedrooms.Size = new System.Drawing.Size(120, 31);
            this.NUDBedrooms.TabIndex = 23;
            this.NUDBedrooms.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NUDBathrooms
            // 
            this.NUDBathrooms.Location = new System.Drawing.Point(301, 203);
            this.NUDBathrooms.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NUDBathrooms.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDBathrooms.Name = "NUDBathrooms";
            this.NUDBathrooms.Size = new System.Drawing.Size(120, 31);
            this.NUDBathrooms.TabIndex = 24;
            this.NUDBathrooms.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NUDPropertySize
            // 
            this.NUDPropertySize.DecimalPlaces = 1;
            this.NUDPropertySize.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUDPropertySize.Location = new System.Drawing.Point(301, 271);
            this.NUDPropertySize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUDPropertySize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NUDPropertySize.Name = "NUDPropertySize";
            this.NUDPropertySize.Size = new System.Drawing.Size(120, 31);
            this.NUDPropertySize.TabIndex = 25;
            this.NUDPropertySize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NUDGarden
            // 
            this.NUDGarden.Location = new System.Drawing.Point(301, 327);
            this.NUDGarden.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDGarden.Name = "NUDGarden";
            this.NUDGarden.Size = new System.Drawing.Size(120, 31);
            this.NUDGarden.TabIndex = 26;
            this.NUDGarden.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NUDDriveway
            // 
            this.NUDDriveway.Location = new System.Drawing.Point(301, 388);
            this.NUDDriveway.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDDriveway.Name = "NUDDriveway";
            this.NUDDriveway.Size = new System.Drawing.Size(120, 31);
            this.NUDDriveway.TabIndex = 27;
            this.NUDDriveway.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NUDSchoolDistance
            // 
            this.NUDSchoolDistance.DecimalPlaces = 1;
            this.NUDSchoolDistance.Location = new System.Drawing.Point(301, 449);
            this.NUDSchoolDistance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NUDSchoolDistance.Name = "NUDSchoolDistance";
            this.NUDSchoolDistance.Size = new System.Drawing.Size(120, 31);
            this.NUDSchoolDistance.TabIndex = 28;
            this.NUDSchoolDistance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NUDTrainDistance
            // 
            this.NUDTrainDistance.DecimalPlaces = 1;
            this.NUDTrainDistance.Location = new System.Drawing.Point(301, 514);
            this.NUDTrainDistance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NUDTrainDistance.Name = "NUDTrainDistance";
            this.NUDTrainDistance.Size = new System.Drawing.Size(120, 31);
            this.NUDTrainDistance.TabIndex = 29;
            this.NUDTrainDistance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PredictPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 721);
            this.Controls.Add(this.NUDTrainDistance);
            this.Controls.Add(this.NUDSchoolDistance);
            this.Controls.Add(this.NUDDriveway);
            this.Controls.Add(this.NUDGarden);
            this.Controls.Add(this.NUDPropertySize);
            this.Controls.Add(this.NUDBathrooms);
            this.Controls.Add(this.NUDBedrooms);
            this.Controls.Add(this.NUDRooms);
            this.Controls.Add(this.NUDRegionID);
            this.Controls.Add(this.LblBedrooms);
            this.Controls.Add(this.BtnMainMenu);
            this.Controls.Add(this.txtInstructions);
            this.Controls.Add(this.BtnPredictPrice);
            this.Controls.Add(this.lblTrainDistance);
            this.Controls.Add(this.lblSchoolDistance);
            this.Controls.Add(this.lblDriveway);
            this.Controls.Add(this.lblGarden);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblBathrooms);
            this.Controls.Add(this.lblRooms);
            this.Controls.Add(this.lblRegionID);
            this.Name = "PredictPrice";
            this.Text = "PredictPrice";
            ((System.ComponentModel.ISupportInitialize)(this.NUDRegionID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDBedrooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDBathrooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPropertySize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDGarden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDDriveway)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSchoolDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTrainDistance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegionID;
        private System.Windows.Forms.Label lblRooms;
        private System.Windows.Forms.Label lblBathrooms;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblGarden;
        private System.Windows.Forms.Label lblDriveway;
        private System.Windows.Forms.Label lblSchoolDistance;
        private System.Windows.Forms.Label lblTrainDistance;
        private System.Windows.Forms.Button BtnPredictPrice;
        private System.Windows.Forms.TextBox txtInstructions;
        private System.Windows.Forms.Button BtnMainMenu;
        private System.Windows.Forms.Label LblBedrooms;
        private System.Windows.Forms.NumericUpDown NUDRegionID;
        private System.Windows.Forms.NumericUpDown NUDRooms;
        private System.Windows.Forms.NumericUpDown NUDBedrooms;
        private System.Windows.Forms.NumericUpDown NUDBathrooms;
        private System.Windows.Forms.NumericUpDown NUDPropertySize;
        private System.Windows.Forms.NumericUpDown NUDGarden;
        private System.Windows.Forms.NumericUpDown NUDDriveway;
        private System.Windows.Forms.NumericUpDown NUDSchoolDistance;
        private System.Windows.Forms.NumericUpDown NUDTrainDistance;
    }
}