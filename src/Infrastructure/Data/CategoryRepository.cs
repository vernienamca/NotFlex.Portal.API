using NotFlex.ApplicationCore.Entities.Structure;
using NotFlex.ApplicationCore.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace NotFlex.Infrastructure.Data
{
    public class CategoryRepository : EFRepository<Category, byte>, ICategoryRepository
    {
        public CategoryRepository(NotFlexContext context) : base(context)
        {
        }

        public async Task<Category> Add(Category category)
        {
            return await AddAsync(category);
        }

        public async Task<Category> Update(Category category)
        {
            return await UpdateAsync(category);
        }

        public async Task Delete(Category category)
        {
            await DeleteAsync(category);
        }

        public IQueryable<Category> Get()
        {
            return _dbContext.Category;
        }

        public async Task<Category> GetById(byte id)
        {
            return await GetByIdAsync(id);
        }
    }
}
