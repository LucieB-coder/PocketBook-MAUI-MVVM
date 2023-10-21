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
            new Book { Id = 1, Title = "La horde du contrevent", Description = "wsrhdxtjgfckhygvljbhkmnjl", Author = "Alain Damasio", CoverImage = "la_horde_du_contrevent", Grade = 2, ReadingStatus = "Terminé", AddedOnLibraryDate = new DateTime(2022, 8, 10), ISBN = "9786542463", NumberOfPages = 654, ParutionYear = 2012, PublishingHouse="Gallimard"},
            new Book { Id = 2, Title = "L'équateur d'Einstein", Description = "wsrhdxtjgfckhygvljbhkmnjfsdwdxgfhjhxngbgdsf<l", Author = "Cixin Liu", CoverImage = "l_equateur_d_einstein", Grade = 1, ReadingStatus = "Non lu", AddedOnLibraryDate = new DateTime(2019, 10, 30), ISBN = "123456789", NumberOfPages = 1000, ParutionYear = 2015, PublishingHouse="POCKET" },
            new Book { Id = 3, Title = "La forêt sombre", Description = "wsrhdxtjgfckhygvljbhkmgfdvsrfsdgvbf gfcjl", Author = "Cixin Liu", CoverImage = "la_foret_sombre", Grade = 4, ReadingStatus = "Terminé", AddedOnLibraryDate = new DateTime(2018, 07, 21), ISBN = "987654321", NumberOfPages = 865, ParutionYear = 2013, PublishingHouse="Gallimard" },
            new Book { Id = 4, Title = "Le problème à trois corps", Description = "wsrhdxtjgfckhwdxrutrfijkucjnghbfxdwsygvljbhkmnjl", Author ="Cixin Liu", CoverImage = "le_probleme_a_trois_corps", Grade = 3, ReadingStatus = "Terminé", AddedOnLibraryDate = new DateTime(2020, 11, 11), ISBN = "9786542463", NumberOfPages = 142, ParutionYear = 2015, PublishingHouse="POCKET" },
            new Book { Id = 5, Title = "Labyrinthes", Description = "wsrhdxtjgfckhygvl<z<etswrgrtdvsefdjbhkmnjl", Author = "Franck Thilliez", CoverImage = "labyrinthes", Grade = 3, ReadingStatus = "Terminé", AddedOnLibraryDate = new DateTime(2015, 03, 01), ISBN = "123789456", NumberOfPages = 367, ParutionYear = 2015, PublishingHouse="Gallimard" },
            new Book { Id = 6, Title = "1991", Description = "wsrhdxtjgfckhygvljbhserytruhbvwrskmnjl", Author = "Franck Thilliez", CoverImage = "franck_thilliez_1991", Grade = 5, ReadingStatus = "En cours", AddedOnLibraryDate = new DateTime(2017,06, 15), ISBN = "789123456", NumberOfPages = 569, ParutionYear = 2016, PublishingHouse="POCKET" },
            new Book { Id = 7, Title = "Au delà de l'horizon", Description = "wsrsexrydfutjyxnggs<edxtjgfckhygvljbhkmnjl", Author = "Franck Thilliez", CoverImage = "au_dela_de_l_horizon", Grade = 0, ReadingStatus = "Terminé", AddedOnLibraryDate = new DateTime(2023, 01, 12), ISBN = "456789123", NumberOfPages = 753, ParutionYear = 2020, PublishingHouse="Gallimard" },
            new Book { Id = 8, Title = "Les Misérables", Description = "wsrhdxtluykut,yjrnhebgsvfjgfckhygvljbhkmnjl", Author = "Victor Hugo", CoverImage = "les_miserables", Grade = 4, ReadingStatus = "Terminé", AddedOnLibraryDate = new DateTime(2021, 07, 08), ISBN = "456123789", NumberOfPages = 357, ParutionYear = 2013, PublishingHouse="POCKET" },
            new Book { Id = 9, Title = "Captive", Description = "wsrhdxtjgfckhygvlqrewstrdxytfucyigou hvpijbhkmnjl", Author = "Sarah Rivens", CoverImage = "captive", Grade = 3, ReadingStatus = "En cours", AddedOnLibraryDate = new DateTime(2023, 10, 21), ISBN = "147258369", NumberOfPages = 159, ParutionYear = 2023, PublishingHouse="Gallimard" }
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