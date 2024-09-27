using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwDealPurchase
{
    public string? Bpname { get; set; }

    public string? BankName { get; set; }

    public string? AccountTitle { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? SerialNo { get; set; }

    public byte? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? Bpcode { get; set; }

    public double? Amount { get; set; }

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

    public int? FileFrom { get; set; }

    public int? FileTo { get; set; }

    public string? DealName { get; set; }

    public double? TotalAmount { get; set; }

    public short? AreaSerialNo { get; set; }

    public string? AreaName { get; set; }

    public string? PaymentMode { get; set; }

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

    public bool? ManualFormNo { get; set; }

    public int? AmountSeven { get; set; }

    public int? RateSeven { get; set; }

    public short? QtySeven { get; set; }

    public byte? PropertySeven { get; set; }

    public short? AreaSeven { get; set; }

    public int? AmountSix { get; set; }

    public int? RateSix { get; set; }

    public short? QtySix { get; set; }

    public byte? PropertySix { get; set; }

    public short? AreaSix { get; set; }

    public string? AreaNameTwo { get; set; }

    public string? AreaNameThree { get; set; }

    public string? AreaNameFour { get; set; }

    public string? AreaNameFive { get; set; }

    public string? AreaNameSix { get; set; }

    public string? AreaNameSeven { get; set; }

    public string? PropertyNameOne { get; set; }

    public string? PropertyNameTwo { get; set; }

    public string? PropertyNameThree { get; set; }

    public string? PropertyNameFour { get; set; }

    public string? PropertyNameFive { get; set; }

    public string? PropertyNameSix { get; set; }

    public string? PropertyNameSeven { get; set; }
}
