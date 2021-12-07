using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2_Task8
{
    class Program
    {
        /* Программно создайте текстовый файл и запишите в него 10 случайных чисел. 
           Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль.*/
        static void Main(string[] args)
        {
            string path = "D:/Task8.txt";
            if (!File.Exists(path))
            {
                File.Create(path).Close();
                
            }

            using (StreamWriter sw = new StreamWriter(path, false))
            {
                int[] array = new int[10];
                Random rnd = new Random();
                foreach (int i in array)
                {
                    array[i] = rnd.Next(0, 10);
                    sw.Write("{0} ", array[i]);
                }

            }
                        
            using (StreamReader sr = new StreamReader(path))
            {
                string s = sr.ReadToEnd().Trim();                
                string[] arrayString = s.Split();
                int Sum = 0;
                for (int i = 0; i < arrayString.Length; i++)
                {
                    int n= Convert.ToInt16(arrayString[i]);
                    Sum+= n;
                }
                Console.WriteLine("Сумма = {0}", Sum);

            }                                
            
            Console.ReadKey();
                        
        }
    }
}
