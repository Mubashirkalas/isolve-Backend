using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwGetSocietyInstallment
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public string SerialNo { get; set; } = null!;

    public byte SubSegmentId { get; set; }

    public DateOnly Date { get; set; }

    public int BookingFormSrno { get; set; }

    public double Payment { get; set; }

    public string? ClientName { get; set; }

    public string? Contact { get; set; }

    public string? BookingFormNo { get; set; }

    public double? Amount { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? Bpname { get; set; }

    public string? VendorCode { get; set; }

    public string? Project { get; set; }

    public string? AreaTitle { get; set; }

    public string? ProjectName { get; set; }

    public string? SocietyInstallmentPayment { get; set; }

    public string? ProjectId { get; set; }

    public string? City { get; set; }

    public DateOnly PaymentDate { get; set; }
}
