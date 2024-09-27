using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class ChequebookRegistrationDetail
{
    public string? Srno { get; set; }

    public short? Sno { get; set; }

    public string? ChequebookNo { get; set; }

    public string? ChequeFrom { get; set; }

    public string? ChequeTo { get; set; }

    public short? TotalLeafs { get; set; }

    public byte? CompId { get; set; }

    public string? FYear { get; set; }

    public virtual ChequebookRegistrationMain? ChequebookRegistrationMain { get; set; }
}
