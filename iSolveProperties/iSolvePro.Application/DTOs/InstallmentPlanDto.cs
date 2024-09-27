using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSolveProperties.Application.DTOs
{
    public class InstallmentPlanDto
    {
        public int SerialNo { get; set; }
        public string? PlanName { get; set; }
        public short? NoofInstallment { get; set; }
        public string? ProjectName { get; set; }
        public string? Description { get; set; }

        public int? SNo { get; set; }
        public string? Srno { get; set; }
        public string? FinancialYear { get; set; }

        public string? Amount { get; set; }

        public short? ProjectId { get; set; }
        public byte AmountPercentage { get; set; }

        public string? FileUpload { get; set; }
        public bool WebPlan { get; set; }
    }
}
