﻿using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class SaleOrderMaster
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string Year { get; set; } = null!;

    public byte? SubSegmentId { get; set; }

    public string? SaleNo { get; set; }

    public DateOnly? SaleDate { get; set; }

    public string? SaleType { get; set; }

    public string? BpCode { get; set; }

    public string? QuotNo { get; set; }

    public string? ContactPerson { get; set; }

    public string? Designation { get; set; }

    public string? Department { get; set; }

    public string? ModeOfShipment { get; set; }

    public double? DeliveryTime { get; set; }

    public string? Per { get; set; }

    public string? Freight { get; set; }

    public string? DeliveryAddress { get; set; }

    public string? SendingInvoiceTo { get; set; }

    public string? Status { get; set; }

    public short? SuserId { get; set; }

    public string? SuserName { get; set; }

    public string? SworkStation { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MuserName { get; set; }

    public string? MworkStation { get; set; }

    public DateTime? McreationDate { get; set; }
}
