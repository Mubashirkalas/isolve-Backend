using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwTradingClosing
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public DateOnly? Date { get; set; }

    public int? TradingSerialNo { get; set; }

    public int? PurchaseAmountPayable { get; set; }

    public int? PurchaseAmountPaid { get; set; }

    public int? SalesAmountPayable { get; set; }

    public int? SalesAmountPaid { get; set; }

    public string? SalesPersonOne { get; set; }

    public string? SalesPersonOneName { get; set; }

    public string? SalesPersonTwo { get; set; }

    public string? SalesPersonTwoName { get; set; }

    public string? SalesPersonThree { get; set; }

    public string? SalesPersonThreeName { get; set; }

    public string? SubDealer { get; set; }

    public string? SubDealerName { get; set; }

    public string Remarks { get; set; } = null!;

    public int? SalesPersonOneCommission { get; set; }

    public int? SalesPersonTwoCommission { get; set; }

    public int? SalesPersonThreeCommission { get; set; }

    public int? SubDealerCommission { get; set; }

    public string? PreparedBy { get; set; }

    public short? ProjectId { get; set; }

    public string? ProjectName { get; set; }

    public string? TradingType { get; set; }

    public short? TradingSubSegmentId { get; set; }

    public string? TradingSubSegmentName { get; set; }

    public string? FileNo { get; set; }

    public string? SalesPersonFour { get; set; }

    public string? SalesPersonFive { get; set; }

    public int? SalesPersonFourCommission { get; set; }

    public int? SalesPersonFiveCommission { get; set; }

    public string? SalesPersonFourName { get; set; }

    public string? SalesPersonFiveName { get; set; }
}
