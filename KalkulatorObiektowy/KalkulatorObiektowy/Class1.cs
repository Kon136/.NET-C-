using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorObiektowy
{
    internal class Kalkulator
    {
        
        private string typDzialania;
        
        

        private float PobierzDane()
        {
            Console.WriteLine("Podaj liczbe");
            float a = float.Parse(Console.ReadLine());
            return a;
            
        }
        private void PobierzTypDzialania()
        {
            Console.WriteLine("Podaj typ dzialania zapisany literami bez uzycia polskich znakow:");
            typDzialania = Console.ReadLine();
            typDzialania = typDzialania.ToLower();
        }
        public void dzialanie()
        {
            Boolean powtorzyc = false;
            Boolean prawidlowo = false;
            do
            {
                PobierzTypDzialania();
                float wynik = 0;
                int liczbaPowtorzen;
                Console.WriteLine("Na ilu liczbach chcesz wykonac dzialanie?? Podaj liczbe zapisana cyframi.");
                liczbaPowtorzen = int.Parse(Console.ReadLine());
                float[] liczby = new float[liczbaPowtorzen];
                switch (typDzialania)
                {
                    case "dodawanie":


                        for (int i = 0; i < liczbaPowtorzen; i++)
                        {
                            liczby[i] = PobierzDane();
                        }
                        for (int i = 0; i < liczbaPowtorzen; i++)
                        {
                            wynik = wynik + liczby[i];
                        }
                        Console.WriteLine("Wynik: " + wynik);
                        break;
                    case "odejmowanie":


                        for (int i = 0; i < liczbaPowtorzen; i++)
                        {
                            liczby[i] = PobierzDane();
                        }
                        wynik = liczby[0];
                        for (int i = 1; i < liczbaPowtorzen; i++)
                        {
                            wynik = wynik - liczby[i];
                        }
                        Console.WriteLine("Wynik: " + wynik);
                        break;
                    case "mnozenie":


                        for (int i = 0; i < liczbaPowtorzen; i++)
                        {
                            liczby[i] = PobierzDane();
                        }
                        wynik = liczby[0];
                        for (int i = 1; i < liczbaPowtorzen; i++)
                        {
                            wynik = wynik * liczby[i];
                        }
                        Console.WriteLine("Wynik: " + wynik);
                        break;
                    case "dzielenie":


                        for (int i = 0; i < liczbaPowtorzen; i++)
                        {
                            liczby[i] = PobierzDane();
                        }
                        wynik = liczby[0];
                        for (int i = 1; i < liczbaPowtorzen; i++)
                        {
                            wynik = wynik / liczby[i];
                        }
                        Console.WriteLine("Wynik: " + wynik);
                        break;
                    case "potegowanie":
                        Console.WriteLine("do ktorej potegi chcesz podniesc liczbe? podaj liczbe zapisana cyframi");
                        int potega = int.Parse(Console.ReadLine());
                        float liczba = PobierzDane();
                        wynik = liczba;
                        for (int i = 1; i < potega; i++)
                        {
                            wynik = wynik * liczba;
                        }
                        Console.WriteLine("Wynik: " + wynik);
                        break;
                    default:
                        Console.WriteLine("Podano zle dane");
                        break;
                }
                do
                    {
                        Console.WriteLine("czy chcesz powtorzyc?");
                        string takNie = Console.ReadLine();
                        takNie.ToLower();
                        if (takNie == "tak"){
                            powtorzyc = true;
                            prawidlowo = true;
                            Console.Clear();
                        }
                        else if (takNie == "nie"){
                            powtorzyc = false;
                            prawidlowo = true;
                        }
                        else Console.WriteLine("Podano zle dane");
                    } while (prawidlowo == false);

            } while (powtorzyc == true);   
        }
    }
}
