using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class InterBankTransferMain
{
    public string Srno { get; set; } = null!;

    public string? SerialNo { get; set; }

    public DateOnly? Date { get; set; }

    public byte? SubSegmentId { get; set; }

    public byte CompId { get; set; }

    public string FYear { get; set; } = null!;

    public string? VKey { get; set; }

    public short? SaveUserid { get; set; }

    public string? SaveWorkstation { get; set; }

    public string? SaveUsername { get; set; }

    public DateTime? SaveCreationDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedUsername { get; set; }

    public string? ModifiedWorkstation { get; set; }

    public short? ModifiedUserId { get; set; }
}
