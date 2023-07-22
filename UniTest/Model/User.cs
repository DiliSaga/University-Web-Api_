using System;
using System.Collections.Generic;

namespace UniTest.Model;

public partial class User
{
    public int UserId { get; set; }

    public string UserFname { get; set; } = null!;

    public string UserLname { get; set; } = null!;

    public string UserEmail { get; set; } = null!;

    public int UserLevel { get; set; }
}
