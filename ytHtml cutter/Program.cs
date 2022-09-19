using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ytHtml_cutter
{
    class Program
    {
        static void Main(string[] args)
        {
            string bufor1;
            string bufor2;
            int count = 0;
	        string path;
            Console.WriteLine("Podaj Ścieżke: ");
	        path = Console.ReadLine();
            using (StreamReader reader = new StreamReader(@path + ".txt"))
            {
                using (StreamWriter writer = new StreamWriter(@path + "2.txt"))
                {
                    //Console.Write(reader.ReadLine());
                    try
                    {
                        for (; ; )
                        {
                            bufor1 = reader.ReadLine();
                            if (bufor1.Contains("er\" aria-label=\"") && bufor1.Contains("title"))
                            {
                                bufor2 = bufor1.Remove(0, bufor1.IndexOf("er\" aria-label=\"") + 16);
                                bufor1 = bufor2.Remove(bufor2.IndexOf("views"));
                                writer.WriteLine(bufor1);
                                count++;
                                Console.WriteLine(count + ": " + bufor1);
                            }
                        }

                    }
                    catch
                   {
                        Console.WriteLine("End Of File");
                    }
                }
                
            }
            Console.Read();
        }
    }
}
