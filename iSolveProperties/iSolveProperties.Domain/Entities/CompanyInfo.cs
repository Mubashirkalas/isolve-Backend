using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class CompanyInfo
{
    public string CompanyName { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Sharevalue { get; set; } = null!;

    public int Tax { get; set; }

    public string Noofshares { get; set; } = null!;

    public int Ntn { get; set; }

    public string Fixedasset { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Derpreciation { get; set; } = null!;

    public string Fax { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string AdjustmentType { get; set; } = null!;

    public DateOnly Date { get; set; }

    public string Budgeting { get; set; } = null!;

    public string Posting { get; set; } = null!;
}
