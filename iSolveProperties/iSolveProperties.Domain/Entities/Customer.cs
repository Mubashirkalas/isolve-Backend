using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Customer
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string PhoneNumber { get; set; } = null!;
}
