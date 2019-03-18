using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    public abstract class Asker
    {
       
        public int can = 100, korX, korY;
        public static int sayac=0;
        public bool takımTuru;
        public bool hayattami = true;
        Random  rastgele = new Random();
        
        public void konumbelirle()
        {
            if (sayac<7)
            {
                takımTuru = true;
                do
                {
                    korX = rastgele.Next(5);
                    korY = rastgele.Next(5);
                } while (Ermeydani.harita[korX,korY].dolumu == true);
                Ermeydani.harita[korX, korY].dolumu = true;

                sayac++;
            }
            else if(sayac<14)
            {
                takımTuru = false;
                do
                {
                    korX = rastgele.Next(11,16);
                    korY = rastgele.Next(11,16);
                } while (Ermeydani.harita[korX,korY].dolumu == true);
                Ermeydani.harita[korX, korY].dolumu = true;
                sayac++;
            }
        }// Askerlerin konumları belirle.

        public void neYapcam(double neyapcam)
        {
            if(neyapcam<0.8)
            {
                HaraketEt(neyapcam);
            }
            else if(neyapcam<0.9)
            {
                AtesEt();
            }
            else
            {
                Bekle();
            }
        }
        public abstract void AtesEt();

        public abstract  void HaraketEt(double Netarafa);

        public abstract void Bekle();

        // ..... //

    }
}
