using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VWSalesInvoiceReport
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string Year { get; set; } = null!;

    public byte? SubsegmentId { get; set; }

    public string? SubSegmentName { get; set; }

    public string? SalesInvoiceNo { get; set; }

    public DateOnly? SalesDate { get; set; }

    public double? TotalBill { get; set; }

    public double? CashReceived { get; set; }

    public double? CastReturn { get; set; }

    public short? Sno { get; set; }

    public string? GroupCode { get; set; }

    public string? ItDesc { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? Uom { get; set; }

    public int? Qty { get; set; }

    public double? Rate { get; set; }

    public double? Value { get; set; }

    public string? CName { get; set; }

    public string? CAbber { get; set; }

    public string? Address { get; set; }

    public string? Saletax { get; set; }

    public string? Ntn { get; set; }

    public string? Phoneno { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Url { get; set; }

    public byte[]? Pic { get; set; }

    public string? Levels { get; set; }

    public DateOnly? Vdate { get; set; }

    public double? Proceduraldiscount { get; set; }

    public double? Promotionaldiscount { get; set; }

    public double? Seasonaldiscount { get; set; }

    public double? Specialdiscount { get; set; }

    public double? Netbill { get; set; }

    public short? Userid { get; set; }

    public string? UserName { get; set; }

    public string? Bpcode { get; set; }

    public string? BusinessPartnersName { get; set; }

    public string? BpFax { get; set; }

    public string? BpEmail { get; set; }

    public string? BpTel { get; set; }

    public string? RegisteredOfficeAdress { get; set; }

    public double? Discount { get; set; }

    public double? TotalValue { get; set; }
}
