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
    public interface IBDMChangeRequestService
    {
        Task AddRequestAsync(BDMChangeRequestDto requestDto);
        Task<IEnumerable<BDMChangeRequestDto>> GetAllRequestsAsync();

        Task<BDMChangeRequestDto> GetRequestByIdAsync(int id);
        Task <bool> DeleteRequestAsync(int id);
    }
}
