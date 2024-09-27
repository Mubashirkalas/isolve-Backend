using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class BankMaster
{
    public byte BankId { get; set; }

    public string? BankName { get; set; }

    public DateOnly? Date { get; set; }

    public string? RegisterAddress { get; set; }

    public int? SubSegmentId { get; set; }

    public int CompId { get; set; }

    public short? UserId { get; set; }

    public string? WorkStation { get; set; }
}
