﻿using System;
using System.Globalization;
using System.Text.RegularExpressions;

// Регулярные выражения.

/*
 
  System.Text.RegularExpressions - пространство имён где, хранятся нужные методы для работы с Regex'ами.  
 
  МЕТАСИМВОЛЫ - это символы для составления Шаблона поиска.
       
  \d    Определяет символы цифр. 
  \D 	Определяет любой символ, который не является цифрой. 
  \w 	Определяет любой символ цифры, буквы или подчеркивания. 
  \W    Определяет любой символ, который не является цифрой, буквой или подчеркиванием. 
  \s 	Определяет любой непечатный символ, включая пробел. 
  \S 	Определяет любой символ, кроме символов табуляции, новой строки и возврата каретки.
   .    Определяет любой символ кроме символа новой строки. 
  \.    Определяет символ точки.
 
 */

namespace RegularExpressions
{
    class Program
    {
        static void Main()
        {
            // Данный шаблон определяет символы цифр.
            const string pattern = @"\d";

            // Создаем экземпляр класса Regex и передаем в качестве аргумента конструктора шаблон.
            var regex = new Regex(pattern);

            while (true)
            {
                // Строка с которой будет сравниваться шаблон.
                string @string = Console.ReadKey().KeyChar.ToString();

                if (@string == " ")
                    break;

                // Проверка соответствия строки шаблону. 

                // Метод IsMatch - сравнивает принимаемую в первом параметре строку с шаблоном. 
                // IsMatch - метод возвращающий bool. True - в случае, если шаблон соответсвует строке, false - в противном случае.   
                bool success = regex.IsMatch(@string);

                Console.WriteLine(success ?
                                          " matches pattern \"{0}\"" :
                                          " NOT matching pattern \"{0}\"",
                                  pattern);
             
            }
        }
    }
}
