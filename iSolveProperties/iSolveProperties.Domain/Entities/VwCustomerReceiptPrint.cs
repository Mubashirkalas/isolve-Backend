using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwCustomerReceiptPrint
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public string? SubSegmentName { get; set; }

    public DateOnly? Date { get; set; }

    public string? ClientName { get; set; }

    public string? Type { get; set; }

    public short? AreaDetailsSerialNo { get; set; }

    public string? AreaDetailsName { get; set; }

    public string? ProjectRegistrationName { get; set; }

    public short? ProjectRegistrationSerialNo { get; set; }

    public string? UserName { get; set; }

    public string? PaymentMode { get; set; }

    public double? Cash { get; set; }

    public double? Cheque { get; set; }

    public double? Online { get; set; }

    public string? ChequeNo { get; set; }

    public string? ReferenceNo { get; set; }

    public short? SuserId { get; set; }

    public byte[]? SubSegmentPic { get; set; }

    public string? Remarks { get; set; }

    public string? Status { get; set; }

    public double? TotalAmountReceived { get; set; }

    public byte[]? Pic { get; set; }

    public string? FileData { get; set; }

    public string? FileType { get; set; }

    public string? FileName { get; set; }

    public string? Category { get; set; }

    public string? BookingCategoryDetailsSerialNo { get; set; }

    public string? BookingTypeDetailsType { get; set; }

    public string? BookingTypeDetailsSerialNo { get; set; }

    public string? PropertyDetails { get; set; }

    public string? PropertyDetailsSerialNo { get; set; }

    public string? BlocksDetails { get; set; }

    public string? BlocksDetailsSerialNo { get; set; }

    public string? Contact { get; set; }

    public string? Email { get; set; }

    public string? CustomerType { get; set; }

    public string? CommissionRemarks { get; set; }

    public string? SalesPersonCode { get; set; }

    public int? FromBankCode { get; set; }

    public string? ToBankCode { get; set; }

    public DateOnly? BankDate { get; set; }

    public string? FromBankName { get; set; }

    public string? FormNumber { get; set; }

    public string? SalesPersonCommission { get; set; }

    public string? TeamLeaderCode { get; set; }

    public string? TeamLeaderCommission { get; set; }

    public string? DealerCode { get; set; }

    public string? DealerCommission { get; set; }

    public string? SalesPersonName { get; set; }

    public string? TeamLeaderName { get; set; }

    public string? DealerName { get; set; }

    public double? Discount { get; set; }

    public string? Cnic { get; set; }

    public string? CompanyName { get; set; }

    public byte[]? CompanyPic { get; set; }

    public string? InstrumentNo { get; set; }

    public string? ToBankName { get; set; }

    public string? AccountNumber { get; set; }

    public string? AccountTitle { get; set; }

    public byte? BankId { get; set; }

    public int? InstrumentAmount { get; set; }

    public string? DealName { get; set; }

    public int? OwnAmount { get; set; }

    public int? DealSrno { get; set; }

    public bool? Approved { get; set; }

    public short? ApprovedUserId { get; set; }

    public string? ApprovedUserName { get; set; }

    public int? Crsrno { get; set; }

    public short? CrsubSegmentId { get; set; }

    public DateOnly? Crdate { get; set; }

    public int? CrserialNo { get; set; }

    public string CrsubSegmentName { get; set; } = null!;
}
