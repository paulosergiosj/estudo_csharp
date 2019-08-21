using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetMVC.Services
{
    public class SalesRecordService
    {
        private readonly AspNetMVCContext _context;

        public SalesRecordService(AspNetMVCContext context)
        {
            _context = context;
        }

        public async Task InsertAsync(SalesRecord obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }
        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate,DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }
            return await result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }

        public async Task<List<IGrouping<Department, SalesRecord>>> FindByDateGroupingAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }
            return await result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending(x => x.Date)
                .GroupBy(x=>x.Seller.Department)
                .ToListAsync();
        }

        public async Task<List<SalesRecord>> FindAllAsync()
        {
            return await _context.SalesRecord.ToListAsync();
        }
    }
}
