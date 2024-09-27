using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwChequebookRegistrationReport
{
    public string Srno { get; set; } = null!;

    public string? SerialNo { get; set; }

    public DateOnly? ToDate { get; set; }

    public string? AcNo { get; set; }

    public byte CompId { get; set; }

    public string FYear { get; set; } = null!;

    public byte? SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? BranchCode { get; set; }

    public string? BranchName { get; set; }

    public string? AccountTitle { get; set; }

    public string? BranchAddress { get; set; }

    public string? BankName { get; set; }

    public short? TotalLeafs { get; set; }

    public string? ChequeTo { get; set; }

    public string? ChequeFrom { get; set; }

    public string? ChequebookNo { get; set; }

    public short? Sno { get; set; }

    public DateOnly? Vdate { get; set; }

    public string? Levels { get; set; }

    public byte[]? Pic { get; set; }

    public string? Url { get; set; }

    public string? Email { get; set; }

    public string? CompAddress { get; set; }

    public string? Saletax { get; set; }

    public string? Ntn { get; set; }

    public string? Phoneno { get; set; }

    public string? Fax { get; set; }

    public string? CAbber { get; set; }

    public string? CName { get; set; }
}
