using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class ApplicantJob
{
    public int SerialNo { get; set; }

    public byte CompId { get; set; }

    public short Sno { get; set; }

    public string JobTitle { get; set; } = null!;

    public string OrganizationName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateOnly FromDate { get; set; }

    public DateOnly ToDate { get; set; }

    public byte Experience { get; set; }

    public string OrganizationWebLinks { get; set; } = null!;

    public virtual Applicant Applicant { get; set; } = null!;
}
