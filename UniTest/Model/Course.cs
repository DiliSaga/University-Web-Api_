using System;
using System.Collections.Generic;

namespace UniTest.Model;

public partial class Course
{
    public string CourseId { get; set; } = null!;

    public string? CourseType { get; set; }

    public string? CourseName { get; set; }

    public string? CourseField { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
