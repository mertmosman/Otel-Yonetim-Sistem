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
    public class OturanManager
    {
        private string dosyaYolu = "Data.txt";

        public void OturanEkle(Oturan o)
        {
            var mevcutlar = OturanlariOku();
            if (mevcutlar.Any(x => x.Id == o.Id))
            {
                MessageBox.Show("Bu ID'ye sahip bir oturan zaten var!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Sadece Misafir için BagliId yazılır, diğerleri için -1 yazılır
            int bagli = o.Tur == "Misafir" && o.BagliId.HasValue ? o.BagliId.Value : -1;
            string satir = $"{o.Id};{o.Ad};{o.Soyad};{o.Tur};{bagli};{o.MekanId}";
            File.AppendAllText(dosyaYolu, satir + Environment.NewLine);
        }

        public List<Oturan> OturanlariOku()
        {
            List<Oturan> liste = new List<Oturan>();

            if (!File.Exists(dosyaYolu))
                return liste;

            var satirlar = File.ReadAllLines(dosyaYolu);
            foreach (var satir in satirlar)
            {
                var parca = satir.Split(';');
                int id = int.Parse(parca[0]);
                string ad = parca[1];
                string soyad = parca[2];
                string tur = parca[3];
                int bagliId = int.Parse(parca[4]);
                int mekanId = int.Parse(parca[5]);

                if (tur == "AileReisi")
                {
                    liste.Add(new AileReisi
                    {
                        Id = id,
                        Ad = ad,
                        Soyad = soyad,
                        MekanId = mekanId
                    });
                }
                else if (tur == "Misafir")
                {
                    liste.Add(new Misafir
                    {
                        Id = id,
                        Ad = ad,
                        Soyad = soyad,
                        BagliId = bagliId == -1 ? null : bagliId,
                        MekanId = mekanId
                    });
                }
                else
                {
                    // Normal Oturan
                    liste.Add(new Oturan
                    {
                        Id = id,
                        Ad = ad,
                        Soyad = soyad,
                        MekanId = mekanId
                    });
                }
            }

            return liste;
        }

        public void OturanSil(int id)
        {
            var liste = OturanlariOku(); // Tüm verileri oku
            var yeniListe = liste.Where(o => o.Id != id).ToList(); // Seçilen kişiyi çıkar

            // Dosyayı baştan yaz
            File.WriteAllText(dosyaYolu, "");
            foreach (var o in yeniListe)
            {
                OturanEkle(o); // Var olan ekleme fonksiyonuyla yeniden yaz
            }
        }
    }

}
