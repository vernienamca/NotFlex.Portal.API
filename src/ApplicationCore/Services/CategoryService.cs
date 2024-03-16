using NotFlex.ApplicationCore.Entities.Structure;
using NotFlex.ApplicationCore.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace NotFlex.ApplicationCore.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;

        public CategoryService(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public IQueryable<Category> Get()
        {
            return _repository.Get();
        }

        public async Task<Category> GetById(int id)
        {
            return await _repository.GetById(id);
        }
    }
}
