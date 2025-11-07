Console.WriteLine("\n--- Polimorfizm Testi: Maaş Hesaplama ---");

// Yeni, isimlendirilmiş nesneler oluşturulur
Yazilimci yazilimci1 = new Yazilimci() { Ad = "Zisan YAZ", Id = "Y101" };
Yonetici yonetici1 = new Yonetici() { Ad = "Ahmet YON", Id = "Y202" };

// Personel tipinde bir liste tutuyoruz (Polimorfizm burada!)
// Her iki nesne de farklı sınıflardan türemiş olsa da, ana tip (Personel) olarak işlem görüyor.
List<Personel> personeller = new List<Personel>();
personeller.Add(yazilimci1);
personeller.Add(yonetici1);

int calismaSaati = 160;

foreach (Personel personel in personeller)
{
    // Hangi nesne çağrılırsa (Yazilimci ya da Yonetici), 
    // o nesnenin kendi MaasHesapla metodu çalışır (Override).
    decimal maas = personel.MaasHesapla(calismaSaati);

    Console.WriteLine($"Personel Adı: {personel.Ad}");
    Console.WriteLine($"ID: {personel.Id}");
    Console.WriteLine($"Tipi: {personel.GetType().Name}"); // Gerçek sınıf adını yazdırma
    Console.WriteLine($"160 Saatlik Maaş: {maas:C}"); // :C para birimi formatında yazdırır
    Console.WriteLine("-----------------------------");
}

