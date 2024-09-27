using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwAlertUser
{
    public short? Srno { get; set; }

    public string? UserName { get; set; }

    public bool? Internal { get; set; }

    public bool? Email { get; set; }

    public bool? Sms { get; set; }

    public bool? Fax { get; set; }

    public int UserId { get; set; }
}
