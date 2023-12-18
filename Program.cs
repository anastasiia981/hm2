// Задача 2: Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные



using System;

class Program

{
    static void Main()
    {

        string str = "AbCdEfG";

        string result = "";

        foreach (char c in str)

        {

            if (char.IsUpper(c))
            {

                result += char.ToLower(c);

            }
            else
            {
        
                result += c;

            }

        }

        Console.WriteLine(result);

    }

}









        
