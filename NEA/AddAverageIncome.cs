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
    public partial class AddAverageIncome : Form
    {
        public AddAverageIncome()
        {
            InitializeComponent();
        }

        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            //Opens a MainMenu form 

            this.Hide();

            MainMenu mainMenu = new MainMenu();

            mainMenu.Show();
        }

        private static SqlConnection conn = new SqlConnection();
        private void BtnAddAverageIncome_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection("Data Source=DESKTOP-4FCU0KI\\SQLEXPRESS;Initial Catalog=NEAdatabase1;Integrated Security=True"))
            {
                conn.Open();

                SqlCommand AddAverageIncome = new SqlCommand("AddAverageIncome", conn);

                AddAverageIncome.CommandType = CommandType.StoredProcedure;

                //Takes user inputted values as parameters for the SQL query

                AddAverageIncome.Parameters.Add(new SqlParameter("@RegionID", SqlDbType.Int)).Value = Convert.ToInt32(NUDRegionID.Value);
                AddAverageIncome.Parameters.Add(new SqlParameter("@AverageIncome", SqlDbType.Int)).Value = Convert.ToInt32(NUDAverageIncome.Value);
                AddAverageIncome.Parameters.Add(new SqlParameter("@Date", SqlDbType.Date)).Value = DTPAverageIncomeDate.Value;

                AddAverageIncome.ExecuteNonQuery();
            }

            MessageBox.Show("A new average income value has been successfully added to the database");
        }
    }
}
