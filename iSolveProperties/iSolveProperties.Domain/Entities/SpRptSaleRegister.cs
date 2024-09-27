using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class SpRptSaleRegister
{
    public string? Itemcode { get; set; }

    public string ItemName { get; set; } = null!;

    public string? Partycode { get; set; }

    public string PartyName { get; set; } = null!;

    public double? SalesExclSt { get; set; }

    public string? VInvNo { get; set; }

    public DateOnly? VInvDate { get; set; }

    public double? Qty1 { get; set; }

    public string? Unit1 { get; set; }

    public string PartyAddress { get; set; } = null!;

    public short? VstaxRate { get; set; }

    public string StaxReg { get; set; } = null!;

    public string? ContractNo { get; set; }

    public DateOnly? VContractDate { get; set; }

    public double? Qty2 { get; set; }

    public string? Unit2 { get; set; }

    public decimal? VExcRate { get; set; }

    public string? VPort { get; set; }

    public string? CommInv { get; set; }

    public DateOnly? CommInvDate { get; set; }
}
