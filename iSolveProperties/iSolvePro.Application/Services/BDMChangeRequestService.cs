using AutoMapper;
using iSolveProperties.Application.DTOs;
using iSolveProperties.Application.Interfaces;
using iSolveProperties.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = System.Threading.Tasks.Task;

namespace iSolveProperties.Application.Services
{
    public class BDMChangeRequestService: IBDMChangeRequestService
    {
        private readonly IBDMChangeRequestRepository _repository;
        private readonly IMapper _mapper;

        public BDMChangeRequestService(IBDMChangeRequestRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task AddRequestAsync(BDMChangeRequestDto requestDto)
        {
            var request = _mapper.Map<BDMChangeRequest>(requestDto);
              await _repository.AddAsync(request);
            
        }

        public async Task<IEnumerable<BDMChangeRequestDto>> GetAllRequestsAsync()
        {
            var requests = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<BDMChangeRequestDto>>(requests);
        }

        public async Task<BDMChangeRequestDto> GetRequestByIdAsync(int id)
        {
            var request = await _repository.GetRequestByIdAsync(id);
            return _mapper.Map<BDMChangeRequestDto>(request);
        }

        public async Task<bool> DeleteRequestAsync(int id)
        {
            var existingRequest = await _repository.DeleteAsync(id);
            if (existingRequest)
            {
                return true;
            }

            return false;
        }
    }
}
