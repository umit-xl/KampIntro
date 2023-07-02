using MyDictionary;
using System;
using System.Collections.Generic;

// Bir Dictionary örneği oluşturma.
Dictionary<string, int> dictionary = new Dictionary<string, int>();

// Dictionary'ye eleman ekleme.
dictionary.Add("elma", 50);
dictionary.Add("armut", 100);
dictionary.Add("portakal", 75);

// Dictionary'deki tüm elemanların yazdırılması.
foreach (KeyValuePair<string, int> kvp in dictionary)
{
    Console.WriteLine("Anahtar = {0}, Değer = {1}", kvp.Key, kvp.Value);
}

// Dictionary'deki belirli bir elemanın değerini güncelleme.
dictionary["elma"] = 30;

// Dictionary'deki belirli bir elemanın değerini yazdırma.
int value;
if (dictionary.TryGetValue("elma", out value))
{
    Console.WriteLine("elma değeri: {0}", value);
}
else
{
    Console.WriteLine("elma anahtarı yok.");
}




//Kendi Dictionary yapımızı oluşturalım. 

MyDictionary<int, string> musteriBilgileri = new MyDictionary<int, string>();

musteriBilgileri.Add(13, "Ümit");
musteriBilgileri.Add(25, "Alba");
musteriBilgileri.Add(30, "Ferit");

// Kendi oluşturduğumuz KeyValuePair adlı yapıyı çalıştırıp yazdırma işlemi yapalım.

MyKeyValuePair<int,string> myKeyValuePair = new MyKeyValuePair<int,string>();

foreach (MyKeyValuePair<int, string> item in musteriBilgileri)
{
    Console.WriteLine("Numara: " + item.Key + ", İsim: " + item.Value);
}






