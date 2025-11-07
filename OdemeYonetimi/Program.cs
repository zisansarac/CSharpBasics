/*
 * Mantık: Sistemimizde farklı ödeme tipleri olabilir, ama biz onları IOdeme (ödeme yeteneğine sahip) tek bir tip altında toplayıp yönetmek istiyoruz.
 * 
*/

decimal siparisTutari = 1000m;

// IOdeme tipinde bir liste oluşturuyoruz. 
// Bu liste, IOdeme sözleşmesini uygulayan her şeyi tutabilir. (Polimorfizm!)
List<IOdeme> odemeYontemleri = new List<IOdeme>();

// Farklı sınıflardan nesneleri, ortak arayüz tipiyle listeye ekliyoruz.
odemeYontemleri.Add(new KrediKartiOdemesi());
odemeYontemleri.Add(new HavaleOdemesi());

Console.WriteLine($"--- 1000 TL'lik Sipariş İçin Ödeme Hesaplamaları ---");
Console.WriteLine("-----------------------------------------------------");

foreach (IOdeme odeme in odemeYontemleri)
{
    // Polimorfizm! odeme.Hesapla() çağrısı, nesnenin gerçek tipine göre (KrediKarti ya da Havale)
    // farklı sonuç verecek. Kodu değiştirmeden farklı mantıkları çalıştırıyoruz.

    decimal sonTutar = odeme.Hesapla(siparisTutari);

    // Nesnenin gerçek tipini yazdırmak için GetType().Name kullanılır.
    Console.WriteLine($"Ödeme Yöntemi: {odeme.GetType().Name}");
    Console.WriteLine($"Komisyon/İndirim Sonrası Tutar: {sonTutar:C}");
    Console.WriteLine("-----------------------------------------------------");

}
