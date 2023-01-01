using KisiselWebSayfasi.Areas.Identity.Data;

namespace KisiselWebSayfasi.Core.Repositories
{
    public interface IUserRepository
    {
        ICollection<User> GetUsers();
        User GetUser(string id);
        User UpdateUser(User user);

    }
}
