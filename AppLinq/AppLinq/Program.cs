/****************  Uso de LINQ *****************************/

// Creacion de la coleccion
var frutas = new string[] { "manzana", "Pera", "Mango", "Mango Tomy", "Mango azucar" };

// Uso de la libreria LINQ
var listaFrutas = frutas.Where(p => p.StartsWith("Mango")).ToList();

// Imprimir los valores de la lista
listaFrutas.ForEach(p => Console.WriteLine(p));

/********************************************************** */