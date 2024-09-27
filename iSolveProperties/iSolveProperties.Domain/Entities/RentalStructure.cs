using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class RentalStructure
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string? FinancialYear { get; set; }

    public int? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public int? ProjectSaleSrno { get; set; }

    public DateOnly? RentalStartDate { get; set; }

    public DateOnly? RentalEndDate { get; set; }

    public short? TotalRentals { get; set; }

    public string? Remarks { get; set; }

    public short? SuserId { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public string? SworkStation { get; set; }

    public DateTime? McreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MuserName { get; set; }

    public string? MworkStation { get; set; }

    public virtual ProjectSale? ProjectSale { get; set; }
}
