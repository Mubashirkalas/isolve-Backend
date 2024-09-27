using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSolveProperties.Domain.Entities
{
    [Table("BDMChangeRequest")]
    public partial class BDMChangeRequest
    {
        public int Id { get; set; }  // Primary Key

        public string? Name { get; set; }  // Name of the person making the request

        public string? RequestedBDM { get; set; }  // Name of the requested BDM

        public string? Reason { get; set; }  // Reason for the request

        public DateOnly RequestedOn { get; set; } = DateOnly.FromDateTime(DateTime.Now); // Date the request was made

        public string? Status { get; set; }  // Status (pending, approved, declined)

        public string? UserId { get; set; }

    }
}
