using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class BookingTypeDetail
{
    public byte SerialNo { get; set; }

    public byte CompId { get; set; }

    public string? Type { get; set; }

    public short? SuserId { get; set; }

    public string? SuserName { get; set; }

    public string? SworkStation { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MuserName { get; set; }

    public string? MworkStation { get; set; }

    public DateTime? McreationDate { get; set; }

    public virtual ICollection<EmailCompaign> EmailCompaigns { get; set; } = new List<EmailCompaign>();

    public virtual ICollection<ProjectSale> ProjectSales { get; set; } = new List<ProjectSale>();
}
