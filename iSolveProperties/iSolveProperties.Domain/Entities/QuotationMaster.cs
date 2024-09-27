using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class QuotationMaster
{
    public string SrNo { get; set; } = null!;

    public string? BpCode { get; set; }

    public string? BpName { get; set; }

    public string? Attention { get; set; }

    public string? Designation { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? ContactNo { get; set; }

    public string? Terms { get; set; }

    public string? ComplimentaryClose { get; set; }

    public byte CompId { get; set; }

    public string FYear { get; set; } = null!;

    public short? UserId { get; set; }

    public string? Subject { get; set; }

    public DateOnly? Date { get; set; }

    public string? RefNo { get; set; }

    public string? SerialNo { get; set; }

    public byte SubSegmentId { get; set; }

    public short? SaveUserId { get; set; }

    public string? SaveWorkstation { get; set; }

    public string? SaveUsername { get; set; }

    public DateTime? SaveCreationDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedUsername { get; set; }

    public string? ModifiedWorkstation { get; set; }

    public short? ModifiedUserId { get; set; }

    public string? Status { get; set; }

    public virtual BusinessPartnersMain? BusinessPartnersMain { get; set; }
}
