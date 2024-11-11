using System.Collections.Generic;

namespace libreriaXAGFRRR.Data.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        //Propiedades de navegación
        public List<Book_Author> book_Authors { get; set; }
    }
}
