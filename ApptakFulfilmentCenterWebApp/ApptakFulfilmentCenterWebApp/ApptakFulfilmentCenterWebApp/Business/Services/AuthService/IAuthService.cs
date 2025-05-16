using ApptakFulfilmentCenterWebApp.Models;
using ApptakFulfilmentCenterWebApp.Models.Dto;

namespace ApptakFulfilmentCenterWebApp.Business.Services.AuthService
{
    public interface IAuthService
    {
        Task<TaUsersAdmin?> AuthenticateUserAsync(string email, string plainPassword);
        Task<(bool Success, string Message)> SignUpAsync(SignUpDto signUpDto);
    }
}
