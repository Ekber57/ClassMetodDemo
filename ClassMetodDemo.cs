using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public class Program 
    {
        public static void Main()
        {
			Musteri musteri = new Musteri();
			musteri.Id = 1;
			musteri.Ad = "Ekber";
			musteri.Soyad = "Quliyev";
			
			Musteri musteri1 = new Musteri();
			musteri1.Id = 2;
			musteri1.Ad = "Elnur";
			musteri1.Soyad = "Yusifzade";
			
			
			
			
			MusteriManager musteriManager = new MusteriManager();
			musteriManager.Ekle(musteri);
			musteriManager.Ekle(musteri1);
			musteriManager.Listele();
			musteriManager.Sil(musteri);
			musteriManager.Listele();
        }
    }
}