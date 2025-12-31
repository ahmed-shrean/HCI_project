using System;
using System.Collections.Generic;

namespace HCI_project.Models;

public partial class Task
{
    public int TaskId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime? Deadline { get; set; }

    public bool? IsCompleted { get; set; }

    public int CourseId { get; set; }

    public int UserId { get; set; }

    public virtual Course Course { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
