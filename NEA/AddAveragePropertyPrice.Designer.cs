
namespace NEA
{
    partial class AddAveragePropertyPrice
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
            this.LblAveragePP = new System.Windows.Forms.Label();
            this.LblAPPDate = new System.Windows.Forms.Label();
            this.TxtInstructions = new System.Windows.Forms.TextBox();
            this.BtnAddAPP = new System.Windows.Forms.Button();
            this.BtnMainMenu = new System.Windows.Forms.Button();
            this.NUDRegionID = new System.Windows.Forms.NumericUpDown();
            this.NUDAPP = new System.Windows.Forms.NumericUpDown();
            this.DTPAPPDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.NUDRegionID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAPP)).BeginInit();
            this.SuspendLayout();
            // 
            // LblRegion
            // 
            this.LblRegion.AutoSize = true;
            this.LblRegion.Location = new System.Drawing.Point(32, 32);
            this.LblRegion.Name = "LblRegion";
            this.LblRegion.Size = new System.Drawing.Size(112, 25);
            this.LblRegion.TabIndex = 0;
            this.LblRegion.Text = "Region ID:";
            // 
            // LblAveragePP
            // 
            this.LblAveragePP.AutoSize = true;
            this.LblAveragePP.Location = new System.Drawing.Point(32, 87);
            this.LblAveragePP.Name = "LblAveragePP";
            this.LblAveragePP.Size = new System.Drawing.Size(270, 25);
            this.LblAveragePP.TabIndex = 1;
            this.LblAveragePP.Text = "Average property Price (£):";
            // 
            // LblAPPDate
            // 
            this.LblAPPDate.AutoSize = true;
            this.LblAPPDate.Location = new System.Drawing.Point(32, 149);
            this.LblAPPDate.Name = "LblAPPDate";
            this.LblAPPDate.Size = new System.Drawing.Size(291, 25);
            this.LblAPPDate.TabIndex = 2;
            this.LblAPPDate.Text = "Average Property Price Date:";
            // 
            // TxtInstructions
            // 
            this.TxtInstructions.Location = new System.Drawing.Point(505, 26);
            this.TxtInstructions.Multiline = true;
            this.TxtInstructions.Name = "TxtInstructions";
            this.TxtInstructions.ReadOnly = true;
            this.TxtInstructions.Size = new System.Drawing.Size(283, 319);
            this.TxtInstructions.TabIndex = 6;
            this.TxtInstructions.Text = "The following Region IDs are:\r\n\r\n1 - North East\r\n2 - North West\r\n3 - Yorkshire an" +
    "d the Humber\r\n4 - East Midlands\r\n5 - West Midlands\r\n6 - East\r\n7 - London\r\n8 - So" +
    "uth East\r\n9 - South West";
            // 
            // BtnAddAPP
            // 
            this.BtnAddAPP.Location = new System.Drawing.Point(36, 211);
            this.BtnAddAPP.Name = "BtnAddAPP";
            this.BtnAddAPP.Size = new System.Drawing.Size(371, 58);
            this.BtnAddAPP.TabIndex = 7;
            this.BtnAddAPP.Text = "Add Average Property Price to the Database";
            this.BtnAddAPP.UseVisualStyleBackColor = true;
            this.BtnAddAPP.Click += new System.EventHandler(this.BtnAddAPP_Click);
            // 
            // BtnMainMenu
            // 
            this.BtnMainMenu.Location = new System.Drawing.Point(36, 289);
            this.BtnMainMenu.Name = "BtnMainMenu";
            this.BtnMainMenu.Size = new System.Drawing.Size(371, 56);
            this.BtnMainMenu.TabIndex = 8;
            this.BtnMainMenu.Text = "Main Menu";
            this.BtnMainMenu.UseVisualStyleBackColor = true;
            this.BtnMainMenu.Click += new System.EventHandler(this.BtnMainMenu_Click);
            // 
            // NUDRegionID
            // 
            this.NUDRegionID.Location = new System.Drawing.Point(329, 32);
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
            this.NUDRegionID.Size = new System.Drawing.Size(150, 31);
            this.NUDRegionID.TabIndex = 9;
            this.NUDRegionID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NUDAPP
            // 
            this.NUDAPP.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUDAPP.Location = new System.Drawing.Point(329, 87);
            this.NUDAPP.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.NUDAPP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDAPP.Name = "NUDAPP";
            this.NUDAPP.Size = new System.Drawing.Size(150, 31);
            this.NUDAPP.TabIndex = 10;
            this.NUDAPP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DTPAPPDate
            // 
            this.DTPAPPDate.Location = new System.Drawing.Point(329, 149);
            this.DTPAPPDate.MaxDate = new System.DateTime(2022, 4, 8, 0, 0, 0, 0);
            this.DTPAPPDate.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.DTPAPPDate.Name = "DTPAPPDate";
            this.DTPAPPDate.Size = new System.Drawing.Size(150, 31);
            this.DTPAPPDate.TabIndex = 11;
            this.DTPAPPDate.Value = new System.DateTime(2022, 4, 8, 0, 0, 0, 0);
            // 
            // AddAveragePropertyPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DTPAPPDate);
            this.Controls.Add(this.NUDAPP);
            this.Controls.Add(this.NUDRegionID);
            this.Controls.Add(this.BtnMainMenu);
            this.Controls.Add(this.BtnAddAPP);
            this.Controls.Add(this.TxtInstructions);
            this.Controls.Add(this.LblAPPDate);
            this.Controls.Add(this.LblAveragePP);
            this.Controls.Add(this.LblRegion);
            this.Name = "AddAveragePropertyPrice";
            this.Text = "AddAveragePropertyPrice";
            ((System.ComponentModel.ISupportInitialize)(this.NUDRegionID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAPP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblRegion;
        private System.Windows.Forms.Label LblAveragePP;
        private System.Windows.Forms.Label LblAPPDate;
        private System.Windows.Forms.TextBox TxtInstructions;
        private System.Windows.Forms.Button BtnAddAPP;
        private System.Windows.Forms.Button BtnMainMenu;
        private System.Windows.Forms.NumericUpDown NUDRegionID;
        private System.Windows.Forms.NumericUpDown NUDAPP;
        private System.Windows.Forms.DateTimePicker DTPAPPDate;
    }
}