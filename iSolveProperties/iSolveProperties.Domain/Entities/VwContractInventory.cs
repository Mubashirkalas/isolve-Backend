using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwContractInventory
{
    public short? Sno { get; set; }

    public int? InventorySerialNo { get; set; }

    public string? InventoryName { get; set; }

    public string? Remarks { get; set; }

    public short? BlockSerialNo { get; set; }

    public string? BlockName { get; set; }

    public byte? Qty { get; set; }

    public string Remark { get; set; } = null!;

    public string PurchaserName { get; set; } = null!;

    public string PurchaserFatherName { get; set; } = null!;

    public string PurchaserCnic { get; set; } = null!;

    public string PurchaserCellNo { get; set; } = null!;

    public string SellerName { get; set; } = null!;

    public string SellerFatherName { get; set; } = null!;

    public string SellerCnic { get; set; } = null!;

    public string SellerCellNo { get; set; } = null!;

    public string PurchaserAddress { get; set; } = null!;

    public DateOnly Date { get; set; }

    public int Srno { get; set; }

    public byte CompId { get; set; }
}
