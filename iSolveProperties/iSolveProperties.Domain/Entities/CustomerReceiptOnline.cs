using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class CustomerReceiptOnline
{
    public int SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? ClientName { get; set; }

    public short? ProjectId { get; set; }

    public string? BookingTypeId { get; set; }

    public short? AreaId { get; set; }

    public string? BookingCategoryId { get; set; }

    public string? PropertyId { get; set; }

    public string? BlockId { get; set; }

    public string? Cnic { get; set; }

    public double? Cash { get; set; }

    public double? Cheque { get; set; }

    public string? InstrumentNo { get; set; }

    public double? InstrumentAmount { get; set; }

    public int? DealSrno { get; set; }

    public double? Online { get; set; }

    public string? AccountNo { get; set; }

    public short? UserId { get; set; }
}
