using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwTeamLeaderDetail
{
    public int SerialNo { get; set; }

    public byte CompId { get; set; }

    public short? Sno { get; set; }

    public short? UserId { get; set; }

    public string? UserName { get; set; }

    public short? LeaderUserId { get; set; }
}
