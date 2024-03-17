using NotFlex.ApplicationCore.Entities.Structure;
using System.Linq;
using System.Threading.Tasks;

namespace NotFlex.ApplicationCore.Interfaces
{
    public interface ICategoryRepository
    {
        Task<Category> Add(Category category);
        IQueryable<Category> Get();
        Task<Category> GetById(byte id);
    }
}
