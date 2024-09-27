using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class TokenReceipt
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public string? SerialNo { get; set; }

    public byte? SubSegmentId { get; set; }

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

    public virtual AreaDetail? AreaDetail { get; set; }

    public virtual ProjectRegistration? ProjectRegistration { get; set; }
}
