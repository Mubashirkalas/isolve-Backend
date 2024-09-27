using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class BlocksDetail
{
    public short SerialNo { get; set; }

    public byte CompId { get; set; }

    public string? BlockName { get; set; }

    public short? SuserId { get; set; }

    public string? SuserName { get; set; }

    public string? SworkStation { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MuserName { get; set; }

    public string? MworkStation { get; set; }

    public DateTime? McreationDate { get; set; }

    public virtual ICollection<ItemBoqplan> ItemBoqplans { get; set; } = new List<ItemBoqplan>();

    public virtual ICollection<ProjectSale> ProjectSales { get; set; } = new List<ProjectSale>();
}
