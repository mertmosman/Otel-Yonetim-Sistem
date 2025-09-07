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
    public class MekanManager
    {
        public void MekanEkle(Mekan m)
        {
            var mevcutlar = MekanlariOku();
            if (mevcutlar.Any(x => x.Id == m.Id))
            {
                MessageBox.Show("Bu ID'ye sahip bir mekan zaten var!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string satir = $"{m.Id};{m.Ad};{m.Konum};{m.Tur}";
            File.AppendAllText("Mekan.txt", satir + Environment.NewLine);
        }


        public List<Mekan> MekanlariOku()
        {
            var mekanlar = new List<Mekan>();

            if (File.Exists("Mekan.txt"))
            {
                string[] satirlar = File.ReadAllLines("Mekan.txt");

                foreach (var satir in satirlar)
                {
                    var parca = satir.Split(';');
                    if (parca.Length < 4) continue;  // Güvenlik önlemi

                    int id = int.Parse(parca[0]);
                    string ad = parca[1];
                    string konum = parca[2];
                    string tur = parca[3];

                    Mekan m = null;

                    switch (tur)
                    {
                        case "Daire":
                            m = new Daire(); break;
                        case "Havuz":
                            m = new HavuzKul(); break;
                        case "Fitness":
                            m = new Fitness(); break;
                    }

                    if (m != null)
                    {
                        m.Id = id;
                        m.Ad = ad;
                        m.Konum = konum;
                        mekanlar.Add(m);
                    }
                }
            }

            return mekanlar;
        }

    }
}
