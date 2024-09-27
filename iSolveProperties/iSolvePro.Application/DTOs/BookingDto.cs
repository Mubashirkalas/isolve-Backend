using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSolveProperties.Application.DTOs
{
    public class BookingDto
    {
        public int Srno { get; set; }
        public int? SerialNo { get; set; }
        public string? SubsegmentName { get; set; }
        public DateOnly? Date { get; set; }
        public string? ClientName { get; set; }
        public string? ProjectName { get; set; }
        public string? PropertyDescription { get; set; }
        public string? AreaTitle { get; set; }
        public string?   PropertyDetail { get; set; }
        public string? CategoryTitle { get; set; }
        public string? BlockName { get; set; }
        public string? BookingType { get; set; }
        public double? TotalAmount { get; set; }
        public string?   ProjectStatus { get; set; }
        public double? DealerCommission { get; set; }
    }
}
