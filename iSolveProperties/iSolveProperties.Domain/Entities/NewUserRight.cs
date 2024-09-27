using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class NewUserRight
{
    public short? Userid { get; set; }

    public byte? CompId { get; set; }

    public bool? AddRecord { get; set; }

    public bool? EditRecord { get; set; }

    public bool? DeleteRecord { get; set; }
}
