using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace iSolveProperties.Application.DTOs
{
    public record RealtorDto
    {



        [Required]
        public string? RealtorName { get; set; }
        [Required]
        public string? UserType { get; set; }
        [Required]
        public string? ContactNo { get; set; }
        [Required]
        public string? OfficeAddress { get; set; }
        [Required]
        public string? CompanyName { get; set; }
        [Required]
        public string? City { get; set; }
        [Required]
        public string? AgentId { get; set; }
        [Required]
        public string? Cnic { get; set; }

        // This will hold the file path in the database
        public string? CnicImage { get; set; }

        // This will be used to receive the file from the frontend
        public IFormFile? CnicImageFile { get; set; }

        public string? OfficeImage { get; set; }

        public IFormFile? OfficeImageFile { get; set; }

        public bool? Approved { get; set; }


    }
}
