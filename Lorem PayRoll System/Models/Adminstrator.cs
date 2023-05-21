using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Lorem_PayRoll_System.Models;

[Table("adminstrator")]
public partial class Adminstrator : IEntity
{
    [Key]
    public int Id { get; set; }
   
    [Required(ErrorMessage ="Date of Birth is required to create Adminstrator", AllowEmptyStrings = false)]
    public string Email { get; set; } = null!;

    [Required(ErrorMessage ="Password is required", AllowEmptyStrings = false)]
    public string Password { get; set; } = null!;
}
