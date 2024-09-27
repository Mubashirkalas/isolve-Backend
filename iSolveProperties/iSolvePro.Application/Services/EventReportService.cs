using AutoMapper;
using iSolveProperties.Application.DTOs;
using iSolveProperties.Application.Interfaces;
using iSolveProperties.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace iSolveProperties.Application.Services
{
    public class EventReportService : IEventReportService
    {
        private readonly IEventReportRepository _repository;
        private readonly IMapper _mapper;

        public EventReportService(IEventReportRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<EventReport> AddEventReportAsync(EventReportDto eventReportDto)
        {
            var eventReport = _mapper.Map<EventReport>(eventReportDto);
            await _repository.AddEventReportAsync(eventReport);
            return eventReport;
        }

        public async Task<List<EventReport>> GetAllEventReportsAsync()
        {
            var eventReports = await _repository.GetAllAsync();  // Fetch all from repository
            return eventReports;
        }
    }
}
