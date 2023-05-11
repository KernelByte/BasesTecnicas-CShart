using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLinq
{
    internal class LinqQueries
    {
        private List<Book> booksCollection = new List<Book>();

        public LinqQueries() 
        {   
            // Herramienta para leer un archivo
            using (StreamReader reader = new StreamReader("books.json"))
            {   
                // Lee todo el archivo completo y lo guarda en la variable json
                string json = reader.ReadToEnd();

                // Conversion a la coleccion
                this.booksCollection = System.Text.Json.JsonSerializer.Deserialize<List<Book>>(json, new System.Text.Json.JsonSerializerOptions() {PropertyNameCaseInsensitive = true});
            }
        }

        // Funcion para retornar toda la coleccion
        public IEnumerable<Book> GetBooks()
        {
            return booksCollection;
        }
    }
}
