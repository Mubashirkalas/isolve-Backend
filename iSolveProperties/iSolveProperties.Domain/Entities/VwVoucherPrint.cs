using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwVoucherPrint
{
    public int SNo { get; set; }

    public string VType { get; set; } = null!;

    public DateTime VDate { get; set; }

    public string VNo { get; set; } = null!;

    public string GlCode { get; set; } = null!;

    public string Narration { get; set; } = null!;

    public double? Dabit { get; set; }

    public double? Credit { get; set; }

    public string VKey { get; set; } = null!;

    public string VCheqNo { get; set; } = null!;

    public string Vcheqdate { get; set; } = null!;

    public string? VUserName { get; set; }

    public DateTime? VEnterDate { get; set; }

    public string? VConfirmedBy { get; set; }

    public string GlDesc { get; set; } = null!;

    public string VoucherType { get; set; } = null!;

    public string GlYear { get; set; } = null!;

    public int CompId { get; set; }

    public string? Invno { get; set; }

    public bool Vpost { get; set; }
}
