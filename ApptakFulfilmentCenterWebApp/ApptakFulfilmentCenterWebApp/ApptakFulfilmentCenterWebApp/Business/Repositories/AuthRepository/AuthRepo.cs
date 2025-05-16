using ApptakFulfilmentCenterWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ApptakFulfilmentCenterWebApp.Business.Repositories.AuthRepository
{
    public class AuthRepo : IAuthRepo
    {
        private readonly ApplicationDbContext _context;

        public AuthRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<TaUsersAdmin?> ValidateUserAsync(string email, string hashedPassword)
        {
            try
            {
                var user = await _context.TaUsersAdmins
                                .FirstOrDefaultAsync(u => u.Email == email && u.Password == hashedPassword);
                return user ?? new TaUsersAdmin(); // Ensure non-null
            }
            catch (Exception ex)
            {
                return new TaUsersAdmin();
            }
        }

        public async Task<bool> RegisterUserAsync(TaUsersAdmin adminUser)
        {
            try
            {
                await _context.TaUsersAdmins.AddAsync(adminUser);
                int affectedRows = await _context.SaveChangesAsync();
                return affectedRows > 0;
            }
            catch (Exception)
            {
                // Optionally log exception
                return false;
            }
        }

        public async Task<bool> IsEmailExistsAsync(string email)
        {
            return await _context.TaUsersAdmins.AnyAsync(u => u.Email == email);
        }
    }
}
