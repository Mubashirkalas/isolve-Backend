using iSolveProperties.Application.Services;
using iSolveProperties.Application.DTOs;
using iSolveProperties.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace iSolveProperties.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessPartnerController : ControllerBase
    {
        private readonly IBusinessPartnerService _businessPartnerService;
        private readonly ITokenService _tokenService;


        public BusinessPartnerController(IBusinessPartnerService businessPartnerService, ITokenService tokenService)
        {
            _businessPartnerService = businessPartnerService;
            _tokenService = tokenService;

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BusinessPartnerDto>>> GetAllBusinessPartners()
        {
            var businessPartners = await _businessPartnerService.GetAllBusinessPartnersAsync();
            return Ok(businessPartners);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
        {
            try
            {
                var businessPartner = await _businessPartnerService.AuthenticateAsync(loginDto);
                if (businessPartner != null)
                {
                    // Generate JWT token
                    var token = await _tokenService.GetTokenAsync(int.Parse(loginDto.UserId)); // Adjust as necessary

                    // Return the token in the response
                    return Ok(new
                    {
                        Token = token,
                        UserId = loginDto.UserId,
                        BusinessPartnerName = businessPartner.BusinessPartnersName

                    });
                }

                // Invalid credentials
                return Unauthorized("Invalid credentials");
            }
            catch (UnauthorizedAccessException)
            {
                return Unauthorized();
            }
        }


        [HttpPost("update-password")]
        public async Task<IActionResult> UpdatePassword([FromBody] UpdatePasswordDto updatePasswordDto)
        {
            try
            {
                var isUpdated = await _businessPartnerService.UpdatePasswordAsync(updatePasswordDto);

                if (isUpdated)
                {
                    return Ok();
                }

                return BadRequest("Failed to update password");
            }
            catch (UnauthorizedAccessException)
            {
                return Unauthorized("Invalid current password");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred: " + ex.Message);
            }
        }

        [HttpGet("user/{userId}")]
        public IActionResult GetCommissions(string userId)
        {
            if (string.IsNullOrWhiteSpace(userId))
            {
                return BadRequest("User ID cannot be empty.");
            }

            // Get commissions for the user by their user ID
            CommissionsDto commissions = _businessPartnerService.GetCommissionsByUserId(userId);

            return Ok(commissions);  // Return the DTO which contains all three values
        }


        [HttpGet("GetBusinessPartnerName/{bpUserId}")]
        public async Task<IActionResult> GetBusinessPartnerName(string bpUserId)
        {
            var businessPartnerName = await _businessPartnerService.GetBusinessPartnerNameByUserIdAsync(bpUserId);

            if (businessPartnerName == null)
            {
                return NotFound("Business Partner not found.");
            }

            return Ok(businessPartnerName);
        }


    }

    }



