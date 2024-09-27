using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class BusinessPartnersDetailBank
{
    public int? Sno { get; set; }

    public string? BankCode { get; set; }

    public string? BankName { get; set; }

    public string? AccountNumber { get; set; }

    public string? BranchName { get; set; }

    public string? BranchCode { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    public string? BusinessPartnersCode { get; set; }

    public byte? CompId { get; set; }

    public string? BpType { get; set; }

    public virtual BusinessPartnersMain? BusinessPartnersMain { get; set; }
}
