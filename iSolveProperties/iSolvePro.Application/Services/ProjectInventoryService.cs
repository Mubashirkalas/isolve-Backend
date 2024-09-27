using AutoMapper;
using iSolveProperties.Application.DTOs;
using iSolveProperties.Application.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace iSolveProperties.Application.Services
{
    public class ProjectInventoryService : IProjectInventoryService
    {
        private readonly IProjectInventoryRepository _repository;
        private readonly IMapper _mapper;
        

        public ProjectInventoryService(IProjectInventoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
            
        }

        public async Task<IEnumerable<ProjectInventoryDetailDto>> GetAllProjectInventoryDetailsAsync()
        {
            var entities = await _repository.GetProjectInventoryDetailsAsync();
            return _mapper.Map<IEnumerable<ProjectInventoryDetailDto>>(entities);
        }

        public async Task<IEnumerable<ProjectInventoryDetailDto?>> GetProjectInventoryDetailByIdAsync(int id)
        {
            var entity = await _repository.GetProjectInventoryDetailByIdAsync(id);

            if (entity == null || !entity.Any())
            {
                return Enumerable.Empty<ProjectInventoryDetailDto>(); // or throw an exception if preferred
            }

            return _mapper.Map< IEnumerable<ProjectInventoryDetailDto>>(entity);
        }

        public async Task<IEnumerable<ProjectInventoryDetailSummaryDto>> GetProjectInventoryDetailSummaryByIdAsync(int id)
        {
            var entity = await _repository.GetDistinctProjectInventoryDetailSummaryAsync(id);

            if (entity == null || !entity.Any())
            {
                return Enumerable.Empty<ProjectInventoryDetailSummaryDto>();
            }

            return entity;
        }

        public async Task UploadFileAsync(ProjectInventoryDetailDto dto, IFormFile file)
        {
            if (file == null || file.Length == 0)
                throw new ArgumentException("File is not provided.");

            // FTP URL (this is the destination where you want to upload the file)
            var ftpUrl = "ftp://babarislamco.com";

            // Generate the file name based on project name and SNo
            var fileName = $"{dto.ProjectName}_{dto.SNo}{Path.GetExtension(file.FileName)}";

            // Construct the full URL for the FTP upload
            var ftpFullUrl = $"{ftpUrl}{fileName}";

            // FTP credentials
            var ftpUsername = "babarisl";
            var ftpPassword = "@dzn8v*ME5UH90";

            // Create an FTP request to upload the file
            var request = (FtpWebRequest)WebRequest.Create(ftpFullUrl);
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential(ftpUsername, ftpPassword);
            request.UsePassive = true;
            request.UseBinary = true;
            request.KeepAlive = false;

            // Copy the IFormFile stream to the FTP request stream
            using (var fileStream = file.OpenReadStream())
            using (var ftpStream = request.GetRequestStream())
            {
                await fileStream.CopyToAsync(ftpStream);
            }

            // Update the database with the remote file path (relative URL)
            dto.FileUpload = $"https://www.leadyard.pk/images/{fileName}";
            await _repository.UpdateFilePathAsync(dto);
        }

        public string GetFileForDownload(string srno, int sNo, string financialYear)
        {
            var detail = _repository.GetFilePath(srno, sNo, financialYear);
            return detail?.FileUpload; // Return the file path
        }

        public async Task<List<InstallmentPlanDto>> GetInstallmentPlansAsync(int projectId, int? sNo, string srno, string financialYear)
        {
            return await _repository.GetInstallmentPlansAsync(projectId, sNo, srno, financialYear);
        }

    }
}
