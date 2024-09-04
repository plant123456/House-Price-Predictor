
namespace NEA
{
    partial class ShowRelationship
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
            this.TxtInstructions = new System.Windows.Forms.TextBox();
            this.BtnShowRooms = new System.Windows.Forms.Button();
            this.BtnShowBedrooms = new System.Windows.Forms.Button();
            this.BtnShowBathrooms = new System.Windows.Forms.Button();
            this.BtnShowSize = new System.Windows.Forms.Button();
            this.BtnShowSchoolDistance = new System.Windows.Forms.Button();
            this.BtnShowTrainDistance = new System.Windows.Forms.Button();
            this.TxtRegion = new System.Windows.Forms.TextBox();
            this.TxtAPP = new System.Windows.Forms.TextBox();
            this.TxtNorthEastAPP = new System.Windows.Forms.TextBox();
            this.TxtNorthWestAPP = new System.Windows.Forms.TextBox();
            this.TxtYorkshireAPP = new System.Windows.Forms.TextBox();
            this.TxtEastMidlandsAPP = new System.Windows.Forms.TextBox();
            this.TxtWestMidlandsAPP = new System.Windows.Forms.TextBox();
            this.TxtEastAPP = new System.Windows.Forms.TextBox();
            this.TxtLondonAPP = new System.Windows.Forms.TextBox();
            this.TxtSouthEastAPP = new System.Windows.Forms.TextBox();
            this.TxtSouthWestAPP = new System.Windows.Forms.TextBox();
            this.BtnMainMenu = new System.Windows.Forms.Button();
            this.WbViewChart = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // TxtInstructions
            // 
            this.TxtInstructions.Location = new System.Drawing.Point(24, 30);
            this.TxtInstructions.Name = "TxtInstructions";
            this.TxtInstructions.ReadOnly = true;
            this.TxtInstructions.Size = new System.Drawing.Size(467, 26);
            this.TxtInstructions.TabIndex = 0;
            this.TxtInstructions.Text = "Choose a feature below to see the relationship with price:";
            // 
            // BtnShowRooms
            // 
            this.BtnShowRooms.Location = new System.Drawing.Point(24, 90);
            this.BtnShowRooms.Name = "BtnShowRooms";
            this.BtnShowRooms.Size = new System.Drawing.Size(191, 40);
            this.BtnShowRooms.TabIndex = 1;
            this.BtnShowRooms.Text = "No. of rooms";
            this.BtnShowRooms.UseVisualStyleBackColor = true;
            this.BtnShowRooms.Click += new System.EventHandler(this.SetGraphData);
            // 
            // BtnShowBedrooms
            // 
            this.BtnShowBedrooms.Location = new System.Drawing.Point(24, 166);
            this.BtnShowBedrooms.Name = "BtnShowBedrooms";
            this.BtnShowBedrooms.Size = new System.Drawing.Size(191, 40);
            this.BtnShowBedrooms.TabIndex = 2;
            this.BtnShowBedrooms.Text = "No. of bedrooms";
            this.BtnShowBedrooms.UseVisualStyleBackColor = true;
            this.BtnShowBedrooms.Click += new System.EventHandler(this.SetGraphData);

            // 
            // BtnShowBathrooms
            // 
            this.BtnShowBathrooms.Location = new System.Drawing.Point(24, 244);
            this.BtnShowBathrooms.Name = "BtnShowBathrooms";
            this.BtnShowBathrooms.Size = new System.Drawing.Size(191, 40);
            this.BtnShowBathrooms.TabIndex = 3;
            this.BtnShowBathrooms.Text = "No. of bathrooms";
            this.BtnShowBathrooms.UseVisualStyleBackColor = true;
            this.BtnShowBathrooms.Click += new System.EventHandler(this.SetGraphData);

            // 
            // BtnShowSize
            // 
            this.BtnShowSize.Location = new System.Drawing.Point(300, 90);
            this.BtnShowSize.Name = "BtnShowSize";
            this.BtnShowSize.Size = new System.Drawing.Size(191, 40);
            this.BtnShowSize.TabIndex = 4;
            this.BtnShowSize.Text = "Property size";
            this.BtnShowSize.UseVisualStyleBackColor = true;
            this.BtnShowSize.Click += new System.EventHandler(this.SetGraphData);

            // 
            // BtnShowSchoolDistance
            // 
            this.BtnShowSchoolDistance.Location = new System.Drawing.Point(300, 166);
            this.BtnShowSchoolDistance.Name = "BtnShowSchoolDistance";
            this.BtnShowSchoolDistance.Size = new System.Drawing.Size(191, 40);
            this.BtnShowSchoolDistance.TabIndex = 5;
            this.BtnShowSchoolDistance.Text = "Distance to school";
            this.BtnShowSchoolDistance.UseVisualStyleBackColor = true;
            this.BtnShowSchoolDistance.Click += new System.EventHandler(this.SetGraphData);

