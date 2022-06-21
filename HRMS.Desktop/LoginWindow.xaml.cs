using HRMS.Desktop.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;

namespace HRMS.Desktop
{
    public partial class LoginWindow : Window
    {
        private readonly IServiceProvider ServiceProvider;
        private readonly IAuthService AuthService;

        public LoginWindow(
            IServiceProvider serviceProvider,
            IAuthService authService)
        {
            InitializeComponent();
            ServiceProvider = serviceProvider;
            AuthService = authService;
        }

        private async void btn_Login_Click(object sender, RoutedEventArgs e)
        {
            var isLogged = await AuthService.Login(txt_Email.Text, txt_Password.Password);

            if (isLogged)
            {
                App.Current.MainWindow.Close();

                var mainWindow = ServiceProvider.GetService<MainWindow>();
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