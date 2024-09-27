using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class CylinderFillingSessionMain
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string Year { get; set; } = null!;

    public byte? SubSegmentId { get; set; }

    public string? CfsessionNo { get; set; }

    public DateOnly? CfsessionDate { get; set; }

    public string? Platform { get; set; }

    public string? Shift { get; set; }

    public string? Product { get; set; }

    public string? ProductType { get; set; }

    public string? Fillerman { get; set; }

    public string? Name { get; set; }

    public string? Purity { get; set; }

    public string? Checkedby { get; set; }

    public string? TankNo { get; set; }

    public double? Tf990 { get; set; }

    public double? Tf790 { get; set; }

    public double? Tf680 { get; set; }

    public double? Tf590 { get; set; }

    public double? Tf500 { get; set; }

    public double? Tf340 { get; set; }

    public double? Tf170 { get; set; }

    public double? Tf085 { get; set; }

    public double? TotalFilled { get; set; }

    public double? Tf990mcl { get; set; }

    public double? Tf990cp { get; set; }

    public double? Tf790mcl { get; set; }

    public double? Tf790cp { get; set; }

    public double? Tf680mcl { get; set; }

    public double? Tf680cp { get; set; }

    public double? Tf590mcl { get; set; }

    public double? Tf590cp { get; set; }

    public double? Tf500mcl { get; set; }

    public double? Tf500cp { get; set; }

    public double? Tf340mcl { get; set; }

    public double? Tf340cp { get; set; }

    public double? Tf170mcl { get; set; }

    public double? Tf170cp { get; set; }

    public double? Tf085mcl { get; set; }

    public double? Tf085cp { get; set; }

    public string? SinKey { get; set; }

    public string? GrnKey { get; set; }

    public string? VoucherKey { get; set; }
}
