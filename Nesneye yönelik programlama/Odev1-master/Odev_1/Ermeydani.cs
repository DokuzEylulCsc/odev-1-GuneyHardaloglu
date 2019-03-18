using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    public class Ermeydani
    {
        public static Bolge[,] harita = new Bolge[16, 16];
        public static Takim takimA = new Takim();
        public static Takim takimB = new Takim();
        Random rastgele = new Random();
        
        public static List<int> SayiOlustur(int xbas, int xson, int ybas, int yson)
        {
            List<int> list = new List<int>();

            Random r = new Random();
            int x = 0, y = 0;
            bool buldum = false;
            while(!buldum)
            {
                x = r.Next(xbas, xson + 1);
                y = r.Next(ybas, yson + 1);
                if (harita[x, y].dolumu != true)
                {
                    list.Add(x);
                    list.Add(y);
                    buldum = true;
                }
               
            }
            
            

            return list;
        }


        public static void kapışma()
        {
            

        bool hangitakim = true;
            Random rand = new Random();
            double hangiİslem;
            int i=0,saydim=0;
            do
            {
                Random r = new Random();
                Console.WriteLine(" geldim"+ saydim.ToString());
                saydim++;
                hangiİslem = rand.NextDouble();
                if (hangitakim)//TakimA işlemleri.
                {
                    
                    bool dene=true;
                    while(dene)
                    {
                        i = r.Next(7);
                        if (takimA.birlik[i].hayattami)
                        {
                            takimA.birlik[i].neYapcam(hangiİslem);
                            dene = false;
                        }
                    }
                   

                }
                else//TakimB işlemleri.
                {
                    
                    bool dene = true;
                    while(dene)
                    {
                        i = r.Next(7);
                        if (takimB.birlik[i].hayattami)
                        {
                            takimB.birlik[i].neYapcam(hangiİslem);
                            dene = false;
                        }

                    }
                    
                    
                    
                }
                hangitakim = !hangitakim;

            }
            while (takimA.takimcani !=0 && takimB.takimcani != 0 );
            if (takimA.takimcani==0)
            {
                Console.WriteLine(takimA.takimcani.ToString());
                Console.WriteLine(takimB.takimcani.ToString());
                Console.WriteLine("TAKIM B KAZANDI!!!");
            }
            else
            {
                Console.WriteLine(takimA.takimcani.ToString());
                Console.WriteLine(takimB.takimcani.ToString());
                Console.WriteLine("TAKIM A KAZINDI!!!");
            }
        }
        // ..... //
    }
}
