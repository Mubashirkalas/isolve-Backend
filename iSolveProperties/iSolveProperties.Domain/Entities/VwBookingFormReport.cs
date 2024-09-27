using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwBookingFormReport
{
    public string? SerialNo { get; set; }

    public DateOnly? Date { get; set; }

    public string? ClientName { get; set; }

    public string? BookingFormNo { get; set; }

    public string? PropertyDetailSerialNo { get; set; }

    public string? AreaDetailSerialNo { get; set; }

    public string? ChequeNo { get; set; }

    public double? Amount { get; set; }

    public string? FileNo { get; set; }

    public string? Bpname { get; set; }

    public DateOnly? IssueDate { get; set; }

    public DateOnly? FileDate { get; set; }

    public byte CompId { get; set; }

    public string ChequeStatus { get; set; } = null!;

    public double? DealerChequeAdjustment { get; set; }

    public DateOnly? ChequeDate { get; set; }

    public string? ReferringPerson { get; set; }

    public string CompanyStatus { get; set; } = null!;

    public double? DealerCashAdjustment { get; set; }

    public double? DealerComissionAdjustment { get; set; }

    public double? CompanyChequeAdjustment { get; set; }

    public double? CompanyCashAdjustment { get; set; }

    public double? CompanyComissionAdjustment { get; set; }

    public string? BookingCategorySerialNo { get; set; }

    public string? BookingTypeSerialNo { get; set; }

    public string? PropertyDetail { get; set; }

    public string? Area { get; set; }

    public string? BookingType { get; set; }

    public string? BookingCategory { get; set; }

    public string? BlockName { get; set; }

    public string? BlockSerialNo { get; set; }

    public string? Project { get; set; }

    public DateOnly? AllotmentDate { get; set; }

    public double? Discount { get; set; }

    public string? ConfirmationPayment { get; set; }

    public string? Confirmation { get; set; }

    public string? FileDelivery { get; set; }

    public string? FileReceiving { get; set; }

    public string? BookingReceiptsDelivery { get; set; }

    public string? BookingReceipts { get; set; }

    public string? BookingFormDelivery { get; set; }

    public string? ConfirmationReceiptsDelivery { get; set; }

    public string? ConfirmationReceipt { get; set; }

    public string? UserName { get; set; }
}
