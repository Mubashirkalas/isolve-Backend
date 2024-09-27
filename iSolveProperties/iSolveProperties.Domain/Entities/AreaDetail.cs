using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class AreaDetail
{
    public short SerialNo { get; set; }

    public byte CompId { get; set; }

    public string? Area { get; set; }

    public short? SuserId { get; set; }

    public string? SuserName { get; set; }

    public string? SworkStation { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MuserName { get; set; }

    public string? MworkStation { get; set; }

    public DateTime? McreationDate { get; set; }

    public virtual ICollection<CustomerReceiptPrint> CustomerReceiptPrints { get; set; } = new List<CustomerReceiptPrint>();

    public virtual ICollection<ProjectSale> ProjectSales { get; set; } = new List<ProjectSale>();

    public virtual ICollection<QuotaAllocationDetail> QuotaAllocationDetails { get; set; } = new List<QuotaAllocationDetail>();

    public virtual ICollection<TokenReceipt> TokenReceipts { get; set; } = new List<TokenReceipt>();

    public virtual ICollection<TradingTokenReceipt> TradingTokenReceipts { get; set; } = new List<TradingTokenReceipt>();

    public virtual ICollection<TradingTokenReturn> TradingTokenReturns { get; set; } = new List<TradingTokenReturn>();
}
