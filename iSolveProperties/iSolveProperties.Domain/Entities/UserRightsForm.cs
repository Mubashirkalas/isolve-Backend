using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class UserRightsForm
{
    public int UserId { get; set; }

    public string? Item { get; set; }
}
