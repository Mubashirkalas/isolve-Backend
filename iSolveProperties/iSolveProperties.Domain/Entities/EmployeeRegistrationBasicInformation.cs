using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class EmployeeRegistrationBasicInformation
{
    public byte? CompId { get; set; }

    public int? SrNo { get; set; }

    public string? Name { get; set; }

    public string? FatherName { get; set; }

    public string? Dob { get; set; }

    public string? Gender { get; set; }

    public string? Religion { get; set; }

    public string? Nationality { get; set; }

    public string? MaritalStatus { get; set; }

    public string? Cnic { get; set; }

    public string? Referedby { get; set; }

    public string? ContactNo { get; set; }

    public string? Address { get; set; }

    public string? EmailAddress { get; set; }

    public string? PostalAddress { get; set; }

    public string? NextToKinName { get; set; }

    public string? NextToKinContactNo { get; set; }

    public string? BloodGroup { get; set; }

    public virtual EmployeeRegistrationMain? EmployeeRegistrationMain { get; set; }
}
