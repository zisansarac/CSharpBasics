/*
 * Mantýk: Havale ile ödeme teþvik edildiði için %1 indirim yapýlýr.

OOP Ýliþkisi: Polimorfizm. Ayný metot (Hesapla), farklý bir sonuç üretiyor.
*/

public class HavaleOdemesi:IOdeme
{
    public decimal Hesapla(decimal tutar)
    {
        decimal indirim = tutar * 0.01m;
        return tutar - indirim;
    }
}