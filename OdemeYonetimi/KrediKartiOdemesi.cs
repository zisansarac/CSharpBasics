// Þimdi iki farklý sýnýfýn birincisindeyiz. Bu sýnýflar IOdeme arayüzünü uyguladýklarý için
// zorunlu olarak Hesapla metodunu kendi mantýklarýyla yazmak zorundadýrlar.

/*
 * mantýk: Kredi kartý ödemelerinde banka komisyonu nedeniyle %2 ek maliyet olur.
 *  // polymorphism
 *  
 *  */

public class KrediKartiOdemesi: IOdeme
{
    public decimal Hesapla(decimal tutar)
    {
        decimal komisyon = tutar * 0.02m;
        return tutar + komisyon;
    }
}