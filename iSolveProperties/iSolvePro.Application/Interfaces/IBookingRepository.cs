using iSolveProperties.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSolveProperties.Application.Interfaces
{
    public interface IBookingRepository
    {
        Task<IEnumerable<BookingDto>> GetBookingsAsync(string dealerCode , string projectStatus);
    }
}
