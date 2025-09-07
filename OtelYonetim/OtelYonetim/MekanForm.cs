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

    public partial class MekanForm : Form
    {
        MekanManager mekanManager = new MekanManager();
        List<Mekan> mekanListesi = new List<Mekan>();
        public MekanForm()
        {
            InitializeComponent();
        }

        private void MekanForm_Load(object sender, EventArgs e)
        {
            cmbTur.Items.Clear();
            cmbTur.Items.Add("Daire");
            cmbTur.Items.Add("Fitness");
            cmbTur.Items.Add("Havuz");
            cmbTur.SelectedIndex = 0; // Varsayılan seçim: Daire

            MekanlariListele();
        }

        private void MekanlariListele()
        {
            lstMekanlar.Items.Clear();
            mekanListesi = mekanManager.MekanlariOku();

            foreach (var m in mekanListesi)
            {
                lstMekanlar.Items.Add(m);
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            // ID kontrolü
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Lütfen geçerli bir ID giriniz (sayı olmalı).", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ad ve Konum boş bırakılmamalı
            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtKonum.Text))
            {
                MessageBox.Show("Ad ve Konum alanları boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tür seçimi yapılmış mı?
            string tur = cmbTur.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(tur))
            {
                MessageBox.Show("Lütfen bir mekan türü seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mekan nesnesi oluşturuluyor
            Mekan m = null;

            if (tur == "Daire")
                m = new Daire();
            else if (tur == "Fitness")
                m = new Fitness();
            else if (tur == "Havuz")
                m = new HavuzKul();

            if (m != null)
            {
                m.Id = id;
                m.Ad = txtAd.Text.Trim();
                m.Konum = txtKonum.Text.Trim();
                m.Tur = tur;

                mekanManager.MekanEkle(m);
                MekanlariListele();

                // Temizlik
                txtId.Clear();
                txtAd.Clear();
                txtKonum.Clear();
                cmbTur.SelectedIndex = -1;

                MessageBox.Show("Mekan başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lstMekanlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Mekan seçildiğinde detayları göster
            if (lstMekanlar.SelectedIndex >= 0)
            {
                var secilen = mekanListesi[lstMekanlar.SelectedIndex];
                txtId.Text = secilen.Id.ToString();
                txtAd.Text = secilen.Ad;
                txtKonum.Text = secilen.Konum;

                // Eğer türünü de göstermek istersen:
                cmbTur.SelectedItem = secilen.GetType().Name;
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //Mekan güncelleme işlemi
            if (lstMekanlar.SelectedIndex >= 0)
            {
                Mekan guncellenecek;

                switch (cmbTur.SelectedItem.ToString())
                {
                    case "Daire":
                        guncellenecek = new Daire();
                        break;
                    case "Havuz":
                        guncellenecek = new HavuzKul();
                        break;
                    case "Fitness":
                        guncellenecek = new Fitness();
                        break;
                    default:
                        MessageBox.Show("Tür seçilmedi.");
                        return;
                }

                guncellenecek.Id = int.Parse(txtId.Text);
                guncellenecek.Ad = txtAd.Text;
                guncellenecek.Konum = txtKonum.Text;

                mekanListesi[lstMekanlar.SelectedIndex] = guncellenecek;

                File.WriteAllText("Mekan.txt", "");
                foreach (var m in mekanListesi)
                {
                    mekanManager.MekanEkle(m);
                }

                MekanlariListele();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstMekanlar.SelectedIndex >= 0)
            {
                mekanListesi.RemoveAt(lstMekanlar.SelectedIndex);
                File.WriteAllText("Mekan.txt", "");
                foreach (var m in mekanListesi)
                {
                    mekanManager.MekanEkle(m);
                }

                MekanlariListele();
            }
        }


    }
}
