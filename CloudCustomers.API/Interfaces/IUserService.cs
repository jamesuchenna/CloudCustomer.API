using CloudCustomers.API.Models;

namespace CloudCustomers.API.Interfaces
{
    public interface IUserService
    {
        public Task<List<User>> GetAllUsers();
    }
}
