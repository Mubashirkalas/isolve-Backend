using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwRental
{
    public byte CompId { get; set; }

    public string Srno { get; set; } = null!;

    public string FinancialYear { get; set; } = null!;

    public string? SerialNo { get; set; }

    public byte? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? PaymentMode { get; set; }

    public string? BankId { get; set; }

    public double? Amount { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public string? AreaTitle { get; set; }

    public string? PropertyTitle { get; set; }

    public string? PropertyDetail { get; set; }

    public string? ProjectSaleSerialNo { get; set; }

    public string? ClientCode { get; set; }

    public string? ClientName { get; set; }

    public string? ProjectSaleSrno { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? BankName { get; set; }

    public string? ProjectId { get; set; }

    public string? ProjectName { get; set; }
}
