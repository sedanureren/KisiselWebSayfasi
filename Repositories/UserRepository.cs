using KisiselWebSayfasi.Areas.Identity.Data;
using KisiselWebSayfasi.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace KisiselWebSayfasi.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public User GetUser(string id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }

        public ICollection<User> GetUsers()
        {
            return _context.Users.ToList();
        }

        public User UpdateUser(User user)
        {
             _context.Update(user);
            _context.SaveChanges();
            return user;

        }
    }
}
