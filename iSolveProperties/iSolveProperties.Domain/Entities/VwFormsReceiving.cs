using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwFormsReceiving
{
    public string? ReceivedBy { get; set; }

    public int? Srno { get; set; }

    public byte? CompId { get; set; }

    public string? FinancialYear { get; set; }

    public DateOnly? Date { get; set; }

    public int? DealPurchaseSrno { get; set; }

    public short? UserId { get; set; }

    public string? Location { get; set; }

    public int? SerialNo { get; set; }

    public string? Vendor { get; set; }

    public string? ProjectName { get; set; }

    public string? DealName { get; set; }
}
