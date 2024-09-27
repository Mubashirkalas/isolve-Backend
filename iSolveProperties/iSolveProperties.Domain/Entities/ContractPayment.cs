using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class ContractPayment
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public short SubSegmentId { get; set; }

    public int SerialNo { get; set; }

    public int ContractSrno { get; set; }

    public DateOnly Date { get; set; }

    public string Remarks { get; set; } = null!;

    public int? Cash { get; set; }

    public int? Bank { get; set; }

    public short SuserId { get; set; }

    public string SworkStation { get; set; } = null!;

    public string SuserName { get; set; } = null!;

    public DateTime ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public int? Cpprice { get; set; }

    public int? Cptax236C { get; set; }

    public int? CpadmittedTax { get; set; }

    public int? Cptax236K { get; set; }

    public int? Cppra { get; set; }

    public int? Cpgst { get; set; }

    public int? CpstampDuty { get; set; }

    public int? CpotherTax { get; set; }

    public string? InstrumentNo { get; set; }

    public int? CptransferFee { get; set; }

    public string? VoucherNo { get; set; }

    public virtual Companysetup Comp { get; set; } = null!;

    public virtual Contract Contract { get; set; } = null!;
}
