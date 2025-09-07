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
    public partial class OturanForm : Form
    {
        private OturanManager oturanManager = new OturanManager();
        private List<Oturan> oturanListesi = new List<Oturan>();
        public OturanForm()
        {
            InitializeComponent();
        }

        private void ListeyiGuncelle()
        {
            lstOturanlar.Items.Clear();
            oturanListesi = oturanManager.OturanlariOku();

            foreach (var o in oturanListesi)
                lstOturanlar.Items.Add(o.ToString());
        }

        private int SecilenOturanId()
        {
            if (lstOturanlar.SelectedIndex == -1) return -1;

            // Format: "Ad Soyad [Tür] (#Id)"
            string secilen = lstOturanlar.SelectedItem.ToString();
            int start = secilen.IndexOf("(#") + 2;
            int end = secilen.IndexOf(")", start);
            string idStr = secilen.Substring(start, end - start);

            return int.TryParse(idStr, out int id) ? id : -1;
        }

        private void OturanlariListele()
        {
            lstOturanlar.Items.Clear();
            var liste = oturanManager.OturanlariOku();

            foreach (var o in liste)
            {
                lstOturanlar.Items.Add($"{o.Ad} {o.Soyad} [{o.Tur}] (#{o.Id})");
            }
        }


        private void OturanForm_Load(object sender, EventArgs e)
        {
            cmbTur.Items.AddRange(new[] { "AileReisi", "Standart", "Misafir" });
            cmbTur.SelectedIndex = 0;

            cmbTur.SelectedIndexChanged += cmbTur_SelectedIndexChanged;
            cmbBagli.Visible = false;

            ListeyiGuncelle();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // ID kontrolü
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Lütfen geçerli bir ID giriniz (sayı olmalı).", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ad ve Soyad boş mu?
            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text))
            {
                MessageBox.Show("Ad ve Soyad alanları boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tür seçilmiş mi?
            if (cmbTur.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir tür seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tur = cmbTur.SelectedItem.ToString();
            Oturan yeni;

            if (tur == "AileReisi")
            {
                yeni = new AileReisi();
            }
            else if (tur == "Misafir")
            {
                if (cmbBagli.SelectedItem == null)
                {
                    MessageBox.Show("Misafir için bağlı kişi seçilmelidir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                yeni = new Misafir
                {
                    BagliId = ((Oturan)cmbBagli.SelectedItem).Id
                };
            }
            else
            {
                yeni = new Oturan(); // Diğer türler için
            }

            // Bilgileri doldur
            yeni.Id = id;
            yeni.Ad = txtAd.Text.Trim();
            yeni.Soyad = txtSoyad.Text.Trim();

            // Kaydet
            oturanManager.OturanEkle(yeni);

            // Temizle
            txtId.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            cmbTur.SelectedIndex = -1;
            cmbBagli.SelectedIndex = -1;

            ListeyiGuncelle();

        }


        private void lstOturanlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOturanlar.SelectedIndex < 0) return;

            var secilen = oturanListesi[lstOturanlar.SelectedIndex];

            txtId.Text = secilen.Id.ToString();
            txtAd.Text = secilen.Ad;
            txtSoyad.Text = secilen.Soyad;
            cmbTur.SelectedItem = secilen.Tur;

            // Eğer Misafir ise BagliId'yi göster
            if (secilen is Misafir misafir)
            {
                cmbBagli.Enabled = true;
                cmbBagli.Visible = true;

                // Bağlı kişi listede varsa seç
                if (misafir.BagliId.HasValue)
                {
                    var bagli = oturanListesi.FirstOrDefault(o => o.Id == misafir.BagliId.Value);
                    if (bagli != null)
                        cmbBagli.SelectedItem = bagli;
                }
                else
                {
                    cmbBagli.SelectedIndex = -1;
                }
            }
            else
            {
                cmbBagli.Enabled = false;
                cmbBagli.Visible = false;
                cmbBagli.SelectedIndex = -1;
            }
        }

        private void cmbTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBagli.Items.Clear();
            cmbBagli.Visible = cmbTur.SelectedItem?.ToString() == "Misafir";

            if (cmbBagli.Visible)
            {
                var baglanabilirler = oturanManager.OturanlariOku()
                    .Where(o => !(o is Misafir)).ToList();

                foreach (var kisi in baglanabilirler)
                    cmbBagli.Items.Add(kisi); // ToString ile gösterilir
            }
        }

        private void cmbBagli_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = SecilenOturanId();
            if (id == -1)
            {
                MessageBox.Show("Lütfen silmek için bir kişi seçiniz.");
                return;
            }

            DialogResult sonuc = MessageBox.Show("Bu kişiyi silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
            if (sonuc == DialogResult.Yes)
            {
                oturanManager.OturanSil(id);
                OturanlariListele(); // listeyi güncelle
                MessageBox.Show("Kişi silindi.");
            }
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstOturanlar.SelectedIndex < 0) return;

            int seciliIndex = lstOturanlar.SelectedIndex;
            int id = int.Parse(txtId.Text);
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string tur = cmbTur.SelectedItem.ToString();

            Oturan guncellenecek;

            if (tur == "Misafir")
            {
                int? bagliId = null;
                if (cmbBagli.SelectedItem != null)
                {
                    var secilen = cmbBagli.SelectedItem as Oturan;
                    bagliId = secilen?.Id;
                }

                guncellenecek = new Misafir
                {
                    Id = id,
                    Ad = ad,
                    Soyad = soyad,
                    BagliId = bagliId
                };
            }
            else if (tur == "AileReisi")
            {
                guncellenecek = new AileReisi
                {
                    Id = id,
                    Ad = ad,
                    Soyad = soyad
                };
            }
            else
            {
                guncellenecek = new Oturan
                {
                    Id = id,
                    Ad = ad,
                    Soyad = soyad
                };
            }

            // Listeyi güncelle
            oturanListesi[seciliIndex] = guncellenecek;

            // Dosyaya yaz
            File.WriteAllText("Data.txt", "");
            foreach (var o in oturanListesi)
            {
                oturanManager.OturanEkle(o);
            }

            OturanlariListele();
            MessageBox.Show("Kişi başarıyla güncellendi.");
        }
    }
}
