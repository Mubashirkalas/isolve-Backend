using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class ApplicantEducation
{
    public int SerialNo { get; set; }

    public byte CompId { get; set; }

    public short Sno { get; set; }

    public string DegreeTitle { get; set; } = null!;

    public string Institution { get; set; } = null!;

    public string Marks { get; set; } = null!;

    public string InstitutionAddress { get; set; } = null!;

    public string InstitutionWebLink { get; set; } = null!;

    public virtual Applicant Applicant { get; set; } = null!;
}
