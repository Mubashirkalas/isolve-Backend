using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class BankDetail
{
    public int SubSegmentId { get; set; }

    public string? AccountNumber { get; set; }

    public string? AccountTitle { get; set; }

    public string? BranchCode { get; set; }

    public string? BranchName { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    public string? Address { get; set; }

    public string? TelephoneNo { get; set; }

    public DateOnly? AccountOpeningDate { get; set; }

    public string? ContactPerson { get; set; }

    public string? CellNo { get; set; }

    public byte BankId { get; set; }

    public int CompId { get; set; }

    public short? SrNo { get; set; }

    public string? CaCashAtBank { get; set; }

    public string? CaBankChargers { get; set; }

    public string? CaWht { get; set; }

    public string? CaBankClearing { get; set; }
}
