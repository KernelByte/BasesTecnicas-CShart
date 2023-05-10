int creditos = 0;
int apuesta = 0;
int totalJugador = 0;
int totalDealer = 0;
int num = 0;
string message = "";
string controlOtraCarta = "";
string switchControl = "menu";
System.Random random = new System.Random();

//Blackjack, Juntar 21 pidiendo, en casa de pasarte de 21 pierdes.
//cartas o en caso de tener menos
//de 21 igual tener mayor puntuación que el dealer
while (true)
{
    Console.WriteLine("Hello, welcome to K-sino!");
    Console.WriteLine("¿Cuántos creditos deseas comprar?\n" +
        "*Ingresa un número entero*\n" +
        "*Cada partida de juego tiene un costo de 1 credito*");
    creditos = Convert.ToInt32(Console.ReadLine());



    for (int i = 0; i < creditos * 2; i++)
    {
        totalJugador = 0;
        totalDealer = 0;

        switch (switchControl)
        {
            case "menu":
                Console.WriteLine("\nEscriba ‘21’ para jugar al 21.\n" +
                                  "        ‘S’  para salir y guardar sus creditos.");
                switchControl = Console.ReadLine();

                if (switchControl == "21")
                {
                    Console.WriteLine($"Ingrese la cantidad de creditos que desee apostar\n" +
                        $"  Cantidad de creditos disponibles: {creditos}");
                    apuesta = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                else if (switchControl == "S" || switchControl == "s")
                {
                    Environment.Exit(1);
                }
                break;

            case "21":
                do
                {
                    num = random.Next(1, 12);
                    totalJugador = totalJugador + num;
                    Console.WriteLine("Toma tu carta, jugador,");
                    Console.WriteLine($"Te salió el número: {num} ");
                    Console.WriteLine("¿Deseas otra carta?");
                    controlOtraCarta = Console.ReadLine();

                } while (controlOtraCarta == "Si" ||
                         controlOtraCarta == "si" ||
                         controlOtraCarta == "yes");

                totalDealer = random.Next(14, 23);
                Console.WriteLine($"\nTu puntuaje fue: {totalJugador}");
                Console.WriteLine($"El dealer obtuvo: {totalDealer}\n");

                if (totalJugador > totalDealer && totalJugador < 22 || totalDealer > 21)
                {
                    creditos += apuesta;
                    message = "Felicidades, venciste al dealer\n" +
                        $"   Conseguiste: {apuesta} creditos!!!\n" +
                        $"Total de creditos: {creditos}";
                    switchControl = "menu";
                }
                else if (totalJugador >= 22)
                {
                    creditos -= apuesta;
                    message = "Te pasaste de 21 vs el dealer\n" +
                        $"   Perdiste: {apuesta} creditos!\n" +
                        $"Total de creditos: {creditos}";
                    switchControl = "menu";
                }
                else if (totalJugador < totalDealer)
                {
                    creditos -= apuesta;
                    message = "Lo siento, perdiste vs el dealer\n" +
                        $"   Perdiste: {apuesta} creditos!\n" +
                        $"Total de creditos: {creditos}";
                    switchControl = "menu";
                }
                else if (totalJugador == totalDealer)
                {
                    message = "Empataste vs el dealer\n" +
                        "   Conservas tus creditos!";
                    switchControl = "menu";
                }
                else
                {
                    message = "Condición no válida, intentalo de nuevo";
                    switchControl = "menu";
                }
                Console.WriteLine(message);
                break;

            default:
                Console.WriteLine("Valor ingresado no válido en el K-sino");
                switchControl = "menu";
                break;
        }
    }
    Console.WriteLine("\n     Tus creditos se han terminado!!!\n" +
        "Presione cualquier tecla para continuar...");
    Console.ReadLine();
    Console.Clear();

}