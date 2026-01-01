using System;
using System.Collections.Generic;

namespace HCI_project.Models;

public partial class Course
{
    public int CourseId { get; set; }

    public string Name { get; set; } = null!;

    public string Code { get; set; } = null!;

    public int CreditHours { get; set; }

    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();

    public virtual ICollection<Note> Notes { get; set; } = new List<Note>();

    public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
}
