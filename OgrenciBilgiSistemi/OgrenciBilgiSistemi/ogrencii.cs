using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Ogrencii
    {

        public string ad, soyad, durum;
        public int ogr_no;
        public int vize, final;
        public double ortalama;
        public void Ortalamahesap()
        {
            ortalama = (vize * 0.4 + final * 0.6);
        }
        public override string ToString()
        {
            return "ogrenci numarası: "+ogr_no+" Adi: " + ad + " soyad: " + soyad;
        }

    }

}