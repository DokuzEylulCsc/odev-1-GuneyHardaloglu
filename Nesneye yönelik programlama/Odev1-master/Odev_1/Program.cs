using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Odev_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    Ermeydani.harita[i, j]=new Bolge();
                }
            }
           Ermeydani.takimA.takım_olusturma();
           Ermeydani.takimB.takım_olusturma();
           Ermeydani.kapışma();
            Console.ReadKey();
        }
    }
}
