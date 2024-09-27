using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwAssetAdditionModificationDetail
{
    public string? Branch { get; set; }

    public string? Type { get; set; }

    public short Sno { get; set; }

    public int TypeId { get; set; }

    public int Amount { get; set; }

    public string Bpcode { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? Vendor { get; set; }

    public short BranchId { get; set; }

    public string Location { get; set; } = null!;

    public int? DepreciationRate { get; set; }

    public string Keys { get; set; } = null!;

    public string? BpType { get; set; }

    public string? NewLocation { get; set; }

    public int Srno { get; set; }

    public byte CompId { get; set; }

    public int? SerialNo { get; set; }

    public DateOnly? Date { get; set; }

    public string? SubSegmentName { get; set; }

    public string? BankName { get; set; }

    public string? AccountNo { get; set; }

    public int? AmountInBank { get; set; }

    public int? AmountInCash { get; set; }

    public short? SubSegmentId { get; set; }

    public string? UserName { get; set; }
}
