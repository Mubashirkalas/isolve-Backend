using iSolveProperties.Application.DTOs;
using iSolveProperties.Application.Interfaces;
using iSolveProperties.Application.Services;
using iSolveProperties.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace iSolveProperties.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectInventoryController : ControllerBase
    {
        private readonly IProjectInventoryService _service;

        public ProjectInventoryController(IProjectInventoryService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetProjectInventoryDetails()
        {
            try
            {
                var details = await _service.GetAllProjectInventoryDetailsAsync();
                return Ok(details);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "internal server error");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProjectInventoryDetail(int id)
        {
            try
            {
                var detail = await _service.GetProjectInventoryDetailByIdAsync(id);

                if (detail == null)
                {
                    return NotFound();
                }

                return Ok(detail);
            }

            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }


        [HttpGet("{id}/summary")]
        public async Task<ActionResult<IEnumerable<ProjectInventoryDetailSummaryDto>>> GetProjectInventorySummary(int id)
        {
            try
            {
                var result = await _service.GetProjectInventoryDetailSummaryByIdAsync(id);

                if (!result.Any())
                {
                    return NotFound();
                }

                return Ok(result);

            }

            catch (Exception e) 
            {

                return StatusCode(500, "Internal server error");
            
            }
        }
        [HttpPost("upload")]
        public async Task<IActionResult> UploadFile([FromForm] ProjectInventoryDetailDto dto, [FromForm] IFormFile file)
        {
            if (file == null || file.Length == 0)
            {   
                return BadRequest("No file uploaded.");
            }

            await _service.UploadFileAsync(dto, file);
            return Ok(new { message = "File uploaded successfully." });
        }

        [HttpGet("download")]
        public IActionResult DownloadFile(string srno, int sNo , string financialYear)
        {
            var filePath = _service.GetFileForDownload(srno, sNo,  financialYear);

            if (string.IsNullOrEmpty(filePath) || !System.IO.File.Exists(filePath))
            {
                return NotFound("File not found.");
            }

            var fileName = Path.GetFileName(filePath);
            var contentType = "application/octet-stream"; // Set appropriate content type

            var fileBytes = System.IO.File.ReadAllBytes(filePath);
            return File(fileBytes, contentType, fileName);
        }



        [HttpGet("installment-plans")]
        public async Task<IActionResult> GetInstallmentPlans(
       [FromQuery] int projectId,
       [FromQuery] int? sNo,
       [FromQuery] string srno,
       [FromQuery] string financialYear)
        {
            var installmentPlans = await _service.GetInstallmentPlansAsync(projectId, sNo, srno, financialYear);

            if (installmentPlans == null || !installmentPlans.Any())
            {
                return NotFound("No installment plans found.");
            }

            return Ok(installmentPlans);
        }

    }
}
