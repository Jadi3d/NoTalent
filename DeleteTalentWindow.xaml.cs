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
    public partial class DeleteTalentWindow : Window
    {
        private readonly string connectionString;

        public DeleteTalentWindow()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["NoTalentDB"].ConnectionString;
        }

        private void DeleteTalentButton_Click(object sender, RoutedEventArgs e)
        {
            string query = "DeleteTalent";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@TalentID", Convert.ToInt32(TalentIDTextBox.Text));

                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Talent deleted successfully.");
            }
        }
    }
}

