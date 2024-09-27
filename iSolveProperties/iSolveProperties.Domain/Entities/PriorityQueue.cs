using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class PriorityQueue
{
    public short SerialNo { get; set; }

    public byte CompId { get; set; }

    public DateOnly? Date { get; set; }

    public string? TeamName { get; set; }

    public double? Responded { get; set; }

    public double? NotResponded { get; set; }

    public short? TeamId { get; set; }
}
