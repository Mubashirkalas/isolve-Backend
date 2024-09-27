using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class LatePaymentCharge
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public byte SubSegmentId { get; set; }

    public int SerialNo { get; set; }

    public DateOnly Date { get; set; }

    public string Bpcode { get; set; } = null!;

    public int ProjectSaleSrno { get; set; }

    public string PaymentMode { get; set; } = null!;

    public int Cash { get; set; }

    public string BankId { get; set; } = null!;

    public int AmountInBank { get; set; }

    public int WaiveOff { get; set; }

    public short SuserId { get; set; }

    public string SworkStation { get; set; } = null!;

    public string SuserName { get; set; } = null!;

    public DateTime ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public virtual ProjectSale ProjectSale { get; set; } = null!;
}
