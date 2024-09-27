using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class EmailCompaign
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? SerialNo { get; set; }

    public string? Keys { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? CustomerType { get; set; }

    public short? Project { get; set; }

    public string? Msg { get; set; }

    public byte? TypeId { get; set; }

    public string? Subject { get; set; }

    public virtual BookingTypeDetail? BookingTypeDetail { get; set; }

    public virtual Companysetup Comp { get; set; } = null!;

    public virtual ProjectRegistration? ProjectRegistration { get; set; }

    public virtual SubSegment? SubSegment { get; set; }
}
