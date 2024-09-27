using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class PartialReceipt
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? DocumentNo { get; set; }

    public string? PaymentMode { get; set; }

    public int? Amount { get; set; }

    public string? AccountNo { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MuserName { get; set; }

    public string? MworkStation { get; set; }

    public DateTime? McreationDate { get; set; }

    public string? PaymentTo { get; set; }

    public string? SalesManId { get; set; }

    public int? DocumentSrno { get; set; }

    public virtual BusinessPartnersMain? BusinessPartnersMain { get; set; }

    public virtual SubSegment? SubSegment { get; set; }
}
