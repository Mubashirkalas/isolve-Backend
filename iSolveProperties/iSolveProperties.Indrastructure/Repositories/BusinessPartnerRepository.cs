using iSolveProperties.Application.DTOs;
using iSolveProperties.Application.Interfaces;
using iSolveProperties.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace iSolveProperties.Infrastructure.Repositories
{
    public class BusinessPartnerRepository : IBusinessPartnerRepository
    {
        private readonly ISolveContext _Context;

        public BusinessPartnerRepository(ISolveContext Context)
        {
            _Context = Context;
        }

        public async Task<IEnumerable<BusinessPartnerDto>> GetAllBusinessPartnersAsync()
        {
            return await _Context.VwBusinessPartners

                  .Where(bp => bp.PartyType == "employee")
                 .Select(bp => new BusinessPartnerDto
                 {
                     BusinessPartnersCode = bp.BusinessPartnersCode,
                     BusinessPartnersName = bp.BusinessPartnersName
                 })
            .ToListAsync();
        }

        public async Task<VwBusinessPartner> GetByCredentialsAsync(string userId, string password)
        {
            return await _Context.VwBusinessPartners
             .Where(bp => bp.Bpuserid == userId && bp.Bppassword == password)
             .SingleOrDefaultAsync();
        }

        public async Task<bool> UpdatePasswordAsync(string userId, string newPassword)
        {
            // Fetch the business partner from the BusinessPartnersMain table
            var businessPartner = await _Context.BusinessPartnersMains
                .SingleOrDefaultAsync(bp => bp.Bpuserid == userId);  // Query based on the Bpuserid

            if (businessPartner != null)
            {
                businessPartner.Bppassword = newPassword; // Update the password
                _Context.BusinessPartnersMains.Update(businessPartner);  // Track the changes
                await _Context.SaveChangesAsync();  // Save the changes to the database
                return true;
            }

            return false; // Return false if no matching user is found

        }


        public CommissionsDto GetCommissionByBpCode(string bpCode)
        {
            var result = _Context.PartyVoucherDetails
                .Where(v => v.BpCode == bpCode && new[] { "cv", "cav" }.Contains(v.VType))
                .GroupBy(v => v.BpCode)
                .Select(g => new CommissionsDto
                {
                 NetValue    = g.Sum(v => v.Debit) ?? 0,  // Sum of Debit (Payable)
                    Paid = g.Sum(v => v.Credit) ?? 0,    // Sum of Credit (Paid)
                    Payable = (g.Sum(v => v.Debit) ?? 0) - (g.Sum(v => v.Credit) ?? 0) // Payable - Paid (NetValue)
                })
                .FirstOrDefault();

            return result ?? new CommissionsDto { Payable = 0, Paid = 0, NetValue = 0 };
        }


        public string GetBpCodeByUserId(string userId)
        {
            // Implement logic to retrieve BP_Code based on user ID
            return _Context.BusinessPartnersMains
                .Where(u => u.Bpuserid == userId)
                .Select(u => u.BusinessPartnersCode) // Adjust property name according to your User model
                .FirstOrDefault();
        }

        public async Task<string?> GetBusinessPartnerNameByUserIdAsync(string bpUserId)
        {
            var businessPartner = await _Context.BusinessPartnersMains
                .Where(bp => bp.Bpuserid == bpUserId)
                .Select(bp => bp.BusinessPartnersName)
                .FirstOrDefaultAsync();

            return businessPartner;
        }
    }
}
