/****************************************************************************
**					SAKARYA ÜNÝVERSÝTESÝ
**				BÝLGÝSAYAR VE BÝLÝÞÝM BÝLÝMLERÝ FAKÜLTESÝ
**				    BÝLGÝSAYAR MÜHENDÝSLÝÐÝ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSÝ
**					2014-2015 BAHAR DÖNEMÝ
**	
**				ÖDEV NUMARASI..........: PROJE
**				ÖÐRENCÝ ADI............: MUHAMMED OSMAN MERT
**				ÖÐRENCÝ NUMARASI.......: B241210350
**                         DERSÝN ALINDIÐI GRUP: 1/B
****************************************************************************/
namespace OtelYonetim
{
    public partial class Form1 : Form
    {
        private ReservationManager rezervasyonManager = new ReservationManager();
        private List<Reservation> odenmisRezervasyonlar = new List<Reservation>();
        public Form1()
        {
            InitializeComponent();
        }

        public void ListeyiGuncelle()
        {
            // Havuz kullananlar
            lstHavuzKullananlar.Items.Clear();
            if (File.Exists("HavuzKul.txt"))
            {
                var havuzSatirlari = File.ReadAllLines("HavuzKul.txt");
                lstHavuzKullananlar.Items.AddRange(havuzSatirlari);
            }

            // Fitness kullananlar
            lstFitnessKullananlar.Items.Clear();
            if (File.Exists("Fitness.txt"))
            {
                var fitnessSatirlari = File.ReadAllLines("Fitness.txt");
                lstFitnessKullananlar.Items.AddRange(fitnessSatirlari);
            }
        }

        private void OdenmisRezervasyonlariYukle()
        {
            odenmisRezervasyonlar = rezervasyonManager.RezervasyonlariOku()
                                                      .Where(r => r.OdendiMi)
                                                      .ToList();

            lstOdenmisRezervasyonlar.Items.Clear();
            lstOdenmisRezervasyonlar.Items.AddRange(odenmisRezervasyonlar.ToArray());
        }

        private void btnMekan_Click(object sender, EventArgs e)
        {
            MekanForm form = new MekanForm();
            form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OdenmisRezervasyonlariGuncelle();
            ListeyiGuncelle();
        }

        public void OdenmisRezervasyonlariGuncelle()
        {
            OdenmisRezervasyonlariYukle();
        }

        private void btnOturan_Click(object sender, EventArgs e)
        {
            OturanForm form = new OturanForm();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RezervasyonForm frm = new RezervasyonForm();
            frm.ShowDialog();
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            OdemeForm odemeForm = new OdemeForm();
            odemeForm.Form1Referans = this;
            odemeForm.Show();
        }

        private void btnHavuz_Click(object sender, EventArgs e)
        {
            new HavuzForm().ShowDialog();
        }

        private void btnFitness_Click(object sender, EventArgs e)
        {
            new FitnessForm().ShowDialog();
        }
    }
}
