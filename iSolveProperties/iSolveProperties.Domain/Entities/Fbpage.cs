using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Fbpage
{
    public int FbpagesId { get; set; }

    public string? PageId { get; set; }

    public string? Name { get; set; }

    public string? AccessToken { get; set; }

    public string? Response { get; set; }

    public DateTime? AddedDate { get; set; }
}
