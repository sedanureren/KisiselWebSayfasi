using KisiselWebSayfasi.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;

namespace KisiselWebSayfasi.Core.Repositories
{
    public interface IRoleRepository
    {
        ICollection<IdentityRole> GetRoles();
    }
}
