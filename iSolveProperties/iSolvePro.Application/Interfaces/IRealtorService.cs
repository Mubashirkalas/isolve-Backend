using iSolveProperties.Application.DTOs;
using iSolveProperties.Domain.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace iSolveProperties.Application.Interfaces
{
    public interface IRealtorService
    {
       
        Task<Realtor> AddRealtorAsync(RealtorDto realtorDto);
        Task<RealtorDto> GetRealtorByIdAsync(int id);

    }
}
