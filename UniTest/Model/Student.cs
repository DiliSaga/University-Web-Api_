using System;
using System.Collections.Generic;

namespace UniTest.Model;

public partial class Student
{
    public int StudentId { get; set; }

    public string StudentFname { get; set; } = null!;

    public string StudentLname { get; set; } = null!;

    public string StudentGender { get; set; } = null!;

    public DateTime StudentDob { get; set; }

    public string StudentNic { get; set; } = null!;

    public string StudentEmail { get; set; } = null!;

    public int GuardianId { get; set; }

    public string? CourseId { get; set; }

    public virtual Course? Course { get; set; }

    public virtual Guardian Guardian { get; set; } = null!;
}
