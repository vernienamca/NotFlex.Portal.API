using NotFlex.ApplicationCore.Entities.Structure;
using NotFlex.ApplicationCore.Models;
using System.Collections.Generic;
using System.Linq;

namespace NotFlex.ApplicationCore.Interfaces
{
    public interface IMovieService
    {
        IReadOnlyCollection<MovieModel> Get();
    }
}
