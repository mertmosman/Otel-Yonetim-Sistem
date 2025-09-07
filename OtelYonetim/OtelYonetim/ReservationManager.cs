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
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelYonetim
{
    public class ReservationManager
    {
        private string dosyaYolu = "Reservations.txt";

        public void RezervasyonEkle(Reservation r)
        {
            string satir = $"{r.Id};{r.OturanId};{r.MekanId};{r.BaslangicTarihi:yyyy-MM-dd};{r.BitisTarihi:yyyy-MM-dd};{r.OdendiMi};{r.OdenenTutar}";
            File.AppendAllText(dosyaYolu, satir + Environment.NewLine);
        }

        public List<Reservation> RezervasyonlariOku()
        {
            var liste = new List<Reservation>();
            if (!File.Exists(dosyaYolu)) return liste;

            var satirlar = File.ReadAllLines(dosyaYolu);
            foreach (var s in satirlar)
            {
                if (string.IsNullOrWhiteSpace(s)) continue; // boş satır atla

                var parca = s.Split(';');
                if (parca.Length < 7) continue; // eksik alan atla veya hata fırlatabilirsin

                try
                {
                    var rezervasyon = new Reservation
                    {
                        Id = int.Parse(parca[0]),
                        OturanId = int.Parse(parca[1]),
                        MekanId = int.Parse(parca[2]),
                        BaslangicTarihi = DateTime.ParseExact(parca[3], "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        BitisTarihi = DateTime.ParseExact(parca[4], "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        OdendiMi = bool.Parse(parca[5]),
                        OdenenTutar = decimal.Parse(parca[6], CultureInfo.InvariantCulture)
                    };
                    liste.Add(rezervasyon);
                }
                catch (Exception ex)
                {
                    // Hata logla veya atla
                    Console.WriteLine($"Satır okuma hatası: {ex.Message}");
                }
            }

            return liste;
        }

        public void RezervasyonGuncelle(Reservation guncellenmis)
        {
            var rezervasyonlar = RezervasyonlariOku();
            int index = rezervasyonlar.FindIndex(r => r.Id == guncellenmis.Id);
            if (index >= 0)
            {
                rezervasyonlar[index] = guncellenmis;
                RezervasyonlariYenidenYaz(rezervasyonlar);
            }
        }

        public decimal BorcGetir(int oturanId)
        {
            var rezervasyonlar = RezervasyonlariOku()
                .Where(r => r.OturanId == oturanId)
                .ToList();

            return rezervasyonlar.Sum(r => r.ToplamTutar - r.OdenenTutar);
        }
        public void RezervasyonSil(int id)
        {
            var rezervasyonlar = RezervasyonlariOku();
            rezervasyonlar.RemoveAll(r => r.Id == id);
            RezervasyonlariYenidenYaz(rezervasyonlar);
        }


        public void RezervasyonlariYenidenYaz(List<Reservation> rezervasyonlar)
        {
            var satirlar = rezervasyonlar.Select(r =>
                $"{r.Id};{r.OturanId};{r.MekanId};{r.BaslangicTarihi:yyyy-MM-dd};{r.BitisTarihi:yyyy-MM-dd};{r.OdendiMi};{r.OdenenTutar}");
            File.WriteAllLines(dosyaYolu, satirlar);
        }
    }
}
