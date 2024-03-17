using NotFlex.ApplicationCore.DTO;
using NotFlex.ApplicationCore.Entities.Structure;
using System.Linq;
using System.Threading.Tasks;

namespace NotFlex.ApplicationCore.Interfaces
{
    public interface ICategoryService
    {
        Task<Category> Add(CategoryDTO categoryDto);
        IQueryable<Category> Get();
        Task<Category> GetById(byte id);
    }
}
