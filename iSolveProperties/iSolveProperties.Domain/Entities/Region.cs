using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Region
{
    public string GlCode { get; set; } = null!;

    public string? GlDesc { get; set; }

    public string? GlYear { get; set; }

    public byte CompId { get; set; }

    public string? GlHidecode { get; set; }

    public virtual ICollection<DeliveryDispatchMaster> DeliveryDispatchMasters { get; set; } = new List<DeliveryDispatchMaster>();
}
