using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task8
{
    class Program
    {
        /* Выберите любую папку на своем компьютере, имеющую вложенные директории.
           Выведите на консоль ее содержимое и содержимое всех подкаталогов. */
        static void Main(string[] args)
        {
            string path = "D:/";
                     
            DirectoryInfo dir = new DirectoryInfo(path);
            DirectoryInfo[] directories = dir.GetDirectories();
            FileInfo[] files = dir.GetFiles();

            Console.WriteLine("============Список каталогов=============");
            foreach (DirectoryInfo d in directories)
            {
                Console.WriteLine(d.Name);
                Console.WriteLine();
            }

            Console.WriteLine("==============Список файлов==============");
            foreach (FileInfo f in files)
            {
                Console.WriteLine(f.Name);
            }
            Console.ReadKey();
        }
    }
}
