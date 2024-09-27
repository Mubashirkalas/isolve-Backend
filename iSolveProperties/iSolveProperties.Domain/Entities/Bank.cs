using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Bank
{
    public byte CompId { get; set; }

    public byte BankId { get; set; }

    public string? BankName { get; set; }
}
