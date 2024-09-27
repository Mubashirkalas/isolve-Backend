using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Feedback
{
    public int SerialNo { get; set; }

    public string? Type { get; set; }

    public string? Priority { get; set; }

    public string? Remarks { get; set; }

    public string? CustomerName { get; set; }

    public string? Cnic { get; set; }

    public DateTime? Date { get; set; }
}
