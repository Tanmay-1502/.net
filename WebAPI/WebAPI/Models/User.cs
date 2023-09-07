using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models;

[Table("User")]
public partial class User
{
    [Key]
    [Column(TypeName = "character varying(50)[]")]
    public string[] UserId { get; set; } = null!;

    [Column(TypeName = "character varying(50)[]")]
    public string[] Username { get; set; } = null!;

    [Column("Department ", TypeName = "character varying(50)[]")]
    public string[]? Department { get; set; }

    [Column(TypeName = "character varying(50)[]")]
    public string[]? Designation { get; set; }

    public int? ManagementLevel { get; set; }

    [Column(TypeName = "character varying(500)[]")]
    public string[] Password { get; set; } = null!;

    [InverseProperty("User")]
    public virtual ICollection<Issue> Issues { get; set; } = new List<Issue>();
}
