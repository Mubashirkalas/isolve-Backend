using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class AppRight
{
    public short UserId { get; set; }

    public int? FromAmount { get; set; }

    public int? ToAmount { get; set; }

    public bool? Bookingform { get; set; }

    public bool? Confirmation { get; set; }

    public bool? SocietyInstallment { get; set; }

    public bool? ProjectSale { get; set; }
}
