using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class UserAndPartyMaping
{
    public string SerialNo { get; set; } = null!;

    public byte CompId { get; set; }

    public short? UserId { get; set; }

    public string? Bpcode { get; set; }

    public int? EmployeeSrno { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public virtual BusinessPartnersMain? BusinessPartnersMain { get; set; }

    public virtual Companysetup Comp { get; set; } = null!;

    public virtual EmployeeRegistrationMain? EmployeeRegistrationMain { get; set; }

    public virtual User? Muser { get; set; }

    public virtual User? Suser { get; set; }

    public virtual User? User { get; set; }
}
