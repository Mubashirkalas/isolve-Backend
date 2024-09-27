﻿using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwFileInventoryDetail
{
    public string? Bpname { get; set; }

    public string? BankName { get; set; }

    public string? AccountTitle { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public string? SerialNo { get; set; }

    public byte? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? Bpcode { get; set; }

    public double? PaidViaCash { get; set; }

    public int? BankId { get; set; }

    public string? AccountNo { get; set; }

    public double? PaidViaBank { get; set; }

    public string? ChequebookNo { get; set; }

    public string? ChequeNo { get; set; }

    public DateOnly? ChequeDate { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public int? Project { get; set; }

    public string? ProjectName { get; set; }

    public double? Amount { get; set; }

    public string? FileNo { get; set; }

    public int? Sno { get; set; }

    public string? Status { get; set; }

    public double? FileInventoryAmount { get; set; }
}
