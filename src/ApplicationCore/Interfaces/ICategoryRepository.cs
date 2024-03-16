using NotFlex.ApplicationCore.Entities.Structure;
using System.Linq;
using System.Threading.Tasks;

namespace NotFlex.ApplicationCore.Interfaces
{
    public interface ICategoryRepository
    {
        IQueryable<Category> Get();
        Task<Category> GetById(int id);
    }
}
