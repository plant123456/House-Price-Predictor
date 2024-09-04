
namespace NEA
{
    partial class MainMenu
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
            this.BtnDatabaseAdd = new System.Windows.Forms.Button();
            this.BtnPredictPrice = new System.Windows.Forms.Button();
            this.BtnFeatureRelationships = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnDatabaseAdd
            // 
            this.BtnDatabaseAdd.Location = new System.Drawing.Point(179, 74);
            this.BtnDatabaseAdd.Name = "BtnDatabaseAdd";
            this.BtnDatabaseAdd.Size = new System.Drawing.Size(346, 48);
            this.BtnDatabaseAdd.TabIndex = 0;
            this.BtnDatabaseAdd.Text = "Add to Database";
            this.BtnDatabaseAdd.UseVisualStyleBackColor = true;
            this.BtnDatabaseAdd.Click += new System.EventHandler(this.BtnDatabaseAdd_Click);
            // 
            // BtnPredictPrice
            // 
            this.BtnPredictPrice.Location = new System.Drawing.Point(179, 154);
            this.BtnPredictPrice.Name = "BtnPredictPrice";
            this.BtnPredictPrice.Size = new System.Drawing.Size(346, 48);
            this.BtnPredictPrice.TabIndex = 1;
            this.BtnPredictPrice.Text = "Predict Property Price";
            this.BtnPredictPrice.UseVisualStyleBackColor = true;
            this.BtnPredictPrice.Click += new System.EventHandler(this.BtnPredictPrice_Click);
            // 
            // BtnFeatureRelationships
            // 
            this.BtnFeatureRelationships.AutoSize = true;
            this.BtnFeatureRelationships.Location = new System.Drawing.Point(179, 234);
            this.BtnFeatureRelationships.Name = "BtnFeatureRelationships";
            this.BtnFeatureRelationships.Size = new System.Drawing.Size(346, 48);
            this.BtnFeatureRelationships.TabIndex = 2;
            this.BtnFeatureRelationships.Text = "Show Feature/Price Relationships";
            this.BtnFeatureRelationships.UseVisualStyleBackColor = true;
            this.BtnFeatureRelationships.Click += new System.EventHandler(this.BtnFeatureRelationships_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(179, 315);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(346, 48);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Exit Program";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // MainMenu
            // 
            this.ClientSize = new System.Drawing.Size(723, 551);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnFeatureRelationships);
            this.Controls.Add(this.BtnPredictPrice);
            this.Controls.Add(this.BtnDatabaseAdd);
            this.Name = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        #endregion

        private System.Windows.Forms.Button BtnDatabaseAdd;
        private System.Windows.Forms.Button BtnPredictPrice;
        private System.Windows.Forms.Button BtnFeatureRelationships;
        private System.Windows.Forms.Button BtnExit;
    }
}

