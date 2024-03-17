using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NotFlex.ApplicationCore.DTO;
using NotFlex.ApplicationCore.Entities.Structure;
using NotFlex.ApplicationCore.Interfaces;
using NotFlex.ApplicationCore.Models;

namespace NotFlex.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DashboardController : ControllerBase
    {
        #region Variables

        private readonly ICategoryService _categoryService;
        private readonly IMovieService _movieService;

        #endregion Variables

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardController"/> class.
        /// <param name="categoryService">The category service.</param>
        /// <param name="movieService">The movie service.</param>
        /// </summary>
        public DashboardController(ICategoryService categoryService
            , IMovieService movieService)
        {
            _categoryService = categoryService;
            _movieService = movieService;
        }

        #endregion Constructor

        #region Get

        /// <summary>
        /// List the movies.
        /// </summary>
        /// <returns></returns>
        [HttpGet("movies")]
        [ProducesResponseType(typeof(IReadOnlyCollection<MovieModel>), StatusCodes.Status200OK)]
        public IEnumerable<MovieModel> GetMovies()
        {
            return _movieService.Get();
        }

        /// <summary>
        /// List the category.
        /// </summary>
        /// <returns></returns>
        [HttpGet("category")]
        [ProducesResponseType(typeof(IReadOnlyCollection<Category>), StatusCodes.Status200OK)]
        public IEnumerable<Category> GetCategory()
        {
            return _categoryService.Get();
        }

        /// <summary>
        /// Get the category by identifier.
        /// </summary>
        /// <param name="id">The category identifier.</param>
        /// <returns></returns>
        [HttpGet("category/{id:int}")]
        [ProducesResponseType(typeof(Category), StatusCodes.Status200OK)]
        public async Task<Category> GetById([FromQuery] byte id)
        {
            return await _categoryService.GetById(id);
        }

        #endregion Get

        #region Post

        /// <summary>
        /// Posts the create category.
        /// </summary>
        /// <param name="categoryDto">The category data object.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">command</exception>
        [HttpPost]
        public async Task<ActionResult> PostCreateCategory([FromBody] CategoryDTO categoryDto)
        {
            if (categoryDto == null)
                throw new ArgumentNullException(nameof(categoryDto));

            return Ok(await _categoryService.Add(categoryDto));
        }

        #endregion Post

        #region Put

        /// <summary>
        /// Puts the update category.
        /// </summary>
        /// <param name="id">The category identifier.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">command</exception>
        [HttpPut("{id:int}")]
        public async Task<ActionResult> PutUpdateCategory(byte id, [FromBody] CategoryDTO categoryDto)
        {
            if (categoryDto == null)
                throw new ArgumentNullException(nameof(categoryDto));

            var category = await _categoryService.GetById(id);

            category.Name = categoryDto.Name;
            category.UpdatedBy = categoryDto.UpdatedBy;
            category.DateUpdated = DateTime.Now;

            return Ok(await _categoryService.Update(category));
        }

        #endregion Put

        #region Delete

        /// <summary>
        /// Delete the category by identifier.
        /// </summary>
        /// <param name="id">The category identifier.</param>
        /// <returns></returns>
        [HttpDelete("{id:int}")]
        public IActionResult Delete(byte id)
        {
            return Ok(_categoryService.Delete(id));
        }

        #endregion Delete
    }
}
