using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSolveProperties.Application.Mapping
{

    using AutoMapper;
    using iSolveProperties.Application.DTOs;
    using iSolveProperties.Domain.Entities;
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {

            CreateMap<Realtor, RealtorDto>().ReverseMap();
            CreateMap<BusinessPartnersMain, BusinessPartnerDto>().ReverseMap();
            CreateMap<VwProjectInventoryDetailNew, ProjectInventoryDetailDto>().ReverseMap();
            CreateMap<VwProjectInventoryDetailNew, ProjectInventoryDetailSummaryDto>().ReverseMap();
            CreateMap<VwBusinessPartner, BusinessPartnerDto>().ReverseMap();
            CreateMap<EventReport, EventReportDto>().ReverseMap();
            CreateMap<BDMChangeRequest, BDMChangeRequestDto>().ReverseMap();


        }
    }
}
