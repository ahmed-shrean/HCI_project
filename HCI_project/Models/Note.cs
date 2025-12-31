using System;
using System.Collections.Generic;

namespace HCI_project.Models;

public partial class Note
{
    public int NoteId { get; set; }

    public string Content { get; set; } = null!;

    public int CourseId { get; set; }

    public int UserId { get; set; }

    public virtual Course Course { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
