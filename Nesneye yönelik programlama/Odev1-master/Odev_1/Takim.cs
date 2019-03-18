using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    public class Takim
    {
        public Random rastgele = new Random();
        public Asker[] birlik = new Asker[7];
        public int takimcani = 7;
        public void takım_olusturma()
        {
            int x = rastgele.Next(4);
            if (x == 0)//1 Teğmenli Takım.
            {
                birlik[0] = new Tegmen();
                birlik[0].konumbelirle();
                
                for (int i = 1; i < 7; i++)
                {
                    birlik[i] = new Er();
                    birlik[i].konumbelirle();
                }
            }//1 Teğmenli takım.
            else if (x == 1)//2 Twğmenli takım.
            {
                birlik[0] = new Tegmen();
                birlik[0].konumbelirle();
                birlik[1] = new Tegmen();
                birlik[1].konumbelirle();
                for (int i = 2; i < 7; i++)
                {
                    birlik[i] = new Er();
                    birlik[i].konumbelirle();
                }
            }//2 Teğmenli takım.
            else if (x == 2)//1 Yüzbaşılı 1 Teğmenli takım.
            {
                birlik[0] = new Yuzbasi();
                birlik[0].konumbelirle();
                birlik[1] = new Tegmen();
                birlik[1].konumbelirle();
                for (int i = 2; i < 7; i++)
                {
                    birlik[i] = new Er();
                    birlik[i].konumbelirle();
                }
            }//1 Yüzbaşılı 1 Teğmenli takım.
            else//1 Yüzbaşılı 2 Teğmenli takım.
            {
                birlik[0] = new Yuzbasi();
                birlik[0].konumbelirle();
                birlik[1] = new Tegmen();
                birlik[1].konumbelirle();
                birlik[2] = new Tegmen();
                birlik[2].konumbelirle();
                for (int i = 3; i < 7; i++)
                {
                    birlik[i] = new Er();
                    birlik[i].konumbelirle();
                }
            }//1 Yüzbaşılı 2 Teğmenli takım.
        }
    }
}

