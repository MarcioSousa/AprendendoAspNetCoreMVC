using EstudosWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EstudosWebMvc.Services
{
    public class SalesRecordsService
    {
        private readonly EstudosWebMvcContext _context;

        public SalesRecordsService(EstudosWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;

            if (minDate.HasValue)
            {
                result = result.Where(x => x.DataSales >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.DataSales <= maxDate.Value);
            }

            return await result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Departament)
                .OrderByDescending(x => x.DataSales)
                .ToListAsync();
        }

    }
}
