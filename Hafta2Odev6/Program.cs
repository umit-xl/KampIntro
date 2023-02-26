class Urun
{
    public string UrunAdi { get; set; }
    public int UrunFiyati { get; set; }
    public int StokAdedi { get; set; }

}

class Program
{
    static void Main(string[] args)
    {
        Urun urun1= new Urun();
        Urun urun2= new Urun();
        Urun urun3= new Urun();
        Urun urun4= new Urun();

        urun1.UrunAdi = "Monitör";
        urun1.UrunFiyati = 3000;
        urun1.StokAdedi = 10;

        urun2.UrunAdi = "Klavye";
        urun2.UrunFiyati = 200;
        urun2.StokAdedi = 100;

        urun3.UrunAdi = "Ekran Kartı";
        urun3.UrunFiyati=3000;
        urun3.StokAdedi = 20;

        urun4.UrunAdi = "İşlemci";
        urun4.UrunFiyati = 3500;
        urun4.StokAdedi = 30;

        Urun [] urunler = new Urun[] {urun1, urun2,urun3, urun4};

        foreach (var item in urunler)
        {
            Console.WriteLine(item.UrunAdi + " = " + item.UrunFiyati + " TL -  " + " Stok Adedi : " + item.StokAdedi);
        }

        Console.WriteLine("------------------------------------- Döngü Sonu -----------------------------------");

        for (int i = 0; i < urunler.Length; i++)
        {
            Console.WriteLine(urunler[i].UrunAdi + " = " + urunler[i].UrunFiyati + " TL -  " + " Stok Adedi : " + urunler[i].StokAdedi);
        }

        Console.WriteLine("------------------------------------- Döngü Sonu -----------------------------------");

        int urunListele = 0;
        while (urunListele < urunler.Length)
        {
            Console.WriteLine(urunler[urunListele].UrunAdi + " = " + urunler[urunListele].UrunFiyati + " TL -  " + " Stok Adedi : " + urunler[urunListele].StokAdedi);
            urunListele++;
        }
        
    }
}