using System;

class Program
{
    static void Main()
    {
        // Bankoplader som string-arrays
        string[,] plade1 = { { "2", "11", "42", "53", "70" }, { "31", "43", "58", "74", "82" }, { "28", "34", "45", "69", "90" } };
        string[,] plade2 = { { "2", "14", "30", "45", "86" }, { "5", "22", "47", "65", "73" }, { "7", "49", "59", "67", "77" } };
        string[,] plade3 = { { "23", "40", "55", "70", "80" }, { "5", "35", "65", "71", "87" }, { "7", "16", "27", "69", "90" } };
        string[,] plade4 = { { "1", "15", "63", "74", "86" }, { "3", "25", "42", "57", "76" }, { "26", "39", "58", "77", "89" } };

        //int[] tal = new int[90];
        //int antalTrukne = 0;
        //string spilStatus = "1række";


       // Console.WriteLine("trukne tal");
       // for (int i = 0; i < antalTrukne; i++)
       // {
       //     Console.WriteLine(tal[i]+" ");
        //}
        //Console.WriteLine();

        // Udskriv plader
        Console.WriteLine("Plade 1:");
        PrintPlade(plade1);

        Console.WriteLine("Plade 2:");
        PrintPlade(plade2);

        Console.WriteLine("Plade 3:");
        PrintPlade(plade3);

        Console.WriteLine("Plade 4:");
        PrintPlade(plade4);

        while (true) // Loop for at tillade gentagne inputs
        {
            Console.Write("Skriv et tal: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int tal))
            {
                bool found = false;

                // Tjek tallet på plade1 og erstat med "X" hvis fundet
                for (int i = 0; i < plade1.GetLength(0); i++) // Rækker
                {
                    for (int j = 0; j < plade1.GetLength(1); j++) // Kolonner
                    {
                        if (plade1[i, j] == tal.ToString()) // Sammenlign som string
                        {
                            plade1[i, j] = "X"; // Erstat med "X"
                            found = true;
                            break; // Stop når fundet
                        }
                    }
                    if (found) break; // Stop ydre loop hvis fundet
                }

                int fullRows = CountFullRows(plade1);
                if (fullRows >= 1)
                {
                    Console.WriteLine("Tillykke! Du har fået 1 række!");
                }

                if (fullRows >= 2)
                {
                    Console.WriteLine("Tillykke! Du har fået 2 rækker!");
                }

                if (IsFullPlade(plade1))
                {
                    Console.WriteLine("Tillykke! Du har fuld plade!");
                }

                if (found)
                {
                    Console.WriteLine($"{tal} er på pladen og er markeret som 'X'.");
                }
                else
                {
                    Console.WriteLine($"{tal} findes ikke på pladen.");
                }
                // Tjek tallet på plade2 og erstat med "X" hvis fundet
                for (int i = 0; i < plade2.GetLength(0); i++) // Rækker
                {
                    for (int j = 0; j < plade2.GetLength(1); j++) // Kolonner
                    {
                        if (plade2[i, j] == tal.ToString()) // Sammenlign som string
                        {
                            plade2[i, j] = "X"; // Erstat med "X"
                            found = true;
                            break; // Stop når fundet
                        }
                    }
                    if (found) break; // Stop ydre loop hvis fundet
                }
                // Tjek tallet på plade3 og erstat med "X" hvis fundet
                for (int i = 0; i < plade3.GetLength(0); i++) // Rækker
                {
                    for (int j = 0; j < plade3.GetLength(1); j++) // Kolonner
                    {
                        if (plade3[i, j] == tal.ToString()) // Sammenlign som string
                        {
                            plade3[i, j] = "X"; // Erstat med "X"
                            found = true;
                            break; // Stop når fundet
                        }
                    }
                    if (found) break; // Stop ydre loop hvis fundet
                }

                // Tjek tallet på plade4 og erstat med "X" hvis fundet
                for (int i = 0; i < plade4.GetLength(0); i++) // Rækker
                {
                    for (int j = 0; j < plade4.GetLength(1); j++) // Kolonner
                    {
                        if (plade4[i, j] == tal.ToString()) // Sammenlign som string
                        {
                            plade4[i, j] = "X"; // Erstat med "X"
                            found = true;
                            break; // Stop når fundet
                        }
                    }
                    if (found) break; // Stop ydre loop hvis fundet
                }

                if (found)
                {
                    Console.WriteLine($"{tal} er på pladen og er markeret som 'X'.");
                }
                else
                {
                    Console.WriteLine($"{tal} findes ikke på pladen.");
                }

                if (found)
                {
                    Console.WriteLine($"{tal} er på pladen og er markeret som 'X'.");
                }
                else
                {
                    Console.WriteLine($"{tal} findes ikke på pladen.");
                }

                if (found)
                {
                    Console.WriteLine($"{tal} er på pladen og er markeret som 'X'.");
                }
                else
                {
                    Console.WriteLine($"{tal} findes ikke på pladen.");
                }
                // Udskriv pladen igen med ændringer
                Console.WriteLine("Opdateret Pladen/Pladerne:");
                PrintPlade(plade1);

                //if (CheckFullRow(plade1))
                //{
                   // Console.WriteLine("du fik en række på plade 1");
                //}

            }
            else
            {
                Console.WriteLine("Ugyldigt input, skriv et gyldigt tal.");
            }
        }
    }

    // Funktion til at udskrive pladen
    static void PrintPlade(string[,] plade)
    {
        for (int i = 0; i < plade.GetLength(0); i++)
        {
            for (int j = 0; j < plade.GetLength(1); j++)
            {
                Console.Write(plade[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine(); // Ekstra linje for at adskille plader
    }
}
