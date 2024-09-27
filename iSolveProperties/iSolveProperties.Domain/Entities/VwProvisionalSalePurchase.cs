using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwProvisionalSalePurchase
{
    public int SerialNo { get; set; }

    public string? Date { get; set; }

    public string? Type { get; set; }

    public string? Project { get; set; }

    public string? BookingType { get; set; }

    public string? Area { get; set; }

    public short? SuserId { get; set; }

    public string? UserName { get; set; }

    public bool? Approved { get; set; }

    public string? Amount { get; set; }

    public string ApproveStatus { get; set; } = null!;

    public short? ProjectId { get; set; }

    public short? SizeId { get; set; }

    public short? BookingTypeId { get; set; }

    public short? ApprovedUserId { get; set; }
}
