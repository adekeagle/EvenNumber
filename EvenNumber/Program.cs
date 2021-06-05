using System;

namespace EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę do sprawdzenia czy jest parzysta :");
            try
            {
                int evenNumber = GetNumber();

                if (IsEvenNumber(evenNumber))
                    Console.WriteLine($"Podana liczba {evenNumber} nie jest parzysta");
                else
                    Console.WriteLine($"Podana liczba {evenNumber} jest parzysta");
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }

        private static bool IsEvenNumber(int number)
        {
            if (number % 2 == 0)
            {
                return false;
            }

            return true;
        }

        private static int GetNumber()
        {
            if (!int.TryParse(Console.ReadLine(), out int evenNumber))
            {
                throw new Exception("Podana wartość jest nieprawidłowa");
            }

            return evenNumber;
        }
    }
}
