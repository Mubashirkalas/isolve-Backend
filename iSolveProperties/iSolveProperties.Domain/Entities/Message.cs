using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Message
{
    public string? Subject { get; set; }

    public string? Message1 { get; set; }

    public string? Sender { get; set; }

    public string? Status { get; set; }

    public short? SuserId { get; set; }

    public DateTime? ScreationDate { get; set; }

    public int Messageno { get; set; }
}
