using iSolveProperties.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSolveProperties.Application.Interfaces
{
    public interface IEventReportRepository
    {
        Task<EventReport> AddEventReportAsync(EventReport eventReport);
        Task<List<EventReport>> GetAllAsync();
    }
}
