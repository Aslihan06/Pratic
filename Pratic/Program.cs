using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

class Araba
{
    // Araba özellikleri
    public DateTime UretimTarihi { get; private set; }
    public string SeriNumarasi { get; set; }
    public string Marka { get; set; }
    public string Model { get; set; }
    public string Renk { get; set; }
    public int KapiSayisi { get; set; }

    // Constructor ile üretim tarihini otomatik atıyoruz
    public Araba()
    {
        UretimTarihi = DateTime.Now;
    }
}

class Program
{
    static void Main()
    {
        List<Araba> arabalar = new List<Araba>();
        string cevap;

    // Araba üretmek isteyip istemediğini sormak
    Baslangic:
        Console.Write("Araba üretmek istiyor musunuz? (e/h): ");
        cevap = Console.ReadLine().ToLower();

        if (cevap == "h")
        {
            Console.WriteLine("Program sonlandırıldı.");
            return;
        }
        else if (cevap != "e")
        {
            Console.WriteLine("Geçersiz cevap! Lütfen 'e' ya da 'h' giriniz.");
            goto Baslangic;
        }

        while (cevap == "e")
        {
            Araba yeniAraba = new Araba();

            // Araba bilgilerini kullanıcıdan al
            Console.Write("Seri Numarası: ");
            yeniAraba.SeriNumarasi = Console.ReadLine();

            Console.Write("Marka: ");
            yeniAraba.Marka = Console.ReadLine();

            Console.Write("Model: ");
            yeniAraba.Model = Console.ReadLine();

            Console.Write("Renk: ");
            yeniAraba.Renk = Console.ReadLine();

        KapiSayisi:
            try
            {
                Console.Write("Kapı Sayısı: ");
                yeniAraba.KapiSayisi = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Geçersiz giriş! Lütfen sayısal bir değer giriniz.");
                goto KapiSayisi;
            }

            // Arabayı listeye ekle
            arabalar.Add(yeniAraba);

        // Yeni araba üretmek isteyip istemediğini tekrar sor
        TekrarSor:
            Console.Write("Başka bir araba üretmek istiyor musunuz? (e/h): ");
            cevap = Console.ReadLine().ToLower();

            if (cevap == "h")
            {
                break;
            }
            else if (cevap != "e")
            {
                Console.WriteLine("Geçersiz cevap! Lütfen 'e' ya da 'h' giriniz.");
                goto TekrarSor;
            }
        }

        // Arabaların seri numaraları ve markalarını yazdırma
        Console.WriteLine("\nÜretilen Arabalar:");
        foreach (var araba in arabalar)
        {
            Console.WriteLine($"Seri Numarası: {araba.SeriNumarasi}, Marka: {araba.Marka}");
        }
    }
}
