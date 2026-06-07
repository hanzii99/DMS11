using DMS.Data;
using DMS.Models;
using Microsoft.EntityFrameworkCore;

namespace DMS.Services
{
    public class AppSevices
    {
        private readonly ApplicationDbContext _context;

        public AppSevices(ApplicationDbContext context)
        {
            _context = context;
        }

        // READ ALL
        public async Task<List<App>> GetAppsAsync()
        {
            // CreatedDate remove kar diya, ab bas ID descending kar do
            return await _context.Apps
                .OrderByDescending(x => x.ID)
                .ToListAsync();
        }

        // READ BY ID
        public async Task<App?> GetAppByIdAsync(int id)
        {
            return await _context.Apps.FindAsync(id);
        }

        // CREATE
        public async Task AddAppAsync(App app)
        {
            // CreatedDate remove, ab direct add karo
            _context.Apps.Add(app);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAppAsync(App app)
        {
            _context.Apps.Update(app);
            await _context.SaveChangesAsync();
        }

        // DELETE
        public async Task DeleteAppAsync(int id)
        {
            var app = await _context.Apps.FindAsync(id);
            if (app != null)
            {
                _context.Apps.Remove(app);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<List<User>> GetUsersAsync()
        {
            return await _context.Set<User>()
                .OrderByDescending(x => x.UserId)
                .ToListAsync();
        }

        // CREATE USER
        public async Task AddUserAsync(User user)
        {
            _context.Set<User>().Add(user);
            await _context.SaveChangesAsync();
        }

        // READ USER BY ID
        public async Task<User?> GetUserByIdAsync(int id)
        {
            return await _context.Set<User>().FindAsync(id);
        }

        // UPDATE USER
        public async Task UpdateUserAsync(User user)
        {
            _context.Set<User>().Update(user);
            await _context.SaveChangesAsync();
        }

        // DELETE USER
        public async Task DeleteUserAsync(int id)
        {
            var user = await _context.Set<User>().FindAsync(id);

            if (user != null)
            {
                _context.Set<User>().Remove(user);
                await _context.SaveChangesAsync();
            }
        }
    }
}