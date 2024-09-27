using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class TradingTokenReturn
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public int? TokenReceiptSrno { get; set; }

    public string? PaymentMode { get; set; }

    public string? BankId { get; set; }

    public double? TradingTokenReturnAmount { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public int? AmountInBank { get; set; }

    public string? Remarks { get; set; }

    public int? Amount { get; set; }

    public short? ProjectId { get; set; }

    public short? AreaId { get; set; }

    public string? ClientName { get; set; }

    public string? Type { get; set; }

    public int? TokenReceiptSerialNo { get; set; }

    public virtual AreaDetail? AreaDetail { get; set; }

    public virtual ProjectRegistration? ProjectRegistration { get; set; }

    public virtual SubSegment? SubSegment { get; set; }

    public virtual User? Suser { get; set; }

    public virtual TradingTokenReceipt? TradingTokenReceipt { get; set; }
}
