using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AutoMapperDropDown.Models
{
    [Index(nameof(DepartmentRefId), Name = "IX_Employees_DepartmentRefId")]
    [Index(nameof(NationalityRefId), Name = "IX_Employees_NationalityRefId")]
    public partial class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; }
        public DateTime? DateOfBirth { get; set; }
        [StringLength(1)]
        [Unicode(false)]
        public string Gender { get; set; }
        public int DepartmentRefId { get; set; }
        public int NationalityRefId { get; set; }


        [ForeignKey(nameof(DepartmentRefId))]
        [InverseProperty(nameof(Department.Employees))]
        public virtual Department DepartmentRef { get; set; }
        [ForeignKey(nameof(NationalityRefId))]
        [InverseProperty(nameof(Nationality.Employees))]
        public virtual Nationality NationalityRef { get; set; }
        
    }
}
