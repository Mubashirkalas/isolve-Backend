using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class ServiceBoqplanDetail
{
    public int SerialNo { get; set; }

    public byte CompId { get; set; }

    public short? Sno { get; set; }

    public short? ServiceId { get; set; }

    public virtual ServiceBoqplan ServiceBoqplan { get; set; } = null!;
}
