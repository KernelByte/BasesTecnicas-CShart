/****************  Uso de LINQ *****************************/

using AppLinq;

LinqQueries linq = new LinqQueries();

// Traer todos los datos
//ShowValues(linq.GetBooks());

// Traer datos filtrados 
ShowValues(linq.GetBooksPython());

//Console.WriteLine($"El resultado es: {linq.GetBooksAllAndAny()}");


// Meotodo para imprimir los valores
void ShowValues(IEnumerable<Book> listBooks)
{
    Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Titulo", "# Paginas", "Fecha publicacion");
    foreach (var item in listBooks)
    {
        Console.WriteLine("{0,-60} {1, 15} {2, 15}", item.title, item.pageCount, item.publishedDate.ToShortDateString());
    }
}