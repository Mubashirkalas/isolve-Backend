using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class LoaderRegistration
{
    public string LoaderId { get; set; } = null!;

    public byte CompId { get; set; }

    public string? Name { get; set; }

    public string? Cnic { get; set; }

    public string? PhoneNo { get; set; }

    public DateOnly? RegistrationDate { get; set; }

    public string? Address { get; set; }

    public DateOnly? JoiningDate { get; set; }

    public string? DailyExpense { get; set; }

    public string? DailyPayable { get; set; }
}
