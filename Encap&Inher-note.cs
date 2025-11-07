/*
 * Kapsülleme(Encapsulation) ve Kalýtým(Inheritance)
 * 
 * Encapsulation:
 * Kapsülleme, bir nesnenin verilerini (alanlarýný) dýþ dünyadan
 * gizleme ve bu verilere eriþimi metotlar aracýlýðýyla kontrol etme
 * yöntemidir.
 *    Eriþim Belirleyiciler(Access Modifiers):
 *    - public: her yerden eriþilebilir.
 *    - private: yalnýzca tanýmlandýðý sýnýf içerisinden eriþilebilir.
 *    Bu, veriyi gizlemenin anahtarýdýr.
 *    
 *    Properties (Özellikler): Veriyi güvenli bir þekilde okuma ve yazma 
 *    için kullanýlýr. Genellikle public olur, ancak arka plandaki private
 *    alaný yönetir.
 *    
 */

/*
public class Musteri
{
    // Kapsüllenmiþ alan: sadece bu sýnýf içinde deðiþtirilebilir.
    private string _ad;

    // Public Property: Dýþ dünyaya kontrollü eriþim saðlar.
    public string Ad
    {
        get { return _ad; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                _ad = value; // Kontrol baþarýlýysa deðeri ata
            }
        }
    }

    // Auto-implemented Property: C# bunu otomatik olarak private bir alanla yönetir.
    public int MusteriID { get; private set; }
    // ID dýþarýdan okunabilir, ama sadece sýnýf içinden ayarlanabilir.
}

/*
 * Kalýtým (Inheritance) :
 *  Kalýtým, bir sýnýfýn (alt sýnýf/türetilmiþ sýnýf)
 *  baþka bir sýnýfýn (üst sýnýf/temel sýnýf) özelliklerini ve
 *  davranýþlarýný devralmasýna izin verir.
 *  Bu, kod tekrarýný azaltýr ve bir "bir ...'dýr" iliþkisini
 *  (örneðin: "Köpek bir Hayvan'dýr") temsil eder.
 */

/*
// Temel Sýnýf
public class Hayvan
{
    public void NefesAl()
    {
        Console.WriteLine("Nefes alýnýyor...");
    }
}

// Türetilmiþ Sýnýf: Hayvan'ýn özelliklerini devralýr.
public class Kopek : Hayvan // ":" Kalýtým operatörüdür
{
    public void Havla()
    {
        Console.WriteLine("Hav hav!");
    }
}

*/

// Program.cs'te
/*
Kopek kopegim = new Kopek();
kopegim.NefesAl(); // Hayvan sýnýfýndan gelen metot
kopegim.Havla();  // Kopek sýnýfýna ait metot
*/