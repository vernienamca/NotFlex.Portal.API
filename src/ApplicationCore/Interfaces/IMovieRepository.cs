using NotFlex.ApplicationCore.Entities.Structure;
using NotFlex.ApplicationCore.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotFlex.ApplicationCore.Interfaces
{
    public interface IMovieRepository
    {
        IReadOnlyCollection<MovieModel> Get();
    }
}
