using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwAddUser1
{
    public string AreaId { get; set; } = null!;

    public string AreaName { get; set; } = null!;

    public string SeniorId { get; set; } = null!;

    public string SeniorName { get; set; } = null!;

    public string ZoneId { get; set; } = null!;

    public string ZoneName { get; set; } = null!;

    public string RegionId { get; set; } = null!;

    public string RegionName { get; set; } = null!;

    public short UserId { get; set; }

    public string? UserName { get; set; }

    public string? UserRole { get; set; }

    public string? PasswordTwo { get; set; }

    public string? DeviceId { get; set; }

    public string MasterdataName { get; set; } = null!;

    public string SubSegmentName { get; set; } = null!;

    public string? AcceptingStatus { get; set; }

    public string? Status { get; set; }

    public string? FinanceDeviceId { get; set; }

    public string? DepttCode { get; set; }

    public string? JobPosition { get; set; }

    public short? SubSegmentId { get; set; }

    public int? UserCode { get; set; }

    public string? UserLogin { get; set; }
}
