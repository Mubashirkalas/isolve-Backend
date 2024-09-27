using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class QueryForPurchase
{
    public int SerialNo { get; set; }

    public short? SizeId { get; set; }

    public string? PhoneNo { get; set; }

    public string? CustomerName { get; set; }

    public byte? Qty { get; set; }

    public int? Amount { get; set; }

    public string? Status { get; set; }

    public bool? Viewed { get; set; }

    public DateTime? Date { get; set; }

    public short? PropertyDetailId { get; set; }

    public string? Address { get; set; }

    public string? Remarks { get; set; }

    public int? DownPayment { get; set; }

    public int? Installment { get; set; }

    public int? TimePeriod { get; set; }
}
