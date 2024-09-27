using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class FormsReceivingDetail
{
    public int? Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public short Sno { get; set; }

    public short? AreaId { get; set; }

    public byte? CategoryId { get; set; }

    public int? FileNo { get; set; }

    public string? Status { get; set; }

    public string? FormNo { get; set; }

    public virtual AreaDetail? AreaDetail { get; set; }

    public virtual FormsReceiving? FormsReceiving { get; set; }

    public virtual PropertyDetail? PropertyDetail { get; set; }
}
