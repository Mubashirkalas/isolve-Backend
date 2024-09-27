using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class UserRight
{
    public int? UserId { get; set; }

    public bool? AddRecord { get; set; }

    public bool? EditRecord { get; set; }

    public bool? DeleteRecord { get; set; }

    public bool? EntityFrm { get; set; }

    public bool? ChartFrm { get; set; }

    public bool? VouchertypeFrm { get; set; }

    public bool? GroupingFrm { get; set; }

    public bool? ConfigurationFrm { get; set; }

    public bool? PartyaddFrm { get; set; }

    public bool? VoucherpostingFrm { get; set; }

    public bool? VoucherviewFrm { get; set; }

    public bool? DeliveryorderFrm { get; set; }

    public bool? SalesinvoiceFrm { get; set; }

    public bool? GrnFrm { get; set; }

    public bool? AdminFrm { get; set; }

    public bool? UtilityFrm { get; set; }

    public bool? GlledgerRpt { get; set; }

    public bool? LedgerRpt { get; set; }

    public bool? VouchersRpt { get; set; }

    public bool? TrailRpt { get; set; }

    public bool? DailytrialRpt { get; set; }

    public bool? BlRpt { get; set; }

    public bool? PlRpt { get; set; }

    public bool? PostRpt { get; set; }

    public bool? ChartofaccountRpt { get; set; }

    public bool? ChartalphabaticallyRpt { get; set; }

    public bool? DeilverorderRpt { get; set; }

    public bool? DeliverorderpartyRpt { get; set; }

    public bool? SaleinvoiceRpt { get; set; }

    public bool? SalepartywiseRpt { get; set; }

    public bool? SalesregRpt { get; set; }

    public bool? PayableRpt { get; set; }

    public bool? ReceivableRpt { get; set; }

    public bool? SalesmanRpt { get; set; }

    public bool? InventoryRpt { get; set; }

    public bool? OwnerRpt { get; set; }
}
