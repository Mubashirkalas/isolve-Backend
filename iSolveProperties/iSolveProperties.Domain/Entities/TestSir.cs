using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class TestSir
{
    public short? SrNo { get; set; }

    public string? CompId { get; set; }

    public string? FYear { get; set; }

    public string? VoucherNo { get; set; }

    public DateOnly? VoucherDate { get; set; }
}
