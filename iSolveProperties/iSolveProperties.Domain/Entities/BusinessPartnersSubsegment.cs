using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class BusinessPartnersSubsegment
{
    public byte? SubSegmentId { get; set; }

    public string? BusinessPartnersCode { get; set; }

    public byte? CompId { get; set; }

    public string? BpType { get; set; }

    public int? Listindex { get; set; }

    public virtual BusinessPartnersMain? BusinessPartnersMain { get; set; }
}
