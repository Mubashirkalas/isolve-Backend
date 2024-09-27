using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class TradingTokenReceipt
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public double? Amount { get; set; }

    public string? PaymentMode { get; set; }

    public short? ProjectRegistrationSerialNo { get; set; }

    public short? AreaDetailsSerialNo { get; set; }

    public int? BankId { get; set; }

    public string? Remarks { get; set; }

    public string? TokenReturn { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public string? FileInventoryFileNo { get; set; }

    public string? ProjectInventoryStatusUpdationKey { get; set; }

    public string? InventoryType { get; set; }

    public string? AccountNumber { get; set; }

    public string? ClientName { get; set; }

    public int? AmountInBank { get; set; }

    public string? Type { get; set; }

    public string? Status { get; set; }

    public string? PartyCode { get; set; }

    public virtual AreaDetail? AreaDetail { get; set; }

    public virtual Companysetup Comp { get; set; } = null!;

    public virtual ProjectRegistration? ProjectRegistration { get; set; }

    public virtual SubSegment? SubSegment { get; set; }

    public virtual User? Suser { get; set; }

    public virtual ICollection<TradingTokenReturn> TradingTokenReturns { get; set; } = new List<TradingTokenReturn>();
}
