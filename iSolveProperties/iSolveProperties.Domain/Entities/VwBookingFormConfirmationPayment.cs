using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwBookingFormConfirmationPayment
{
    public string? SerialNo { get; set; }

    public string Srno { get; set; } = null!;

    public string FinancialYear { get; set; } = null!;

    public byte CompId { get; set; }
}
