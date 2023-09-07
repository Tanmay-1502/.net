using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models;

[Table("OilRig")]
public partial class OilRig
{
    [Key]
    [Column(TypeName = "character varying(50)[]")]
    public string[] RigId { get; set; } = null!;

    [Column(TypeName = "character varying(50)[]")]
    public string[] RigName { get; set; } = null!;

    [Column(TypeName = "character varying(50)[]")]
    public string[] Location { get; set; } = null!;

    public double[] Temperature { get; set; } = null!;

    public double[] Pressure { get; set; } = null!;

    [Column(TypeName = "character varying(50)[]")]
    public string[] ProductionRate { get; set; } = null!;

    [Column(TypeName = "character varying(50)[]")]
    public string[]? Status { get; set; }

    [InverseProperty("Rig")]
    public virtual ICollection<Alert> Alerts { get; set; } = new List<Alert>();

    [InverseProperty("Rig")]
    public virtual ICollection<Issue> Issues { get; set; } = new List<Issue>();
}
