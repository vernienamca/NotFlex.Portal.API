using NotFlex.ApplicationCore.Entities.Structure;
using NotFlex.ApplicationCore.Interfaces;
using NotFlex.ApplicationCore.Models;
using System.Collections.Generic;
using System.Linq;

namespace NotFlex.ApplicationCore.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _repository;

        public MovieService(IMovieRepository repository)
        {
            _repository = repository;
        }

        public IReadOnlyCollection<MovieModel> Get()
        {
            return _repository.Get();
        }
    }
}
