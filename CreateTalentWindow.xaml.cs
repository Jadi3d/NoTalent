using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Configuration;
using System.Data.SqlClient;

namespace NoTalent
{
    public partial class CreateTalentWindow : Window
    {
        private readonly string connectionString;

        public CreateTalentWindow()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["NoTalentDB"].ConnectionString;
        }

        private void CreateTalentButton_Click(object sender, RoutedEventArgs e)
        {
            string query = "InsertTalent";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@Name", NameTextBox.Text);
                command.Parameters.AddWithValue("@Age", Convert.ToInt32(AgeTextBox.Text));
                command.Parameters.AddWithValue("@Rates", Convert.ToDecimal(RatesTextBox.Text));
                command.Parameters.AddWithValue("@ContactInfo", ContactInfoTextBox.Text);
                command.Parameters.AddWithValue("@Portfolio_Details", PortfolioDetailsTextBox.Text);
                command.Parameters.AddWithValue("@Skillset", SkillsetTextBox.Text);
                command.Parameters.AddWithValue("@Gender", GenderTextBox.Text);
                command.Parameters.AddWithValue("@AvailabilityID", Convert.ToInt32(AvailabilityIDTextBox.Text));

                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Talent created successfully.");
            }
        }
    }
}
