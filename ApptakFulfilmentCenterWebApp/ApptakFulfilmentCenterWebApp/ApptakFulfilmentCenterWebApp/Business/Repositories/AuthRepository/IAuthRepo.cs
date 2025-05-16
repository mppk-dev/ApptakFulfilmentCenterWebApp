using ApptakFulfilmentCenterWebApp.Models;

namespace ApptakFulfilmentCenterWebApp.Business.Repositories.AuthRepository
{
    public interface IAuthRepo
    {
        Task<TaUsersAdmin?> ValidateUserAsync(string email, string hashedPassword);
        Task<bool> RegisterUserAsync(TaUsersAdmin adminUser);
        Task<bool> IsEmailExistsAsync(string email);
    }
}
