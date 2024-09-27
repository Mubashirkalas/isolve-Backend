using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Realtor
{
    public int SerialNo { get; set; }

    public DateOnly? Registerdate { get; set; } = DateOnly.FromDateTime(DateTime.Now);

    public string? RealtorName { get; set; }

    public string? UserType { get; set; }

    public string? ContactNo { get; set; }

    public string? OfficeAddress { get; set; }

    public string? CompanyName { get; set; }

    public string? City { get; set; }

    public string? AgentId { get; set; }

    public string? Cnic { get; set; }

    public string? Cnicimage { get; set; }

    public string? OfficeImage { get; set; }

    public bool? Approved { get; set; } = false;
}
