using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Stub
{
    public class Books
    {
        public IEnumerable<Book> BookList { get; set; } = new List<Book> 
        { 
            new Book { Id = 1, Title = "La horde du contrevent", Description = "wsrhdxtjgfckhygvljbhkmnjl", Authors = new List<int> { 1 }, CoverImage = "la_horde_du_contrevent", Grade = 2, ReadingStatus = "Terminé" },
            new Book { Id = 2, Title = "L'équateur d'Einstein", Description = "wsrhdxtjgfckhygvljbhkmnjl", Authors = new List<int> { 2 }, CoverImage = "l_equateur_d_einstein", Grade = 4, ReadingStatus = "Non lu" },
            new Book { Id = 3, Title = "La forêt sombre", Description = "wsrhdxtjgfckhygvljbhkmnjl", Authors = new List<int> { 2 }, CoverImage = "la_foret_sombre", Grade = 4, ReadingStatus = "Terminé" },
            new Book { Id = 4, Title = "Le problème à trois corps", Description = "wsrhdxtjgfckhygvljbhkmnjl", Authors = new List<int> { 2 }, CoverImage = "le_probleme_a_trois_corps", Grade = 3, ReadingStatus = "Terminé" },
            new Book { Id = 5, Title = "Labyrinthes", Description = "wsrhdxtjgfckhygvljbhkmnjl", Authors = new List<int> { 3 }, CoverImage = "labyrinthes", Grade = 3, ReadingStatus = "Terminé" },
            new Book { Id = 6, Title = "1991", Description = "wsrhdxtjgfckhygvljbhkmnjl", Authors = new List<int> { 3 }, CoverImage = "franck_thilliez_1991", Grade = 5, ReadingStatus = "En cours" },
            new Book { Id = 7, Title = "Au delà de l'horizon", Description = "wsrhdxtjgfckhygvljbhkmnjl", Authors = new List<int> { 3 }, CoverImage = "au_dela_de_l_horizon", Grade = 4, ReadingStatus = "Terminé" },
            new Book { Id = 8, Title = "Les Misérables", Description = "wsrhdxtjgfckhygvljbhkmnjl", Authors = new List<int> { 4 }, CoverImage = "les_miserables", Grade = 4, ReadingStatus = "Terminé" },
            new Book { Id = 9, Title = "Captive", Description = "wsrhdxtjgfckhygvljbhkmnjl", Authors = new List<int> { 5 }, CoverImage = "captive", Grade = 3, ReadingStatus = "En cours" }
        };
    }
}