using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Vwpo
{
    public string? PoNo { get; set; }

    public DateOnly? PoDate { get; set; }

    public string? Terms { get; set; }

    public string? Remarks { get; set; }

    public DateOnly? DelivryDate { get; set; }

    public string? DeliveryPlace { get; set; }

    public string? ModeofPacking { get; set; }

    public double? PoDiscountper { get; set; }

    public double? PoStaxper { get; set; }

    public string? Importvia { get; set; }

    public string? Receiptno { get; set; }

    public DateOnly? Receiptdate { get; set; }

    public string? Lcno { get; set; }

    public DateOnly? Lcdate { get; set; }

    public string? Bank { get; set; }

    public string? Lcterm { get; set; }

    public string? Shippedfrom { get; set; }

    public string? Shippedto { get; set; }

    public string? Shippingvia { get; set; }

    public DateOnly? Shippingdate { get; set; }

    public string? Shippingterm { get; set; }

    public string? Clearingagent { get; set; }

    public string? Forwardcontractno { get; set; }

    public DateOnly? Forwarddate { get; set; }

    public string? Currency { get; set; }

    public double? Spotrate { get; set; }

    public int? Srno { get; set; }

    public string? PoItemno { get; set; }

    public decimal? PoQtyord { get; set; }

    public decimal? PoRate { get; set; }

    public decimal? PoValue { get; set; }

    public string? Uom { get; set; }

    public string? ItDesc { get; set; }

    public string? Name { get; set; }

    public string? PoQuotno { get; set; }

    public string? Mop { get; set; }

    public string? AdAddress1 { get; set; }

    public string? AdAddress2 { get; set; }

    public string? AdCity { get; set; }

    public string? AdCountry { get; set; }

    public double? PoPi { get; set; }

    public bool? Checkimport { get; set; }
}
