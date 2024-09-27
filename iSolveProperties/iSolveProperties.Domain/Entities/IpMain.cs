using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class IpMain
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string Year { get; set; } = null!;

    public short SubSegmentId { get; set; }

    public int IpNo { get; set; }

    public string BpCode { get; set; } = null!;

    public DateOnly? IpDate { get; set; }

    public string? PartyType { get; set; }

    public double? AdvanceBal { get; set; }

    public double? InvoiceBal { get; set; }

    public string? SecurityBal { get; set; }

    public string? ApaccuralBal { get; set; }

    public short? Userid { get; set; }

    public string? Workstation { get; set; }

    public string? Username { get; set; }

    public DateTime? CreationDate { get; set; }

    public short? ModifiedUserId { get; set; }

    public string? ModifiedWorkstation { get; set; }

    public string? ModifiedUsername { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ChargedTo { get; set; }

    public string? PaidBy { get; set; }

    public string? Status { get; set; }

    public string? PaymentMode { get; set; }

    public string? Keys { get; set; }

    public string? RateStatus { get; set; }

    public string? Pod { get; set; }

    public string? PodParty { get; set; }

    public string? PodPartyAddress { get; set; }

    public string? Policy { get; set; }

    public string? DriverName { get; set; }

    public string? VehicleNo { get; set; }

    public string? Ogp { get; set; }

    public double? LoadingUnloading { get; set; }

    public double? Packing { get; set; }

    public double? OtherCharges { get; set; }

    public double? GrandTotal { get; set; }

    public string? DocumentKeys { get; set; }

    public int? DocumentNo { get; set; }

    public virtual BusinessPartnersMain BusinessPartnersMain { get; set; } = null!;

    public virtual SubSegment SubSegment { get; set; } = null!;
}
