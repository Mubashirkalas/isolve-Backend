using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class EmployeeVoucherMain
{
    public string VType { get; set; } = null!;

    public DateOnly? VDate { get; set; }

    public int VNo { get; set; }

    public bool? VCancel { get; set; }

    public bool? VPost { get; set; }

    public string VKey { get; set; } = null!;

    public string? VUsername { get; set; }

    public DateTime? VEnterDate { get; set; }

    public byte? CompId { get; set; }

    public short? VUserId { get; set; }

    public string? VWorkStation { get; set; }

    public byte? SegmentId { get; set; }

    public string? FYear { get; set; }

    public string? Vremarks { get; set; }

    public string? ModifiedUserName { get; set; }

    public short? ModifiedUserId { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedWs { get; set; }

    public byte SubSegmentId { get; set; }
}
