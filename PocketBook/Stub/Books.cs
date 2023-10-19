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
        private IEnumerable<Book> books { get; set; } = new List<Book> 
        { 
            new Book { Id = 1, Title = "La horde du contrevent", Description = "wsrhdxtjgfckhygvljbhkmnjl", Author = "Alain Damasio", CoverImage = "la_horde_du_contrevent", Grade = 2, ReadingStatus = "Terminé" },
            new Book { Id = 2, Title = "L'équateur d'Einstein", Description = "wsrhdxtjgfckhygvljbhkmnjl", Author = "Cixin Liu", CoverImage = "l_equateur_d_einstein", Grade = 4, ReadingStatus = "Non lu" },
            new Book { Id = 3, Title = "La forêt sombre", Description = "wsrhdxtjgfckhygvljbhkmnjl", Author = "Cixin Liu", CoverImage = "la_foret_sombre", Grade = 4, ReadingStatus = "Terminé" },
            new Book { Id = 4, Title = "Le problème à trois corps", Description = "wsrhdxtjgfckhygvljbhkmnjl", Author ="Cixin Liu", CoverImage = "le_probleme_a_trois_corps", Grade = 3, ReadingStatus = "Terminé" },
            new Book { Id = 5, Title = "Labyrinthes", Description = "wsrhdxtjgfckhygvljbhkmnjl", Author = "Franck Thilliez", CoverImage = "labyrinthes", Grade = 3, ReadingStatus = "Terminé" },
            new Book { Id = 6, Title = "1991", Description = "wsrhdxtjgfckhygvljbhkmnjl", Author = "Franck Thilliez", CoverImage = "franck_thilliez_1991", Grade = 5, ReadingStatus = "En cours" },
            new Book { Id = 7, Title = "Au delà de l'horizon", Description = "wsrhdxtjgfckhygvljbhkmnjl", Author = "Franck Thilliez", CoverImage = "au_dela_de_l_horizon", Grade = 4, ReadingStatus = "Terminé" },
            new Book { Id = 8, Title = "Les Misérables", Description = "wsrhdxtjgfckhygvljbhkmnjl", Author = "Victor Hugo", CoverImage = "les_miserables", Grade = 4, ReadingStatus = "Terminé" },
            new Book { Id = 9, Title = "Captive", Description = "wsrhdxtjgfckhygvljbhkmnjl", Author = "Sarah Rivens", CoverImage = "captive", Grade = 3, ReadingStatus = "En cours" }
        };
        public IEnumerable<Book> BookList {
            get
            {
                return books;
            }
            set 
            {
                books = value;
            } 
        }
    }
}