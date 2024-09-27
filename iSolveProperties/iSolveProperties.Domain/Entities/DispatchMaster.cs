using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class DispatchMaster
{
    public string SrNo { get; set; } = null!;

    public string? DispatchNo { get; set; }

    public DateOnly? Date { get; set; }

    public byte? SubSegment { get; set; }

    public byte CompId { get; set; }

    public string Year { get; set; } = null!;

    public string? UserName { get; set; }

    public string? WorkStation { get; set; }

    public DateOnly? CreationDate { get; set; }

    public short? UserId { get; set; }

    public string? ModifiedUserName { get; set; }

    public string? ModifiedWorkstation { get; set; }

    public short? ModifiedUserId { get; set; }

    public DateOnly? ModifiedDate { get; set; }
}
