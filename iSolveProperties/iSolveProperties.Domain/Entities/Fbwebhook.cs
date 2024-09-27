using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Fbwebhook
{
    public int Id { get; set; }

    public string? Response { get; set; }

    public DateTime? AddedDate { get; set; }
}
