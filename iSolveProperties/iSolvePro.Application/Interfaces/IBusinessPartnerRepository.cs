using iSolveProperties.Application.DTOs;
using iSolveProperties.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSolveProperties.Application.Interfaces
{
    public interface IBusinessPartnerRepository
    {
        Task<IEnumerable<BusinessPartnerDto>> GetAllBusinessPartnersAsync();
        Task<VwBusinessPartner> GetByCredentialsAsync(string userId, string password);

        Task<bool> UpdatePasswordAsync(string userId, string newPassword);

        public CommissionsDto GetCommissionByBpCode(string bpCode);


        string GetBpCodeByUserId(string userId);

        Task<string?> GetBusinessPartnerNameByUserIdAsync(string bpUserId);
    }
}

