using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class CustomerReceipt
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? ClientName { get; set; }

    public string? Type { get; set; }

    public short? AreaDetailsSerialNo { get; set; }

    public short? ProjectRegistrationSerialNo { get; set; }

    public string? PaymentMode { get; set; }

    public double? Cash { get; set; }

    public double? Cheque { get; set; }

    public double? Online { get; set; }

    public string? ChequeNo { get; set; }

    public string? ReferenceNo { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public int? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

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

    public string? FromBankCode { get; set; }

    public string? ToBankCode { get; set; }

    public DateOnly? BankDate { get; set; }

    public string? FormNumber { get; set; }

    public string? SalesPersonCommission { get; set; }

    public string? TeamLeaderCode { get; set; }

    public string? TeamLeaderCommission { get; set; }

    public string? DealerCode { get; set; }

    public string? DealerCommission { get; set; }

    public double? Discount { get; set; }

    public string? Cnic { get; set; }

    public string? InstrumentNo { get; set; }

    public int? InstrumentAmount { get; set; }

    public int? DealSrno { get; set; }

    public int? OwnAmount { get; set; }

    public string? SonOf { get; set; }

    public string? JointOwner { get; set; }

    public int? PricelistId { get; set; }

    public int? TotalPrice { get; set; }

    public int? BookingAmount { get; set; }

    public int? ConfirmationAmount { get; set; }

    public int? MembershipFee { get; set; }

    public bool? Approved { get; set; }

    public short? ApprovedUserId { get; set; }

    public string? DepoistorName { get; set; }

    public string? AccountNo { get; set; }

    public string? PartyCode { get; set; }

    public DateOnly? ClearingDate { get; set; }

    public short? ClearedByUserId { get; set; }

    public string? ReceiptClearingStatus { get; set; }

    public string? PaymentType { get; set; }

    public DateTime? BankClearingDate { get; set; }

    public string? ClearingBankAccountNo { get; set; }

    public string? BankRemarks { get; set; }

    public short? BankClearedById { get; set; }

    public DateTime? BankClearedDate { get; set; }

    public bool? IsBankCleared { get; set; }

    public int? AdvanceAmount { get; set; }

    public string? Msno { get; set; }

    public virtual ICollection<Crcancellation> Crcancellations { get; set; } = new List<Crcancellation>();

    public virtual DealPurchase? DealPurchase { get; set; }
}
