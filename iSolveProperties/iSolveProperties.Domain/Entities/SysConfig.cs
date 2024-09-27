using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class SysConfig
{
    public string LoginId { get; set; } = null!;

    public bool IsGrn { get; set; }

    public bool IsSir { get; set; }

    public bool IsThirdParty { get; set; }

    public bool IsCoa { get; set; }

    public bool IsInventory { get; set; }

    public bool IsWo { get; set; }

    public bool IsMch { get; set; }

    public bool IsCc { get; set; }

    public bool IsParty { get; set; }

    public bool IsItemImp { get; set; }

    public bool IsReOrder { get; set; }

    public bool IsDemandOpening { get; set; }

    public bool IsIntegAccount { get; set; }

    public bool IsReturnfromDept { get; set; }

    public bool IsStoreSale { get; set; }

    public bool IsIgp { get; set; }

    public bool IsOgp { get; set; }

    public bool IsInspRec { get; set; }

    public bool IsinspUnRec { get; set; }

    public bool IsInsptoGrn { get; set; }

    public bool IsDemand { get; set; }

    public bool IsPo { get; set; }

    public bool IsPreturn { get; set; }

    public bool IsPostSirvoucher { get; set; }
}
