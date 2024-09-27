using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iSolveProperties.Application.DTOs;
using iSolveProperties.Application.Interfaces;
using iSolveProperties.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace iSolveProperties.Infrastructure.Repositories
{
    public class ProjectRepository : IProjectRepository

    {
        private readonly ISolveContext _Context;

        public ProjectRepository(ISolveContext Context)
        {
            _Context = Context;
        }

        public async Task<IEnumerable<ProjectDto>> GetAllProjectsAsync()
        {
            return await _Context.ProjectRegistrations
                .Where(p => !string.IsNullOrEmpty(p.Project)) // Ensure Project field is not empty
                .Select(p => new ProjectDto
                {
                    Id = p.SerialNo,


                    ProjectName = p.Project
                })
                .ToListAsync();
        }


    }
}
