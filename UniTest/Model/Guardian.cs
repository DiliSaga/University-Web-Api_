using System;
using System.Collections.Generic;

namespace UniTest.Model;

public partial class Guardian
{
    public int GuardianId { get; set; }

    public string? GuardianFname { get; set; }

    public string? GuardianLname { get; set; }

    public string? GuardianEmail { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
