using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream("E:\\boi.txt", FileMode.Append, FileAccess.Write); // Задаем файловую переменную указывая режим и назначение файла
            StreamWriter writer = new StreamWriter(file); // Создаем поток для записи в файловую переменную
            writer.Write("Hi, m8!"); // Используя поток пишем информацию в файл
            writer.Close(); // Закрываем поток записи

            FileStream file1 = new FileStream("E:\\boi.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file1); // Создаем поток для чтения 
            Console.Write(reader.ReadToEnd()); // Выводим в консоль информацию из файла пока не конец
            reader.Close(); // Закрываем поток чтения

            Console.ReadLine();
        }
    }
}
