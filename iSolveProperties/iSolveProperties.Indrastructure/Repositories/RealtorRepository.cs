using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iSolveProperties.Domain.Entities;
using iSolveProperties.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace iSolveProperties.Infrastructure.Repositories
{
    public class RealtorRepository : IRealtorRepository
    {
        private readonly ISolveContext _context;


        public RealtorRepository(ISolveContext context)
        {
            _context = context;
        }

        public async Task<Realtor> AddRealtorAsync(Realtor realtor)
        {
            _context.Realtors.Add(realtor);
             await _context.SaveChangesAsync();
            return realtor;
        }

        public async Task<Realtor> GetByIdAsync(int id)
        {
            return await _context.Realtors.FindAsync(id); // Use Entity Framework's FindAsync to get the realtor
        }

    }


}
