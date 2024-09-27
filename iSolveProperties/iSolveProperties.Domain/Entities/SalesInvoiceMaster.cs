using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class SalesInvoiceMaster
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string Year { get; set; } = null!;

    public byte? SubsegmentId { get; set; }

    public string? SalesInvoiceNo { get; set; }

    public DateOnly? SalesDate { get; set; }

    public string? Description { get; set; }

    public string? Type { get; set; }

    public string? Bpcode { get; set; }

    public double? TotalBill { get; set; }

    public double? Proceduraldiscount { get; set; }

    public double? Promotionaldiscount { get; set; }

    public double? Seasonaldiscount { get; set; }

    public double? Specialdiscount { get; set; }

    public double? Netbill { get; set; }

    public double? CashReceived { get; set; }

    public double? CastReturn { get; set; }

    public short? Userid { get; set; }

    public string? Workstation { get; set; }

    public string? Username { get; set; }

    public DateTime? CreationDate { get; set; }

    public short? ModifiedUserId { get; set; }

    public string? ModifiedWorkstation { get; set; }

    public string? ModifiedUsername { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? SinKey { get; set; }

    public string? VoucherKey { get; set; }

    public string? SalesMan { get; set; }

    public string? CustomerName { get; set; }

    public string? CustomerNumber { get; set; }

    public double? BankCharges { get; set; }

    public string? SalesType { get; set; }
}
