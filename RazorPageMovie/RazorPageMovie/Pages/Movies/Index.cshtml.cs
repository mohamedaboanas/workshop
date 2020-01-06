using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Extensions.Internal;
using RazorPageMovie.Models;
using static System.String;

namespace RazorPageMovie.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MovieContext _context;

        public IndexModel(MovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public SelectList Genres;
        public string MovieGenre { get; set; }

        public async Task OnGetAsync(string movieGenre , string searchString)
        {
            IQueryable<string> genreQuery = from m in _context.Movies
                orderby m.Genre
                select m.Genre;

            var movies = from m in _context.Movies
                select m;

            if (!IsNullOrEmpty(searchString))
            {
                movies = movies.Where(m => m.Title.Contains(searchString));
            }

            if (!IsNullOrEmpty(movieGenre))
            {
                movies = movies.Where(m => m.Genre == movieGenre);
            }

            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());
            Movie = await movies.ToListAsync();
        }
    }
}
