using iSolveProperties.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = System.Threading.Tasks.Task;

namespace iSolveProperties.Application.Interfaces
{
    public interface IBDMChangeRequestRepository
    {
        Task AddAsync(BDMChangeRequest request);
        Task<IEnumerable<BDMChangeRequest>> GetAllAsync();

        Task<BDMChangeRequest> GetRequestByIdAsync(int id);
        Task<bool> DeleteAsync(int id);
    }
}
