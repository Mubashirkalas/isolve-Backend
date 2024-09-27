using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class TradingClosing
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public int? TradingSerialNo { get; set; }

    public int? PurchaseAmountPayable { get; set; }

    public int? PurchaseAmountPaid { get; set; }

    public int? SalesAmountPayable { get; set; }

    public int? SalesAmountPaid { get; set; }

    public string? SalesPersonOne { get; set; }

    public string? SalesPersonTwo { get; set; }

    public string? SalesPersonThree { get; set; }

    public string? SubDealer { get; set; }

    public string Remarks { get; set; } = null!;

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public int? SalesPersonOneCommission { get; set; }

    public int? SalesPersonTwoCommission { get; set; }

    public int? SalesPersonThreeCommission { get; set; }

    public int? SubDealerCommission { get; set; }

    public string? TradingType { get; set; }

    public short? TradingSubSegmentId { get; set; }

    public string? SalesPersonFour { get; set; }

    public string? SalesPersonFive { get; set; }

    public int? SalesPersonFourCommission { get; set; }

    public int? SalesPersonFiveCommission { get; set; }

    public virtual SubSegment? SubSegment { get; set; }
}
