using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwJoborderDriverLoader
{
    public string? DriverName { get; set; }

    public string? DriverLicenseType { get; set; }

    public DateOnly? DriverLicenseExpiryDate { get; set; }

    public string? DriverPhoneNo { get; set; }

    public string DriverCode { get; set; } = null!;
}
