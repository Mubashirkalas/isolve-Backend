using iSolveProperties.Application.DTOs;
using iSolveProperties.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = System.Threading.Tasks.Task;

namespace iSolveProperties.Application.Interfaces
{
    public interface IProjectInventoryRepository
    {
        Task<IEnumerable<VwProjectInventoryDetailNew>> GetProjectInventoryDetailsAsync();
        Task <IEnumerable<VwProjectInventoryDetailNew>> GetProjectInventoryDetailByIdAsync(int id);

       Task<IEnumerable<ProjectInventoryDetailSummaryDto>> GetDistinctProjectInventoryDetailSummaryAsync(int id);

        Task UpdateFilePathAsync(ProjectInventoryDetailDto dto);

        ProjectInventoryDetailDto GetFilePath(string srno, int sNo, string financialYear);

        Task<List<InstallmentPlanDto>> GetInstallmentPlansAsync(int projectId, int? sNo, string srno, string financialYear);
    }
}
