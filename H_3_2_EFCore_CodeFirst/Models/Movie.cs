using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H_3_2_EFCore_CodeFirst.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public ICollection<Category> Categories { get; set; }
        public string Name { get; set; }
        public int IMDB { get; set; }
        public DateTime ProductionDate { get; set; }
        public string Director { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
