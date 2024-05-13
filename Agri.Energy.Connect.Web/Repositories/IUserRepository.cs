using Microsoft.AspNetCore.Identity;

namespace Agri.Energy.Connect.Web.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<IdentityUser>> GetAll();
    }
}
