using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class SireturnMaster
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string Year { get; set; } = null!;

    public byte? SubsegmentId { get; set; }

    public string? SireturnNo { get; set; }

    public string? SrnoSi { get; set; }

    public DateOnly? SireturnDate { get; set; }

    public string? Type { get; set; }

    public double? TotalBill { get; set; }

    public double? NetCashPayableBill { get; set; }

    public double? Proceduraldiscount { get; set; }

    public double? Promotionaldiscount { get; set; }

    public double? Seasonaldiscount { get; set; }

    public double? Specialdiscount { get; set; }

    public double? Netbill { get; set; }

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
}
