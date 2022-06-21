using HRMS.Desktop.Interfaces;
using System.Windows.Controls;

namespace HRMS.Desktop.Controls
{
    public partial class Employees : UserControl
    {
        private readonly IDepartmentService DepartmentService;
        private readonly IEmployeePositionService EmployeePositionService;
        private readonly IEmployeeService EmployeeService;
        private readonly IPositionService PositionService;

        public Employees(
            IDepartmentService departmentService,
            IEmployeePositionService employeePositionService,
            IEmployeeService employeeService,
            IPositionService positionService)
        {
            InitializeComponent();
            DepartmentService = departmentService;
            EmployeePositionService = employeePositionService;
            EmployeeService = employeeService;
            PositionService = positionService;

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