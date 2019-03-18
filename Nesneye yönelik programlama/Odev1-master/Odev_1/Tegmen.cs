using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Tegmen : Asker
    {
        Random rnd = new Random();
        public override void AtesEt()
        {
            StreamWriter SW = File.AppendText("dosya.txt");
            {
                int sayi = rnd.Next(3);
                int hasar1 = 10, hasar2 = 20, hasar3 = 25;
                for (int i = 0; i < 7; i++)
                {
                    if (takımTuru == true)
                    {
                        if (Ermeydani.takimB.birlik[i].korX > this.korX - 2 && Ermeydani.takimB.birlik[i].korX < this.korX + 2 && Ermeydani.takimB.birlik[i].korY > this.korY - 2 
                            && Ermeydani.takimB.birlik[i].korY < this.korY + 2)// Karşı takımın bütün krodinatlarını menzil içerisinde olup olmadığını kontrol etti.
                        {
                            if (sayi == 0)
                            {
                                Ermeydani.takimB.birlik[i].can = Ermeydani.takimB.birlik[i].can - hasar1;
                                SW.WriteLine(Ermeydani.takimB.birlik[i].ToString() + " A takımındaki Teğmen tarafından " + hasar1 + " hasar aldı.");
                                if (Ermeydani.takimB.birlik[i].can <= 0)
                                {
                                    Ermeydani.takimB.birlik[i].korX = 250;
                                    Ermeydani.takimB.birlik[i].hayattami = false;
                                    Ermeydani.takimB.takimcani--;
                                    SW.WriteLine(Ermeydani.takimB.birlik[i].ToString() + " A takımındaki Teğmen tarafından öldürüldü.");
                                }
                            }
                            else if (sayi == 1)
                            {
                                Ermeydani.takimB.birlik[i].can = Ermeydani.takimB.birlik[i].can - hasar2;
                                SW.WriteLine(Ermeydani.takimB.birlik[i].ToString() + " A takımındaki Teğmen tarafından " + hasar2 + " hasar aldı.");
                                if (Ermeydani.takimB.birlik[i].can <= 0)
                                {
                                    Ermeydani.takimB.birlik[i].korX = 250;
                                    Ermeydani.takimB.birlik[i].hayattami = false;
                                    Ermeydani.takimB.takimcani--;
                                    SW.WriteLine(Ermeydani.takimB.birlik[i].ToString() + " A takımındaki Teğmen tarafından öldürüldü.");
                                }
                            }
                            else
                            {
                                Ermeydani.takimB.birlik[i].can = Ermeydani.takimB.birlik[i].can - hasar3;
                                SW.WriteLine(Ermeydani.takimB.birlik[i].ToString() + " A takımındaki Teğmen tarafından " + hasar3 + " hasar aldı.");
                                if (Ermeydani.takimB.birlik[i].can <= 0)
                                {
                                    Ermeydani.takimB.birlik[i].korX = 250;
                                    Ermeydani.takimB.birlik[i].hayattami = false;
                                    Ermeydani.takimB.takimcani--;
                                    SW.WriteLine(Ermeydani.takimB.birlik[i].ToString() + " A takımındaki Teğmen tarafından öldürüldü.");
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
                                SW.WriteLine(Ermeydani.takimB.birlik[i].ToString() + " A takımındaki Teğmen tarafından " + hasar1 + " hasar aldı.");
                                if (Ermeydani.takimA.birlik[i].can <= 0)
                                {
                                    Ermeydani.takimA.birlik[i].korX = 250;
                                    Ermeydani.takimA.birlik[i].hayattami = false;
                                    Ermeydani.takimA.takimcani--;
                                    SW.WriteLine(Ermeydani.takimB.birlik[i].ToString() + " A takımındaki Teğmen tarafından öldürüldü.");
                                }
                            }
                            else if (sayi == 1)
                            {
                                Ermeydani.takimA.birlik[i].can = Ermeydani.takimA.birlik[i].can - hasar2;
                                SW.WriteLine(Ermeydani.takimB.birlik[i].ToString() + " A takımındaki Teğmen tarafından " + hasar2 + " hasar aldı.");
                                if (Ermeydani.takimA.birlik[i].can <= 0)
                                {
                                    Ermeydani.takimA.birlik[i].korX = 250;
                                    Ermeydani.takimA.birlik[i].hayattami = false;
                                    Ermeydani.takimA.takimcani--;
                                    SW.WriteLine(Ermeydani.takimB.birlik[i].ToString() + " A takımındaki Teğmen tarafından öldürüldü.");
                                }
                            }
                            else
                            {
                                Ermeydani.takimA.birlik[i].can = Ermeydani.takimA.birlik[i].can - hasar3;
                                SW.WriteLine(Ermeydani.takimB.birlik[i].ToString() + " A takımındaki Teğmen tarafından " + hasar3 + " hasar aldı.");
                                if (Ermeydani.takimA.birlik[i].can <= 0)
                                {
                                    Ermeydani.takimA.birlik[i].korX = 250;
                                    Ermeydani.takimA.birlik[i].hayattami = false;
                                    Ermeydani.takimA.takimcani--;
                                    SW.WriteLine(Ermeydani.takimB.birlik[i].ToString() + " A takımındaki Teğmen tarafından öldürüldü.");
                                }
                            }
                        }
                    }
                    
                }
            }
            SW.Close();
        }

        public override void HaraketEt(double Netarafa)
        {
            StreamWriter SW = File.AppendText("dosya.txt");
            if (Netarafa <0.2) //AŞAĞI GİTME.
            {
                if (korY > 0)
                {
                    if (Ermeydani.harita[korX, korY - 1].dolumu == false)
                    {
                        Ermeydani.harita[korX, korY].dolumu = !Ermeydani.harita[korX, korY].dolumu;
                        korY--;
                        Ermeydani.harita[korX, korY].dolumu = !Ermeydani.harita[korX, korY].dolumu;
                        if (takımTuru=true)
                        {
                            SW.WriteLine("A takımında ki Teğmen aşağı hareket etti.");
                        }
                        else
                        {
                            SW.WriteLine("B takımında ki Teğmen aşağı hareket etti.");
                        }
                        
                    }
                }
                else
                {
                    if (korX > 0)
                    {
                        if (Ermeydani.harita[korX - 1, korY].dolumu == false)
                        {
                            Ermeydani.harita[korX, korY].dolumu = !Ermeydani.harita[korX, korY].dolumu;
                            korX--;
                            Ermeydani.harita[korX, korY].dolumu = !Ermeydani.harita[korX, korY].dolumu;
                            if (takımTuru = true)
                            {
                                SW.WriteLine("A takımında ki Teğmen sola hareket etti.");
                            }
                            else
                            {
                                SW.WriteLine("B takımında ki Teğmen sola hareket etti.");
                            }
                        }
                    }
                }

            }// Aşağı Gitme.
            else if (Netarafa < 0.4) //YUKARI GİTME.
            {
                if (korY < 15)
                {

                    if (Ermeydani.harita[korX, korY + 1].dolumu == false)
                    {
                        Ermeydani.harita[korX, korY].dolumu = !Ermeydani.harita[korX, korY].dolumu;
                        korY++;
                        Ermeydani.harita[korX, korY].dolumu = !Ermeydani.harita[korX, korY].dolumu;
                        if (takımTuru = true)
                        {
                            SW.WriteLine("A takımında ki Teğmen yukarı hareket etti.");
                        }
                        else
                        {
                            SW.WriteLine("B takımında ki Teğmen yukarı hareket etti.");
                        }
                    }
                }
                else
                {
                    if (korX < 15)
                    {
                        if (Ermeydani.harita[korX + 1, korY].dolumu == false)
                        {
                            Ermeydani.harita[korX, korY].dolumu = !Ermeydani.harita[korX, korY].dolumu;
                            korX++;
                            Ermeydani.harita[korX, korY].dolumu = !Ermeydani.harita[korX, korY].dolumu;
                            if (takımTuru = true)
                            {
                                SW.WriteLine("A takımında ki Teğmen sağa hareket etti.");
                            }
                            else
                            {
                                SW.WriteLine("B takımında ki Teğmen sağa hareket etti.");
                            }
                        }
                    }
                }
            }// Yukarı Gitme.
            else if(Netarafa < 0.6) //Sağa Gitme.
            {
                if(korX<15)
                {
                    if (Ermeydani.harita[korX+1,korY].dolumu==false)
                    {
                        Ermeydani.harita[korX, korY].dolumu = !Ermeydani.harita[korX, korY].dolumu;
                        korX++;
                        Ermeydani.harita[korX, korY].dolumu = !Ermeydani.harita[korX, korY].dolumu;
                        if (takımTuru = true)
                        {
                            SW.WriteLine("A takımında ki Teğmen sağa hareket etti.");
                        }
                        else
                        {
                            SW.WriteLine("B takımında ki Teğmen sağa hareket etti.");
                        }
                        
                        //Ödevde en kenarda olduğu taktirde yapılacak alternatif belirtilmediği için alternatif hareket belirlemedim. 
                    }
                }
            }//Sağa Gitme.
            else if(Netarafa < 0.8)//Sola Gitme.
            {
                if (korX>0)
                {
                    if (Ermeydani.harita[korX - 1, korY].dolumu == false)
                    {
                        Ermeydani.harita[korX, korY].dolumu = !Ermeydani.harita[korX, korY].dolumu;
                        korX--;
                        Ermeydani.harita[korX, korY].dolumu = !Ermeydani.harita[korX, korY].dolumu;
                        if (takımTuru = true)
                        {
                            SW.WriteLine("A takımında ki Teğmen sola hareket etti.");
                        }
                        else
                        {
                            SW.WriteLine("B takımında ki Teğmen sola hareket etti.");
                        }
                        //Ödevde en kenarda olduğu taktirde yapılacak alternatif belirtilmediği için alternatif hareket belirlemedim. 
                    }
                   
                }
            }//Sola Gitme.
            SW.Close();
        }

        public override void Bekle()
        {
            StreamWriter SW = File.AppendText("dosya.txt");
            if (takımTuru == true)
            {
                SW.WriteLine("A takımının Teğmen bekledi.");
            }
            else
            {
                SW.WriteLine("B takımının Teğmen bekledi.");
            }
            SW.Close();
        }
    }
}
