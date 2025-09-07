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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelYonetim
{
    public partial class HavuzForm : Form
    {
        private List<Reservation> rezervasyonlar;
        private List<Oturan> tumOturanlar;
        private List<Mekan> mekanlar;
        private ReservationManager reservationManager = new ReservationManager();
        private OturanManager oturanManager = new OturanManager();
        private MekanManager mekanManager = new MekanManager();
        public HavuzForm()
        {
            InitializeComponent();
        }



        private void HavuzForm_Load(object sender, EventArgs e)
        {
            mekanlar = mekanManager.MekanlariOku();
            tumOturanlar = oturanManager.OturanlariOku();
            rezervasyonlar = reservationManager.RezervasyonlariOku();

            // Sadece havuz mekanları
            var havuzMekanlar = mekanlar.Where(m => m.Tur == "Havuz").Select(m => m.Id).ToList();

            // Bu mekanlara ait tüm rezervasyonlar (ödeme durumu fark etmez)
            var havuzRezervasyonlar = rezervasyonlar
                .Where(r => havuzMekanlar.Contains(r.MekanId))
                .ToList();

            var uygunKisiler = new List<Oturan>();

            foreach (var rez in havuzRezervasyonlar)
            {
                var kisi = tumOturanlar.FirstOrDefault(o => o.Id == rez.OturanId);
                if (kisi != null)
                {
                    uygunKisiler.Add(kisi);

                    // Ona bağlı misafirleri de al
                    var misafirler = tumOturanlar.Where(m => m.BagliId == kisi.Id).ToList();
                    uygunKisiler.AddRange(misafirler);
                }
            }

            lstKisiler.Items.Clear();
            lstKisiler.Items.AddRange(uygunKisiler.Distinct().ToArray());
        }

        private decimal BorcGetir(Oturan kisi)
        {
            // Misafir ise bağlı olduğu kişinin borcunu kontrol et
            int kontrolId = kisi.Tur == "Misafir" ? kisi.BagliId.GetValueOrDefault() : kisi.Id;

            var rezervasyonlar = reservationManager.RezervasyonlariOku()
                .Where(r => r.OturanId == kontrolId)
                .ToList();

            decimal toplamTutar = rezervasyonlar.Sum(r => r.ToplamTutar);
            decimal odenen = rezervasyonlar.Sum(r => r.OdenenTutar);

            return toplamTutar - odenen;
        }

        private void btnHavuzKullan_Click(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen bir kişi seçin.");
                return;
            }

            var secilen = (Oturan)lstKisiler.SelectedItem;
            var borc = BorcGetir(secilen);

            string durum = borc > 0 ? "kullandırılmadı" : "kullandırıldı";
            string satir = $"{DateTime.Now:yyyy-MM-dd HH:mm} - {secilen.Ad} {secilen.Soyad} - Havuz - {durum}";

            File.AppendAllText("HavuzKul.txt", satir + Environment.NewLine);

            MessageBox.Show($"İşlem tamamlandı: {durum}");

            ((Form1)Application.OpenForms["Form1"]).ListeyiGuncelle();
        }
    }
}
