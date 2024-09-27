using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class TeamLeaderDetail
{
    public int SerialNo { get; set; }

    public byte CompId { get; set; }

    public short? Sno { get; set; }

    public short? UserId { get; set; }

    public short? LeaderUserId { get; set; }

    public virtual TeamLeader TeamLeader { get; set; } = null!;

    public virtual User? User { get; set; }
}
