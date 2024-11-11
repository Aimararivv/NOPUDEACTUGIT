using System;
using System.Collections.Generic;

namespace libreriaXAGFRRR.Data.Models
{
    public class Books
    {
        public int id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public bool ISRead { get; set; }
        public DateTime? DateRead { get; set; }
        public int? Rate { get; set; }
        public string Genero { get; set; }
        public string Autor { get; set; }
        public string CoverUrl { get; set; }
        public DateTime DateAdded { get; set; }

        //Propiedades de navegación (En esta parte es donde "mapeamos")
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
        public List<Book_Author> book_Authors { get; set; }

    }
}
