using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwDiscountPostingMainDetail
{
    public string? Bpcode { get; set; }

    public string? PolicySrno { get; set; }

    public DateOnly? Date { get; set; }

    public string? Bpname { get; set; }

    public string? PolicyName { get; set; }

    public double? DiscountValue { get; set; }

    public byte CompId { get; set; }

    public string? SerialNo { get; set; }
}
