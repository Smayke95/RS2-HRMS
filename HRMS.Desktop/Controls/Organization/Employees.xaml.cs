using HRMS.Desktop.Interfaces;
using HRMS.Desktop.Services;
using System.Windows.Controls;

namespace HRMS.Desktop.Controls
{
    public partial class Employees : UserControl
    {
        private readonly IDepartmentService DepartmentService;
        private readonly IEmployeePositionService EmployeePositionService;
        private readonly IEmployeeService EmployeeService;
        private readonly IPositionService PositionService;

        public Employees()
        {
            InitializeComponent();
            DepartmentService = new DepartmentService();
            EmployeePositionService = new EmployeePositionService();
            EmployeeService = new EmployeeService();
            PositionService = new PositionService();

            Load();
        }

        private async void Load()
        {
            dg_Employees.ItemsSource = await EmployeeService.GetAll();
            dg_EmployeePositions.ItemsSource = await EmployeePositionService.GetAll();
            dg_Positions.ItemsSource = await PositionService.GetAll();
            dg_Departments.ItemsSource = await DepartmentService.GetAll();
        }
    }
}