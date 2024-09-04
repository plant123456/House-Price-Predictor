
namespace NEA
{
    partial class AddCrimeRate
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
            this.LblRegion = new System.Windows.Forms.Label();
            this.LblCrimeRate = new System.Windows.Forms.Label();
            this.LblCrimeRateDate = new System.Windows.Forms.Label();
            this.TxtInstructions = new System.Windows.Forms.TextBox();
            this.BtnAddCrimeRate = new System.Windows.Forms.Button();
            this.BtnMainMenu = new System.Windows.Forms.Button();
            this.NUDRegionID = new System.Windows.Forms.NumericUpDown();
            this.NUDCrimeRate = new System.Windows.Forms.NumericUpDown();
            this.DTPCrimeRateDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.NUDRegionID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCrimeRate)).BeginInit();
            this.SuspendLayout();
            // 
            // LblRegion
            // 
            this.LblRegion.AutoSize = true;
            this.LblRegion.Location = new System.Drawing.Point(24, 40);
            this.LblRegion.Name = "LblRegion";
            this.LblRegion.Size = new System.Drawing.Size(112, 25);
            this.LblRegion.TabIndex = 0;
            this.LblRegion.Text = "Region ID:";
            // 
            // LblCrimeRate
            // 
            this.LblCrimeRate.AutoSize = true;
            this.LblCrimeRate.Location = new System.Drawing.Point(24, 98);
            this.LblCrimeRate.Name = "LblCrimeRate";
            this.LblCrimeRate.Size = new System.Drawing.Size(156, 25);
            this.LblCrimeRate.TabIndex = 1;
            this.LblCrimeRate.Text = "Crime rate (%):";
            // 
            // LblCrimeRateDate
            // 
            this.LblCrimeRateDate.AutoSize = true;
            this.LblCrimeRateDate.Location = new System.Drawing.Point(24, 160);
            this.LblCrimeRateDate.Name = "LblCrimeRateDate";
            this.LblCrimeRateDate.Size = new System.Drawing.Size(165, 25);
            this.LblCrimeRateDate.TabIndex = 2;
            this.LblCrimeRateDate.Text = "Crime rate date:";
            // 
            // TxtInstructions
            // 
            this.TxtInstructions.Location = new System.Drawing.Point(425, 36);
            this.TxtInstructions.Multiline = true;
            this.TxtInstructions.Name = "TxtInstructions";
            this.TxtInstructions.ReadOnly = true;
            this.TxtInstructions.Size = new System.Drawing.Size(296, 338);
            this.TxtInstructions.TabIndex = 6;
            this.TxtInstructions.Text = "The following Region IDs are:\r\n\r\n1 - North East\r\n2 - North West\r\n3 - Yorkshire an" +
    "d the Humber\r\n4 - East Midlands\r\n5 - West Midlands\r\n6 - East\r\n7 - London\r\n8 - So" +
    "uth East\r\n9 - South West";
            // 
            // BtnAddCrimeRate
            // 
            this.BtnAddCrimeRate.Location = new System.Drawing.Point(28, 244);
            this.BtnAddCrimeRate.Name = "BtnAddCrimeRate";
            this.BtnAddCrimeRate.Size = new System.Drawing.Size(312, 53);
            this.BtnAddCrimeRate.TabIndex = 7;
            this.BtnAddCrimeRate.Text = "Add Crime rate to Database";
            this.BtnAddCrimeRate.UseVisualStyleBackColor = true;
            this.BtnAddCrimeRate.Click += new System.EventHandler(this.BtnAddCrimeRate_Click);
            // 
            // BtnMainMenu
            // 
            this.BtnMainMenu.Location = new System.Drawing.Point(28, 321);
            this.BtnMainMenu.Name = "BtnMainMenu";
            this.BtnMainMenu.Size = new System.Drawing.Size(312, 53);
            this.BtnMainMenu.TabIndex = 8;
            this.BtnMainMenu.Text = "Main Menu";
            this.BtnMainMenu.UseVisualStyleBackColor = true;
            this.BtnMainMenu.Click += new System.EventHandler(this.BtnMainMenu_Click);
            // 
            // NUDRegionID
            // 
            this.NUDRegionID.Location = new System.Drawing.Point(195, 40);
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
            this.NUDRegionID.Size = new System.Drawing.Size(170, 31);
            this.NUDRegionID.TabIndex = 9;
            this.NUDRegionID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NUDCrimeRate
            // 
            this.NUDCrimeRate.DecimalPlaces = 1;
            this.NUDCrimeRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NUDCrimeRate.Location = new System.Drawing.Point(195, 98);
            this.NUDCrimeRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NUDCrimeRate.Name = "NUDCrimeRate";
            this.NUDCrimeRate.Size = new System.Drawing.Size(170, 31);
            this.NUDCrimeRate.TabIndex = 10;
            this.NUDCrimeRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // DTPCrimeRateDate
            // 
            this.DTPCrimeRateDate.Location = new System.Drawing.Point(195, 160);
            this.DTPCrimeRateDate.MaxDate = new System.DateTime(2022, 4, 8, 0, 0, 0, 0);
            this.DTPCrimeRateDate.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.DTPCrimeRateDate.Name = "DTPCrimeRateDate";
            this.DTPCrimeRateDate.Size = new System.Drawing.Size(170, 31);
            this.DTPCrimeRateDate.TabIndex = 11;
            this.DTPCrimeRateDate.Value = new System.DateTime(2022, 4, 8, 0, 0, 0, 0);
            // 
            // AddCrimeRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 434);
            this.Controls.Add(this.DTPCrimeRateDate);
            this.Controls.Add(this.NUDCrimeRate);
            this.Controls.Add(this.NUDRegionID);
            this.Controls.Add(this.BtnMainMenu);
            this.Controls.Add(this.BtnAddCrimeRate);
            this.Controls.Add(this.TxtInstructions);
            this.Controls.Add(this.LblCrimeRateDate);
            this.Controls.Add(this.LblCrimeRate);
            this.Controls.Add(this.LblRegion);
            this.Name = "AddCrimeRate";
            this.Text = "AddCrimeRate";
            ((System.ComponentModel.ISupportInitialize)(this.NUDRegionID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCrimeRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblRegion;
        private System.Windows.Forms.Label LblCrimeRate;
        private System.Windows.Forms.Label LblCrimeRateDate;
        private System.Windows.Forms.TextBox TxtInstructions;
        private System.Windows.Forms.Button BtnAddCrimeRate;
        private System.Windows.Forms.Button BtnMainMenu;
        private System.Windows.Forms.NumericUpDown NUDRegionID;
        private System.Windows.Forms.NumericUpDown NUDCrimeRate;
        private System.Windows.Forms.DateTimePicker DTPCrimeRateDate;
    }
}