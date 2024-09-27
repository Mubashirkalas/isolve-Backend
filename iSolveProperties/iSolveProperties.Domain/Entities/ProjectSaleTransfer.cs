using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class ProjectSaleTransfer
{
    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int ProjectSaleSrno { get; set; }

    public string? Cnic { get; set; }

    public string? City { get; set; }

    public string? Email { get; set; }

    public string? Contact { get; set; }

    public string? ClientCode { get; set; }

    public string? ProjectTranferSrno { get; set; }

    public byte[]? Pic { get; set; }

    public string? Tcnic { get; set; }

    public string? Tcity { get; set; }

    public string? Temail { get; set; }

    public string? Tcontact { get; set; }

    public string? TclientCode { get; set; }

    public byte[]? Tpic { get; set; }

    public string? TnextToKin { get; set; }

    public string? TnextToKinContact { get; set; }

    public string? FatherName { get; set; }

    public string? Relationship { get; set; }

    public string? NextToKinAddress { get; set; }

    public string? TfatherName { get; set; }

    public string? Trelationship { get; set; }

    public string? TnextToKinAddress { get; set; }

    public string? TnextToKinCnic { get; set; }

    public virtual BusinessPartnersMain? BusinessPartnersMain { get; set; }

    public virtual BusinessPartnersMain? BusinessPartnersMainNavigation { get; set; }

    public virtual ProjectSale ProjectSale { get; set; } = null!;
}
