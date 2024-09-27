using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Crcancellation
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? SerialNo { get; set; }

    public short? AreaId { get; set; }

    public string? ClientName { get; set; }

    public DateOnly? Date { get; set; }

    public int? CustomerReceiptSrno { get; set; }

    public string? PaymentMode { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public double? Cash { get; set; }

    public double? Cheque { get; set; }

    public double? Online { get; set; }

    public double? InstrumentAmount { get; set; }

    public double? MembershipFee { get; set; }

    public double? TotalAmountReceived { get; set; }

    public short? ProjectId { get; set; }

    public int? CrserialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public virtual Companysetup Comp { get; set; } = null!;

    public virtual CustomerReceipt? CustomerReceipt { get; set; }

    public virtual SubSegment? SubSegment { get; set; }

    public virtual User? Suser { get; set; }
}
