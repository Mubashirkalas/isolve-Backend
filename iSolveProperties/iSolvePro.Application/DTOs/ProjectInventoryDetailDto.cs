using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;


namespace iSolveProperties.Application.DTOs
{
    public class ProjectInventoryDetailDto
    {
        public string? SerialNo { get; set; }
        public string? PropertyDescription { get; set; }
        public string? PropertyDetailsTitle { get; set; }

        public double? CostPerProperty { get; set; }
        public string? BlockName { get; set; }
        public string? AreaName { get; set; }

        public string? Srno { get; set; }
        public byte? CompID { get; set; }
        public string? FinancialYear { get; set; }
        public string? ProjectName { get; set; }
        public int? SNo { get; set; }

        public string? Status { get; set; }
        public string? ProjectSerialNo { get; set; }
      
        public int? SalesPrice { get; set; }

        public string? FileUpload { get; set; }

        public IFormFile? File { get; set; }
    }
}
