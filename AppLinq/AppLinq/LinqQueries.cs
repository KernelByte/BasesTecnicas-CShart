﻿using System;
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

        public IEnumerable<Book> GetBooksOld()
        {
            // Extension method
            //return booksCollection.Where(p => p.publishedDate.Year > 2000);

            return from l in booksCollection where l.publishedDate.Year > 2000 select l;
        }

        public IEnumerable<Book> GetBooksFilter()
        {
            // Extension method
            //return booksCollection.Where(p => p.publishedDate.Year > 2000);

            return from l in booksCollection where l.pageCount > 250 && l.title.Contains("in Action") select l;
        }

        // uso del operador ALL
        public bool GetBooksAllAndAny()
        {
            // ALL
            //return booksCollection.All(p => p.status != string.Empty);

            // ANY
            return booksCollection.Any(p => p.publishedDate.Year == 1950);
        }

        // uso del operador Contains
        public IEnumerable<Book> GetBooksPython()
        {

            // Contains
            return booksCollection.Where(p => p.categories.Contains("Python"));
        }


        // uso del order by
        public IEnumerable<Book> GetBooksJava()
        {

            // Contains
            return booksCollection.Where(p => p.categories.Contains("Java")).OrderBy(p => p.title);
        }

    }
}
