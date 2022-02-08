using HRMS.Desktop.Interfaces;
using HRMS.Desktop.Services;
using System.Windows;

namespace HRMS.Desktop
{
    public partial class MainWindow : Window
    {
        private readonly IDepartmentService DepartmentService;

        public MainWindow()
        {
            InitializeComponent();
            DepartmentService = new DepartmentService();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            dgKorisnici.ItemsSource = await DepartmentService.GetAll();
        }
    }
}