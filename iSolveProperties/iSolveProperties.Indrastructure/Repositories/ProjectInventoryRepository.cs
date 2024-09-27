using iSolveProperties.Application.Interfaces;
using iSolveProperties.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using iSolveProperties.Application.DTOs;
using Task = System.Threading.Tasks.Task;

namespace iSolveProperties.Infrastructure.Repositories
{
    public class ProjectInventoryRepository : IProjectInventoryRepository
    {
        private readonly ISolveContext _context;

        public ProjectInventoryRepository(ISolveContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<VwProjectInventoryDetailNew>> GetProjectInventoryDetailsAsync()
        {
            var list = await _context.VwProjectInventoryDetailNews.ToListAsync();
            return list;
        }

        public async Task<IEnumerable<VwProjectInventoryDetailNew>> GetProjectInventoryDetailByIdAsync(int id)
        {
           return await _context.VwProjectInventoryDetailNews
     .Where(p => p.ProjectSerialNo == id.ToString())
     .GroupBy(p => p.PropertyDescription)  // Group by PropertyDescription for distinct values
        .Select(g => g.First())  // Select the first record from each group to get distinct PropertyDescriptions
     .ToListAsync();

            
        }

        public async Task<IEnumerable<ProjectInventoryDetailSummaryDto>> GetDistinctProjectInventoryDetailSummaryAsync(int id)
        {
            return await _context.VwProjectInventoryDetailNews
                .Where(p => p.ProjectSerialNo == id.ToString())


                .Select(p => new ProjectInventoryDetailSummaryDto
                {
                    BlockName = p.BlockName,
                    ProjectSerialNo = p.ProjectSerialNo,
                    BlocksDetailsSerialNo = p.BlocksDetailsSerialNo
                })
                .Distinct()
                .ToListAsync();
        }

        public async Task UpdateFilePathAsync(ProjectInventoryDetailDto dto)
        {
            /*var entity = await _context.ProjectInventoryDetails.FindAsync(dto.SNo);
            if (entity != null)
            {
                // Map properties from dto to entity
                entity.FileUpload = dto.FileUpload; // Update the file path
                                                    // Update other properties as needed
                await _context.SaveChangesAsync();
            }*/



            var entity = await _context.ProjectInventoryDetails
       .FirstOrDefaultAsync(p => p.Srno == dto.Srno && p.FinancialYear == dto.FinancialYear && p.Sno == dto.SNo);

            if (entity != null)
            {
                // Map the file path to the entity
                entity.FileUpload = dto.FileUpload;
                _context.Attach(entity);
                _context.Entry(entity).Property(x => x.FileUpload).IsModified = true;

                // Map other fields if necessary
                // e.g., entity.Status = dto.Status;

                // Save changes to the database
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new KeyNotFoundException("Record not found.");
            }

        }

        public ProjectInventoryDetailDto GetFilePath(string srno, int sNo, string financialYear)
        {
            return _context.ProjectInventoryDetails
                .Where(p => p.Srno == srno && p.Sno == sNo && p.FinancialYear == financialYear)
                .Select(p => new ProjectInventoryDetailDto
                {
                    FileUpload = p.FileUpload
                })
                .FirstOrDefault();
        }


        public async Task<List<InstallmentPlanDto>> GetInstallmentPlansAsync(int projectId, int? sNo, string srno, string financialYear)
        {
            try
            {
                //var result = await _context.VwProjectInventoryDetails.Where(s => s.Sno == sNo && s.FinancialYear == financialYear && s.Srno == srno && Convert.ToInt32(s.ProjectSerialNo) == projectId).AsNoTrackingWithIdentityResolution().FirstOrDefaultAsync();



                //var query = from ipn in _context.VwInstallmentPlanNews
                //            join ipd in _context.InstallmentPlanDetailNews
                //            on new { ipn.CompId, ipn.SerialNo } equals new { ipd.CompId, ipd.SerialNo }
                //            where ipn.ProjectId == projectId && ipn.WebPlan == true
                //            select new InstallmentPlanDto
                //            {
                //                SerialNo = ipn.SerialNo,
                //                ProjectId = ipn.ProjectId,
                //                PlanName = ipn.PlanName,
                //                NoofInstallment = ipn.NoofInstallment,
                //                ProjectName = ipn.ProjectName,
                //                Description = ipd.Description,
                //                AmountPercentage = ipd.AmountPercentage,
                //                Amount = Convert.ToString(result.SalesPrice * ipd.AmountPercentage / 100),
                //                WebPlan = ipn.WebPlan,
                //            };
                //var check = query.ToListAsync();
                //return await query.ToListAsync();
                // Retrieve the result asynchronously
                var result = await _context.VwProjectInventoryDetails
                    .AsNoTrackingWithIdentityResolution()
                    .FirstOrDefaultAsync(s => s.Sno == sNo && s.FinancialYear == financialYear &&
                                              s.Srno == srno &&
                                              Convert.ToInt32(s.ProjectSerialNo) == projectId);

                // Check if the result is null to avoid null reference exceptions
                if (result == null)
                {
                    return new List<InstallmentPlanDto>(); // or handle as appropriate
                }

                // Use async to execute the join query
                var query = from ipn in _context.VwInstallmentPlanNews
                            join ipd in _context.InstallmentPlanDetailNews
                            on new { ipn.CompId, ipn.SerialNo } equals new { ipd.CompId, ipd.SerialNo }
                            where ipn.ProjectId == projectId && ipn.WebPlan
                            select new InstallmentPlanDto
                            {
                                SerialNo = ipn.SerialNo,
                                ProjectId = ipn.ProjectId,
                                PlanName = ipn.PlanName,
                                NoofInstallment = ipn.NoofInstallment,
                                ProjectName = ipn.ProjectName,
                                Description = ipd.Description,
                                AmountPercentage = ipd.AmountPercentage,
                                Amount = Convert.ToString(result.SalesPrice * Convert.ToInt32(ipd.AmountPercentage) / 100),
                                WebPlan = ipn.WebPlan,
                                FileUpload= result.FileUpload
                            };

                // Await the execution of the query asynchronously
                var installmentPlans = await query.ToListAsync();
                return installmentPlans;


            }

            catch (Exception ex) {

                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            return null;
        }
    }
}
