using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class DeliveryDispatchMaster
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? SerialNo { get; set; }

    public DateOnly? Date { get; set; }

    public short? SubSegmentId { get; set; }

    public string? Bpcode { get; set; }

    public string? Type { get; set; }

    public string? FreightType { get; set; }

    public double? FreightAmount { get; set; }

    public string? PaidBy { get; set; }

    public string? Region { get; set; }

    public int? Dono { get; set; }

    public DateOnly? Dodate { get; set; }

    public string? Status { get; set; }

    public string? Dokey { get; set; }

    public string? Keys { get; set; }

    public string? TransporterId { get; set; }

    public string? CreditNoteStatus { get; set; }

    public string? TransporterName { get; set; }

    public int? SalesManId { get; set; }

    public string? ContactNo { get; set; }

    public string? VehicleNo { get; set; }

    public string? TransportType { get; set; }

    public short? SuserId { get; set; }

    public string? SuserName { get; set; }

    public string? SworkStation { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MuserName { get; set; }

    public string? MworkStation { get; set; }

    public DateTime? McreationDate { get; set; }

    public virtual BusinessPartnersMain? BusinessPartnersMain { get; set; }

    public virtual EmployeeRegistrationMain? EmployeeRegistrationMain { get; set; }

    public virtual Region? RegionNavigation { get; set; }

    public virtual SubSegment? SubSegment { get; set; }
}
