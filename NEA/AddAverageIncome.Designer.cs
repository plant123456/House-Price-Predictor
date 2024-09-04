
namespace NEA
{
    partial class AddAverageIncome
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
            this.LblAverageIncome = new System.Windows.Forms.Label();
            this.LblAverageIncomeDate = new System.Windows.Forms.Label();
            this.TxtInstructions = new System.Windows.Forms.TextBox();
            this.BtnAddAverageIncome = new System.Windows.Forms.Button();
            this.BtnMainMenu = new System.Windows.Forms.Button();
            this.NUDRegionID = new System.Windows.Forms.NumericUpDown();
            this.NUDAverageIncome = new System.Windows.Forms.NumericUpDown();
            this.DTPAverageIncomeDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.NUDRegionID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAverageIncome)).BeginInit();
            this.SuspendLayout();
            // 
            // LblRegion
            // 
            this.LblRegion.AutoSize = true;
            this.LblRegion.Location = new System.Drawing.Point(33, 35);
            this.LblRegion.Name = "LblRegion";
            this.LblRegion.Size = new System.Drawing.Size(112, 25);
            this.LblRegion.TabIndex = 0;
            this.LblRegion.Text = "Region ID:";
            // 
            // LblAverageIncome
            // 
            this.LblAverageIncome.AutoSize = true;
            this.LblAverageIncome.Location = new System.Drawing.Point(33, 97);
            this.LblAverageIncome.Name = "LblAverageIncome";
            this.LblAverageIncome.Size = new System.Drawing.Size(205, 25);
            this.LblAverageIncome.TabIndex = 1;
            this.LblAverageIncome.Text = "Average Income (£):";
            // 
            // LblAverageIncomeDate
            // 
            this.LblAverageIncomeDate.AutoSize = true;
            this.LblAverageIncomeDate.Location = new System.Drawing.Point(33, 166);
            this.LblAverageIncomeDate.Name = "LblAverageIncomeDate";
            this.LblAverageIncomeDate.Size = new System.Drawing.Size(224, 25);
            this.LblAverageIncomeDate.TabIndex = 2;
            this.LblAverageIncomeDate.Text = "Average Income Date:";
            // 
            // TxtInstructions
            // 
            this.TxtInstructions.Location = new System.Drawing.Point(443, 32);
            this.TxtInstructions.Multiline = true;
            this.TxtInstructions.Name = "TxtInstructions";
            this.TxtInstructions.ReadOnly = true;
            this.TxtInstructions.Size = new System.Drawing.Size(307, 315);
            this.TxtInstructions.TabIndex = 6;
            this.TxtInstructions.Text = "The following Region IDs are:\r\n\r\n1 - North East\r\n2 - North West\r\n3 - Yorkshire an" +
    "d the Humber\r\n4 - East Midlands\r\n5 - West Midlands\r\n6 - East\r\n7 - London\r\n8 - So" +
    "uth East\r\n9 - South West";
            // 
            // BtnAddAverageIncome
            // 
            this.BtnAddAverageIncome.Location = new System.Drawing.Point(40, 232);
            this.BtnAddAverageIncome.Name = "BtnAddAverageIncome";
            this.BtnAddAverageIncome.Size = new System.Drawing.Size(334, 46);
            this.BtnAddAverageIncome.TabIndex = 7;
            this.BtnAddAverageIncome.Text = "Add Average Income to the Database";
            this.BtnAddAverageIncome.UseVisualStyleBackColor = true;
            this.BtnAddAverageIncome.Click += new System.EventHandler(this.BtnAddAverageIncome_Click);
            // 
            // BtnMainMenu
            // 
            this.BtnMainMenu.Location = new System.Drawing.Point(40, 298);
            this.BtnMainMenu.Name = "BtnMainMenu";
            this.BtnMainMenu.Size = new System.Drawing.Size(335, 49);
            this.BtnMainMenu.TabIndex = 8;
            this.BtnMainMenu.Text = "Main Menu";
            this.BtnMainMenu.UseVisualStyleBackColor = true;
            this.BtnMainMenu.Click += new System.EventHandler(this.BtnMainMenu_Click);
            // 
            // NUDRegionID
            // 
            this.NUDRegionID.Location = new System.Drawing.Point(263, 35);
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
            this.NUDRegionID.Size = new System.Drawing.Size(149, 31);
            this.NUDRegionID.TabIndex = 9;
            this.NUDRegionID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NUDAverageIncome
            // 
            this.NUDAverageIncome.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUDAverageIncome.Location = new System.Drawing.Point(263, 95);
            this.NUDAverageIncome.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NUDAverageIncome.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDAverageIncome.Name = "NUDAverageIncome";
            this.NUDAverageIncome.Size = new System.Drawing.Size(149, 31);
            this.NUDAverageIncome.TabIndex = 10;
            this.NUDAverageIncome.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DTPAverageIncomeDate
            // 
            this.DTPAverageIncomeDate.Location = new System.Drawing.Point(263, 166);
            this.DTPAverageIncomeDate.MaxDate = new System.DateTime(2022, 4, 8, 0, 0, 0, 0);
            this.DTPAverageIncomeDate.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.DTPAverageIncomeDate.Name = "DTPAverageIncomeDate";
            this.DTPAverageIncomeDate.Size = new System.Drawing.Size(150, 31);
            this.DTPAverageIncomeDate.TabIndex = 11;
            this.DTPAverageIncomeDate.Value = new System.DateTime(2022, 4, 8, 0, 0, 0, 0);
            // 
            // AddAverageIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DTPAverageIncomeDate);
            this.Controls.Add(this.NUDAverageIncome);
            this.Controls.Add(this.NUDRegionID);
            this.Controls.Add(this.BtnMainMenu);
            this.Controls.Add(this.BtnAddAverageIncome);
            this.Controls.Add(this.TxtInstructions);
            this.Controls.Add(this.LblAverageIncomeDate);
            this.Controls.Add(this.LblAverageIncome);
            this.Controls.Add(this.LblRegion);
            this.Name = "AddAverageIncome";
            this.Text = "AddAverageIncome";
            ((System.ComponentModel.ISupportInitialize)(this.NUDRegionID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAverageIncome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblRegion;
        private System.Windows.Forms.Label LblAverageIncome;
        private System.Windows.Forms.Label LblAverageIncomeDate;
        private System.Windows.Forms.TextBox TxtInstructions;
        private System.Windows.Forms.Button BtnAddAverageIncome;
        private System.Windows.Forms.Button BtnMainMenu;
        private System.Windows.Forms.NumericUpDown NUDRegionID;
        private System.Windows.Forms.NumericUpDown NUDAverageIncome;
        private System.Windows.Forms.DateTimePicker DTPAverageIncomeDate;
    }
}