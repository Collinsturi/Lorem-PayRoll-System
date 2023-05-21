using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Lorem_PayRoll_System.Models;

[Table("casualemployees")]
public partial class Casualemployee : IEntity
{
    [Key]
    public int Id { get; set; }

    [Required(AllowEmptyStrings =false, ErrorMessage ="First Name is required")]
    public string FirstName { get; set; } = null!;

    [Required(AllowEmptyStrings = false, ErrorMessage = "Last Name is required")]
    public string LastName { get; set; } = null!;

    [MaxLength(6)]
    [Required(AllowEmptyStrings = false, ErrorMessage = "Date of birth is required")]
    public DateTime DateOfBirth { get; set; }

    [Required(AllowEmptyStrings = false, ErrorMessage = "Gender is required")]
    public string Gender { get; set; } = null!;

    [Required(AllowEmptyStrings = false, ErrorMessage = "Employee type is required")]
    public string EmployeeType { get; set; } = null!;

    [Required(AllowEmptyStrings = false, ErrorMessage = "Pin Number is required")]
    public int PinNumber { get; set; }

    [Required(AllowEmptyStrings = false, ErrorMessage = "Employee number is required")]
    public int EmployeeNumber { get; set; }
    
    [Required(AllowEmptyStrings = false, ErrorMessage = "Contract time is required")]
    public double ContractTime { get; set; }

    [Required(AllowEmptyStrings = false, ErrorMessage = "Amounts worked is required")]
    public double MonthsWorked { get; set; }

    [Precision(10)]
    [Required(AllowEmptyStrings = false, ErrorMessage = "Salary is required")]
    public decimal Salary { get; set; }

    [Precision(10)]
    [Required(AllowEmptyStrings = false, ErrorMessage = "Pay per Month is required")]
    public decimal PayPerMonth { get; set; }
}
