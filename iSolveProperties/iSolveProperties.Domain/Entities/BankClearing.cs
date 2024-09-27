using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class BankClearing
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public short? SubSegmentId { get; set; }

    public string? SerialNo { get; set; }

    public DateOnly? Date { get; set; }

    public string? AccountNo { get; set; }

    public string? Type { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public DateTime? McreationDate { get; set; }

    public string? MuserName { get; set; }

    public string? MworkStation { get; set; }

    public short? MuserId { get; set; }
}
