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
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelYonetim
{

    public partial class OdemeForm : Form
    {
        public Form1 Form1Referans { get; set; }
        private ReservationManager rezervasyonManager = new ReservationManager();
        private List<Reservation> rezervasyonlar;
        public OdemeForm()
        {
            InitializeComponent();
        }

        private void OdemeForm_Load(object sender, EventArgs e)
        {
            RezervasyonlariYukle();
        }

        private void RezervasyonlariYukle()
        {
            // Sadece ödenmemiş rezervasyonları yükle
            rezervasyonlar = rezervasyonManager.RezervasyonlariOku()
                                                .Where(r => !r.OdendiMi)
                                                .ToList();

            lstOdemeBekleyenler.Items.Clear();
            lstOdemeBekleyenler.Items.AddRange(rezervasyonlar.ToArray());
        }
        private void lstOdemeBekleyenler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            if (lstOdemeBekleyenler.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen bir rezervasyon seçin.");
                return;
            }

            var secilen = rezervasyonlar[lstOdemeBekleyenler.SelectedIndex];

            if (!decimal.TryParse(txtOdemeMiktari.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal odenenMiktar))
            {
                MessageBox.Show("Lütfen geçerli bir ödeme tutarı girin.");
                return;
            }

            decimal kalanBorç = secilen.ToplamTutar - secilen.OdenenTutar;

            if (odenenMiktar <= 0)
            {
                MessageBox.Show("Ödeme tutarı sıfırdan büyük olmalıdır.");
                return;
            }

            if (odenenMiktar > kalanBorç)
            {
                MessageBox.Show($"Ödeme tutarı kalan borçtan ({kalanBorç:C}) fazla olamaz.");
                return;
            }

            // Ödeme miktarını ekle
            secilen.OdenenTutar += odenenMiktar;

            // Eğer borç kapandıysa işaretle
            if (secilen.OdenenTutar >= secilen.ToplamTutar)
                secilen.OdendiMi = true;

            // Dosyadaki tüm rezervasyonları oku ve güncelle
            var tumRez = rezervasyonManager.RezervasyonlariOku();
            var guncellenecek = tumRez.FirstOrDefault(r => r.Id == secilen.Id);
            if (guncellenecek != null)
            {
                guncellenecek.OdenenTutar = secilen.OdenenTutar;
                guncellenecek.OdendiMi = secilen.OdendiMi;
                rezervasyonManager.RezervasyonlariYenidenYaz(tumRez);
            }

            MessageBox.Show("Ödeme işlemi tamamlandı.");

            txtOdemeMiktari.Clear();
            RezervasyonlariYukle(); // Ödeme formundaki listeyi güncelle

            // **Burada Form1 referansı null değilse, Form1’deki ödenmiş rezervasyon listesini güncelle**
            Form1Referans?.OdenmisRezervasyonlariGuncelle();
        }

        private void txtOdemeMiktari_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstOdemeBekleyenler.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen bir rezervasyon seçin.");
                return;
            }

            var secilen = rezervasyonlar[lstOdemeBekleyenler.SelectedIndex];

            if (!decimal.TryParse(txtOdemeMiktari.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal yeniOdeme))
            {
                MessageBox.Show("Lütfen geçerli bir ödeme tutarı girin.");
                return;
            }

            if (yeniOdeme <= 0)
            {
                MessageBox.Show("Ödeme tutarı sıfırdan büyük olmalıdır.");
                return;
            }

            decimal kalanBorc = secilen.ToplamTutar - secilen.OdenenTutar;

            if (yeniOdeme > kalanBorc)
            {
                MessageBox.Show($"Girilen tutar kalan borçtan ({kalanBorc:C}) fazla olamaz.");
                return;
            }

            // Yeni ödeme ekleniyor
            secilen.OdenenTutar += yeniOdeme;

            // Borç tamamlandıysa OdendiMi true yap
            if (secilen.OdenenTutar >= secilen.ToplamTutar)
                secilen.OdendiMi = true;

            // Güncellenmiş rezervasyonu dosyaya yaz
            var tumRezervasyonlar = rezervasyonManager.RezervasyonlariOku();
            var guncellenecek = tumRezervasyonlar.FirstOrDefault(r => r.Id == secilen.Id);
            if (guncellenecek != null)
            {
                guncellenecek.OdenenTutar = secilen.OdenenTutar;
                guncellenecek.OdendiMi = secilen.OdendiMi;

                rezervasyonManager.RezervasyonlariYenidenYaz(tumRezervasyonlar);
            }

            MessageBox.Show("Ödeme bilgisi güncellendi.");

            txtOdemeMiktari.Clear();
            RezervasyonlariYukle();

            // Form1 güncellemesi gerekiyorsa
            Form1Referans?.OdenmisRezervasyonlariGuncelle();
        }
    }
}
