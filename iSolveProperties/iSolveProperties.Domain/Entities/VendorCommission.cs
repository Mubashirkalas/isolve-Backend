using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VendorCommission
{
    public string SerialNo { get; set; } = null!;

    public byte CompId { get; set; }

    public string? Bpcode { get; set; }

    public DateOnly? ApplicableDate { get; set; }

    public string? PlanName { get; set; }

    public short? SuserId { get; set; }

    public string? SuserName { get; set; }

    public string? SworkStation { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MuserName { get; set; }

    public string? MworkStation { get; set; }

    public DateTime? McreationDate { get; set; }

    public virtual BusinessPartnersMain? BusinessPartnersMain { get; set; }
}
