using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Applicant
{
    public int SerialNo { get; set; }

    public byte CompId { get; set; }

    public DateOnly Date { get; set; }

    public string Name { get; set; } = null!;

    public string ContactA { get; set; } = null!;

    public string ContactB { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Reference { get; set; } = null!;

    public string ReferenceContact { get; set; } = null!;

    public string Position { get; set; } = null!;

    public string CurrentAddress { get; set; } = null!;

    public string PermanentAddress { get; set; } = null!;

    public string Other { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public string LinkedIn { get; set; } = null!;

    public string Facebook { get; set; } = null!;
}
