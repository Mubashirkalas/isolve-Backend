using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwTokenReturn
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? TokenReceiptSrno { get; set; }

    public string? PaymentMode { get; set; }

    public string? BankId { get; set; }

    public double? TokenReturnAmount { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? ToBankName { get; set; }

    public int? AmountInBank { get; set; }

    public string? UserName { get; set; }

    public string? ClientName { get; set; }

    public short? AreaDetailsSerialNo { get; set; }

    public string? AreaName { get; set; }

    public string? ToBankCode { get; set; }

    public string? CrtoBankName { get; set; }

    public int? DealSrno { get; set; }

    public short? ProjectId { get; set; }

    public string? ProjectName { get; set; }

    public int? TokenReceiptSerialNo { get; set; }

    public string? Remarks { get; set; }

    public double? Cash { get; set; }

    public double? Cheque { get; set; }

    public double? Online { get; set; }

    public double? InstrumentAmount { get; set; }

    public double? Discount { get; set; }

    public double? MembershipFee { get; set; }

    public double? OwnAmount { get; set; }

    public double? TotalAmountReceived { get; set; }

    public int? CrownAmount { get; set; }

    public int? CrmembershipFee { get; set; }

    public double? Crcash { get; set; }

    public double? Crcheque { get; set; }

    public double? Cronline { get; set; }

    public double? CrtotalAmountReceived { get; set; }

    public double? Crdiscount { get; set; }

    public int? CrinstrumentAmount { get; set; }

    public string? SalesPersonCommission { get; set; }

    public string? SalesPersonName { get; set; }

    public byte? BankIdonly { get; set; }
}
