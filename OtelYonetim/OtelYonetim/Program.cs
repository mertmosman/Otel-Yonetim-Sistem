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
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}