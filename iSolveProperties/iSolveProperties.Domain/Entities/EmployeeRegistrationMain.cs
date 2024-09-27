using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class EmployeeRegistrationMain
{
    public byte CompId { get; set; }

    public int SrNo { get; set; }

    public string? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public string? AppointLetterNo { get; set; }

    public string? JobPosition { get; set; }

    public string? Scale { get; set; }

    public DateOnly? Date { get; set; }

    public string? DepttCode { get; set; }

    public string? EmployeeId { get; set; }

    public string? BioMetricId { get; set; }

    public byte[]? Pic { get; set; }

    public string? Username { get; set; }

    public DateOnly? EnterDate { get; set; }

    public short? UserId { get; set; }

    public string? WorkStation { get; set; }

    public string? ModifiedUserName { get; set; }

    public short? ModifiedUserId { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedWs { get; set; }

    public string? BankName { get; set; }

    public string? AccountNo { get; set; }

    public string? Name { get; set; }

    public string? FatherName { get; set; }

    public DateOnly? Dob { get; set; }

    public string? Gender { get; set; }

    public string? Religion { get; set; }

    public string? Nationality { get; set; }

    public string? MaritalStatus { get; set; }

    public string? Cnic { get; set; }

    public string? Referedby { get; set; }

    public string? ContactNo { get; set; }

    public string? Address { get; set; }

    public string? EmailAddress { get; set; }

    public string? PostalAddress { get; set; }

    public string? NextToKinName { get; set; }

    public string? NextToKinContactNo { get; set; }

    public string? BloodGroup { get; set; }

    public string? EmployeeBank { get; set; }

    public string? EmployeeAccount { get; set; }

    public string? EmploymentType { get; set; }

    public string? PaymentMode { get; set; }

    public byte[]? Signature { get; set; }

    public bool? OpenAsParty { get; set; }

    public string? Bpcode { get; set; }

    public short? UserIds { get; set; }

    public string? PaymentType { get; set; }

    public int? Zkid { get; set; }

    public DateOnly? ResigningDate { get; set; }

    public DateOnly? JoiningDate { get; set; }

    public bool? IsResigned { get; set; }

    public virtual ICollection<DeliveryDispatchMaster> DeliveryDispatchMasters { get; set; } = new List<DeliveryDispatchMaster>();

    public virtual ICollection<UserAndPartyMaping> UserAndPartyMapings { get; set; } = new List<UserAndPartyMaping>();
}
