using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metot_Sorular
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //Liste olarak aldığı sayılardan tek olanları liste olarak döndüren metodu yazınız.
            //TekDondur() List<int>

            //List<int> sayilar = new List<int>() { 5, 6, 8, 11, 27, 63, 56, 2 };
            //List<int> ekranayaz = TekDondur(sayilar);
            //for (int i = 0; i < ekranayaz.Count; i++)
            //{
            //    Console.WriteLine(ekranayaz[i]);
            //}

            #endregion







            #region
            //Kendisine gönderilen int tipinde 2 sayıdan büyük olanı döndüren metodu yazınız.
            //BuyukDondur() 2 parametre

            //Console.WriteLine($"En büyük: "+BuyukDondur(10,20,30));













            //kendisine gönderilen 3 sayıdan büyük olanı döndüren metodu yazınız.
            //BuyukDondur() 3 parametre
            //Püf: if kullanmayın.aynı metodu 2 parametreli kullanarak çözmeye çalışın.
            #endregion



            //kendisine gönderilen fiyata kdv ekleyip geri döndüren metodu yazınız.
            //ürün kategorisine göre KDV eklenecek
            //gıda:%8, eğitim:%5, diğerleri:%18
            //parametreler:fiyat,kategori

            double s = parametre("gıda",100);
            Console.WriteLine(s);


            Console.ReadKey();

        }

        

        static double parametre(string kategori,double fiyat)
        {
            
            if (kategori== "gıda")
            {

                return fiyat * 1.08;
            }
            else if (kategori == "eğitim")
            {

                return fiyat * 1.05;
            }
            else 
            {
                
                return fiyat * 1.18;
            }
            
        }











        //static int BuyukDondur(int s1,int s2)
        //{
        //    if (s1>s2)
        //    {
        //        return s1;
        //    }
        //    else
        //    {
        //        return s2;
        //    }
        //}

        //static int BuyukDondur(int s1,int s2,int s3)
        //{
        //    int buyuk = BuyukDondur(s1, s2);
        //    int enbuyuk = BuyukDondur(buyuk, s3);
        //    return enbuyuk;
        //}



        //static List<int> TekDondur(List<int> tsayilar)
        //{
        //    List<int> sayilar = new List<int>();
        //    for (int i = 0; i < tsayilar.Count; i++)
        //    {
        //        if (tsayilar[i]%2==1)
        //        {
        //            sayilar.Add(tsayilar[i]);
        //        }

        //    }
        //    return sayilar;

    }
    }

