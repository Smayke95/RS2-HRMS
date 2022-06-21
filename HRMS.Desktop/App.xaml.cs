using HRMS.Desktop.Controls;
using HRMS.Desktop.Extensions;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace HRMS.Desktop
{
    public partial class App : Application
    {
        private ServiceProvider ServiceProvider;

        public App()
        {
            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            ServiceProvider = services.BuildServiceProvider();
        }

        private void ConfigureServices(ServiceCollection services)
        {
            services.AddAutoMapper(typeof(App));
            services.AddScopedServices();

            services.AddSingleton<LoginWindow>();
            services.AddSingleton<MainWindow>();
            services.AddSingleton<Employees>();
        }

        private void ApplicationStart(object sender, StartupEventArgs e)
        {
            Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;

            var loginWindow = ServiceProvider.GetService<LoginWindow>();
            loginWindow.Show();
        }
    }
}