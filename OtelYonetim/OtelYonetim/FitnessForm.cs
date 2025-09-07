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
    public partial class FitnessForm : Form
    {
        private List<Oturan> tumKisiler;
        private List<Mekan> mekanlar;
        private List<Reservation> rezervasyonlar;
        private OturanManager oturanManager = new OturanManager();
        private MekanManager mekanManager = new MekanManager();
        private ReservationManager rezervasyonManager = new ReservationManager();
        public FitnessForm()
        {
            InitializeComponent();
        }

        private void FitnessForm_Load(object sender, EventArgs e)
        {
            tumKisiler = oturanManager.OturanlariOku();
            mekanlar = mekanManager.MekanlariOku();
            rezervasyonlar = rezervasyonManager.RezervasyonlariOku();

            // Fitness türü mekanların Id'leri
            var fitnessMekanIdler = mekanlar
                .Where(m => m.Tur == "Fitness")
                .Select(m => m.Id)
                .ToList();

            // Bu mekanlara yapılan tüm rezervasyonlar (ödeme fark etmeksizin)
            var fitnessRezervasyonlar = rezervasyonlar
                .Where(r => fitnessMekanIdler.Contains(r.MekanId))
                .ToList();

            var uygunKisiler = new List<Oturan>();

            foreach (var rez in fitnessRezervasyonlar)
            {
                var kisi = tumKisiler.FirstOrDefault(o => o.Id == rez.OturanId);
                if (kisi != null)
                {
                    uygunKisiler.Add(kisi);

                    // Ona bağlı misafirleri de ekle
                    var misafirler = tumKisiler.Where(m => m.BagliId == kisi.Id).ToList();
                    uygunKisiler.AddRange(misafirler);
                }
            }

            lstFitnessKullanicilar.Items.Clear();
            lstFitnessKullanicilar.Items.AddRange(uygunKisiler.Distinct().ToArray());
        }

        private void btnFitnessKullan_Click(object sender, EventArgs e)
        {
            if (lstFitnessKullanicilar.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen bir kişi seçin.");
                return;
            }

            var kisi = (Oturan)lstFitnessKullanicilar.SelectedItem;
            int kontrolId = kisi.Tur == "Misafir" ? kisi.BagliId.GetValueOrDefault() : kisi.Id;

            decimal borc = rezervasyonManager.BorcGetir(kontrolId);
            string durum = borc > 0 ? "kullandırılmadı" : "kullandırıldı";

            string log = $"{DateTime.Now:yyyy-MM-dd HH:mm} - {kisi.Ad} {kisi.Soyad} - Fitness - {durum}";
            File.AppendAllText("Fitness.txt", log + Environment.NewLine);

            MessageBox.Show($"Kayıt tamamlandı: {durum}");
            ((Form1)Application.OpenForms["Form1"]).ListeyiGuncelle();
        }
    }
}
