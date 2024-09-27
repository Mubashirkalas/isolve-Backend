using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class SmscompaignDetail
{
    public int? Srno { get; set; }

    public short? CompId { get; set; }

    public string? FinancialYear { get; set; }

    public short? SubSegmentId { get; set; }

    public string? Keys { get; set; }

    public int? Sno { get; set; }

    public int? BookingFormSrno { get; set; }

    public int? LeadsFormSrno { get; set; }

    public int? ProjectSaleSrno { get; set; }

    public virtual Smscompaign? Smscompaign { get; set; }
}
