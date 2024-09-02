using System;
using System.Collections.Generic;

namespace API_CRUD_EF_MVC.Models;

public partial class Student
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Gender { get; set; }

    public string? Standard { get; set; }

    public int? Age { get; set; }
}
