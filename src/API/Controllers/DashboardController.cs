using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NotFlex.ApplicationCore.Entities.Structure;
using NotFlex.ApplicationCore.Interfaces;

namespace NotFlex.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DashboardController : ControllerBase
    {
        #region Variables

        private readonly ICategoryService _service;

        #endregion Variables

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardController"/> class.
        /// <param name="service">The category service.</param>
        /// </summary>
        public DashboardController(ICategoryService service)
        {
            _service = service;
        }

        #endregion Constructor

        #region Get

        /// <summary>
        /// List the category.
        /// </summary>
        /// <returns></returns>
        [HttpGet()]
        [ProducesResponseType(typeof(IReadOnlyCollection<Category>), StatusCodes.Status200OK)]
        public IEnumerable<Category> Get()
        {
            return _service.Get();
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
            return await _service.GetById(id);
        }

        #endregion
    }
}
