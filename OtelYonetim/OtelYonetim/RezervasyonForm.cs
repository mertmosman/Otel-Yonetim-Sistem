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
    public partial class RezervasyonForm : Form
    {

        private List<Oturan> oturanListesi;
        private List<Mekan> mekanListesi;
        private List<Reservation> rezervasyonListesi;

        private OturanManager oturanManager = new OturanManager();
        private MekanManager mekanManager = new MekanManager();
        private ReservationManager rezervasyonManager = new ReservationManager();
        private Reservation seciliRezervasyon;

        public RezervasyonForm()
        {
            InitializeComponent();
        }

        private void RezervasyonForm_Load(object sender, EventArgs e)
        {
            oturanListesi = oturanManager.OturanlariOku();
            mekanListesi = mekanManager.MekanlariOku();
            rezervasyonListesi = rezervasyonManager.RezervasyonlariOku();

            lstKisiler.Items.Clear();
            lstKisiler.Items.AddRange(oturanListesi.ToArray());

            lstMekanlar.Items.Clear();
            lstMekanlar.Items.AddRange(mekanListesi.ToArray());

            dtBaslangic.Value = DateTime.Today;
            dtBitis.Value = DateTime.Today.AddDays(1);

            ListeleRezervasyonlar();
        }

        private void btnRezerveEt_Click(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedIndex < 0 || lstMekanlar.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen kişi ve mekan seçin.");
                return;
            }

            var secilenKisi = oturanListesi[lstKisiler.SelectedIndex];
            var secilenMekan = mekanListesi[lstMekanlar.SelectedIndex];

            if (dtBitis.Value <= dtBaslangic.Value)
            {
                MessageBox.Show("Bitiş tarihi, başlangıç tarihinden sonra olmalı.");
                return;
            }

            int yeniId = rezervasyonListesi.Count > 0 ? rezervasyonListesi.Max(r => r.Id) + 1 : 1;

            var yeniRezervasyon = new Reservation
            {
                Id = yeniId,
                OturanId = secilenKisi.Id,
                MekanId = secilenMekan.Id,
                BaslangicTarihi = dtBaslangic.Value.Date,
                BitisTarihi = dtBitis.Value.Date,
                OdendiMi = false
            };

            rezervasyonManager.RezervasyonEkle(yeniRezervasyon);
            rezervasyonListesi.Add(yeniRezervasyon);

            ListeleRezervasyonlar();

            MessageBox.Show("Rezervasyon oluşturuldu.");
        }

        private void ListeleRezervasyonlar()
        {
            lstRezervasyonlar.Items.Clear();

            foreach (var r in rezervasyonListesi)
            {
                var oturan = oturanListesi.FirstOrDefault(o => o.Id == r.OturanId);
                var mekan = mekanListesi.FirstOrDefault(m => m.Id == r.MekanId);

                string oturanAdi = oturan != null ? $"{oturan.Ad} {oturan.Soyad}" : "Bilinmiyor";
                string mekanAdi = mekan != null ? mekan.ToString() : "Bilinmiyor";

                string bilgi = $"#{r.Id}: {oturanAdi} - {mekanAdi} | {r.BaslangicTarihi:dd.MM.yyyy} - {r.BitisTarihi:dd.MM.yyyy} | Ödendi: {(r.OdendiMi ? "Evet" : "Hayır")}";
                lstRezervasyonlar.Items.Add(bilgi);
            }
        }

        private void lstRezervasyonlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = lstRezervasyonlar.SelectedIndex;
            if (idx < 0 || idx >= rezervasyonListesi.Count)
            {
                seciliRezervasyon = null;
                return;
            }

            seciliRezervasyon = rezervasyonListesi[idx];

            // Oturan ve mekan seçimini ayarla
            var oturanIdx = oturanListesi.FindIndex(o => o.Id == seciliRezervasyon.OturanId);
            if (oturanIdx >= 0) lstKisiler.SelectedIndex = oturanIdx;

            var mekanIdx = mekanListesi.FindIndex(m => m.Id == seciliRezervasyon.MekanId);
            if (mekanIdx >= 0) lstMekanlar.SelectedIndex = mekanIdx;

            dtBaslangic.Value = seciliRezervasyon.BaslangicTarihi;
            dtBitis.Value = seciliRezervasyon.BitisTarihi;
        }

        private void btnRezervasyonSil_Click(object sender, EventArgs e)
        {
            if (seciliRezervasyon == null)
            {
                MessageBox.Show("Silmek için rezervasyon seçin.");
                return;
            }

            var sonuc = MessageBox.Show("Seçilen rezervasyonu silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo);
            if (sonuc == DialogResult.Yes)
            {
                rezervasyonManager.RezervasyonSil(seciliRezervasyon.Id);
                rezervasyonListesi.Remove(seciliRezervasyon);
                ListeleRezervasyonlar();
                seciliRezervasyon = null;

                // Seçimleri temizle
                lstKisiler.SelectedIndex = -1;
                lstMekanlar.SelectedIndex = -1;
                dtBaslangic.Value = DateTime.Today;
                dtBitis.Value = DateTime.Today.AddDays(1);

                MessageBox.Show("Rezervasyon silindi.");
            }
            ((Form1)Application.OpenForms["Form1"]).OdenmisRezervasyonlariGuncelle();

        }

        private void btnRezervasyonGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliRezervasyon == null)
            {
                MessageBox.Show("Güncellemek için rezervasyon seçin.");
                return;
            }

            if (lstKisiler.SelectedIndex < 0 || lstMekanlar.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen kişi ve mekan seçin.");
                return;
            }

            var secilenKisi = oturanListesi[lstKisiler.SelectedIndex];
            var secilenMekan = mekanListesi[lstMekanlar.SelectedIndex];

            if (dtBitis.Value <= dtBaslangic.Value)
            {
                MessageBox.Show("Bitiş tarihi, başlangıç tarihinden sonra olmalı.");
                return;
            }

            // Güncellenen bilgileri ata
            seciliRezervasyon.OturanId = secilenKisi.Id;
            seciliRezervasyon.MekanId = secilenMekan.Id;
            seciliRezervasyon.BaslangicTarihi = dtBaslangic.Value.Date;
            seciliRezervasyon.BitisTarihi = dtBitis.Value.Date;

            rezervasyonManager.RezervasyonGuncelle(seciliRezervasyon);

            // Listeyi yeniden oku ve listele
            rezervasyonListesi = rezervasyonManager.RezervasyonlariOku();
            ListeleRezervasyonlar();

            MessageBox.Show("Rezervasyon güncellendi.");
        }
    }
}
