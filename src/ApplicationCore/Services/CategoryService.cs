using NotFlex.ApplicationCore.DTO;
using NotFlex.ApplicationCore.Entities.Structure;
using NotFlex.ApplicationCore.Interfaces;
using System;
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

        public async Task<Category> Add(CategoryDTO categoryDto)
        {
            var category = new Category()
            {
                Name = categoryDto.Name,
                CreatedBy = categoryDto.CreatedBy,
                DateCreated = DateTime.Now
            };

            return await _repository.Add(category);
        }

        public async Task<Category> Update(Category category)
        {
            return await _repository.Update(category);
        }

        public async Task Delete(byte id)
        {
            var category = await _repository.GetById(id);

            await _repository.Delete(category);
        }

        public IQueryable<Category> Get()
        {
            return _repository.Get();
        }

        public async Task<Category> GetById(byte id)
        {
            return await _repository.GetById(id);
        }
    }
}
