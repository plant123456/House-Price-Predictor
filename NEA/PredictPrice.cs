using System;
using System.Collections;
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
    public partial class PredictPrice : Form
    {
        public PredictPrice()
        {
            InitializeComponent();

        }

        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            // Takes the user back to the main menu when the main menu button is clicked
            this.Hide();

            MainMenu mainMenu = new MainMenu();

            mainMenu.Show();
            
        }

        private static SqlConnection conn = new SqlConnection();

        private void BtnPredictPrice_Click(object sender, EventArgs e)
        {
            double[,] userFeatures = new double[12, 1];

            // Sets the user inputted values as each item in the userFeatures matrix
           
            userFeatures[0, 0] = Convert.ToDouble(NUDRooms.Value);
            userFeatures[1, 0] = Convert.ToDouble(NUDBedrooms.Value);
            userFeatures[2, 0] = Convert.ToDouble(NUDBathrooms.Value);
            userFeatures[3, 0] = Convert.ToDouble(NUDPropertySize.Value);
            userFeatures[4, 0] = Convert.ToDouble(NUDGarden.Value);
            userFeatures[5, 0] = Convert.ToDouble(NUDDriveway.Value);
            userFeatures[6, 0] = Convert.ToDouble(NUDSchoolDistance.Value);
            userFeatures[7, 0] = Convert.ToDouble(NUDTrainDistance.Value);
            userFeatures[8, 0] = GetSpecificCrimeRate();
            userFeatures[9, 0] = GetSpecificUnemploymentRate();
            userFeatures[10, 0] = GetSpecificAverageIncome();
            userFeatures[11, 0] = GetSpecificAveragePropertyPrice();

            // Calculates and outputs the predicted price
            double[,] parameters = TrainModel();

            MessageBox.Show("The predicted price for a property with these features is: £" + Convert.ToString(Math.Round(CalculateHypothesis(parameters, userFeatures)-700000)));

        }

        private double GetSpecificCrimeRate()
        {
            // Extracts the specific crime rate value from the database 

            using (conn = new SqlConnection("Data Source=DESKTOP-4FCU0KI\\SQLEXPRESS;Initial Catalog=NEAdatabase1;Integrated Security=True"))
            {
                conn.Open(); //The 'using' statement automatically closes the connection at the end of the statement

                SqlCommand ExtractCR = new SqlCommand("ExtractSpecificCrimeRate", conn);

                ExtractCR.CommandType = CommandType.StoredProcedure;

                ExtractCR.Parameters.Add(new SqlParameter("@RegionID", SqlDbType.Int)).Value = Convert.ToInt32(NUDRegionID.Value);
                ExtractCR.Parameters.Add(new SqlParameter("@Date", SqlDbType.Date)).Value = DateTime.Now;

                double specificCrimeRate = Convert.ToDouble(ExtractCR.ExecuteScalar());

                return specificCrimeRate;

            }
        }

        private double GetSpecificUnemploymentRate()
        {
            // Extracts the specific unemployment rate value from the database 

            using (conn = new SqlConnection("Data Source=DESKTOP-4FCU0KI\\SQLEXPRESS;Initial Catalog=NEAdatabase1;Integrated Security=True"))
            {
                conn.Open();

                SqlCommand ExtractUR = new SqlCommand("ExtractSpecificUnemploymentRate", conn);

                ExtractUR.CommandType = CommandType.StoredProcedure;

                ExtractUR.Parameters.Add(new SqlParameter("@RegionID", SqlDbType.Int)).Value = Convert.ToInt32(NUDRegionID.Value);
                ExtractUR.Parameters.Add(new SqlParameter("@Date", SqlDbType.Date)).Value = DateTime.Now;

                double specificUnemploymentRate = Convert.ToDouble(ExtractUR.ExecuteScalar());

                return specificUnemploymentRate;

            }
        }

        private double GetSpecificAverageIncome()
        {
            // Extracts the specific average income value from the user database 

            using (conn = new SqlConnection("Data Source=DESKTOP-4FCU0KI\\SQLEXPRESS;Initial Catalog=NEAdatabase1;Integrated Security=True"))
            {
                conn.Open();

                SqlCommand ExtractAI = new SqlCommand("ExtractSpecificAverageIncome", conn);

                ExtractAI.CommandType = CommandType.StoredProcedure;

                ExtractAI.Parameters.Add(new SqlParameter("@RegionID", SqlDbType.Int)).Value = Convert.ToInt32(NUDRegionID.Value);
                ExtractAI.Parameters.Add(new SqlParameter("@Date", SqlDbType.Date)).Value = DateTime.Now;

                double specificAvIncome = Convert.ToDouble(ExtractAI.ExecuteScalar());

                return specificAvIncome;

            }
        }

        private double GetSpecificAveragePropertyPrice()
        {
            // Extracts the specific average property price value from the database

            using (conn = new SqlConnection("Data Source=DESKTOP-4FCU0KI\\SQLEXPRESS;Initial Catalog=NEAdatabase1;Integrated Security=True"))
            {
                conn.Open();

                SqlCommand ExtractAPP = new SqlCommand("ExtractSpecificAveragePropertyPrice", conn);

                ExtractAPP.CommandType = CommandType.StoredProcedure;

                ExtractAPP.Parameters.Add(new SqlParameter("@RegionID", SqlDbType.Int)).Value = Convert.ToInt32(NUDRegionID.Value);
                ExtractAPP.Parameters.Add(new SqlParameter("@Date", SqlDbType.Date)).Value = DateTime.Now;

                double specificAvPropPrice = Convert.ToDouble(ExtractAPP.ExecuteScalar());

                return specificAvPropPrice;

            }
        }

        private static double CalculateHypothesis(double[,] parameters, double[,] matrixA)
        {
            
            double[,] hypothesisMatrix = MatrixMultiplication(MatrixTranspose(parameters), matrixA);

            double hypothesisPrice = 0;

            foreach (double item in hypothesisMatrix)
            {
                hypothesisPrice += item;
            }

            return hypothesisPrice;

        }

        private static double[,] TrainModel()
        {
            //Optimises parameter values for the property features and prices in the database

            double[,] trainingFeatures = GetTrainingFeatures();

            double[,] trainingPrices = GetTrainingPrices();

            double[,] modelParameters = OptimiseParameters(trainingFeatures, trainingPrices);

            return modelParameters;

        }

        private static double [,] GetTrainingPrices()
        {
            using (conn = new SqlConnection("Data Source=DESKTOP-4FCU0KI\\SQLEXPRESS;Initial Catalog=NEAdatabase1;Integrated Security=True"))
            {
                conn.Open();

                SqlCommand ExtractSalePrices = new SqlCommand("ExtractSalePrices", conn);

                ExtractSalePrices.CommandType = CommandType.StoredProcedure;

                SqlCommand NoOfPrices = new SqlCommand("CountNoOfSalePrices", conn);

                NoOfPrices.CommandType = CommandType.StoredProcedure;

                int numberOfPrices = (int)NoOfPrices.ExecuteScalar();

                List<int> extractedPrices = new List<int>();

                //Adds all values from the result of query ExtractSalePrices to the List

                using (SqlDataReader reader = ExtractSalePrices.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        extractedPrices.Add((int)reader["SalePrice"]);
                    }
                }

                double[,] trainingPrices = new double[numberOfPrices, 1];

                //  Copies each value in the List into the correct position in a 2D array 

                for (int j = 0; j < 1; j++)
                {
                    for (int i = 0; i < numberOfPrices; i++)
                    {
                        trainingPrices[i, j] = extractedPrices[(i + 1) * (j + 1) - 1];
                    }
                }

                return trainingPrices;
            }
        }

        private static double [,] GetTrainingFeatures()
        {
            List<List<float>> extractedFeatures = new List<List<float>>();

            using (conn = new SqlConnection("Data Source=DESKTOP-4FCU0KI\\SQLEXPRESS;Initial Catalog=NEAdatabase1;Integrated Security=True"))
            {
                conn.Open();

                SqlCommand ExtractFeatures = new SqlCommand("ExtractFeatures", conn);

                ExtractFeatures.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = ExtractFeatures.ExecuteReader())
                { 
                    // Adds the values from each row of the ExtractFeatures query to the list of lists

                    while (reader.Read())
                    {
                        var rowOfFeatures = new List<float>();

                        for (int i = 0; i <= reader.FieldCount - 1; i++)
                        {
                            rowOfFeatures.Add(Convert.ToSingle(reader.GetValue(i)));
                            
                        }
                        
                        extractedFeatures.Add(rowOfFeatures);
                    }
                    
                }

                // Copies each value in the list of lists to a 2D array

                double[,] trainingFeatures = new double[extractedFeatures.Count, extractedFeatures[0].Count];
                for (int i = 0; i < extractedFeatures.Count; i++)
                {
                    for (int j = 0; j < extractedFeatures[i].Count; j++)
                    {
                        trainingFeatures[i, j] = extractedFeatures[i][j];
                    }
                }

                return trainingFeatures;
            }
        }

        private static double[,] OptimiseParameters(double[,] matrixA, double[,] matrixB)
        {
            double[,] optimisedParameters = (MatrixMultiplication(MatrixInverse(MatrixMultiplication((MatrixTranspose(matrixA)), matrixA)), (MatrixMultiplication((MatrixTranspose(matrixA)), matrixB))));
            
            return optimisedParameters;

        }
        private static double[,] MatrixMultiplication(double[,] matrixA, double[,] matrixB)
        {   
            // Checks the number of columns of matrix A is equal to the number of rows of Matrix B

            int rowsA = matrixA.GetLength(0);

            int columnsA = matrixA.GetLength(1);

            int rowsB = matrixB.GetLength(0);

            int columnsB = matrixB.GetLength(1);

            if (columnsA != rowsB)
            {
                MessageBox.Show("This matrix cannot be multiplied - The number of columns of the first matrix must be the same as the number of rows of the second matrix");
            }

            double[,] multipliedMatrix = new double[rowsA, columnsB];

            // Sums up multiplied values for each row & column multiplcation process

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < columnsB; j++)
                { 
                    for (int k = 0; k < columnsA; k++)
                    {
                        multipliedMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }

            return multipliedMatrix;
        }

        private static double[,] MatrixTranspose(double[,] matrixA)
        {
            
            int rowsA = matrixA.GetLength(0);

            int columnsA = matrixA.GetLength(1);

            double[,] transposeMatrix = new double[columnsA, rowsA];

            for (int i = 0; i < rowsA; i++) // Flips the rows and columns of matrixA
            {
                for (int j = 0; j < columnsA; j++)
                {
                    transposeMatrix[j, i] = matrixA[i, j];
                }
            }

            return transposeMatrix;
        }

        private static double[,] MatrixInverse(double[,] matrixA)
        {
            // Checks input matrix is a square matrix 

            int rowsA = matrixA.GetLength(0);

            int columnsA = matrixA.GetLength(1);

            if (rowsA != columnsA)
            {
                MessageBox.Show("This is not a square matrix therefore this matrix does not have an inverse");

                return null;

            }

            int matrixOrder = rowsA; 

            double[,] inverseMatrix = new double[rowsA, columnsA]; 

            double[,] augmentedMatrix = new double[rowsA, columnsA * 2]; 

            // Create augmented matrix - Adds identity matrix to the end of the origina matrix

            for (int i = 0; i < matrixOrder; i++)
            {

                for (int j = 0; j < matrixOrder; j++)
                {
                    augmentedMatrix[i, j] = matrixA[i, j];

                    if (j == i) // Checks if position is in the leading diagonal
                    {
                        
                        augmentedMatrix[i, j + matrixOrder] = 1;
                    }
                    else
                    {
                        augmentedMatrix[i, j + matrixOrder] = 0;
                    }
                }
            }

            // Interchange the row of the augmented matrix in descending order, starting from the last row 

            for (int i = matrixOrder - 1; i > 0; i--)
            {

                // Swaps row if the first value in the latter row is greater than the first value in the row before

                if (augmentedMatrix[i - 1, 0] < augmentedMatrix[i, 0])
                {
                    for (int j = 0; j < 2 * matrixOrder; j++)
                    {
                        double switchValue = augmentedMatrix[i, j];

                        augmentedMatrix[i, j] = augmentedMatrix[i - 1, j];

                        augmentedMatrix[i - 1, j] = switchValue;
                    }
                }

            }

            // Replace a row by sum of itself and a multiple of another row of the augmented matrix

            for (int i = 0; i < matrixOrder; i++)
            {

                for (int j = 0; j < matrixOrder; j++)
                {

                    if (j != i) //checks if the value is in the leading diagonal 
                    {

                        double multiplyingValue = augmentedMatrix[j, i] / augmentedMatrix[i, i]; 

                        for (int k = 0; k < 2 * matrixOrder; k++)
                        {

                            augmentedMatrix[j, k] -= augmentedMatrix[i, k] * multiplyingValue;
                        }
                    }
                }
            }


            // Divides each row's element by the diagonal element of that row

            for (int i = 0; i < matrixOrder; i++)
            {

                double dividingValue = augmentedMatrix[i, i];

                for (int j = 0; j < 2 * matrixOrder; j++)
                {

                    augmentedMatrix[i, j] = augmentedMatrix[i, j] / dividingValue;
                }
            }

            // Gauss-Jordan elimination has been completed 
            //Augmented matrix is now made up of the identity matrix concatenated to the matrix inverse

            // Takes the inverse matrix out of the second half of the augmented matrix 
            for (int i = 0; i < matrixOrder; i++)
            {

                for (int j = 0; j < matrixOrder; j++)
                {
                    inverseMatrix[i, j] = augmentedMatrix[i, j + matrixOrder];
                }
            }

            return inverseMatrix;

        }
    }
}



