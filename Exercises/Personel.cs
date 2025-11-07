// base model for encapsulation ve inheritance

public abstract class Personel
{
    public string Ad { get; set; }

    // Id'yi dýþarýdan  sadece okutmak, atamayý içeride tutmak (kapsülleme)
    // Yani Id'nin dýþarýdan ayarlanmasýný engelledim.
    public string Id { get; private set; }

    private decimal _maas; //private alan (gizlenen veri)

    abstract public decimal MaasHesapla(int calismaSaati);

    public decimal Maas { 
        get { return _maas; }

        set
        {
            // kapsülleme burada devreye giriyor: Kontrolsüz atamaya izin vermiyoruz.
            // atanan deðeri kontrol et (value > 0)
            if (value > 0)
            {
                _maas = value; // geçerliyse private alana ata
            }
            else
            {
                Console.WriteLine("Maaþ sýfýrdan küçük veya sýfýr olamaz.");
            }
        }
    }

    // Personel nesnesi oluþturulurken Id'nin ayarlanabilmesi için Kurucu Metot (Constructor) ekleyelim.

    public Personel(string id)
    {
        this.Id = id; // private set olduðu için sadece sýnýf içinden ayarlanabilir.
    }

    // parametresiz kurucu metot, miras almayý kolaylaþtýrmak için
    public Personel() { }

}
