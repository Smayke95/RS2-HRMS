using HRMS.Desktop.Interfaces;
using HRMS.Desktop.Services;
using System.Windows;

namespace HRMS.Desktop
{
    public partial class LoginWindow : Window
    {
        private readonly IAuthService AuthService;

        public LoginWindow()
        {
            InitializeComponent();
            AuthService = new AuthService();
        }

        private async void btn_Login_Click(object sender, RoutedEventArgs e)
        {
            var isLogged = await AuthService.Login(txt_Email.Text, txt_Password.Password);

            if (isLogged)
            {
                App.Current.MainWindow.Close();

                var mainWindow = new MainWindow();
                App.Current.ShutdownMode = ShutdownMode.OnMainWindowClose;
                App.Current.MainWindow = mainWindow;
                mainWindow.Show();
            }
            else
            {
                txt_Validation.Visibility = Visibility.Visible;
            }
        }
    }
}