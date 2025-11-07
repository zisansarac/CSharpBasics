
public class Yazilimci : Personel
{
    public string ProgramlamaDili { get; set; }

    // Kurucu metot: Temel sýnýfýn (Personel) kurucusunu çaðýrmak zorundayýz.
    public Yazilimci(string id) : base(id) { }
    // veya basitlik için parametresiz kurucuyu kullanalým (Personel() eklediðiniz için):
    public Yazilimci() : base() { }

    // Metot imzasý düzeltildi: decimal dönmeli ve int parametre almalý.
    public override decimal MaasHesapla(int calismaSaati)
    {
        // Not: Tüm sabitleri decimal yapmak C#'ta iyi bir pratik.
        return (decimal)calismaSaati * 500m;
    }
} 