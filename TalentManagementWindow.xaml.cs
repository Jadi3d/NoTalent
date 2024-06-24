using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace NoTalent
{
    public partial class TalentManagementWindow : Window
    {
        public TalentManagementWindow()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            CreateTalentWindow createWindow = new CreateTalentWindow();
            createWindow.Show();
            this.Close();
        }

        private void RetrieveButton_Click(object sender, RoutedEventArgs e)
        {
            RetrieveTalentWindow retrieveWindow = new RetrieveTalentWindow();
            retrieveWindow.Show();
            this.Close();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            UpdateTalentWindow updateWindow = new UpdateTalentWindow();
            updateWindow.Show();
            this.Close();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            DeleteTalentWindow deleteWindow = new DeleteTalentWindow();
            deleteWindow.Show();
            this.Close();
        }
    }
}

