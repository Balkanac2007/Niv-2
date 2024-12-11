using System;

class Program
{
    static void Main()
    {
        int tal;

        do
        {
            Console.Write("Skriv in ett heltal (fortsätt skriva tills du skrivit 0): ");
            tal = int.Parse(Console.ReadLine());
        } while (tal != 0);

        Console.WriteLine("Du skrev in 0. Programmet avslutas.");
    }
}

