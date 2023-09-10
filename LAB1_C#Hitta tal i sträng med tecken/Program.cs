namespace LAB1_C_Hitta_tal_i_sträng_med_tecken
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string input:");
            string input = Console.ReadLine();

            double total = 0;



            for (int i = 0; i < input.Length - 1; i++)//loopar igenom varje tecke av användarens input
            {
                char firstChar = input[i];// visar den första tecke in index i från input





                if (IsDigit(firstChar))// använder metoden för att kontrolera om char variabel är en siffra
                {

                    for (int j = i + 1; j < input.Length; j++)
                    {
                        char lastChar = input[j];//visar tecket in index j, indexj följer i,båda char variabel komtrolerar om det finnsupprepning

                        if (IsDigit(lastChar))
                        {


                            if (lastChar == firstChar)
                            {
                                string potentialSubstring = input.Substring(i, j - i + 1);



                                string beforeSubstring = input.Substring(0, i);
                                string afterSubstring = input.Substring(j + 1);

                                Console.Write(beforeSubstring); // text före den giltiga delsträngen
                                Console.ForegroundColor = ConsoleColor.Yellow;// texten ändra färg
                                Console.Write(potentialSubstring);
                                Console.ResetColor();
                                Console.WriteLine(afterSubstring);

                                double potential = double.Parse(potentialSubstring);



                                total = total + potential;


                                break;


                            }


                        }
                        else
                        {
                            break;

                        }


                    }
                }



            }
            Console.WriteLine(total);
        }


        static bool IsDigit(char CharacterDigit)
        {
            return CharacterDigit >= '0' && CharacterDigit <= '9';
        }


    }
}