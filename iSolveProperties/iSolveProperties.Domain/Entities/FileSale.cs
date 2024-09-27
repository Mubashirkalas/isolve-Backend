using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class FileSale
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public string? SerialNo { get; set; }

    public byte? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? Bpcode { get; set; }

    public double? Cash { get; set; }

    public double? Bank { get; set; }

    public int BankId { get; set; }

    public string? AccountNo { get; set; }

    public double? Total { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public string? ReferingPersonCode { get; set; }

    public double? Commision { get; set; }

    public short? ProjectId { get; set; }

    public string? ChequeNo { get; set; }

    public DateOnly? ChequeDate { get; set; }

    public string? RemarksMain { get; set; }

    public string? Sp2code { get; set; }

    public int? Com2 { get; set; }

    public string? Sp3code { get; set; }

    public int? Com3 { get; set; }

    public string? Sp4code { get; set; }

    public int? Com4 { get; set; }

    public virtual BusinessPartnersMain? BusinessPartnersMain { get; set; }

    public virtual ProjectRegistration? ProjectRegistration { get; set; }
}
