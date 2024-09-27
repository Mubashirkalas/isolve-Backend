using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class LiveChat
{
    public string? RoomId { get; set; }

    public string? Chat { get; set; }

    public string? PlayerId { get; set; }

    public string? CustomerName { get; set; }

    public string? Cnic { get; set; }

    public DateTime? Chatdate { get; set; }

    public bool? Viewed { get; set; }

    public int SerialNo { get; set; }

    public string? UserType { get; set; }

    public string? UserPlayerId { get; set; }
}
