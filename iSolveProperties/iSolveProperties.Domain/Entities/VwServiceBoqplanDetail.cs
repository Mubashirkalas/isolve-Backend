using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwServiceBoqplanDetail
{
    public int SerialNo { get; set; }

    public byte CompId { get; set; }

    public short? Sno { get; set; }

    public short? ServiceId { get; set; }

    public string? ServicesName { get; set; }
}
