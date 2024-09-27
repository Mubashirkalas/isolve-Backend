using iSolveProperties.Application.Interfaces;
using iSolveProperties.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSolveProperties.Infrastructure.Repositories
{
    public class EventReportRepository : IEventReportRepository
    {
        private readonly ISolveContext _context;

        public EventReportRepository(ISolveContext context)
        {
            _context = context;
        }

        public async Task<EventReport> AddEventReportAsync(EventReport eventReport)
        {
            _context.EventReports.Add(eventReport);
            await _context.SaveChangesAsync();
            return eventReport;
        }

        public async Task<List<EventReport>> GetAllAsync()
        {
            return await _context.EventReports.ToListAsync();  // Fetch all event reports from the database
        }
    }
}
