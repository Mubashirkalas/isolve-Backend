using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwLeaderUser
{
    public short UserId { get; set; }

    public short? LeaderUserId { get; set; }

    public string? UserName { get; set; }

    public bool? IsMobileUser { get; set; }

    public string? LeaderUserName { get; set; }
}
