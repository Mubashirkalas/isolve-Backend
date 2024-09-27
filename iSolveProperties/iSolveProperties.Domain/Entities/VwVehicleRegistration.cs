using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwVehicleRegistration
{
    public short SrNo { get; set; }

    public int CompId { get; set; }

    public string? Year { get; set; }

    public int? SUser { get; set; }

    public string? ClassOfVehicle { get; set; }

    public string? TypeOfBody { get; set; }

    public string? Make { get; set; }

    public string? YearOfManufacturing { get; set; }

    public string? Color { get; set; }

    public string? ChassissNo { get; set; }

    public string? RegistrationNo { get; set; }

    public string? PaymentOfToken { get; set; }

    public double? TokenAmount { get; set; }

    public DateOnly? ValidityDate { get; set; }

    public string? HorsePower { get; set; }

    public string? FuelUsed { get; set; }

    public string? SittingCapacityWithDriver { get; set; }

    public string? TypeOfVehicle { get; set; }

    public double? TareWeight { get; set; }

    public double? TotalFuelTankCapacity { get; set; }

    public double? MaximumLoad { get; set; }

    public string? TypeOfOwnership { get; set; }

    public DateOnly? PurchasedDate { get; set; }

    public string? PurchasedFrom { get; set; }

    public int? VehicleCost { get; set; }

    public string? RemarksCo { get; set; }

    public DateOnly? HiredDate { get; set; }

    public string? HireFrom { get; set; }

    public DateOnly? HireDateStart { get; set; }

    public DateOnly? HireDateEnd { get; set; }

    public string? RemarksHire { get; set; }

    public DateOnly? LeasedDate { get; set; }

    public string? LeasedFrom { get; set; }

    public DateOnly? LeasedDateStart { get; set; }

    public DateOnly? LeasedDateEnd { get; set; }

    public string? RemarksLeased { get; set; }

    public string? AreaDepartmentOfAllocation { get; set; }

    public string? ResponsiblePerson { get; set; }

    public DateOnly? AssigningDate { get; set; }

    public int? MeterReadingAtAssignment { get; set; }

    public string? NatureOfUse { get; set; }

    public double? AllowedFuel { get; set; }

    public byte? OilChange { get; set; }

    public byte? ServiceOrTuning { get; set; }

    public byte? FilterChange { get; set; }

    public byte? GreaseOil { get; set; }

    public string? FuelConsumption { get; set; }

    public string? FuelConsumptionDesc { get; set; }

    public string? RepairAndMaintenance { get; set; }

    public string? RepairAndMaintenanceDesc { get; set; }

    public string? TollTax { get; set; }

    public string? TollTaxDesc { get; set; }

    public string? Insurance { get; set; }

    public string? InsuranceDesc { get; set; }

    public string? Uid { get; set; }
}
