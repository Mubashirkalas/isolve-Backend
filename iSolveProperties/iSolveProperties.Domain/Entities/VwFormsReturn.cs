using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwFormsReturn
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? SerialNo { get; set; }

    public DateOnly? Date { get; set; }

    public short? UserId { get; set; }

    public string? Bpcode { get; set; }

    public string? UserName { get; set; }

    public string? Bpname { get; set; }
}
