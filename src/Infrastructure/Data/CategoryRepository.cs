using NotFlex.ApplicationCore.Entities.Structure;
using NotFlex.ApplicationCore.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace NotFlex.Infrastructure.Data
{
    public class CategoryRepository : EFRepository<Category, int>, ICategoryRepository
    {
        public CategoryRepository(NotFlexContext context) : base(context)
        {
        }

        public IQueryable<Category> Get()
        {
            return _dbContext.Category;
        }

        public async Task<Category> GetById(int id)
        {
            return await GetByIdAsync(id);
        }
    }
}
