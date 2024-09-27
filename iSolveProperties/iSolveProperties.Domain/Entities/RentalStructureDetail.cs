using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class RentalStructureDetail
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public short? Sno { get; set; }

    public DateOnly? Date { get; set; }

    public int? RentalAmount { get; set; }

    public virtual RentalStructure RentalStructure { get; set; } = null!;
}
