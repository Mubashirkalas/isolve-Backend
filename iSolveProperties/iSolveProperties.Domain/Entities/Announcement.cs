using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Announcement
{
    public int SerialNo { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public byte? Days { get; set; }

    public DateTime? StartDate { get; set; }
}
