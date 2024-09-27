using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class ProvisionalSalePurchase
{
    public int SerialNo { get; set; }

    public string? Type { get; set; }

    public DateTime? Date { get; set; }

    public short? ProjectId { get; set; }

    public short? SizeId { get; set; }

    public short? BookingTypeId { get; set; }

    public double? Amount { get; set; }

    public short? SuserId { get; set; }

    public bool? Approved { get; set; }

    public short? ApprovedUserId { get; set; }

    public string? ApprovalTime { get; set; }

    public DateTime? ApprovalDateTime { get; set; }
}
