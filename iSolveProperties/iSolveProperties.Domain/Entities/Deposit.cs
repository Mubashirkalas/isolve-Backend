using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Deposit
{
    public int SerialNo { get; set; }

    public int? LeadSerialNo { get; set; }

    public DateOnly? DepositDate { get; set; }

    public int? Amount { get; set; }

    public int? UserId { get; set; }
}
