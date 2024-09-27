using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using iSolveProperties.Application.DTOs;
using iSolveProperties.Domain.Entities;
using iSolveProperties.Application.Interfaces;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace iSolveProperties.Application.Services
{
    public class RealtorService : IRealtorService
    {
        private readonly IRealtorRepository _realtorRepository;
        private readonly IMapper _mapper;

        public RealtorService(IRealtorRepository realtorRepository, IMapper mapper)
        {
            _realtorRepository = realtorRepository;
            _mapper = mapper;

        }

        public async Task<Realtor> AddRealtorAsync(RealtorDto realtorDto)
        {
            var realtor = _mapper.Map<Realtor>(realtorDto);
            //companyId = student.GetAllCompany();
            await _realtorRepository.AddRealtorAsync(realtor);


            return realtor;
        }

        public async Task<RealtorDto> GetRealtorByIdAsync(int id)
        {
            var realtor = await _realtorRepository.GetByIdAsync(id);
            if (realtor == null)
            {
                return null;
            }
            return _mapper.Map<RealtorDto>(realtor); // Map entity to DTO
        }

    }

   
}
