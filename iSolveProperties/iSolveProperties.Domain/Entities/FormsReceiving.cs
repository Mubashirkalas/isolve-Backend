using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class FormsReceiving
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public DateOnly? Date { get; set; }

    public int? DealPurchaseSrno { get; set; }

    public short? UserId { get; set; }

    public string? Location { get; set; }

    public int? SerialNo { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public virtual ICollection<FormsIssuance> FormsIssuances { get; set; } = new List<FormsIssuance>();

    public virtual User? User { get; set; }
}
