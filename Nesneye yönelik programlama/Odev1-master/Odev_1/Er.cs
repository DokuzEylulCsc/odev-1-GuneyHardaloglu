using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Odev_1
{
    public class Er : Asker 
    {
        Random rnd = new Random();
        public override void AtesEt()
        {
            StreamWriter SW = File.AppendText("dosya.txt");
            int sayi = rnd.Next(3);
            int hasar1=5, hasar2=10, hasar3=15;
            for (int i = 0; i < 7; i++)
            {   
                if(takımTuru == true)
                {
                    if (Ermeydani.takimB.birlik[i].korX>this.korX-1 && Ermeydani.takimB.birlik[i].korX<this.korX+1 && Ermeydani.takimB.birlik[i].korY>this.korY-1 
                        && Ermeydani.takimB.birlik[i].korY<this.korY+1)// Karşı takımın bütün krodinatlarını menzil içerisinde olup olmadığını kontrol etti.
                    {
                        if(sayi==0)
                        {
                            Ermeydani.takimB.birlik[i].can = Ermeydani.takimB.birlik[i].can-hasar1;
                            SW.WriteLine(Ermeydani.takimB.birlik[i].ToString() + " A takımındaki Er tarafından "+hasar1+ " hasar aldı.");
                            if (Ermeydani.takimB.birlik[i].can<=0)
                            {
                                Ermeydani.takimB.birlik[i].korX = 250;
                                Ermeydani.takimB.birlik[i].hayattami = false;
                                Ermeydani.takimB.takimcani--;
                                SW.WriteLine(Ermeydani.takimB.birlik[i].ToString()+" A takımındaki Er tarafından öldürüldü.");
                            }
                        }
                        else if (sayi==1)
                        {
                            Ermeydani.takimB.birlik[i].can = Ermeydani.takimB.birlik[i].can - hasar2;
                            SW.WriteLine(Ermeydani.takimB.birlik[i].ToString() + " A takımındaki Er tarafından"+ hasar2+ "kadar hasar aldı.");
                            if (Ermeydani.takimB.birlik[i].can <= 0)
                            {
                                Ermeydani.takimB.birlik[i].korX = 250;
                                Ermeydani.takimB.birlik[i].hayattami = false;
                                Ermeydani.takimB.takimcani--;
                                SW.WriteLine(Ermeydani.takimB.birlik[i].ToString() + " A takımındaki Er tarafından öldürüldü.");
                            }
                        }
                        else
                        {
                            Ermeydani.takimB.birlik[i].can = Ermeydani.takimB.birlik[i].can - hasar3;
                            SW.WriteLine(Ermeydani.takimB.birlik[i].ToString() + " A takımındaki Er tarafından" + hasar3 + "kadar hasar aldı.");
                            if (Ermeydani.takimB.birlik[i].can <= 0)
                            {
                                Ermeydani.takimB.birlik[i].korX = 250;
                                Ermeydani.takimB.birlik[i].hayattami = false;
                                Ermeydani.takimB.takimcani--;
                                SW.WriteLine(Ermeydani.takimB.birlik[i].ToString() + " A takımındaki Er tarafından öldürüldü.");
                            }
                        }   
                    }
                   
                }
                else
                {
                    if (Ermeydani.takimA.birlik[i].korX > this.korX - 1 && Ermeydani.takimA.birlik[i].korX < this.korX + 1 && Ermeydani.takimA.birlik[i].korY > this.korY - 1 && Ermeydani.takimA.birlik[i].korY < this.korY + 1)
                    {
                        if (sayi == 0)
                        {
                            Ermeydani.takimA.birlik[i].can = Ermeydani.takimA.birlik[i].can - hasar1;
                            SW.WriteLine(Ermeydani.takimA.birlik[i].ToString() + " B takımındaki Er tarafından " + hasar1 + " hasar aldı.");
                            if (Ermeydani.takimA.birlik[i].can <= 0)
                            {
                                Ermeydani.takimA.birlik[i].korX = 250;
                                Ermeydani.takimA.birlik[i].hayattami = false;
                                Ermeydani.takimA.takimcani--;
                                SW.WriteLine(Ermeydani.takimB.birlik[i].ToString() + " B takımındaki Er tarafından öldürüldü.");
                            }
                        }
                        else if (sayi == 1)
                        {
                            Ermeydani.takimA.birlik[i].can = Ermeydani.takimA.birlik[i].can - hasar2;
                            SW.WriteLine(Ermeydani.takimA.birlik[i].ToString() + " B takımındaki Er tarafından " + hasar2 + " hasar aldı.");
                            if (Ermeydani.takimA.birlik[i].can <= 0)
                            {
                                Ermeydani.takimA.birlik[i].korX = 250;
                                Ermeydani.takimA.birlik[i].hayattami = false;
                                Ermeydani.takimA.takimcani--;
                                SW.WriteLine(Ermeydani.takimB.birlik[i].ToString() + " B takımındaki Er tarafından öldürüldü.");
                            }
                        }
                        else
                        {
                            Ermeydani.takimA.birlik[i].can = Ermeydani.takimA.birlik[i].can - hasar3;
                            SW.WriteLine(Ermeydani.takimA.birlik[i].ToString() + " B takımındaki Er tarafından " + hasar2 + " hasar aldı.");
                            if (Ermeydani.takimA.birlik[i].can <= 0)
                            {
                                Ermeydani.takimA.birlik[i].korX = 250;
                                Ermeydani.takimA.birlik[i].hayattami = false;
                                Ermeydani.takimA.takimcani--;
                                SW.WriteLine(Ermeydani.takimA.birlik[i].ToString() + " B takımındaki Er tarafından öldürüldü.");
                            }
                        }
                    }
                    
                }  
            }
            SW.Close();
        }

        public  override void HaraketEt(double Netarafa)
        {
            StreamWriter SW = File.AppendText("dosya.txt");
            if (Netarafa <0.4) //AŞAĞI GİTME.
            {
                if (korY != 0)
                {
                    if(Ermeydani.harita[korX,korY-1].dolumu==false)
                    {
                        Ermeydani.harita[korX, korY].dolumu = !Ermeydani.harita[korX, korY].dolumu;
                        korY--;
                        Ermeydani.harita[korX, korY].dolumu = !Ermeydani.harita[korX, korY].dolumu;
                        if (takımTuru==true)
                        {
                            SW.WriteLine("A takımında ki er aşağı hareket etti.");
                        }
                        else
                        {
                            SW.WriteLine("B takımında ki er aşağı hareket etti.");
                        }
                        
                    }
                }
                else
                {
                    if(korX!=0)
                    {
                        if(Ermeydani.harita[korX-1,korY].dolumu==false)
                        {
                            Ermeydani.harita[korX, korY].dolumu = !Ermeydani.harita[korX, korY].dolumu;
                            korX--;
                            Ermeydani.harita[korX, korY].dolumu = !Ermeydani.harita[korX, korY].dolumu;
                            if(takımTuru == true)
                        {
                                SW.WriteLine("A takımında ki er yukarı hareket etti.");
                            }
                        else
                        {
                                SW.WriteLine("B takımında ki er yukarı hareket etti.");
                            }
                        }
                    }
                }
            }//Aşağı Gitme
            else if (Netarafa <0.8) //YUKARI GİTME.
            {
                if (korY != 15)
                {

                    if (Ermeydani.harita[korX, korY + 1].dolumu == false)
                    {
                        Ermeydani.harita[korX, korY].dolumu = !Ermeydani.harita[korX, korY].dolumu;
                        korY++;
                        Ermeydani.harita[korX, korY].dolumu = !Ermeydani.harita[korX, korY].dolumu;
                        SW.WriteLine("A takımında ki er yukarı hareket etti.");
                    }
                }
                else
                {
                    if (korX != 15)
                    {
                        if (Ermeydani.harita[korX + 1, korY].dolumu == false)
                        {
                            Ermeydani.harita[korX, korY].dolumu = !Ermeydani.harita[korX, korY].dolumu;
                            korX++;
                            Ermeydani.harita[korX, korY].dolumu = !Ermeydani.harita[korX, korY].dolumu;
                            SW.WriteLine("A takımında ki er sağa hareket etti.");
                        }
                    }
                }
            }//Yukarı Gitme.
            SW.Close();
        }

        public override void Bekle()
        {
            StreamWriter SW = File.AppendText("dosya.txt");
            if(takımTuru==true)
            {
                SW.WriteLine("A takımının Eri bekledi.");
            }
            else
            {
                SW.WriteLine("B takımının Eri bekledi.");
            }
            SW.Close();
        }
    }
}
