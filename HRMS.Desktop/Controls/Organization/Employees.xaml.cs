﻿using HRMS.Desktop.Interfaces;
using HRMS.Desktop.Services;
using System.Windows;
using System.Windows.Controls;

namespace HRMS.Desktop.Controls
{
    public partial class Employees : UserControl
    {
        private readonly IDepartmentService DepartmentService;

        public Employees()
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