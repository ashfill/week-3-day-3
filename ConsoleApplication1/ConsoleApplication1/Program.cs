using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace ConsoleApplication1
{
    class Program
    {


        static void Main(string[] args)
        {
            //string filename = "C:\\Users\\ashton\\Documents\\week3day3.txt";

            ////List<string1> c = new List<string1>();

            //string1 d = new string1();
            //d.Number = "The number is {0}";

            //StreamWriter gh = new StreamWriter(filename, true);

            //for (int i = 0; i < 100; i++)
            //{
            //    string1 g = new string1();
            //    g.Number = string.Format("The number is {0}", i + 1);
            //    gh.Write(g.Number);

            //}
            //gh.Close();

            //StreamReader yt = new StreamReader(filename);
            //Console.ReadKey();

            List<plants> z = new List<plants>();

            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\Users\\ashton\\Documents\\plant_catalog.xml");

            XmlNode catNode = doc.DocumentElement.SelectSingleNode("/CATALOG");

            foreach (XmlNode child in catNode.ChildNodes)
            {
                plants NewPlant = new plants();
                foreach (XmlNode grandChild in child.ChildNodes)
                {
                    switch (grandChild.Name)
                    {
                        case "COMMON":
                            {
                                NewPlant.COMMON = grandChild.InnerText;
                                break;
                            }
                        case "BOTANICAL":
                            {
                                NewPlant.BOTANICAL = grandChild.InnerText;
                                break;
                            }
                        case "ZONE":
                            {
                                NewPlant.ZONE = grandChild.InnerText;
                                break;
                            }
                        case "LIGHT":
                            {
                                NewPlant.LIGHT = grandChild.InnerText;
                                break;
                            }
                        case "PRICE":
                            {
                                NewPlant.PRICE = grandChild.InnerText;
                                break;
                            }
                        case "AVAILABILITY":
                            {
                                NewPlant.AVAILABILITY = grandChild.InnerText;
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }
                }
                z.Add(NewPlant);
            }
            for (int i = 0; i < z.Count; i++)
            {
                Console.WriteLine(string.Format("Plant {0} ", z[i].COMMON));
                Console.WriteLine(string.Format("------------------"));
               Console.WriteLine(string.Format("Type  {0}", z[i].BOTANICAL));
                Console.WriteLine(string.Format("------------------"));
                Console.WriteLine(string.Format("Zone  {0} ", z[i].ZONE));
                Console.WriteLine(string.Format("------------------"));
                Console.WriteLine(string.Format("Light {0} ", z[i].LIGHT));
                Console.WriteLine(string.Format("------------------"));
                Console.WriteLine(string.Format("Price {0} ", z[i].PRICE));
                Console.WriteLine(string.Format("------------------"));
                Console.WriteLine(string.Format("Availability {0}", z[i].AVAILABILITY));
                Console.WriteLine(string.Format("------------------"));
            }
            Console.ReadKey();
        }




    }
}







