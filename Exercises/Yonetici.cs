public class Yonetici : Personel
{
    public Yonetici() : base() { } // Basitlik için parametresiz kurucu

    // Metot imzasý düzeltildi.
    public override decimal MaasHesapla(int calismaSaati)
    {
        // 20.000 TL prim eklendi.
        return ((decimal)calismaSaati * 750m) + 20000m;
    }

}