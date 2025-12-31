using System;
using System.Collections.Generic;

namespace HCI_project.Models;

public partial class Grade
{
    public int GradeId { get; set; }

    public string ExamName { get; set; } = null!;

    public double Score { get; set; }

    public int MaxScore { get; set; }

    public int CourseId { get; set; }

    public int UserId { get; set; }

    public virtual Course Course { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
