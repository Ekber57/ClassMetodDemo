using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public class MusteriManager 
    {
       List<Musteri> _musteriler;
       public MusteriManager() {
       	_musteriler = new List<Musteri>();
       }
       public void Ekle(Musteri musteri) {
       
       	Console.WriteLine(musteri.Ad + " eklendi");
       	_musteriler.Add(musteri);
       
       }
       
       public void Sil(Musteri musteri) {
       	  
       	Console.WriteLine(musteri.Ad + " silindi");
       	_musteriler.Remove(musteri);
       
       }
       
       public void Listele() {
       	 foreach(Musteri musteri in _musteriler) {
       	 	Console.WriteLine(musteri.Ad);
       	 }
       }
       
    }
}