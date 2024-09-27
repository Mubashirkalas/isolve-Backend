using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class NewUserRightsVtype
{
    public string? Vtype { get; set; }

    public byte? CompId { get; set; }

    public short? Userid { get; set; }

    public byte? ListIndex { get; set; }

    public byte? VId { get; set; }
}
