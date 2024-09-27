using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwPendingLead
{
    public long SerialNo { get; set; }

    public string? CustomerName { get; set; }

    public string? ContactNo { get; set; }

    public int? FromUserId { get; set; }

    public int? ToUserId { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? UpdationTime { get; set; }

    public bool? Status { get; set; }

    public long? LeadNo { get; set; }

    public string? SourceOfReference { get; set; }

    public string? Project { get; set; }

    public string? WhatsAppNo { get; set; }

    public string? Email { get; set; }

    public string? Remarks { get; set; }

    public string? ToUserName { get; set; }

    public string? ProjectTitle { get; set; }

    public bool? IsDropped { get; set; }
}
