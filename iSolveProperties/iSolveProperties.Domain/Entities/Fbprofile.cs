using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Fbprofile
{
    public int FbprofileId { get; set; }

    public string? ProfileId { get; set; }

    public string? AccessToken { get; set; }

    public string? Response { get; set; }

    public DateTime? AddedDate { get; set; }
}
