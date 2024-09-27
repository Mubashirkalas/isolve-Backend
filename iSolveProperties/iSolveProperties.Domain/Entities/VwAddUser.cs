using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwAddUser
{
    public short UserId { get; set; }

    public string? UserName { get; set; }

    public string? UserLogin { get; set; }

    public string? UserPassword { get; set; }

    public int? EmployeeId { get; set; }

    public string? Type { get; set; }

    public string? Status { get; set; }

    public bool? IsMobileUser { get; set; }

    public string? PlayerId { get; set; }

    public bool? LeadPopup { get; set; }

    public bool? CallRecording { get; set; }

    public string? PasswordTwo { get; set; }

    public string? DeviceId { get; set; }

    public string? AcceptingStatus { get; set; }

    public string? Bpcode { get; set; }

    public string? Bpname { get; set; }

    public string? EmployeeName { get; set; }

    public string? TeamMasterNames { get; set; }

    public string? TeamLeaderNames { get; set; }
}
