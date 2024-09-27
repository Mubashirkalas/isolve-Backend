using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class LcmanagementMain
{
    public string Keys { get; set; } = null!;

    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string Year { get; set; } = null!;

    public byte SubSegmentId { get; set; }

    public int? LcNo { get; set; }

    public string LcdocNo { get; set; } = null!;

    public string LcName { get; set; } = null!;

    public DateOnly? LcDate { get; set; }

    public string? AccountNumber { get; set; }

    public string? FacilityNo { get; set; }

    public double? LcAmount { get; set; }

    public string? GasStorecontainer { get; set; }

    public string? TankNo { get; set; }

    public int? CylTotalqty { get; set; }

    public int? CylMclpropertyqty { get; set; }

    public string? CylDesc { get; set; }

    public int? CylCustomerpropertyqty { get; set; }

    public int? Cyl9 { get; set; }

    public int? Cyl6 { get; set; }

    public int? Cyl5 { get; set; }

    public int? Cyl1 { get; set; }

    public int? Cyl7 { get; set; }

    public int? Cyl59 { get; set; }

    public int? Cyl3 { get; set; }

    public int? Cyl0 { get; set; }

    public string? ImportVia { get; set; }

    public string? ForwardingContractno { get; set; }

    public DateOnly? ForwardingContractdate { get; set; }

    public double? SpotRate { get; set; }

    public DateOnly? ShippingDate { get; set; }

    public string? ShippingFrom { get; set; }

    public string? ShippingTo { get; set; }

    public string? ShippingVia { get; set; }

    public string? ShippingTerms { get; set; }

    public string? ClearingAgentcode { get; set; }

    public string? ClearingAgentname { get; set; }

    public double? LcMargin { get; set; }

    public double? LcOc { get; set; }

    public double? SwiftCharges { get; set; }

    public double? FedralExcisedyty { get; set; }

    public double? MiscCharges { get; set; }

    public DateOnly? LcrDate { get; set; }

    public string? LcrSupplierCode { get; set; }

    public string? LcrSupplierName { get; set; }

    public string? LcrDesc { get; set; }

    public double? LcrCivalueFc { get; set; }

    public double? LcrExchangerate { get; set; }

    public double? HsCode { get; set; }

    public double? GdNo { get; set; }

    public DateOnly? GdDate { get; set; }

    public double? PaValue { get; set; }

    public double? AaValue { get; set; }
}
