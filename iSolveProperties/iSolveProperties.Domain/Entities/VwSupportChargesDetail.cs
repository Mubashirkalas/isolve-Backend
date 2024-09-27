using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwSupportChargesDetail
{
    public int SerialNo { get; set; }

    public byte CompId { get; set; }

    public short? Sno { get; set; }

    public string? Bpcode { get; set; }

    public int? SupportCharges { get; set; }

    public byte? DueOn { get; set; }

    public string? Bpname { get; set; }

    public DateOnly? Date { get; set; }

    public string? SubSegmentName { get; set; }

    public short? SubSegmentId { get; set; }
}
