using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class OnlineBooking
{
    public int SerialNo { get; set; }

    public DateTime? Date { get; set; }

    public string? CustomerName { get; set; }

    public short? ProjectId { get; set; }

    public short? BookingTypeId { get; set; }

    public short? SizeId { get; set; }

    public short? BookingCategoryId { get; set; }

    public short? PropertyId { get; set; }

    public short? BlockId { get; set; }

    public string? Cnic { get; set; }

    public string? PaymentType { get; set; }

    public string? ChequeNo { get; set; }

    public string? Remarks { get; set; }

    public string? Imgurl { get; set; }

    public bool? Viewed { get; set; }
}
