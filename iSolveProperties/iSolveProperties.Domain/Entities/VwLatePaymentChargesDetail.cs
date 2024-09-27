using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwLatePaymentChargesDetail
{
    public short? Sno { get; set; }

    public string? FinancialYear { get; set; }

    public int Srno { get; set; }

    public byte CompId { get; set; }

    public int SerialNo { get; set; }

    public DateOnly Date { get; set; }

    public int ProjectSaleSrno { get; set; }

    public string PaymentMode { get; set; } = null!;

    public int Cash { get; set; }

    public string? Bpname { get; set; }

    public string? Description { get; set; }

    public DateOnly? DueDate { get; set; }

    public decimal? DueAmount { get; set; }

    public decimal? LateChargesPayable { get; set; }

    public decimal? LateChargesPaid { get; set; }

    public string? LatePaymentChargesStatus { get; set; }
}
