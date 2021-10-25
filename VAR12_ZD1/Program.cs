using System;
using System.IO;
using System.Text;
using System.Collections;

namespace VAR12_ZD1
{
    class Program
    {
        static void Main(string[] args)
        {
            string zd = "Создать текстовый файл.\nВывести на экран гласные буквы этого файла в обратном порядке.";

            string path = Directory.GetCurrentDirectory();
            FileStream fileStream = null;

            // проверяем существует ли файл файл
            if (!File.Exists(path + "/t.txt"))
            {
                fileStream = File.Create(path + "/t.txt"); // создаем файл
                StreamWriter sr1 = new StreamWriter(fileStream);
                sr1.Write(zd);
                sr1.Close();
            }

                fileStream = File.Open(path + "/t.txt", FileMode.Open);

                StreamReader sr = new StreamReader(fileStream);
                string s = sr.ReadToEnd();
                sr.Close();

                Stack st = new Stack();
                string abc = "аоэеиыуёюя";

                for (int i = 0; i < s.Length; i++)
                {
                    if ((abc.Contains(s[i])) || (abc.ToUpper().Contains(s[i]))) st.Push(s[i]);
                }
                //выводим
                Console.WriteLine("Глассные буквы из файла в обратном порядке");
                while (st.Count > 0)
                {
                    Console.Write($"{st.Pop()} ");
                }

        }
    }
}
