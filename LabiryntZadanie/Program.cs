using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;

class Program
{
    static char[,] labirynt1;
    static int iloscKolumn , iloscWierszy;
    static void Main()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Podaj swoją ilość wierszy:");
                iloscWierszy = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Podaj swoją ilość kolumn:");
                iloscKolumn = Convert.ToInt32(Console.ReadLine());


                ZrobLabirynt1();

                while (true)
                {

                    WyswietlLabirynt();

                    Console.WriteLine("wybierz numer od 1-2");
                    Console.WriteLine("1) Modyfikuj element");
                    Console.WriteLine("2) Wyjście");

                    int wybor = Convert.ToInt32(Console.ReadLine());

                    switch (wybor)
                    {
                        case 1:
                            ModyfikujElement();
                            break;
                        case 2:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("cos poszło nie tak");
                            break;
                    }
                }
            }
            catch (FormatException) { Console.WriteLine("cos  poszło nie tak"); }
        }
    }

    static void ZrobLabirynt1()
    {
        labirynt1 = new char[iloscKolumn, iloscWierszy];

        for (int i = 0; i <  iloscKolumn ; i++)
        {
            for (int j = 0; j < iloscWierszy; j++)
            {
                labirynt1[i, j] = '?';
            }
        }
    }

    static void WyswietlLabirynt()
    {
        System.Threading.Thread.Sleep(500);
        Console.Clear();

        for (int i = 0; i < iloscKolumn; i++)
        {
            for (int j = 0; j < iloscWierszy; j++)
            {
                Console.Write(labirynt1[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void ModyfikujElement()
    {
        Console.WriteLine("1) edytacja \n");
        Console.WriteLine("podaj liczbę wierszy:");
        int wiersz = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("podaj liczbę kolumn:");
        int kolumna = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("wybierz znak:");
        Console.WriteLine("1. brak (znak '?')");
        Console.WriteLine("2. sciezka (znak '!')");
        Console.WriteLine("3. sciana (znak ',')");
        int stan = Convert.ToInt32(Console.ReadLine());

        switch (stan)
        {
            case 1:
                labirynt1[wiersz, kolumna] = '?';
                break;
            case 2:
                labirynt1[wiersz, kolumna] = '!';
                break;
            case 3:
                labirynt1[wiersz, kolumna] = ',';
                break;
            default:
                Console.WriteLine("wpisujesz cos zle");
                break;
        }
    }


}
