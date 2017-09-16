using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_MPP
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Lab_Test\\Lab_Test\\Lab_Test\\bin\\Debug\\Lab_Test.exe";
            try
            {
                var analize = new AnalizeFile(path);
                Console.WriteLine(analize.GetData());
            }
            catch(IOException)
            {
                Console.WriteLine("Файл не найден.");
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
