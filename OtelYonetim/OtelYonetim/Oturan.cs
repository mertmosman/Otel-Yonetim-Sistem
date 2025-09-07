/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2014-2015 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: PROJE
**				ÖĞRENCİ ADI............: MUHAMMED OSMAN MERT
**				ÖĞRENCİ NUMARASI.......: B241210350
**                         DERSİN ALINDIĞI GRUP: 1/B
****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelYonetim
{
    public class Oturan
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int MekanId { get; set; }
        public int? BagliId { get; set; } // Sadece Misafirler için

        public virtual string Tur => "Oturan";

        public override string ToString()
        {
            string temel = $"{Ad} {Soyad} [{Tur}] (#{Id})";

            if (Tur == "Misafir" && BagliId.HasValue)
            {
                temel += $" (Bağlı: {BagliId.Value})";
            }

            return temel;
        }
    }


}
