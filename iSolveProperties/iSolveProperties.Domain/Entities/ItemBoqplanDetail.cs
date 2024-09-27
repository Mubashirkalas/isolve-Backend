using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class ItemBoqplanDetail
{
    public int SerialNo { get; set; }

    public byte CompId { get; set; }

    public short Sno { get; set; }

    public string GroupCode { get; set; } = null!;

    public string ItemCode { get; set; } = null!;

    public string Uom { get; set; } = null!;

    public int Qty { get; set; }

    public virtual ItemBoqplan ItemBoqplan { get; set; } = null!;

    public virtual ItemMaster ItemMaster { get; set; } = null!;
}
