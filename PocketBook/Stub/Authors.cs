using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Stub
{
    public class Authors
    {
        public List<Author> AuthorList { get; set; } = new List<Author> {
            new Author { Id = 1, Name = "Alain Damasio" },
            new Author { Id = 2, Name = "Cixin Liu" },
            new Author { Id = 3, Name = "Franck Thilliez" },
            new Author { Id = 4, Name = "Victor Hugo" },
            new Author { Id = 5, Name = "Sarah Rivens" }
        };
    }
}
