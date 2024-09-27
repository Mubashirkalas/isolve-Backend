using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class SubProject
{
    public short SerialNo { get; set; }

    public byte CompId { get; set; }

    public short? ProjectId { get; set; }

    public string? SubProjectName { get; set; }

    public virtual ProjectRegistration? ProjectRegistration { get; set; }
}
