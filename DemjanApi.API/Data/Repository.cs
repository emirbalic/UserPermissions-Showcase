using System.Threading.Tasks;
using DemjanApi.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DemjanApi.API.Data
{
    public class Repository : IRepository
    {
        private readonly DataContext _context;
        public Repository(DataContext context)
        {
            _context = context;

        }
        public async Task<User> AddPermission(int userId, int permissionId)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == userId);
            if (user == null)
            {
                return null;
            } else {

                return null;
            }

        }

        public async Task<User> AddUser(User user)
        {

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public Task<User> RemovePermission(int userId, int permissionId)
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> UserExists(string username)
        {
            if(await _context.Users.AnyAsync(x => x.Username == username)) {
                return true;
            } 
            return false;
        }
    }
}