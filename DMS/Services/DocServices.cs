using DMS.Data;
using DMS.Models;
using Microsoft.EntityFrameworkCore;

namespace DMS.Services
{
    public class DocServices
    {
        private readonly ApplicationDbContext _context;

        public DocServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAppAsync(App app)
        {
            _context.Apps.Add(app);
            await _context.SaveChangesAsync();
        }

        // used by ALL pages
        public async Task<List<App>> GetAllAsync()
        {
            return await _context.Apps
                .OrderByDescending(x => x.CreatedDate)
                .ToListAsync();
        }
    }
}
