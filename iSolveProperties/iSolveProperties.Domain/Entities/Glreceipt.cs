using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Glreceipt
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int SerialNo { get; set; }

    public short SubSegmentId { get; set; }

    public DateOnly Date { get; set; }

    public string ClientCode { get; set; } = null!;

    public string Contact { get; set; } = null!;

    public string Cnic { get; set; } = null!;

    public short ProjectId { get; set; }

    public string Phase { get; set; } = null!;

    public string OnAccountOf { get; set; } = null!;

    public string ModeOfPayment { get; set; } = null!;

    public int Cash { get; set; }

    public int Bank { get; set; }

    public string BankId { get; set; } = null!;

    public string InstrumentNo { get; set; } = null!;

    public DateOnly InstrumentDate { get; set; }

    public string Remarks { get; set; } = null!;

    public short SuserId { get; set; }

    public string SworkStation { get; set; } = null!;

    public string SuserName { get; set; } = null!;

    public DateTime ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public string Sector { get; set; } = null!;

    public string? City { get; set; }

    public string? Branch { get; set; }

    public string? VoucherType { get; set; }

    public string? VoucherNo { get; set; }

    public int? BankAmountB { get; set; }

    public string? BankAccountB { get; set; }

    public DateOnly? BankDateB { get; set; }

    public string? BranchB { get; set; }

    public int? BankAmountC { get; set; }

    public string? BankAccountC { get; set; }

    public DateOnly? BankDateC { get; set; }

    public string? BranchC { get; set; }

    public virtual BusinessPartnersMain BusinessPartnersMain { get; set; } = null!;

    public virtual Companysetup Comp { get; set; } = null!;

    public virtual ProjectRegistration ProjectRegistration { get; set; } = null!;

    public virtual SubSegment SubSegment { get; set; } = null!;

    public virtual User Suser { get; set; } = null!;
}
