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
    public class Reservation
    {
        public int Id { get; set; }
        public int OturanId { get; set; }
        public int MekanId { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public bool OdendiMi { get; set; } = false;

        public decimal OdenenTutar { get; set; } = 0;

        public decimal KalanTutar => ToplamTutar - OdenenTutar;

        public int GunSayisi => (BitisTarihi - BaslangicTarihi).Days;

        public decimal GunlukUcret { get; set; } = 500; // sabit ücret varsayalım

        public decimal ToplamTutar => GunSayisi * GunlukUcret;

        public override string ToString()
        {
            return $"Rezervasyon #{Id} - OturanID: {OturanId} - MekanID: {MekanId} - {BaslangicTarihi:dd.MM.yyyy} - {BitisTarihi:dd.MM.yyyy} - Ödendi: {(OdendiMi ? "Evet" : "Hayır")} - Kalan Borç: {KalanTutar} TL";
        }
    }
}
