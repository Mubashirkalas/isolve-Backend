using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwProjectWiseGl
{
    public int SerialNo { get; set; }

    public string? InstallmentPayable { get; set; }

    public string? InstallmentPayableDesc { get; set; }

    public string? Discount { get; set; }

    public string? DiscountDesc { get; set; }

    public string? Apaccural { get; set; }

    public string? ApaccuralDesc { get; set; }

    public string? BookingPayable { get; set; }

    public string? BookingPayableDesc { get; set; }

    public string? Token { get; set; }

    public string? TokenDesc { get; set; }

    public string? RentalExpense { get; set; }

    public string? RentalExpenseDesc { get; set; }

    public string? TradingIncome { get; set; }

    public string? Cash { get; set; }

    public string? CashDesc { get; set; }

    public string? FileInventory { get; set; }

    public string? FileInventoryDesc { get; set; }

    public string? Chequesinhand { get; set; }

    public string? ChequesinhandDesc { get; set; }

    public string? ConfirmationPayable { get; set; }

    public string? ConfirmationPayableDesc { get; set; }

    public string? CommissionExpense { get; set; }

    public string? CommissionExpenseDesc { get; set; }

    public string? CommissionIncome { get; set; }

    public string? CommissionIncomeDesc { get; set; }

    public string? TradingReceivable { get; set; }

    public string? TradingReceivableDesc { get; set; }

    public string? InstrumentReceivable { get; set; }

    public string? InstrumentReceivableDesc { get; set; }

    public string? General { get; set; }

    public string? GeneralDesc { get; set; }

    public string? TradingIncomeDesc { get; set; }

    public short? SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public byte CompId { get; set; }

    public short? ProjectId { get; set; }

    public string? ProjectName { get; set; }

    public string? OtherIncome { get; set; }

    public string? OtherIncomeDesc { get; set; }
}
