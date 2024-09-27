using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwFormsIssuance
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? SerialNo { get; set; }

    public int? DealNameSrno { get; set; }

    public DateOnly? Date { get; set; }

    public short? UserId { get; set; }

    public string? UserName { get; set; }

    public string? DealName { get; set; }
}
