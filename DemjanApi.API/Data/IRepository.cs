using System.Threading.Tasks;
using DemjanApi.API.Models;

namespace DemjanApi.API.Data
{
    public interface IRepository
    {
        Task<User> AddUser (User user);
         Task<User> AddPermission(int userId, int permissionId);
         Task<User> RemovePermission(int userId, int permissionId);
         Task<bool> UserExists(string username);
    }
}