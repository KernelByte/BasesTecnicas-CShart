// Declaracion de variables

var LadoA = 0; // Asignacion de un valor inicial
var LadoB = 0;
var Resultado = 0;
const double PI = 3.14159;

/*

Resultado = LadoA + LadoB;

Console.WriteLine("El area de su triangulo es: "+ Resultado); */

/*
 Metodo dinamico de recibir parametros
 */

Console.WriteLine("Ingrese el lado A de su triangulo"); // Se presenta un mensaje en la consola al usuario
LadoA = Convert.ToInt32(Console.ReadLine());            // Se lee texto desde la consola
Console.WriteLine("Ingrese el lado B de su triangulo");
LadoB = Convert.ToInt32(Console.ReadLine());

Resultado = LadoA * LadoB;

Console.WriteLine("El area de su triangulo es: " + Resultado);