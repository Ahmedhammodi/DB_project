﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Entities;

[PrimaryKey("StID", "CrsID")]
[Table("StudentCourse")]
public partial class StudentCourse
{
    [Key]
    public int StID { get; set; }

    [Key]
    public int CrsID { get; set; }

    public double? Grade { get; set; }

    [ForeignKey("CrsID")]
    [InverseProperty("StudentCourses")]
    public virtual Course Crs { get; set; }

    [ForeignKey("StID")]
    [InverseProperty("StudentCourses")]
    public virtual Student St { get; set; }
}