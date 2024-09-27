using iSolveProperties.Application.DTOs;
using iSolveProperties.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSolveProperties.Application.Services
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly IBusinessPartnerRepository _businessRepository;

        public BookingService(IBookingRepository bookingRepository, IBusinessPartnerRepository businessRepository)
        {
            _bookingRepository = bookingRepository;
            _businessRepository = businessRepository;
        }

        public async Task<IEnumerable<BookingDto>> GetBookingsAsync(string dealerCode, string projectStatus)
        {
            return await _bookingRepository.GetBookingsAsync(dealerCode,projectStatus);
        }

        public async Task<string> GetBpCodeByUserIdAsync(string userId)
        {
            return  _businessRepository.GetBpCodeByUserId(userId); // Use repository method
        }

    }
}
