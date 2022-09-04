using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace povtor
{
    public class Dialogwin
    {
        public static string pathStart; // Путь к исходному файлу
       
        public void DialogWindows()
        {

            var ofd = new OpenFileDialog();
            ofd.Filter = "(text files)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pathStart = ofd.FileName;
                var lin = File.ReadAllLines(pathStart);
                string[][] text = new string[lin.Length][];
                for (int i = 0; i < lin.Length; i++)
                {
                    text[i] = lin[i].Split(';');
                }
                string[,] a = new string[text.Length, text[text.Length - 1].Length];
                int j = 0;
                int k;
                string a1 = "pn10";
                string a2 = "pn16";
                string a3 = "pn20";
                string a4 = "pn25";
                foreach (string[] line in text)
                {
                    k = 0;
                    foreach (string s in line)
                    {

                        a[j, k] = s;
                        Console.WriteLine(a[j, k]);/// вывод цикла
                        if ((a[j, 2] == a1))
                        {
                            double b1 = Convert.ToDouble(a[j, 1]);
                            Console.WriteLine(a[j, 1]);
                            double b2 = Convert.ToDouble(a[j, 0]);
                            Console.WriteLine(a[j, 0]);
                            win2 f2 = new win2();
                            double f = f2.testWin(b1, b2);
                            if (((f>=10) && (f<=11)))
                            {
                                Console.WriteLine("Соответствует");
                            }
                            else
                            {
                                Console.WriteLine("не Соответствует--");
                                Console.Write(a[j, 2]);
                            }
                        }
                        k++;
                    }
                    j++;
                }
                
                
                

            }
        }
    }
}
