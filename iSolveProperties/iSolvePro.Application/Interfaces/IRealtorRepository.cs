using iSolveProperties.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSolveProperties.Application.Interfaces
{
    public interface IRealtorRepository
    {
       
        Task<Realtor> AddRealtorAsync(Realtor realtor);
        Task<Realtor> GetByIdAsync(int id);

    }
}
