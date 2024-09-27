using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwQuantativeSale
{
    public string? SalesName { get; set; }

    public string? BusinessPartnersName { get; set; }

    public double? Qty { get; set; }

    public double ReturnQty { get; set; }

    public string? BpCode { get; set; }

    public string? GroupCode { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public string? ItemName { get; set; }

    public string? ItDesc { get; set; }

    public string? RouteName { get; set; }

    public string? SerialNo { get; set; }

    public string? RouteId { get; set; }

    public byte? CompId { get; set; }
}
