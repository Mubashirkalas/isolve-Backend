using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwProjectExchange
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public int? ProjectSaleSrno { get; set; }

    public double? Amount { get; set; }

    public string? ClientCode { get; set; }

    public string? PaymentMode { get; set; }

    public string? BankId { get; set; }

    public string? Keys { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public string? ProjectSaleNo { get; set; }

    public string? ClientName { get; set; }

    public string? ProjectInventoryStatusUpdationKey { get; set; }

    public string? PropertyDescription { get; set; }

    public string? PropertyTitle { get; set; }

    public string? AreaTitle { get; set; }

    public double? TotalPaid { get; set; }

    public string? CompanyName { get; set; }

    public string? CompanyAddress { get; set; }

    public string? Saletax { get; set; }

    public string? Ntn { get; set; }

    public string? Phoneno { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Url { get; set; }

    public string? Levels { get; set; }

    public DateOnly? Vdate { get; set; }

    public string? SubSegmentName { get; set; }

    public short? ProjectId { get; set; }

    public string? ProjectName { get; set; }

    public string? BankName { get; set; }

    public byte[]? Pic { get; set; }

    public string? BioMetricId { get; set; }

    public int? FingerPrintSrno { get; set; }

    public string? Status { get; set; }

    public string? ProjectStatus { get; set; }

    public string? Remarks { get; set; }

    public byte? Prints { get; set; }
}
