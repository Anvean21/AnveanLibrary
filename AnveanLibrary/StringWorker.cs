using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnveanLibrary
{
   public class StringWorker
    {
        
        // Убрать из массива строк строки по определённому критерию
        static string[] array = array.Where(line => !line.Contains("Microsoft Visual C++ ")).ToArray();

        // Создать массив на основании дубликатов первого массива
        // То есть, если в первом массиве идут цифры { 1, 2, 3, 4, 4, 5, 5}, то второй будет = { 4, 5 } 
        static string[] array2 = array2.GroupBy(x => x).Where(g => g.Count() > 1).Select(g => g.Key).ToArray();

        // Преобразовать массив в строку
       static string str = string.Join("\r\n", array);

        // Преобразовать строку в массив
        string[] array3 = str.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
       


        //Разные методы работы со строками
        public static void StringMethdos()
        {
            // Отсортировать массив по алфавиту
            Array.Sort(array);

            // Массив строк минус дубликаты
            array.Distinct().ToArray();

            // Удалить всё, что идёт после определённого символа, не оставляя при этом сам символ
            string text = "Some text";
            text.Remove(text.IndexOf(" "));

            // Удалить всё, что идёт после определённого символа, оставив при этом сам символ
            text.Remove(text.IndexOf(" ") + 1);

            // Удалить из строки всё, что идёт до определённого символа, оставив при этом определённый символ
            text.Substring(text.IndexOf(" "));

            // Удалить из строки всё, что идёт до определённого символа, не оставляя при этом определённый символ
            text.Substring(text.IndexOf(" ") + 1);

            // Удалить из строки всё, что идёт от определённого символа, удалив при этом определённый символ
            text.Substring(0, text.IndexOf(" "));

            // Удалить из строки всё, что идёт до последнего определённого символа, не удаляя сам символ
            text.Substring(text.LastIndexOf(" "));

            // Удалить из строки всё, что идёт после последнего определённого символа, удалив при этом определённый символ
            text.Substring(0, text.LastIndexOf(" "));

            // Удалить из строки всё, что идёт до последнего определённого символа, удалив при этом сам символ
            text.Substring(text.LastIndexOf(" ") + 1);

            // Удалить из строки всё, что идёт после последнего определённого символа, оставив при этом сам символ
            text.Substring(0, text.LastIndexOf(" ") + 1);
        } 
    }
    
    public static class StringExtentio
    {
        //Метод расширения для подсчета букв в строке
        public static int CharCounter(this string str, char c)
        {
            int counter = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
