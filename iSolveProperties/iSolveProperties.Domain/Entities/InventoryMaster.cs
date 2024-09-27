using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class InventoryMaster
{
    public int? Grnno { get; set; }

    public string? Type { get; set; }

    public DateOnly? Grndate { get; set; }

    public string? Bpcode { get; set; }

    public string Keys { get; set; } = null!;

    public string Year { get; set; } = null!;

    public short? SUser { get; set; }

    public byte CompId { get; set; }

    public short? TrUserid { get; set; }

    public string? TrWorkstation { get; set; }

    public string? TrUsername { get; set; }

    public DateTime? TrCreationDate { get; set; }

    public short? SubSegmentId { get; set; }

    public int? Srno { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedUsername { get; set; }

    public string? ModifiedWorkstation { get; set; }

    public short? ModifiedUserId { get; set; }

    public string? GrnVoucherKey { get; set; }

    public string? Status { get; set; }

    public int? GrnReturnNo { get; set; }

    public long SerialNo { get; set; }

    public string? BuiltyNo { get; set; }

    public DateOnly? InvoiceDate { get; set; }

    public decimal? FreightAmount { get; set; }

    public string? CompanyName { get; set; }

    public string? Recievername { get; set; }

    public string? InvoiceNo { get; set; }

    public DateOnly? BuiltyDate { get; set; }

    public string? FreightType { get; set; }

    public string? PaymentMode { get; set; }

    public string? PaidBy { get; set; }

    public short? SuserId { get; set; }

    public string? SuserName { get; set; }

    public string? SworkStation { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MuserName { get; set; }

    public string? MworkStation { get; set; }

    public DateTime? McreationDate { get; set; }

    public string? Remarks { get; set; }

    public string? Igpno { get; set; }

    public string? Igpdate { get; set; }

    public string? Igpkeys { get; set; }

    public string? Igptype { get; set; }

    public bool? Approved { get; set; }
}
