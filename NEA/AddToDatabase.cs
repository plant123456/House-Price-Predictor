using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NEA
{
    public partial class AddToDatabase : Form
    {
        public AddToDatabase()
        {
            InitializeComponent();
        }
        
        private void BtnMainMenu_Click(object sender, EventArgs e)
        {        
            // Opens a Main Menu form 

            this.Hide();

            MainMenu mainMenu = new MainMenu();

            mainMenu.Show();
        }

        private void BtnAddCrimeRate_Click(object sender, EventArgs e)
        {
            //Opens AddCrimeRate form

            this.Hide();

            AddCrimeRate addCrimeRate = new AddCrimeRate();

            addCrimeRate.Show();
        }
        private void BtnAddUnemploymentRate_Click(object sender, EventArgs e)
        {
            //Opens AddUnemploymentRate form 

            this.Hide();

            AddUnemploymentRate addUnemploymentRate = new AddUnemploymentRate();

            addUnemploymentRate.Show();

        }

        private void BtnAddAPP_Click(object sender, EventArgs e)
        {
            // Opens AddAveragePropertyPrice form 

            this.Hide();

            AddAveragePropertyPrice addAveragePropertyPrice = new AddAveragePropertyPrice();

            addAveragePropertyPrice.Show(); 
        }

        private void BtnAddAverageIncome_Click(object sender, EventArgs e)
        {
            // Opens Add AverageIncome form 

            this.Hide();

            AddAverageIncome addAverageIncome = new AddAverageIncome();

            addAverageIncome.Show();
        }

        private static SqlConnection conn = null;
        private void BtnAddproperty_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection("Data Source=DESKTOP-4FCU0KI\\SQLEXPRESS;Initial Catalog=NEAdatabase1;Integrated Security=True"))
            {
                conn.Open();

                SqlCommand AddProperty = new SqlCommand("AddProperty", conn);

                AddProperty.CommandType = CommandType.StoredProcedure;

                //Takes user inputted values as parameters for the SQL query

                AddProperty.Parameters.Add(new SqlParameter("@Region", SqlDbType.Int)).Value = Convert.ToInt32(NUDRegionID.Value);
                AddProperty.Parameters.Add(new SqlParameter("@PropertyType", SqlDbType.Int)).Value = Convert.ToInt32(NUDPropertyType.Value);
                AddProperty.Parameters.Add(new SqlParameter("@SalePrice", SqlDbType.Int)).Value = Convert.ToSingle(NUDSalePrice.Value);
                AddProperty.Parameters.Add(new SqlParameter("@SaleDate", SqlDbType.Date)).Value = DTPSaleDate.Value;
                AddProperty.Parameters.Add(new SqlParameter("@Rooms", SqlDbType.Int)).Value = Convert.ToInt32(NUDRooms.Value);
                AddProperty.Parameters.Add(new SqlParameter("@Bedrooms", SqlDbType.Int)).Value = Convert.ToInt32(NUDBedrooms.Value);
                AddProperty.Parameters.Add(new SqlParameter("@Bathrooms", SqlDbType.Int)).Value = Convert.ToInt32(NUDBathrooms.Value);
                AddProperty.Parameters.Add(new SqlParameter("@PropertySize", SqlDbType.Real)).Value = Convert.ToSingle(NUDPropertySize.Value);
                AddProperty.Parameters.Add(new SqlParameter("@Garden", SqlDbType.Bit)).Value = Convert.ToInt32(NUDGarden.Value);
                AddProperty.Parameters.Add(new SqlParameter("@Driveway", SqlDbType.Bit)).Value = Convert.ToInt32(NUDDriveway.Value);
                AddProperty.Parameters.Add(new SqlParameter("@SchoolDistance", SqlDbType.Real)).Value = Convert.ToSingle(NUDSchoolDistance.Value);
                AddProperty.Parameters.Add(new SqlParameter("@TrainDistance", SqlDbType.Real)).Value = Convert.ToSingle(NUDTrainDistance.Value);

                AddProperty.ExecuteNonQuery();
            }

            MessageBox.Show("A new property has been successfully added to the database");

        }
    }
}
