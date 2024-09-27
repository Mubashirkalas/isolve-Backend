using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class ItemMaster
{
    public string ItemCode { get; set; } = null!;

    public string? ItemName { get; set; }

    public string ItemGroup { get; set; } = null!;

    public string? BarCode { get; set; }

    public string? ItemStatus { get; set; }

    public bool? ItemInventory { get; set; }

    public bool? ItemSales { get; set; }

    public bool? ItemPurchase { get; set; }

    public bool? FixedAssets { get; set; }

    public double? MaxOrder { get; set; }

    public double? MinOrder { get; set; }

    public double? ReOrder { get; set; }

    public string? ValutionSystem { get; set; }

    public string? ValutionMethods { get; set; }

    public string? CaConsumption { get; set; }

    public string? CaConsumptionReturn { get; set; }

    public string? ProcurmentMethod { get; set; }

    public double? MinOrder1 { get; set; }

    public string? LeadTime { get; set; }

    public string? LeadTimePer { get; set; }

    public string? OrderInterval { get; set; }

    public string? OrderIntervalPer { get; set; }

    public string? CaPurchase { get; set; }

    public string? CaPurchaseReturn { get; set; }

    public string? CaPurchaseDiscounts { get; set; }

    public string? CaProduction { get; set; }

    public string? CaProductionReturn { get; set; }

    public string? CaSales { get; set; }

    public string? CaSalesReturn { get; set; }

    public string? Remarks { get; set; }

    public byte CompId { get; set; }

    public double? ConversionCost { get; set; }

    public string? BomUom { get; set; }

    public int? SerialNo { get; set; }

    public string? CaConsumptionWs { get; set; }

    public string? CaConsumptionReturnWs { get; set; }

    public string? CaSalesWs { get; set; }

    public string? CaSalesReturnWs { get; set; }

    public string? CaDiscountAllowedWs { get; set; }

    public string? CaDiscountAllowed { get; set; }

    public string? CaCash { get; set; }

    public string? BarCodeTwo { get; set; }

    public string? ItemDescription { get; set; }

    public string? CaWci { get; set; }

    public string? CaDn { get; set; }

    public string? CalabourChargesPayable { get; set; }

    public string? CalabourCharges { get; set; }

    public bool? ItemBatch { get; set; }

    public string? DrugLicense { get; set; }

    public DateOnly? ExpiryDate { get; set; }
}
