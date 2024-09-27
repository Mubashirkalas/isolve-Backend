using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class DriverRegistration
{
    public string DriverId { get; set; } = null!;

    public byte CompId { get; set; }

    public string? Name { get; set; }

    public string? LicenceNo { get; set; }

    public string? LicenceType { get; set; }

    public DateOnly? LicenceExpiryDate { get; set; }

    public DateOnly? Dob { get; set; }

    public string? Cnic { get; set; }

    public string? Address { get; set; }

    public DateOnly? RegistrationDate { get; set; }

    public DateOnly? JoiningDate { get; set; }

    public string? Province { get; set; }

    public string? City { get; set; }

    public string? PhoneNo { get; set; }

    public string? Mobile { get; set; }

    public bool? Status { get; set; }

    public string? Remarks { get; set; }

    public string? DailyExpense { get; set; }

    public string? DailyPayable { get; set; }
}
