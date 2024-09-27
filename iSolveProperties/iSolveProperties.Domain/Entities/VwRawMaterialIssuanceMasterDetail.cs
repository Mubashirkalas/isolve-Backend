using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwRawMaterialIssuanceMasterDetail
{
    public string Srno { get; set; } = null!;

    public string? SerialNo { get; set; }

    public byte? SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? ItemName { get; set; }

    public string? RequisitionNo { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public string? VehicleNo { get; set; }
}
