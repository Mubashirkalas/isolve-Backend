using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Psdetail
{
    public byte? CompId { get; set; }

    public int ProjectSrno { get; set; }

    public short Sno { get; set; }

    public string? Description { get; set; }

    public DateOnly? DueDate { get; set; }

    public DateOnly? PaidDate { get; set; }

    public int? Amount { get; set; }

    public int? PaidAmount { get; set; }

    public string? PaymentMode { get; set; }

    public string? ReferenceNo { get; set; }

    public string? Remarks { get; set; }

    public string? LatePaymentChargesStatus { get; set; }

    public decimal? LateChargesTotal { get; set; }

    public decimal? LateChargesPaid { get; set; }

    public decimal? LateChargesPayable { get; set; }

    public virtual ProjectSale? ProjectSale { get; set; }
}
