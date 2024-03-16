using NotFlex.ApplicationCore.Entities.Structure;
using System.Linq;
using System.Threading.Tasks;

namespace NotFlex.ApplicationCore.Interfaces
{
    public interface ICategoryService
    {
        IQueryable<Category> Get();
        Task<Category> GetById(int id);
    }
}
