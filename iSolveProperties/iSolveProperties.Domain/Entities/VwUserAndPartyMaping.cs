using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwUserAndPartyMaping
{
    public string SerialNo { get; set; } = null!;

    public byte CompId { get; set; }

    public int? UserId { get; set; }

    public string? Bpcode { get; set; }

    public int? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public int? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public string? UserName { get; set; }

    public string? Bpname { get; set; }

    public string? EmployeeSrno { get; set; }

    public string? EmployeeName { get; set; }
}
