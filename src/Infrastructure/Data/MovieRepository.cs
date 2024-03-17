using Microsoft.EntityFrameworkCore;
using NotFlex.ApplicationCore.Entities.Structure;
using NotFlex.ApplicationCore.Interfaces;
using NotFlex.ApplicationCore.Models;
using System.Collections.Generic;
using System.Linq;

namespace NotFlex.Infrastructure.Data
{
    public class MovieRepository : EFRepository<Movie, byte>, IMovieRepository
    {
        public MovieRepository(NotFlexContext context) : base(context)
        {
        }

        public IReadOnlyCollection<MovieModel> Get()
        {
            var movies = (from mov in _dbContext.Movies.AsNoTracking()
                          select new MovieModel()
                          {
                              Id = mov.Id,
                              Title = mov.Title,
                              Description = mov.Description,
                              GroupName = mov.GroupName,
                              ReleasedDate = mov.ReleasedDate,
                              Director = mov.Director,
                              DistributedBy = mov.DistributedBy,
                              Length = mov.Length,
                              PosterImage = mov.PosterImage,
                              Category = _dbContext.MovieCategory.Where(t => t.MovieId == mov.Id).AsNoTracking()
                                         .Join(_dbContext.Category.AsNoTracking(), mct => mct.CategoryId, cat => cat.Id,
                                         (mct, cat) => new { mct, cat }).Select(s => s.cat.Name).ToList(),
                              IsFeature = mov.IsFeature
                          }).ToList();

            return movies;
        }
    }
}
