using HRMS.Desktop.Controls;
using System.Windows;

namespace HRMS.Desktop
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Dashboard_Click(object sender, RoutedEventArgs e) => ContentArea.Content = new Employees();
        private void Project_Click(object sender, RoutedEventArgs e) => ContentArea.Content = new Employees();
        private void Chat_Click(object sender, RoutedEventArgs e) => ContentArea.Content = new Employees();
        private void Calendar_Click(object sender, RoutedEventArgs e) => ContentArea.Content = new Employees();
        private void Organization_Click(object sender, RoutedEventArgs e) => ContentArea.Content = new Employees();
        private void Settings_Click(object sender, RoutedEventArgs e) => ContentArea.Content = new Employees();
    }
}