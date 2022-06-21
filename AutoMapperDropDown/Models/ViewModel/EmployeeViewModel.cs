using System.ComponentModel.DataAnnotations;

namespace AutoMapperDropDown.Models.ViewModel
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Full Name")]
        public string Name { get; set; } = null!;

        [Display(Name = "Date Of Birth")]
        public DateTime? DateOfBirth { get; set; }

        public string? Gender { get; set; }

        [Display(Name = "Department Id")]
        public int DepartmentRefId { get; set; }

        [Display(Name = "Department")]
        public string DepartmentName { get; set; } = null!;

        [Display(Name = "Nationality Id")]
        public int NationalityRefId { get; set; }

        [Display(Name = "Nationality")]
        public string NationalityText { get; set; } = null!;
    }
}
