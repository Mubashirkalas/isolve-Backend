using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwLatePaymentCharge
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public byte SubSegmentId { get; set; }

    public int SerialNo { get; set; }

    public DateOnly Date { get; set; }

    public string Bpcode { get; set; } = null!;

    public int ProjectSaleSrno { get; set; }

    public string PaymentMode { get; set; } = null!;

    public int Cash { get; set; }

    public string BankId { get; set; } = null!;

    public int AmountInBank { get; set; }

    public byte? PropertyDetail { get; set; }

    public string? Bpname { get; set; }

    public string? BookingType { get; set; }

    public byte? BookingCategory { get; set; }

    public string? Dealer { get; set; }

    public string? DealerCode { get; set; }

    public string? ReferringType { get; set; }

    public string? AreaTitle { get; set; }

    public string? PropertyTitle { get; set; }

    public string? CategoryTitle { get; set; }

    public string? TypeTitle { get; set; }

    public string? ProjectName { get; set; }

    public string? Cnic { get; set; }

    public string? ProjectSaleNo { get; set; }

    public string? PropertyDescription { get; set; }

    public string? BlockName { get; set; }

    public double? TotalAmount { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public byte[]? SubSegmentPic { get; set; }

    public short SuserId { get; set; }

    public string SworkStation { get; set; } = null!;

    public string SuserName { get; set; } = null!;

    public DateTime ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public string? BankName { get; set; }

    public short? ProjectId { get; set; }

    public int WaiveOff { get; set; }
}
