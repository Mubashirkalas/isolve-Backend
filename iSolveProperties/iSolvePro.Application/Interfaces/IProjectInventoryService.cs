using iSolveProperties.Application.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSolveProperties.Application.Interfaces
{
    public interface IProjectInventoryService
    {
        Task<IEnumerable<ProjectInventoryDetailDto>> GetAllProjectInventoryDetailsAsync();
        Task<IEnumerable<ProjectInventoryDetailDto>> GetProjectInventoryDetailByIdAsync(int id);

        Task<IEnumerable<ProjectInventoryDetailSummaryDto>> GetProjectInventoryDetailSummaryByIdAsync(int id);

        Task UploadFileAsync(ProjectInventoryDetailDto dto, IFormFile file);

        string GetFileForDownload(string srno, int sNo, string financialYear);

        Task<List<InstallmentPlanDto>> GetInstallmentPlansAsync(int projectId, int? sNo, string srno, string financialYear);
    }

}