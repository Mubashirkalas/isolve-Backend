using iSolveProperties.Application.Interfaces;
using iSolveProperties.Domain.Entities;
using iSolveProperties.Infrastructure.DIConfigration;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = System.Threading.Tasks.Task;

namespace iSolveProperties.Infrastructure.Repositories
{
    public class BDMChangeRequestRepository : IBDMChangeRequestRepository
    {
        private readonly ISolveContext _context;

        public BDMChangeRequestRepository(ISolveContext context)
        {
            _context = context;
        }

        public async Task AddAsync(BDMChangeRequest request)
        {
            _context.BDMChangeRequests.Add(request);
            await _context.SaveChangesAsync();
            
           
        }

        public async Task<IEnumerable<BDMChangeRequest>> GetAllAsync()
        {
            return await _context.BDMChangeRequests.ToListAsync();
        }

        public async Task<BDMChangeRequest> GetRequestByIdAsync(int id)
        {
            var data = await _context.BDMChangeRequests.FindAsync(id);
            return data;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var request = await _context.BDMChangeRequests.FindAsync(id);
            if (request != null)
            {
                _context.BDMChangeRequests.Remove(request);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
