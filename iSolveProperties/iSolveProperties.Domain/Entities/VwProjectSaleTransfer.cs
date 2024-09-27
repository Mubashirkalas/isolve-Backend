using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwProjectSaleTransfer
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

    public string? ClientName { get; set; }

    public int? SerialNo { get; set; }

    public string? TclientName { get; set; }

    public string? Tcnic { get; set; }

    public string? Tcity { get; set; }

    public string? Temail { get; set; }

    public string? Tcontact { get; set; }

    public string? TclientCode { get; set; }

    public byte[]? Tpic { get; set; }

    public byte[]? Pic { get; set; }

    public string? AreaTitle { get; set; }

    public string? PropertyTitle { get; set; }

    public string? CategoryTitle { get; set; }

    public string? TypeTitle { get; set; }

    public string? ProjectName { get; set; }

    public byte? BookingCategory { get; set; }

    public string? BookingType { get; set; }

    public string? BlockName { get; set; }

    public string? ProjectSaleNo { get; set; }

    public string? BankName { get; set; }

    public double? TransferFee { get; set; }

    public string? CashBank { get; set; }

    public string? SubSegmentName { get; set; }

    public string? TransfererVerified { get; set; }

    public string? BioMetricId { get; set; }

    public string? NextToKin { get; set; }

    public string? NextToKinContact { get; set; }

    public string? TnextToKin { get; set; }

    public string? TnextToKinContact { get; set; }

    public string? FatherName { get; set; }

    public string? Relationship { get; set; }

    public string? NextToKinAddress { get; set; }

    public string? TfatherName { get; set; }

    public string? Trelationship { get; set; }

    public string? TnextToKinAddress { get; set; }
}
