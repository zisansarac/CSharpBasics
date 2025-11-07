
/*
 * Soyut Sýnýflar (abstract class)
 *     Soyutlama, karmaþýk detaylarý gizleyerek yalnýzca gerekli iþlevselliði gösterme sürecidir.
 *     C#'ta bu, genellikle Soyut Sýnýflar (abstract class) ve Arayüzler (interface) ile yapýlýr.
 *     
 *     Soyut Sýnýflar (abstract class)
 *       Amaç: Hem kalýtým almak hem de bir þeylerin nasýl yapýlacaðýný (metot) zorunlu kýlmak için kullanýlýr.
 *       Kural: Soyut sýnýflarýn doðrudan nesnesi oluþturulamaz (new AbstractSinif()).
 *       Zorunluluk: Soyut metotlar (abstract method), türetilmiþ sýnýflar tarafýndan zorunlu olarak override edilmelidir.
 *  
 
// ORNEK: 
 
public abstract class Sekil // Doðrudan nesnesi oluþturulamaz
{
    // Soyut metot: Gövdesi yoktur. Türetilen sýnýf bunu uygulamak ZORUNDADIR.
    public abstract double AlanHesapla(); 

    // Normal metotlar da içerebilir
    public void BilgiYazdir()
    {
        Console.WriteLine("Bu bir geometrik þekildir.");
    }
}

public class Dikdortgen : Sekil
{
    private double Genislik { get; set; }
    private double Yukseklik { get; set; }

    // Soyut metodu uygulamak (override etmek) zorunludur.
    public override double AlanHesapla() 
    {
        return Genislik * Yukseklik;
    }
}

*/

/*
 * Arayüzler (Interfaces) :
 *    Amaç: Sadece bir sözleþme (contract) veya bir yetenek listesi tanýmlar. "Bu nesne bu iþleri yapabilmeli." der.
 *    Kural: Arayüzler metotlarýn yalnýzca imzalarýný (ad, parametreler, dönüþ tipi) içerir, gövdesi (uygulamasý) yoktur.
 *    Uygulama: Bir sýnýf bir arayüzü uyguladýðýnda (class BenimSinifim : IArayuz), arayüzdeki tüm metotlarý uygulamak zorundadýr.
 *    
 *    ÖRNEK: 
 
// Arayüzler genellikle 'I' (Interface) ile baþlar.

public interface IKonsolYazici 
{
    void Yazdir(string mesaj); // Sadece imza var, gövdesi yok.
}

public class RaporServisi : IKonsolYazici
{
    // Arayüzü uygulamak zorunludur.
    public void Yazdir(string mesaj)
    {
        Console.WriteLine($"Rapor Yazdýrýldý: {mesaj}");
    }
}

Arayüzler, özellikle ASP.NET Core'un temelini oluþturan Dependency Injection (Baðýmlýlýk Enjeksiyonu) konusunda hayati öneme sahiptir.
