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

namespace NoTalent
{
    public partial class OptionsWindow : Window
    {
        public OptionsWindow()
        {
            InitializeComponent();
        }

        private void StaffLoginButton_Click(object sender, RoutedEventArgs e)
        {
            StaffLoginWindow staffLoginWindow = new StaffLoginWindow();
            staffLoginWindow.Show();
            
        }

        private void TalentManagementButton_Click(object sender, RoutedEventArgs e)
        {
            TalentManagementWindow talentManagementWindow = new TalentManagementWindow();
            talentManagementWindow.Show();
            
        }

        private void BookingRecordsButton_Click(object sender, RoutedEventArgs e)
        {
            BookingRecordsWindow bookingRecordsWindow = new BookingRecordsWindow();
            bookingRecordsWindow.Show();
            
        }
    }
}
