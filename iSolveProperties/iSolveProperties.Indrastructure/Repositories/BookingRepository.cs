using iSolveProperties.Application.DTOs;
using iSolveProperties.Application.Interfaces;
using iSolveProperties.Domain.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSolveProperties.Infrastructure.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        private readonly ISolveContext _context;

        public BookingRepository(ISolveContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<BookingDto>> GetBookingsAsync(string dealerCode,string ProjectStatus)
        {


            try
            {
                if (ProjectStatus == "All")
                {
                    

                    return await _context.VwProjectSales
                        .Where(x => x.DealerCode == dealerCode && (x.ProjectStatus == "Available" || x.ProjectStatus == "Sold"))
                        .OrderBy(x => x.Date)
                        .Select(x => new BookingDto
                        {
                            Srno = x.Srno,
                            SerialNo = x.SerialNo,
                            SubsegmentName = x.SubSegmentName,
                            Date = x.Date,
                            ClientName = x.ClientName,
                            ProjectName = x.ProjectName,
                            PropertyDescription = x.PropertyDescription,
                            AreaTitle = x.AreaTitle,
                            PropertyDetail = x.PropertyTitle,
                            CategoryTitle = x.CategoryTitle,
                            BlockName = x.BlockName,
                            BookingType = x.TypeTitle,
                            TotalAmount = x.TotalAmount,
                            ProjectStatus = x.ProjectStatus,
                            DealerCommission = x.DealerCommission
                        }).ToListAsync();
                }
                else if (ProjectStatus == "Cancel")
                {
                   

                    return await _context.VwProjectSales
                        .Where(x => x.DealerCode == dealerCode && (x.ProjectStatus != "Available" && x.ProjectStatus != "Sold"))
                        .OrderBy(x => x.Date)
                        .Select(x => new BookingDto
                        {
                            Srno = x.Srno,
                            SerialNo = x.SerialNo,
                            SubsegmentName = x.SubSegmentName,
                            Date = x.Date,
                            ClientName = x.ClientName,
                            ProjectName = x.ProjectName,
                            PropertyDescription = x.PropertyDescription,
                            AreaTitle = x.AreaTitle,
                            PropertyDetail = x.PropertyTitle,
                            CategoryTitle = x.CategoryTitle,
                            BlockName = x.BlockName,
                            BookingType = x.TypeTitle,
                            TotalAmount = x.TotalAmount,
                            ProjectStatus = x.ProjectStatus,
                            DealerCommission = x.DealerCommission
                        })

                        .ToListAsync();
                }

                else if (ProjectStatus == "Commission")
                {


                    return await _context.VwProjectSales
                        .Where(x => x.DealerCode == dealerCode )
                        .OrderBy(x => x.Date)
                        .Select(x => new BookingDto
                        {
                            Srno = x.Srno,
                            SerialNo = x.SerialNo,
                            SubsegmentName = x.SubSegmentName,
                            Date = x.Date,
                            ClientName = x.ClientName,
                            ProjectName = x.ProjectName,
                            PropertyDescription = x.PropertyDescription,
                            AreaTitle = x.AreaTitle,
                            PropertyDetail = x.PropertyTitle,
                            CategoryTitle = x.CategoryTitle,
                            BlockName = x.BlockName,
                            BookingType = x.TypeTitle,
                            TotalAmount = x.TotalAmount,
                            ProjectStatus = x.ProjectStatus,
                            DealerCommission = x.DealerCommission
                        })

                        .ToListAsync();
                }

                return null;
            }

            catch (SqlException sqlEx)
            {
                // Log SQL-specific exception
                Console.WriteLine($"SQL error in GetBookingsAsync: {sqlEx.Message}");
                throw;
            }
            catch (Exception ex)
            {
                // Log generic exceptions
                Console.WriteLine($"Error in GetBookingsAsync: {ex.Message}");
                throw;
            }

        }
    }
}
