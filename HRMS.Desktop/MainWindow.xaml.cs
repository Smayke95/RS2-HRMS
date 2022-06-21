using HRMS.Desktop.Controls;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;

namespace HRMS.Desktop
{
    public partial class MainWindow : Window
    {
        private readonly IServiceProvider ServiceProvider;

        public MainWindow(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            ServiceProvider = serviceProvider;
        }

        private void Dashboard_Click(object sender, RoutedEventArgs e) => ContentArea.Content = ServiceProvider.GetService<Employees>();
        private void Project_Click(object sender, RoutedEventArgs e) => ContentArea.Content = ServiceProvider.GetService<Employees>();
        private void Chat_Click(object sender, RoutedEventArgs e) => ContentArea.Content = ServiceProvider.GetService<Employees>();
        private void Calendar_Click(object sender, RoutedEventArgs e) => ContentArea.Content = ServiceProvider.GetService<Employees>();
        private void Organization_Click(object sender, RoutedEventArgs e) => ContentArea.Content = ServiceProvider.GetService<Employees>();
        private void Settings_Click(object sender, RoutedEventArgs e) => ContentArea.Content = ServiceProvider.GetService<Employees>();
    }
}