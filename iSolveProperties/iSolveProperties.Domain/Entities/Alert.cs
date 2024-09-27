using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Alert
{
    public short? Id { get; set; }

    public string? Description { get; set; }

    public string? Priority { get; set; }

    public bool? Po { get; set; }

    public bool? Grn { get; set; }

    public bool? Grnr { get; set; }

    public bool? Sin { get; set; }

    public bool? Sinr { get; set; }

    public bool? Ip { get; set; }

    public bool? PartyPayment { get; set; }

    public bool? BankClearing { get; set; }

    public bool? PartyReceipts { get; set; }

    public bool? DepositedIn { get; set; }

    public bool? Pnr { get; set; }

    public bool? ItemMaster { get; set; }

    public bool? BusinessPartner { get; set; }

    public string? Type { get; set; }
}
