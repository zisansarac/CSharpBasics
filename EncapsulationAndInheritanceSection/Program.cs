
Yazilimci yazilimci = new Yazilimci();

yazilimci.Ad = "Zisan Sarac";
// private set olduğu için id atayamayız.
yazilimci.Maas = 40000;
yazilimci.ProgramlamaDili = "C# / ASP.NET Core";

Console.WriteLine("Gecersiz Maaş Ataması Testi");
yazilimci.Maas = -100;
Console.WriteLine($"Maas degeri kontrol sonrasi: {yazilimci.Maas}");

// Sonuçları Yazdırma: 
Console.WriteLine("\n -- Yazilimci Bilgileri --");
Console.WriteLine($"Ad:{yazilimci.Ad}");
// Id'yi doğru bir şekilde atamadığımız için varsayılan değeri (null veya 0) gösterecektir.
Console.WriteLine($"Id:{yazilimci.Id}");
Console.WriteLine($"Maas: {yazilimci.Maas} TL");
Console.WriteLine($"Uzmanlık Alanı: {yazilimci.ProgramlamaDili}");

