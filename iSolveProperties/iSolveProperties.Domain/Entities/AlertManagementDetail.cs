using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class AlertManagementDetail
{
    public short? Srno { get; set; }

    public short? UserId { get; set; }

    public bool? Internal { get; set; }

    public bool? Email { get; set; }

    public bool? Sms { get; set; }

    public bool? Fax { get; set; }

    public virtual AlertManagementMain? SrnoNavigation { get; set; }
}
