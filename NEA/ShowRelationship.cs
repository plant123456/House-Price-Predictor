using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Plotly;
using Plotly.NET;
using Plotly.NET.LayoutObjects;
using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;
using System.Data.SqlClient;

namespace NEA
{
    public partial class ShowRelationship : Form
    {
        public ShowRelationship()
        {
            InitializeComponent();

            AveragePropertyPrices();
        }

        private static SqlConnection conn = new SqlConnection();
        public void SetGraphData(object sender, EventArgs e)
        {
            List<int> yData = GetYData();

            string yAxis = ("Price £");

            string xAxis = "";

            List<float> xData = new List<float>();

            //Calls the correct SQL query depending on which button is selected

            switch (((System.Windows.Forms.Button)sender).Name) 
            {
                case "BtnShowRooms":
                    xAxis = "Number of Rooms";
                    xData = GetXData("ExtractRooms");
                    break;
                case "BtnShowBedrooms":
                    xAxis = "Number of Bedrooms";
                    xData = GetXData("ExtractBedrooms");
                    break;
                case "BtnShowBathrooms":
                    xAxis = "Number of Bathrooms";
                    xData = GetXData("ExtractBathrooms");
                    break;
                case "BtnShowSize":
                    xAxis = "Property size (m^2)";
                    xData = GetXData("ExtractPropertySizes");
                    break;
                case "BtnShowSchoolDistance":
                    xAxis = "Distance to school (miles)";
                    xData = GetXData("ExtractSchoolDistance");
                    break;
                case "BtnShowTrainDistance":
                    xAxis = "Distance to train (miles)";
                    xData = GetXData("ExtractTrainDistance");
                    break;
            }

            CreateGraph(xData, yData, xAxis, yAxis);
        }

        private static List<float> GetXData(string queryName) 
        {
            using (conn = new SqlConnection("Data Source=DESKTOP-4FCU0KI\\SQLEXPRESS;Initial Catalog=NEAdatabase1;Integrated Security=True"))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(queryName, conn);

                command.CommandType = CommandType.StoredProcedure;

                List<float> xData = new List<float>();

                //Adds all the results of the SQL query to a list

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        xData.Add(Convert.ToSingle(reader.GetValue(0)));
                    }
                }

                return xData;
            }
        }

        private static List<int> GetYData()
        {

            using (conn = new SqlConnection("Data Source=DESKTOP-4FCU0KI\\SQLEXPRESS;Initial Catalog=NEAdatabase1;Integrated Security=True"))
            {
                conn.Open();

                SqlCommand ExtractSalePrices = new SqlCommand("ExtractSalePrices", conn);

                ExtractSalePrices.CommandType = CommandType.StoredProcedure;

                List<int> yData = new List<int>();

                //Adds all the results of the SQL query to the list

                using (SqlDataReader reader = ExtractSalePrices.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        yData.Add((int)reader["SalePrice"]);
                    }
                }

                return yData;
            }

        }
        private  void CreateGraph(List<float> xData, List<int> yData, string xAxis, string yAxis) 
        {
          
            var yAxisName = LinearAxis.init<IConvertible, IConvertible, IConvertible, IConvertible, IConvertible, IConvertible>(Title: Title.init(yAxis), ZeroLineWidth: 2);
            var xAxisName = LinearAxis.init<IConvertible, IConvertible, IConvertible, IConvertible, IConvertible, IConvertible>(Title: Title.init(xAxis), ZeroLineWidth: 2);
            
            var chart = Chart2D.Chart.Scatter<float, int, string>(x: xData.ToArray(), y: yData.ToArray(), mode: StyleParam.Mode.Markers)
                .WithTitle($"{xAxis} compared to {yAxis}")
                .WithXAxis(xAxisName)
                .WithYAxis(yAxisName);

            //Saves created chart as HTML and displays it in the WebBrowser on the form 

            chart.SaveHtml("Figure", null);
            WbViewChart.Navigate(@"C:\Users\ekmho\Documents\NEA\NEA\bin\Debug\Figure.html");
            
        }
        
        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainMenu mainMenu = new MainMenu();

            mainMenu.Show();

        }

        private void AveragePropertyPrices()
        {
            using (conn = new SqlConnection("Data Source=DESKTOP-4FCU0KI\\SQLEXPRESS;Initial Catalog=NEAdatabase1;Integrated Security=True"))
            {
                conn.Open();

                SqlCommand ExtractAveragePrices = new SqlCommand("ExtractAveragePrices2021", conn);

                ExtractAveragePrices.CommandType = CommandType.StoredProcedure;

                List<int> averagePropertyPrices = new List<int>();

                // Adds the results of the SQL query to a list

                using (SqlDataReader reader = ExtractAveragePrices.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        averagePropertyPrices.Add((int)reader["Average2021"]);
                    }

                    //Shows each individual Average Property Price in the correct textbox

                    for(int i = 0; i<averagePropertyPrices.Count(); i++)
                    {
                        switch(i)
                        {
                            case 0:
                                TxtNorthEastAPP.Text = Convert.ToString(averagePropertyPrices[0]);
                                break;
                            case 1:
                                TxtNorthWestAPP.Text = Convert.ToString(averagePropertyPrices[1]);
                                break;
                            case 2:
                                TxtYorkshireAPP.Text = Convert.ToString(averagePropertyPrices[2]);
                                break;
                            case 3:
                                TxtEastMidlandsAPP.Text = Convert.ToString(averagePropertyPrices[3]);
                                break;
                            case 4:
                                TxtWestMidlandsAPP.Text = Convert.ToString(averagePropertyPrices[4]);
                                break;
                            case 5:
                                TxtEastAPP.Text = Convert.ToString(averagePropertyPrices[5]);
                                break;
                            case 6:
                                TxtLondonAPP.Text = Convert.ToString(averagePropertyPrices[6]);
                                break;
                            case 7:
                                TxtSouthEastAPP.Text = Convert.ToString(averagePropertyPrices[7]);
                                break;
                            case 8:
                                TxtSouthWestAPP.Text = Convert.ToString(averagePropertyPrices[8]);
                                break;


                        }

                    }

                }

            }
        }

    }
}

