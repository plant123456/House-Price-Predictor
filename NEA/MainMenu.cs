using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEA
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            //Shows user instructions 

            MessageBox.Show(" INSTRUCTIONS " + " The model uses data on property prices taken from sold properties in England from Nov 2021 to Apr 2022 " + " If you want to the predict the price in later dates you must add new properties and their latest sale transaction using the ‘Add to Database’ Form " + " When Filling in the Forms for ‘Predict Property Price’ and ‘Add to Database’ no inputs can be left blank ");
        }
        private void BtnDatabaseAdd_Click(object sender, EventArgs e)
        {
            // Opens AddToDatabase form 

            AddToDatabase addToDatabase = new AddToDatabase();
            addToDatabase.Show();
            this.Hide();
        }
        private void BtnPredictPrice_Click(object sender, EventArgs e)
        {
            // Opens PredictPrice form 

            PredictPrice predictPrice = new PredictPrice();
            predictPrice.Show();
            this.Hide();
        }  
        private void BtnFeatureRelationships_Click(object sender, EventArgs e)
        {
            // Opens ShowRelationship form 

            ShowRelationship showRelationship = new ShowRelationship();
            showRelationship.Show();
            this.Hide();
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            //Hides Main menu when Exit is clicked 

            this.Hide();
        }

        
    }
}
