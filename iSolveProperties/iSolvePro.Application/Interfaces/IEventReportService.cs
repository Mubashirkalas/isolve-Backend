using iSolveProperties.Application.DTOs;
using iSolveProperties.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSolveProperties.Application.Interfaces
{
    public interface IEventReportService
    {
        Task<EventReport> AddEventReportAsync(EventReportDto eventReportDto);
        Task<List<EventReport>> GetAllEventReportsAsync();
    }
}
