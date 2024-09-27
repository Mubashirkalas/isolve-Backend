using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSolveProperties.Application.DTOs
{
    public class EventReportDto
    {
        public int EventId { get; set; } // Primary Key

       
        public string? EventTitle { get; set; }
        public DateOnly DateOfEvent { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? EventVenue { get; set; }
        public string? FocusProject { get; set; }
        public string? ProductType { get; set; }
        public string? SalesSupportRequired { get; set; } // Yes/No
        public string? NoOfEventsCitySpecific { get; set; }
        public string? AvgMeetingPerEvent { get; set; }
        public string? AvgSalesVolumePerEvent { get; set; }
        public string? PropertyType { get; set; }
        public string? LeadSource { get; set; }
        public string? MarketingMediumUsed { get; set; }
        public string? NoOfExistingLeads { get; set; }
        public string? NoOfInvestorDatabaseTarget { get; set; }
        public string? OtherSourcesOfLeads { get; set; }
        public string? MarketingBudget { get; set; }
        public string? MarketingPlatform { get; set; }
        public string? NoOfLeadsExpected { get; set; }
        public string? NoOfWalkinsExpected { get; set; }

       
        public string? Status { get; set; }        // Status of the event request
        public string? RequestedBy { get; set; }   // User who created the request


    }


}
