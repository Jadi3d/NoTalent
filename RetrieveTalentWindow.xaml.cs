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
using System.Data;
using System.Data.SqlClient;

namespace NoTalent
{
    public partial class RetrieveTalentWindow : Window
    {
        private readonly string connectionString;

        public RetrieveTalentWindow()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["NoTalentDB"].ConnectionString;
        }

        private void RetrieveTalentButton_Click(object sender, RoutedEventArgs e)
        {
            string query = "GetTalentByTalentID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@TalentID", Convert.ToInt32(TalentIDTextBox.Text));

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable talentTable = new DataTable();
                adapter.Fill(talentTable);

                if (talentTable.Rows.Count > 0)
                {
                    DataRow row = talentTable.Rows[0];
                    ResultTextBlock.Text = $"Name: {row["Name"]}\nAge: {row["Age"]}\nRates: {row["Rates"]}\nContact Info: {row["ContactInfo"]}\nPortfolio Details: {row["Portfolio_Details"]}\nSkillset: {row["Skillset"]}\nGender: {row["Gender"]}\nAvailability ID: {row["AvailabilityID"]}";
                }
                else
                {
                    MessageBox.Show("No data found.");
                }
            }
        }
    }
}

