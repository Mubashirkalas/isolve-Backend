﻿using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwTokenReceipt
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public string? SerialNo { get; set; }

    public byte? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public double? Amount { get; set; }

    public string? PaymentMode { get; set; }

    public short? ProjectRegistrationSerialNo { get; set; }

    public string? AreaDetailsSerialNo { get; set; }

    public int? BankId { get; set; }

    public string? Remarks { get; set; }

    public string? TokenReturn { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? ProjectName { get; set; }

    public bool? InventoryPurchase { get; set; }

    public string? BankName { get; set; }

    public string? AreaName { get; set; }

    public string? CompanyName { get; set; }

    public string? CompanyAddress { get; set; }

    public string? Ntn { get; set; }

    public string? Phoneno { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Url { get; set; }

    public byte[]? Pic { get; set; }

    public string? FileInventoryFileNo { get; set; }

    public string? ProjectInventoryStatusUpdationKey { get; set; }

    public string? ProjectInventorySerialNo { get; set; }

    public string? InventoryType { get; set; }

    public string? FileInventorySerialNo { get; set; }

    public byte[]? SubSegmentPic { get; set; }

    public string? ModifiedUserName { get; set; }

    public string? UserName { get; set; }

    public string? AccountNumber { get; set; }

    public string? ClientName { get; set; }

    public int? AmountInBank { get; set; }
}
