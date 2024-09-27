using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Companysetup
{
    public byte CId { get; set; }

    public string? CName { get; set; }

    public string? CAbber { get; set; }

    public string? Address { get; set; }

    public string? Saletax { get; set; }

    public string? Ntn { get; set; }

    public string? Phoneno { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Url { get; set; }

    public byte[]? Pic { get; set; }

    public string? Levels { get; set; }

    public DateOnly? Vdate { get; set; }

    public string? ImagePath { get; set; }

    public virtual ICollection<AssetHandingOver> AssetHandingOvers { get; set; } = new List<AssetHandingOver>();

    public virtual ICollection<AssetTransfer> AssetTransfers { get; set; } = new List<AssetTransfer>();

    public virtual ICollection<BookingConfirmationLetter> BookingConfirmationLetters { get; set; } = new List<BookingConfirmationLetter>();

    public virtual ICollection<BookingFormReceiving> BookingFormReceivings { get; set; } = new List<BookingFormReceiving>();

    public virtual ICollection<BudgetDefinition> BudgetDefinitions { get; set; } = new List<BudgetDefinition>();

    public virtual ICollection<ContractPayment> ContractPayments { get; set; } = new List<ContractPayment>();

    public virtual ICollection<Crcancellation> Crcancellations { get; set; } = new List<Crcancellation>();

    public virtual ICollection<DealerQuotum> DealerQuota { get; set; } = new List<DealerQuotum>();

    public virtual ICollection<Depreciation> Depreciations { get; set; } = new List<Depreciation>();

    public virtual ICollection<EmailCompaign> EmailCompaigns { get; set; } = new List<EmailCompaign>();

    public virtual ICollection<Glreceipt> Glreceipts { get; set; } = new List<Glreceipt>();

    public virtual ICollection<InvestorDetail> InvestorDetails { get; set; } = new List<InvestorDetail>();

    public virtual ICollection<InvestorRegistration> InvestorRegistrations { get; set; } = new List<InvestorRegistration>();

    public virtual ICollection<ItemBoqplan> ItemBoqplans { get; set; } = new List<ItemBoqplan>();

    public virtual ICollection<ProjectTransfer> ProjectTransfers { get; set; } = new List<ProjectTransfer>();

    public virtual ICollection<SubletService> SubletServices { get; set; } = new List<SubletService>();

    public virtual ICollection<Sublet> Sublets { get; set; } = new List<Sublet>();

    public virtual ICollection<TradingReceiptsPayment> TradingReceiptsPayments { get; set; } = new List<TradingReceiptsPayment>();

    public virtual ICollection<TradingTokenReceipt> TradingTokenReceipts { get; set; } = new List<TradingTokenReceipt>();

    public virtual ICollection<UserAndPartyMaping> UserAndPartyMapings { get; set; } = new List<UserAndPartyMaping>();
}
