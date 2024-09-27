using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwRouteRegistration
{
    public string RouteId { get; set; } = null!;

    public byte CompId { get; set; }

    public string? RouteName { get; set; }

    public string? Mileage { get; set; }

    public string? Time { get; set; }

    public bool? TimeType { get; set; }

    public string? VehicleType { get; set; }

    public short? DriverExpense { get; set; }

    public short? LoaderExpense { get; set; }

    public short? TollTax { get; set; }

    public string? CustomerType { get; set; }

    public short? LoadingExpense { get; set; }
}
