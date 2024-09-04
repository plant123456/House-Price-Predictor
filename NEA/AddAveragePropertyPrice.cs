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
    public partial class AddAveragePropertyPrice : Form
    {
        public AddAveragePropertyPrice()
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
        
        private static SqlConnection conn = null;
        private void BtnAddAPP_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection("Data Source=DESKTOP-4FCU0KI\\SQLEXPRESS;Initial Catalog=NEAdatabase1;Integrated Security=True"))
            {
                conn.Open();

                SqlCommand AddAveragePropertyPrice = new SqlCommand("AddAveragePropertyPrice", conn);

                AddAveragePropertyPrice.CommandType = CommandType.StoredProcedure;

                //Takes user inputted values as parameters

                AddAveragePropertyPrice.Parameters.Add(new SqlParameter("@RegionID", SqlDbType.Int)).Value = Convert.ToInt32(NUDRegionID.Value);
                AddAveragePropertyPrice.Parameters.Add(new SqlParameter("@AveragePropertyPrice", SqlDbType.Int)).Value = Convert.ToInt32(NUDAPP.Value);
                AddAveragePropertyPrice.Parameters.Add(new SqlParameter("@Date", SqlDbType.Date)).Value = DTPAPPDate.Value;

                AddAveragePropertyPrice.ExecuteNonQuery();
            }

            MessageBox.Show("A new average property price has been successfully added to the database");
        }
    }
}
