using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_MPP
{
    public class AnalizeFile
    {
        private string path;

        public string Path
        {
            get
            {
                return path;
            }
            set
            {
                if (!File.Exists(value))
                    throw new IOException("Файл не найден.");
                else
                    path = value;
            }
        }
        public AnalizeFile(string path)
        {
            Path = path;
        }

        public string GetData()
        {
            string result = "";
            var assembly = Assembly.LoadFile(path);
            List<string> result_list = new List<string>();
            foreach (Type tmp in assembly.GetTypes())
                if (tmp.IsPublic)
                    result_list.Add(tmp.FullName.ToString());
            result_list.Sort();
            foreach (string tmp in result_list)
            {
                result += tmp + "\n";
            }
            return result;
        }
    }
}
