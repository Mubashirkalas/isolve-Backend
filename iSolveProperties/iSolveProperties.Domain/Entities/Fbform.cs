using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Fbform
{
    public int FbformId { get; set; }

    public string? FormId { get; set; }

    public string? Name { get; set; }

    public string? AccessToken { get; set; }

    public string? Response { get; set; }

    public DateTime? AddedDate { get; set; }
}
