using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;

[Table("Issue")]
public partial class Issue
{
    [Key]
    [Column(TypeName = "character varying(50)[]")]
    public string[] IssueId { get; set; } = null!;

    [Column(TypeName = "character varying(50)[]")]
    public string[] RigId { get; set; } = null!;

    [Column(TypeName = "character varying(50)[]")]
    public string[] UserId { get; set; } = null!;

    [Column(TypeName = "character varying(50)[]")]
    public string[]? Description { get; set; }

    [Column(TypeName = "character varying(50)[]")]
    public string[] AlertId { get; set; } = null!;

    [Column(TypeName = "character varying(50)[]")]
    public string[]? Status { get; set; }

    [ForeignKey("AlertId")]
    [InverseProperty("Issues")]
    public virtual Alert Alert { get; set; } = null!;

    [ForeignKey("RigId")]
    [InverseProperty("Issues")]
    public virtual OilRig Rig { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("Issues")]
    public virtual User User { get; set; } = null!;
}
