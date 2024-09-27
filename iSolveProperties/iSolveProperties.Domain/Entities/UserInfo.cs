using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class UserInfo
{
    public string? UserTitle { get; set; }

    public string? LoginName { get; set; }

    public string LoginId { get; set; } = null!;

    public string Passward { get; set; } = null!;

    public bool MayEdit { get; set; }

    public bool MayAdd { get; set; }

    public bool MayView { get; set; }

    public bool MayDelete { get; set; }

    public bool MayViewReports { get; set; }

    public bool MayAdmin { get; set; }

    public bool MayViewmisReports { get; set; }

    public bool MaySupperAdmin { get; set; }
}
