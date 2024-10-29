
namespace kalkulator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę");
            float b = float.Parse(Console.ReadLine());
            float c = 0;

            Console.WriteLine("wybierz typ działania");
            Console.WriteLine("1-dodawanie");
            Console.WriteLine("2-odejmowanie");
            Console.WriteLine("3-mnożenie");
            Console.WriteLine("4-dzielenie");

            int typDzialania = int.Parse(Console.ReadLine());

            switch (typDzialania)
            {
                case 1:
                    
                    c = a + b;
                        Console.WriteLine("Wynik:" + c);
                        break;
                case 2:
                    c = a - b;
                    Console.WriteLine("Wynik:" + c);
                    break;
                case 3:
                     c = a * b;
                    Console.WriteLine("Wynik:" + c);
                    break;
                case 4:
                     c = a / b;
                    Console.WriteLine("Wynik:" + c);
                    break;
                default:
                    Console.WriteLine("Podano złe dane");
                    break;


            };
            Console.WriteLine("Wciśnij enter aby zakończyć");
            Console.ReadKey();



        }
    }
}