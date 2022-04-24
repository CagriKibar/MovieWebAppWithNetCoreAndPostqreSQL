using System.Collections.Generic;

namespace MovieProject.Models
{
    public class CategoryMenu
    {
        public Movie Movie { get; set; }
        public IEnumerable<Movie> Movies { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
