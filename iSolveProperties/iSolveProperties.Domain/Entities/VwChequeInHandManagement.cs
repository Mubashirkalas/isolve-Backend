using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwChequeInHandManagement
{
    public string Srno { get; set; } = null!;

    public string Year { get; set; } = null!;

    public byte CompId { get; set; }

    public string? SerialNo { get; set; }

    public DateOnly? Date { get; set; }

    public short? SubSegmentId { get; set; }

    public string? Bpcode { get; set; }

    public DateOnly? ReceivedDate { get; set; }

    public DateOnly? ChequeDate { get; set; }

    public string? Type { get; set; }

    public short? SUser { get; set; }

    public short? TrUserid { get; set; }

    public string? TrWorkstation { get; set; }

    public string? TrUsername { get; set; }

    public DateTime? TrCreationDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedUsername { get; set; }

    public string? ModifiedWorkstation { get; set; }

    public short? ModifiedUserId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? BusinessPartnersName { get; set; }

    public byte? Sno { get; set; }

    public string? ChequeNo { get; set; }

    public DateOnly? ChequeDate1 { get; set; }

    public double? Amount { get; set; }

    public string? Action { get; set; }

    public string? Remarks { get; set; }

    public byte? BankIdentity { get; set; }

    public string? BankName { get; set; }

    public byte? BankId { get; set; }

    public string? BankName1 { get; set; }

    public string? AccountNo { get; set; }

    public string? Status { get; set; }

    public short? RecoveryAgent { get; set; }

    public string? RecoveryAgentName { get; set; }

    public string? ReceiptNo { get; set; }

    public string BpType { get; set; } = null!;

    public string? BookingFormSrno { get; set; }

    public string? BookingFormNo { get; set; }

    public string? ClientName { get; set; }
}
