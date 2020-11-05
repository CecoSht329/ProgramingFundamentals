using System;
using System.Linq;//ПИШЕМ ТОВА 

namespace FastWaysToReadFromTheConsole //.
{                                       //.

    class FastWaysToReadFromTheConsole
    {
        static void Main(string[] args)
        {
            //ТОВА Е ПРИМЕРЕН ВХОД : 1, 2, 3, 4, ЕТЦ..
            //ЗА ДА РАБОТИ ТОВА ↓
            int[] numbers = Console.ReadLine().Split(new[] { ' ', ',' }, 
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

        }
    }
}
