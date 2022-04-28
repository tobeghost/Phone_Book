using System.Collections.Generic;
using System.Threading.Tasks;
using PhoneBook.Libraries.Core;
using PhoneBook.Web.Models.User;

namespace PhoneBook.Web.Services
{
    public interface IUserService
    {
        Task<List<UserViewModel>> GetAllAsync();
        Task<UserViewModel> CreateAsync(UserCreateInput userCreateInput);
        Task<UserViewModel> GetByIdAsync(string id);
        Task<bool> DeleteAsync(string id);

    }
}
