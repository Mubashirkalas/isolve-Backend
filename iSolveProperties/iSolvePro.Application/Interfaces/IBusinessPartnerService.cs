using iSolveProperties.Application.DTOs;
using iSolveProperties.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSolveProperties.Application.Interfaces
{
    public interface IBusinessPartnerService
    {
        Task<IEnumerable<BusinessPartnerDto>> GetAllBusinessPartnersAsync();
        Task<BusinessPartnerDto?> AuthenticateAsync(LoginDto loginDto);

        Task<bool> UpdatePasswordAsync(UpdatePasswordDto updatePasswordDto);

        CommissionsDto GetCommissions(string bpCode);
        CommissionsDto GetCommissionsByUserId(string userId);

        Task<string?> GetBusinessPartnerNameByUserIdAsync(string bpUserId);
    }
}
