
using System;
using System.Linq;
class Program
{
    static void Main()
    {
        int numberStrings = int.Parse(Console.ReadLine());//1.това е бройката думи които ще е изпишат

        int[] numbers = new int[numberStrings];//9.тук създаваме масив от числата които се генерерират в цикъла от т.8.

        string vowels = "aAeEiIoOuU";//6. пишем гласните букви от азбуката
        char[] vowelsArr = vowels.ToCharArray();//превръщаме ги в масив

        for (int i = 0; i < numberStrings; i++)//2. правим цикъл който се върти толкова пъти колкото е бройката думи които трябва да се изпишат
        {
            string word = Console.ReadLine();//3. думата която се изписва всеки път
            char[] letters = word.ToArray();//4. превръщаме думат в масив от char-ове 

            int sum = 0;
            for (int j = 0; j < letters.Length; j++)//5. правим цикъл който се върти толкова пъти колкото е дължината на масива от char-ове 
            {
                char currentChar = letters[j];//текуща буква 
                if (vowelsArr.Contains(currentChar))//8. правим проверка дали текущата буква е представител на гласните 
                {
                    sum += letters[j] * letters.Length;//тук я сумираме според условието
                }
                else
                {
                    sum += letters[j] / letters.Length;//тук я сумираме според условието
                }
            }
            numbers[i] = sum;//запазваме числото което се генерира като елемент от масива в т.9.
        }

        Array.Sort(numbers);//10. с тази команда сортираме елементите в масива numbers

        foreach (int element in numbers)//11. чрез този цикъл принтираме всеки елемент от цикъла 
        {
            Console.WriteLine(element);
        }
    }
}
