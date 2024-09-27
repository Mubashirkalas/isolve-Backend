using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwEmployeeRegistrationJobDescription
{
    public byte CompId { get; set; }

    public string SrNo { get; set; } = null!;

    public string? AppointLetterNo { get; set; }

    public string? JobPosition { get; set; }

    public string? Scale { get; set; }

    public DateTime? Date { get; set; }

    public string? DepttCode { get; set; }

    public string? Username { get; set; }

    public DateOnly? EnterDate { get; set; }

    public short? UserId { get; set; }

    public string? WorkStation { get; set; }

    public string? ModifiedUserName { get; set; }

    public short? ModifiedUserId { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedWs { get; set; }

    public short? SNo { get; set; }

    public string? JobDescription { get; set; }

    public string? Type { get; set; }

    public string? ReportTo { get; set; }

    public string? Remarks { get; set; }

    public string? EmployeeId { get; set; }

    public string? BioMetricId { get; set; }

    public byte[]? Pic { get; set; }

    public string? BankName { get; set; }

    public string? AccountNo { get; set; }

    public string? Dob { get; set; }

    public string? FatherName { get; set; }

    public string? Name { get; set; }

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

    public string? EmployeeBank { get; set; }

    public string? EmployeeAccount { get; set; }
}
