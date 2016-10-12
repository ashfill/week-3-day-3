using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string filename = "C:\\Users\\ashton\\Documents\\week3day3.txt";

            //List<string1> c = new List<string1>();

            string1 d = new string1();
            d.Number = "The number is {0}";

            StreamWriter gh = new StreamWriter(filename, true);
           
            for (int i = 0; i < 100; i++)
            {
                string1 g = new string1();
                g.Number = string.Format("The number is {0}", i + 1);
                gh.Write(g.Number);
              
            }
            gh.Close();

            StreamReader yt = new StreamReader(filename);
            Console.ReadKey();
        }
            }
        }
    

