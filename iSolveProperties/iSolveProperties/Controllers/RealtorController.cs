using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using iSolveProperties.Domain.Entities;
using iSolveProperties.Application.DTOs;
using iSolveProperties.Application.Services;
using iSolveProperties.Application.Interfaces;

using Microsoft.EntityFrameworkCore.Metadata.Internal;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace iSolveProperties.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RealtorController : ControllerBase
    {
        private readonly IRealtorService _realtorService;

        private readonly IWebHostEnvironment _env;

        public RealtorController(IRealtorService realtorService, IWebHostEnvironment env)
        {
            _realtorService = realtorService;
            _env = env;

        }

        [HttpPost("realtors")]
        public async Task<IActionResult> AddRealtor([FromForm] RealtorDto realtorDto)
        {
           
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            // Save files and get file paths
            if (realtorDto.CnicImageFile != null)
            {
                realtorDto.CnicImage = await SaveFileAsync(realtorDto.CnicImageFile);
            }

            if (realtorDto.OfficeImageFile != null)
            {
                realtorDto.OfficeImage = await SaveFileAsync(realtorDto.OfficeImageFile);
            }


            var result = await _realtorService.AddRealtorAsync(realtorDto);
            return Ok(result);
        }


        [HttpGet("realtors/{id}")]
        public async Task<IActionResult> GetRealtorById(int id)
        {
            if (id <= 0)
                return BadRequest("Invalid realtor ID.");

            var realtor = await _realtorService.GetRealtorByIdAsync(id);

            if (realtor == null)
                return NotFound("Realtor not found.");

            return Ok(realtor);
        }

        private async Task<string> SaveFileAsync(IFormFile file)
    {
            try
            {
                string imagesPath = Path.Combine(_env.ContentRootPath, "resources", "images");
                if (!Directory.Exists(imagesPath))
                {
                    Directory.CreateDirectory(imagesPath);
                }

                string fileName = Path.GetFileNameWithoutExtension(file.FileName);
                string extension = Path.GetExtension(file.FileName);
                string uniqueFileName = $"{fileName}_{Guid.NewGuid()}{extension}";
                string filePath = Path.Combine(imagesPath, uniqueFileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                return Path.Combine("resources", "images", uniqueFileName).Replace("\\", "/");
            }
            catch (Exception ex)
            {
                // Log exception
                Console.WriteLine($"Error saving file: {ex.Message}");
                throw;
            }
        }
       
        //[HttpPost("add")]
        //public async Task<IActionResult> AddRealtorAsync([FromForm] RealtorDto realtorDto, [FromForm] IFormFile cnicImage, [FromForm] IFormFile officeImage)
        //{
        //    if (realtorDto == null)
        //    {
        //        return BadRequest("Realtor data is required.");
        //    }

        //    // Save files
        //    string cnicImagePath = null;
        //    string officeImagePath = null;

        //    if (cnicImage != null)
        //    {
        //      //  cnicImagePath = await SaveFileAsync(cnicImage, realtorDto.CompanyName);
        //    }

        //    if (officeImage != null)
        //    {
        //        //officeImagePath = await SaveFileAsync(officeImage, realtorDto.CompanyName);
        //    }

        //    // Update the DTO with file paths
        //    realtorDto.CnicImage = cnicImagePath;
        //    realtorDto.OfficeImage = officeImagePath;

        //    // Call the service to add the realtor
        //    var result = await _realtorService.AddRealtorAsync(realtorDto);

        //    return Ok(result);
        //}

        //private async Task<string> SaveFileAsync(IFormFile file, string companyName)
        //{
        //    if (file.Length > 0)
        //    {
        //        // Create a unique file name or use company name
        //        var fileName = $"{companyName}_{Path.GetFileName(file.FileName)}";
        //        var filePath = Path.Combine(_imagesPath, fileName);

        //        // Ensure the directory exists
        //        if (!Directory.Exists(_imagesPath))
        //        {
        //            Directory.CreateDirectory(_imagesPath);
        //        }

        //        // Save the file
        //        using (var stream = new FileStream(filePath, FileMode.Create))
        //        {
        //            await file.CopyToAsync(stream);
        //        }

        //        // Return the relative path to be saved in the database
        //        return Path.Combine("resources", "images", fileName);
        //    }

        //    return null;
        //}
    }
}