            // 
            // BtnShowTrainDistance
            // 
            this.BtnShowTrainDistance.Location = new System.Drawing.Point(300, 244);
            this.BtnShowTrainDistance.Name = "BtnShowTrainDistance";
            this.BtnShowTrainDistance.Size = new System.Drawing.Size(191, 40);
            this.BtnShowTrainDistance.TabIndex = 6;
            this.BtnShowTrainDistance.Text = "Distance to train";
            this.BtnShowTrainDistance.UseVisualStyleBackColor = true;
            this.BtnShowTrainDistance.Click += new System.EventHandler(this.SetGraphData);

            // 
            // TxtRegion
            // 
            this.TxtRegion.Location = new System.Drawing.Point(24, 335);
            this.TxtRegion.Multiline = true;
            this.TxtRegion.Name = "TxtRegion";
            this.TxtRegion.ReadOnly = true;
            this.TxtRegion.Size = new System.Drawing.Size(204, 409);
            this.TxtRegion.TabIndex = 7;
            this.TxtRegion.Text = "REGION:  \r\n\r\nNorth East\r\n\r\nNorth West\r\n\r\nYorkshire and the Humber\r\n\r\nEast Midland" +
    "s\r\n\r\nWest Midlands\r\n\r\nEast\r\n\r\nLondon\r\n\r\nSouth East\r\n\r\nSouth West";
            // 
            // TxtAPP
            // 
            this.TxtAPP.Location = new System.Drawing.Point(262, 335);
            this.TxtAPP.Name = "TxtAPP";
            this.TxtAPP.ReadOnly = true;
            this.TxtAPP.Size = new System.Drawing.Size(229, 26);
            this.TxtAPP.TabIndex = 8;
            this.TxtAPP.Text = "Average Property Price 2021";
            // 
            // TxtNorthEastAPP
            // 
            this.TxtNorthEastAPP.Location = new System.Drawing.Point(262, 368);
            this.TxtNorthEastAPP.Name = "TxtNorthEastAPP";
            this.TxtNorthEastAPP.ReadOnly = true;
            this.TxtNorthEastAPP.Size = new System.Drawing.Size(229, 26);
            this.TxtNorthEastAPP.TabIndex = 9;
            // 
            // TxtNorthWestAPP
            // 
            this.TxtNorthWestAPP.Location = new System.Drawing.Point(262, 415);
            this.TxtNorthWestAPP.Name = "TxtNorthWestAPP";
            this.TxtNorthWestAPP.ReadOnly = true;
            this.TxtNorthWestAPP.Size = new System.Drawing.Size(229, 26);
            this.TxtNorthWestAPP.TabIndex = 10;
            // 
            // TxtYorkshireAPP
            // 
            this.TxtYorkshireAPP.Location = new System.Drawing.Point(262, 457);
            this.TxtYorkshireAPP.Name = "TxtYorkshireAPP";
            this.TxtYorkshireAPP.ReadOnly = true;
            this.TxtYorkshireAPP.Size = new System.Drawing.Size(229, 26);
            this.TxtYorkshireAPP.TabIndex = 11;
            // 
            // TxtEastMidlandsAPP
            // 
            this.TxtEastMidlandsAPP.Location = new System.Drawing.Point(262, 500);
            this.TxtEastMidlandsAPP.Name = "TxtEastMidlandsAPP";
            this.TxtEastMidlandsAPP.ReadOnly = true;
            this.TxtEastMidlandsAPP.Size = new System.Drawing.Size(229, 26);
            this.TxtEastMidlandsAPP.TabIndex = 12;
            // 
            // TxtWestMidlandsAPP
            // 
            this.TxtWestMidlandsAPP.Location = new System.Drawing.Point(262, 532);
            this.TxtWestMidlandsAPP.Name = "TxtWestMidlandsAPP";
            this.TxtWestMidlandsAPP.ReadOnly = true;
            this.TxtWestMidlandsAPP.Size = new System.Drawing.Size(229, 26);
            this.TxtWestMidlandsAPP.TabIndex = 13;
            // 
            // TxtEastAPP
            // 
            this.TxtEastAPP.Location = new System.Drawing.Point(262, 574);
            this.TxtEastAPP.Name = "TxtEastAPP";
            this.TxtEastAPP.ReadOnly = true;
            this.TxtEastAPP.Size = new System.Drawing.Size(229, 26);
            this.TxtEastAPP.TabIndex = 14;
            // 
            // TxtLondonAPP
            // 
            this.TxtLondonAPP.Location = new System.Drawing.Point(262, 616);
            this.TxtLondonAPP.Name = "TxtLondonAPP";
            this.TxtLondonAPP.ReadOnly = true;
            this.TxtLondonAPP.Size = new System.Drawing.Size(229, 26);
            this.TxtLondonAPP.TabIndex = 15;
            // 
            // TxtSouthEastAPP
            // 
            this.TxtSouthEastAPP.Location = new System.Drawing.Point(262, 658);
            this.TxtSouthEastAPP.Name = "TxtSouthEastAPP";
            this.TxtSouthEastAPP.ReadOnly = true;
            this.TxtSouthEastAPP.Size = new System.Drawing.Size(229, 26);
            this.TxtSouthEastAPP.TabIndex = 16;
            // 
            // TxtSouthWestAPP
            // 
            this.TxtSouthWestAPP.Location = new System.Drawing.Point(262, 703);
            this.TxtSouthWestAPP.Name = "TxtSouthWestAPP";
            this.TxtSouthWestAPP.ReadOnly = true;
            this.TxtSouthWestAPP.Size = new System.Drawing.Size(229, 26);
            this.TxtSouthWestAPP.TabIndex = 17;
            // 
            // BtnMainMenu
            // 
            this.BtnMainMenu.Location = new System.Drawing.Point(24, 796);
            this.BtnMainMenu.Name = "BtnMainMenu";
            this.BtnMainMenu.Size = new System.Drawing.Size(204, 56);
            this.BtnMainMenu.TabIndex = 18;
            this.BtnMainMenu.Text = "Main Menu";
            this.BtnMainMenu.UseVisualStyleBackColor = true;
            this.BtnMainMenu.Click += new System.EventHandler(this.BtnMainMenu_Click);
            // 
            // WbViewChart
            // 
            this.WbViewChart.Location = new System.Drawing.Point(533, 30);
            this.WbViewChart.MinimumSize = new System.Drawing.Size(20, 20);
            this.WbViewChart.Name = "WbViewChart";
            this.WbViewChart.Size = new System.Drawing.Size(725, 699);
            this.WbViewChart.TabIndex = 19;
            // 
            // ShowRelationship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 1065);
            this.Controls.Add(this.WbViewChart);
            this.Controls.Add(this.BtnMainMenu);
            this.Controls.Add(this.TxtSouthWestAPP);
            this.Controls.Add(this.TxtSouthEastAPP);
            this.Controls.Add(this.TxtLondonAPP);
            this.Controls.Add(this.TxtEastAPP);
            this.Controls.Add(this.TxtWestMidlandsAPP);
            this.Controls.Add(this.TxtEastMidlandsAPP);
            this.Controls.Add(this.TxtYorkshireAPP);
            this.Controls.Add(this.TxtNorthWestAPP);
            this.Controls.Add(this.TxtNorthEastAPP);
            this.Controls.Add(this.TxtAPP);
            this.Controls.Add(this.TxtRegion);
            this.Controls.Add(this.BtnShowTrainDistance);
            this.Controls.Add(this.BtnShowSchoolDistance);
            this.Controls.Add(this.BtnShowSize);
            this.Controls.Add(this.BtnShowBathrooms);
            this.Controls.Add(this.BtnShowBedrooms);
            this.Controls.Add(this.BtnShowRooms);
            this.Controls.Add(this.TxtInstructions);
            this.Name = "ShowRelationship";
            this.Text = "ShowRelationship";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtInstructions;
        private System.Windows.Forms.Button BtnShowRooms;
        private System.Windows.Forms.Button BtnShowBedrooms;
        private System.Windows.Forms.Button BtnShowBathrooms;
        private System.Windows.Forms.Button BtnShowSize;
        private System.Windows.Forms.Button BtnShowSchoolDistance;
        private System.Windows.Forms.Button BtnShowTrainDistance;
        private System.Windows.Forms.TextBox TxtRegion;
        private System.Windows.Forms.TextBox TxtAPP;
        private System.Windows.Forms.TextBox TxtNorthEastAPP;
        private System.Windows.Forms.TextBox TxtNorthWestAPP;
        private System.Windows.Forms.TextBox TxtYorkshireAPP;
        private System.Windows.Forms.TextBox TxtEastMidlandsAPP;
        private System.Windows.Forms.TextBox TxtWestMidlandsAPP;
        private System.Windows.Forms.TextBox TxtEastAPP;
        private System.Windows.Forms.TextBox TxtLondonAPP;
        private System.Windows.Forms.TextBox TxtSouthEastAPP;
        private System.Windows.Forms.TextBox TxtSouthWestAPP;
        private System.Windows.Forms.Button BtnMainMenu;
        private System.Windows.Forms.WebBrowser WbViewChart;
    }
}