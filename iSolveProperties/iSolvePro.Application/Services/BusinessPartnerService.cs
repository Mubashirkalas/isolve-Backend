using AutoMapper;
using iSolveProperties.Application.DTOs;
using iSolveProperties.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSolveProperties.Application.Services
{
    public class BusinessPartnerService : IBusinessPartnerService
    {
        private readonly IBusinessPartnerRepository _businessPartnerRepository;
        private readonly IMapper _mapper;

        public BusinessPartnerService(IBusinessPartnerRepository businessPartnerRepository, IMapper mapper)
        {
            _businessPartnerRepository = businessPartnerRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<BusinessPartnerDto>> GetAllBusinessPartnersAsync()
        {
            return await _businessPartnerRepository.GetAllBusinessPartnersAsync();
        }

        public async Task<BusinessPartnerDto?> AuthenticateAsync(LoginDto loginDto)
        {
            var businessPartner = await _businessPartnerRepository.GetByCredentialsAsync(loginDto.UserId, loginDto.Password);

            if (businessPartner == null)
            {
                return null; // or throw an appropriate exception
            }

            // Map the entity to DTO
            return _mapper.Map<BusinessPartnerDto>(businessPartner);
        }

        public async Task<bool> UpdatePasswordAsync(UpdatePasswordDto updatePasswordDto)
        {
            // Validate credentials (check if the current password is correct)
            var businessPartner = await _businessPartnerRepository.GetByCredentialsAsync(updatePasswordDto.UserId, updatePasswordDto.CurrentPassword);

            if (businessPartner == null)
            {
                throw new UnauthorizedAccessException("Invalid current password");
            }

            // Update the password
            var isUpdated = await _businessPartnerRepository.UpdatePasswordAsync(updatePasswordDto.UserId, updatePasswordDto.NewPassword);

            return isUpdated;
        }

        public CommissionsDto GetCommissions(string bpCode)
        {
            return _businessPartnerRepository.GetCommissionByBpCode(bpCode);
        }

        public CommissionsDto GetCommissionsByUserId(string userId)
        {
            string bpCode = _businessPartnerRepository.GetBpCodeByUserId(userId);
            return GetCommissions(bpCode);
        }

        public async Task<string?> GetBusinessPartnerNameByUserIdAsync(string bpUserId)
        {
            return await _businessPartnerRepository.GetBusinessPartnerNameByUserIdAsync(bpUserId);
        }

    }
}
