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

        private void Account_Click(object sender, RoutedEventArgs e) => ContentArea.Content = new Employees();
    }
}