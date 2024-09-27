using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using iSolveProperties.Application.Interfaces;
using iSolveProperties.Application.DTOs;
using iSolveProperties.Application.Services;

namespace iSolveProperties.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventReportController : ControllerBase
    {
        private readonly IEventReportService _service;

        public EventReportController(IEventReportService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> CreateEventReport([FromBody] EventReportDto eventReportDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _service.AddEventReportAsync(eventReportDto);
            return CreatedAtAction(nameof(CreateEventReport), new { id = eventReportDto.EventTitle }, eventReportDto);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEventReports()
        {
            var eventReports = await _service.GetAllEventReportsAsync();
            return Ok(eventReports);  // Return the list of event reports
        }
    }
}
