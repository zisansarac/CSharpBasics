// Polimorfizm (Çok Biçimlilik)

/*
 * Farklý nesnelerin ayný mesaja (metot çaðrýsý) farklý þekillerde cevap vermesi yeteneðidir.
 * 
 * Metot Ezme (Method Overriding)
 *     Kalýtým aldýðýmýz temel sýnýftaki bir metodu, türetilmiþ sýnýfta baþka bir mantýkla yeniden yazmaktýr.
 *     "virtual": Temel sýnýfta, bu metodun türetilmiþ sýnýflarda ezilebileceðini (override) belirtir.
 *     "override": Türetilmiþ sýnýfta, temel sýnýftaki virtual metodu yeniden yazdýðýmýzý belirtir.
 *     
 *      ÖRNEK:
 
 // Temel Sýnýf
public class Hayvan
{
    // Bu metot ezilmeye (override) açýktýr.
    public virtual void SesCikar() 
    {
        Console.WriteLine("Hayvan sesi çýkarýyor.");
    }
}

// Türetilmiþ Sýnýf
public class Kopek : Hayvan
{
    // Temel sýnýftaki metodu kendi mantýðý ile eziyor.
    public override void SesCikar() 
    {
        Console.WriteLine("Köpek: Hav hav!");
    }
}

// Türetilmiþ Sýnýf
public class Kedi : Hayvan
{
    // Temel sýnýftaki metodu kendi mantýðý ile eziyor.
    public override void SesCikar()
    {
        Console.WriteLine("Kedi: Miyav miyav!");
    }
}

// Hayvan türünde bir liste tutuyoruz, bu Polimorfizmdir!
List<Hayvan> hayvanlar = new List<Hayvan>();
hayvanlar.Add(new Kopek()); // Köpek, bir Hayvan'dýr.
hayvanlar.Add(new Kedi());  // Kedi, bir Hayvan'dýr.

foreach (Hayvan hayvan in hayvanlar)
{
    // Hangi nesneyi çaðýrýrsak, o nesnenin kendi SesCikar metodunu çalýþtýrýr.
    hayvan.SesCikar(); // Çýktý: "Köpek: Hav hav!" sonra "Kedi: Miyav miyav!"
}