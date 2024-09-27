using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSolveProperties.Domain.Entities
{
    [Table("Event_Report")]
    public class EventReport
    {
        [Key]
        public int EventId { get; set; }

        [Required]
        [StringLength(255)]

   
        public string? EventTitle { get; set; }

        [Required]
        public DateOnly DateOfEvent { get; set; }

        [Required]
        [StringLength(100)]
        public string? City { get; set; }

        [Required]
        [StringLength(100)]
        public string? Country { get; set; }

        [Required]
        [StringLength(255)]
        public string? EventVenue { get; set; }

        [Required]
        [StringLength(255)]
        public string? FocusProject { get; set; }

        [Required]
        [StringLength(50)]
        public string? ProductType { get; set; }

        [Required]
        [StringLength(3)]
        public string? SalesSupportRequired { get; set; }

        [Required]
        [StringLength(50)]
        public string? NoOfEventsCitySpecific { get; set; }

        [Required]
        [StringLength(50)]
        public string? AvgMeetingPerEvent { get; set; }

        [Required]
        [StringLength(50)]
        public string? AvgSalesVolumePerEvent { get; set; }

        [Required]
        [StringLength(100)]
        public string? PropertyType { get; set; }

        [Required]
        [StringLength(100)]
        public string? LeadSource { get; set; }

        [Required]
        [StringLength(255)]
        public string? MarketingMediumUsed { get; set; }

        [Required]
        [StringLength(50)]
        public string? NoOfExistingLeads { get; set; }

        [Required]
        [StringLength(50)]
        public string? NoOfInvestorDatabaseTarget { get; set; }

        [StringLength(255)]
        public string? OtherSourcesOfLeads { get; set; }

        [Required]
        [StringLength(50)]
        public string? MarketingBudget { get; set; }

        [Required]
        [StringLength(255)]
        public string? MarketingPlatform { get; set; }

        [Required]
        [StringLength(50)]
        public string? NoOfLeadsExpected { get; set; }

        [Required]
        [StringLength(50)]
        public string? NoOfWalkinsExpected { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.Now;


        [StringLength(20)]
        public string? Status { get; set; }

       
        [StringLength(100)] 
        public string?  RequestedBy { get; set; }


    }
}
