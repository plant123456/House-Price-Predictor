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
    public partial class AddCrimeRate : Form
    {
        public AddCrimeRate()
        {
            InitializeComponent();
        }

        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            //Opens MainMenu form 

            this.Hide();

            MainMenu mainMenu = new MainMenu();

            mainMenu.Show();
        }

        private static SqlConnection conn = new SqlConnection();
        private void BtnAddCrimeRate_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection("Data Source=DESKTOP-4FCU0KI\\SQLEXPRESS;Initial Catalog=NEAdatabase1;Integrated Security=True"))
            {
                conn.Open();

                SqlCommand AddCrimeRate = new SqlCommand("AddCrimeRate", conn);

                AddCrimeRate.CommandType = CommandType.StoredProcedure;

                //Takes user inputted values as parameters for the SQL query

                AddCrimeRate.Parameters.Add(new SqlParameter("@RegionID", SqlDbType.Int)).Value = Convert.ToInt32(NUDRegionID.Value);
                AddCrimeRate.Parameters.Add(new SqlParameter("@CrimeRate", SqlDbType.Real)).Value = Convert.ToSingle(NUDCrimeRate.Value);
                AddCrimeRate.Parameters.Add(new SqlParameter("@Date", SqlDbType.Date)).Value = DTPCrimeRateDate.Value;
                
                AddCrimeRate.ExecuteNonQuery();
            }

            MessageBox.Show("A new crime rate has been successfully added to the database");
        }
    }
}
