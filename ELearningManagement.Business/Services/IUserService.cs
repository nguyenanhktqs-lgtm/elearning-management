using ELearningManagement.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ELearningManagement.Business.Services
{
    public interface IUserService
    {
        Task<User> GetUserByIdAsync(int id);
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> AuthenticateAsync(string username, string password);
        Task CreateUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task DeleteUserAsync(int userId);
    }
}