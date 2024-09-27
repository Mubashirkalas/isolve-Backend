using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwRentalStructure
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public int? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public DateOnly? Date { get; set; }

    public int? ProjectSaleSrno { get; set; }

    public DateOnly? RentalStartDate { get; set; }

    public DateOnly? RentalEndDate { get; set; }

    public string? Remarks { get; set; }

    public string? ClientName { get; set; }

    public short? TotalRentals { get; set; }

    public string? ProjectName { get; set; }

    public string? PropertyDescription { get; set; }
}
