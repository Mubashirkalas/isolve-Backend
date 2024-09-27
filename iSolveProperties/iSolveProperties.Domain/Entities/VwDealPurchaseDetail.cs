using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwDealPurchaseDetail
{
    public string? Bpname { get; set; }

    public string? BankName { get; set; }

    public string? AccountTitle { get; set; }

    public string? SubSegmentName { get; set; }

    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? SerialNo { get; set; }

    public byte? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? Bpcode { get; set; }

    public double? PaidViaCash { get; set; }

    public int? BankId { get; set; }

    public string? AccountNo { get; set; }

    public double? PaidViaBank { get; set; }

    public string? ChequebookNo { get; set; }

    public string? ChequeNo { get; set; }

    public DateOnly? ChequeDate { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public short? Project { get; set; }

    public string? ProjectName { get; set; }

    public double? Amount { get; set; }

    public int? FileNo { get; set; }

    public int? Sno { get; set; }

    public string? Status { get; set; }

    public double? DealPurchaseAmount { get; set; }

    public int? FileFrom { get; set; }

    public int? FileTo { get; set; }

    public string? DealName { get; set; }

    public double? TotalAmount { get; set; }

    public short? AreaSerialNo { get; set; }

    public string? AreaName { get; set; }

    public short? AreaId { get; set; }

    public byte? PropertyType { get; set; }

    public int? InstrumentAmount { get; set; }

    public short? AreaTwo { get; set; }

    public short? AreaThree { get; set; }

    public short? AreaFour { get; set; }

    public short? AreaFive { get; set; }

    public byte? PropertyOne { get; set; }

    public byte? PropertyTwo { get; set; }

    public byte? PropertyThree { get; set; }

    public byte? PropertyFour { get; set; }

    public byte? PropertyFive { get; set; }

    public short? QtyOne { get; set; }

    public short? QtyTwo { get; set; }

    public short? QtyThree { get; set; }

    public short? QtyFour { get; set; }

    public short? QtyFive { get; set; }

    public int? RateOne { get; set; }

    public int? RateTwo { get; set; }

    public int? RateThree { get; set; }

    public int? RateFour { get; set; }

    public int? RateFive { get; set; }

    public int? AmountOne { get; set; }

    public int? AmountTwo { get; set; }

    public int? AmountThree { get; set; }

    public int? AmountFour { get; set; }

    public int? AmountFive { get; set; }

    public string? FormNo { get; set; }

    public string? Area { get; set; }

    public string? Property { get; set; }
}
