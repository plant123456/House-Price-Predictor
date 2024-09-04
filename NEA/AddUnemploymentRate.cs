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
    public partial class AddUnemploymentRate : Form
    {
        public AddUnemploymentRate()
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
        private void BtnUnemploymentRate_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection("Data Source=DESKTOP-4FCU0KI\\SQLEXPRESS;Initial Catalog=NEAdatabase1;Integrated Security=True"))
            {
                conn.Open();

                SqlCommand AddUnemploymentRate = new SqlCommand("AddUnemploymentRate", conn);

                AddUnemploymentRate.CommandType = CommandType.StoredProcedure;

                //Takes user inputted values as parameters

                AddUnemploymentRate.Parameters.Add(new SqlParameter("@RegionID", SqlDbType.Int)).Value = Convert.ToInt32(NUDRegionID.Value);
                AddUnemploymentRate.Parameters.Add(new SqlParameter("@UnemploymentRate", SqlDbType.Real)).Value = Convert.ToSingle(NUDUnemploymentRate.Value);
                AddUnemploymentRate.Parameters.Add(new SqlParameter("@Date", SqlDbType.Date)).Value = DTPUnemploymentRateDate.Value;

                AddUnemploymentRate.ExecuteNonQuery();
            }

            MessageBox.Show("A new unemployment rate has been successfully added to the database");
        }
    }
}
