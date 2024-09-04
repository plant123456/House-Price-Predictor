
namespace NEA
{
    partial class AddUnemploymentRate
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
            this.LblUnemploymentRate = new System.Windows.Forms.Label();
            this.LblUnemploymentDate = new System.Windows.Forms.Label();
            this.TxtInstructions = new System.Windows.Forms.TextBox();
            this.BtnUnemploymentRate = new System.Windows.Forms.Button();
            this.BtnMainMenu = new System.Windows.Forms.Button();
            this.NUDRegionID = new System.Windows.Forms.NumericUpDown();
            this.NUDUnemploymentRate = new System.Windows.Forms.NumericUpDown();
            this.DTPUnemploymentRateDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.NUDRegionID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDUnemploymentRate)).BeginInit();
            this.SuspendLayout();
            // 
            // LblRegion
            // 
            this.LblRegion.AutoSize = true;
            this.LblRegion.Location = new System.Drawing.Point(34, 39);
            this.LblRegion.Name = "LblRegion";
            this.LblRegion.Size = new System.Drawing.Size(112, 25);
            this.LblRegion.TabIndex = 0;
            this.LblRegion.Text = "Region ID:";
            // 
            // LblUnemploymentRate
            // 
            this.LblUnemploymentRate.AutoSize = true;
            this.LblUnemploymentRate.Location = new System.Drawing.Point(34, 94);
            this.LblUnemploymentRate.Name = "LblUnemploymentRate";
            this.LblUnemploymentRate.Size = new System.Drawing.Size(243, 25);
            this.LblUnemploymentRate.TabIndex = 1;
            this.LblUnemploymentRate.Text = "Unemployment rate (%):";
            // 
            // LblUnemploymentDate
            // 
            this.LblUnemploymentDate.AutoSize = true;
            this.LblUnemploymentDate.Location = new System.Drawing.Point(34, 153);
            this.LblUnemploymentDate.Name = "LblUnemploymentDate";
            this.LblUnemploymentDate.Size = new System.Drawing.Size(252, 25);
            this.LblUnemploymentDate.TabIndex = 2;
            this.LblUnemploymentDate.Text = "Unemployment rate date:";
            // 
            // TxtInstructions
            // 
            this.TxtInstructions.Location = new System.Drawing.Point(471, 39);
            this.TxtInstructions.Multiline = true;
            this.TxtInstructions.Name = "TxtInstructions";
            this.TxtInstructions.ReadOnly = true;
            this.TxtInstructions.Size = new System.Drawing.Size(297, 322);
            this.TxtInstructions.TabIndex = 6;
            this.TxtInstructions.Text = "The following Region IDs are:\r\n\r\n1 - North East\r\n2 - North West\r\n3 - Yorkshire an" +
    "d the Humber\r\n4 - East Midlands\r\n5 - West Midlands\r\n6 - East\r\n7 - London\r\n8 - So" +
    "uth East\r\n9 - South West";
            // 
            // BtnUnemploymentRate
            // 
            this.BtnUnemploymentRate.Location = new System.Drawing.Point(38, 225);
            this.BtnUnemploymentRate.Name = "BtnUnemploymentRate";
            this.BtnUnemploymentRate.Size = new System.Drawing.Size(361, 57);
            this.BtnUnemploymentRate.TabIndex = 7;
            this.BtnUnemploymentRate.Text = "Add Unemployment rate to the Database";
            this.BtnUnemploymentRate.UseVisualStyleBackColor = true;
            this.BtnUnemploymentRate.Click += new System.EventHandler(this.BtnUnemploymentRate_Click);
            // 
            // BtnMainMenu
            // 
            this.BtnMainMenu.Location = new System.Drawing.Point(38, 305);
            this.BtnMainMenu.Name = "BtnMainMenu";
            this.BtnMainMenu.Size = new System.Drawing.Size(361, 56);
            this.BtnMainMenu.TabIndex = 8;
            this.BtnMainMenu.Text = "Main Menu";
            this.BtnMainMenu.UseVisualStyleBackColor = true;
            this.BtnMainMenu.Click += new System.EventHandler(this.BtnMainMenu_Click);
            // 
            // NUDRegionID
            // 
            this.NUDRegionID.Location = new System.Drawing.Point(292, 40);
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
            this.NUDRegionID.Size = new System.Drawing.Size(157, 31);
            this.NUDRegionID.TabIndex = 9;
            this.NUDRegionID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NUDUnemploymentRate
            // 
            this.NUDUnemploymentRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NUDUnemploymentRate.Location = new System.Drawing.Point(292, 94);
            this.NUDUnemploymentRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NUDUnemploymentRate.Name = "NUDUnemploymentRate";
            this.NUDUnemploymentRate.Size = new System.Drawing.Size(157, 31);
            this.NUDUnemploymentRate.TabIndex = 10;
            this.NUDUnemploymentRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // DTPUnemploymentRateDate
            // 
            this.DTPUnemploymentRateDate.Location = new System.Drawing.Point(292, 153);
            this.DTPUnemploymentRateDate.MaxDate = new System.DateTime(2022, 4, 8, 0, 0, 0, 0);
            this.DTPUnemploymentRateDate.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.DTPUnemploymentRateDate.Name = "DTPUnemploymentRateDate";
            this.DTPUnemploymentRateDate.Size = new System.Drawing.Size(157, 31);
            this.DTPUnemploymentRateDate.TabIndex = 11;
            this.DTPUnemploymentRateDate.Value = new System.DateTime(2022, 4, 8, 0, 0, 0, 0);
            // 
            // AddUnemploymentRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DTPUnemploymentRateDate);
            this.Controls.Add(this.NUDUnemploymentRate);
            this.Controls.Add(this.NUDRegionID);
            this.Controls.Add(this.BtnMainMenu);
            this.Controls.Add(this.BtnUnemploymentRate);
            this.Controls.Add(this.TxtInstructions);
            this.Controls.Add(this.LblUnemploymentDate);
            this.Controls.Add(this.LblUnemploymentRate);
            this.Controls.Add(this.LblRegion);
            this.Name = "AddUnemploymentRate";
            this.Text = "AddUnemploymentRate";
            ((System.ComponentModel.ISupportInitialize)(this.NUDRegionID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDUnemploymentRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblRegion;
        private System.Windows.Forms.Label LblUnemploymentRate;
        private System.Windows.Forms.Label LblUnemploymentDate;
        private System.Windows.Forms.TextBox TxtInstructions;
        private System.Windows.Forms.Button BtnUnemploymentRate;
        private System.Windows.Forms.Button BtnMainMenu;
        private System.Windows.Forms.NumericUpDown NUDRegionID;
        private System.Windows.Forms.NumericUpDown NUDUnemploymentRate;
        private System.Windows.Forms.DateTimePicker DTPUnemploymentRateDate;
    }
}