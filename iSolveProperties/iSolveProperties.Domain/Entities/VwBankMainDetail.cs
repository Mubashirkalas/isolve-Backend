using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwBankMainDetail
{
    public string? AccountNumber { get; set; }

    public string? AccountTitle { get; set; }

    public string? BankName { get; set; }

    public int CompId { get; set; }

    public byte BankId { get; set; }
}
