using iSolveProperties.Application.DTOs;
using iSolveProperties.Application.Interfaces;
using iSolveProperties.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace iSolveProperties.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BDMChangeRequestController : ControllerBase
    {
        private readonly IBDMChangeRequestService _service;

        public BDMChangeRequestController(IBDMChangeRequestService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> AddRequest([FromBody] BDMChangeRequestDto requestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _service.AddRequestAsync(requestDto);
               return Ok(requestDto);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BDMChangeRequestDto>>> GetAllRequests()
        {
            var requests = await _service.GetAllRequestsAsync();
            return Ok(requests);
        }


        [HttpGet("{id}")]
        public async  Task<ActionResult<BDMChangeRequestDto>> GetRequestById(int id)
        {
            var requests = await _service.GetRequestByIdAsync(id);
            if (requests == null)
            {
                return NotFound();
            }
            return Ok(requests);
        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRequest(int id)
        {
            try
            {
                await _service.DeleteRequestAsync(id);
                return NoContent(); // Returns 204 No Content on successful deletion
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log it)
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
