using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Client
{
    public string? ClientName { get; set; }

    public string Cnic { get; set; } = null!;

    public string? PlayerId { get; set; }

    public string? RoomId { get; set; }
}
