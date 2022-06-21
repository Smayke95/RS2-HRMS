using HRMS.Model;
using System;
using System.Windows.Media.Imaging;

namespace HRMS.Desktop.ViewModels
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Name
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public string MaidenName { get; set; }

        public string ParentName { get; set; }

        public Gender Gender { get; set; }

        public string RegistrationNumber { get; set; }

        public string PersonalIdentificationNumber { get; set; }

        public string WorkerCode { get; set; }

        public DateTime BirthDate { get; set; } = DateTime.Now;

        public string Address { get; set; }

        public string Image { get; set; } = "/img/avatars/default.png";

        public BitmapImage ImageFile { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Mobile { get; set; }

        public string OfficePhone { get; set; }

        public string Profession { get; set; }

        public Education Education { get; set; }

        public int PreviousLOSYears { get; set; }

        public int PreviousLOSMonths { get; set; }

        public string BankAccount { get; set; }

        public string Note { get; set; }

        public DateTime CreateDate { get; set; }

        public string Username { get; set; }

        public bool IsEmailConfirmed { get; set; }

        public bool IsLockedOut { get; set; }
    }
}