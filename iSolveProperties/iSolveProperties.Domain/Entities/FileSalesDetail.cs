using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class FileSalesDetail
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? Sno { get; set; }

    public string? FilePurchasingSrno { get; set; }

    public string? FileNo { get; set; }

    public string? BookingFormNo { get; set; }

    public string? Category { get; set; }

    public string? Type { get; set; }

    public string? PropertyDetail { get; set; }

    public string? Area { get; set; }

    public double? PurchasePrice { get; set; }

    public double? SalesPrice { get; set; }

    public double? Difference { get; set; }

    public string? Remarks { get; set; }

    public int? BookingFormSrno { get; set; }

    public short? ProjectId { get; set; }

    public string? ClientName { get; set; }

    public string? Contact { get; set; }

    public string? Cnic { get; set; }

    public short? BlockTypeId { get; set; }

    public string? FileStatus { get; set; }

    public virtual FileSale FileSale { get; set; } = null!;
}
