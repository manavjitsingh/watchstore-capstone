using TheHybridWatchStore.Server.Data.Models;
using TheHybridWatchStore.Server.Models;

namespace TheHybridWatchStore.Server.Services
{
    public class AuthService
    {
        private readonly ApplicationDbContext _context;

        public AuthService(ApplicationDbContext context)
        {
            _context = context;
        }

        public User Authenticate(string email, string password)
        {
            var user = _context.Users.SingleOrDefault(u => u.Email == email);
            if (user == null || !VerifyPassword(password, user.PasswordHash))
            {
                return null;
            }

            return user;
        }

        public User Register(string email, string password)
        {
            if (_context.Users.Any(u => u.Email == email))
            {
                return null;
            }

            var user = new User
            {
                Email = email,
                PasswordHash = HashPassword(password)
            };

            _context.Users.Add(user);
            _context.SaveChanges();

            return user;
        }

        private string HashPassword(string password)
        {
            // Use a strong hashing algorithm like BCrypt, PBKDF2, or Argon2
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        private bool VerifyPassword(string password, string passwordHash)
        {
            return BCrypt.Net.BCrypt.Verify(password, passwordHash);
        }
    }
}
