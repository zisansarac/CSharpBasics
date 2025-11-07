
// arayüz (interface)

// abstraction ýn ilk adýmýdýr. Bu arayüz odeme sistemimizde olmasý gereken zorunlu yeteneði (hesaplama yeteneði) tanýmlar.
// Mantýk: "Ödeme alabilen her þey, bir ödeme tutarýný hesaplayabilmelidir."
// Karmaþýk komisyon/indirim mantýklarýný gizliyoruz ve sadece "Hesapla" diye bir fonksiyonun varlýðýný garanti ediyoruz.

public interface IOdeme
{
    // arayüzler sadece sözleþme imzasý içerir, gövdesi yoktur.
    // deci tutar alýr ve deci sonuç döndürür.
    decimal Hesapla(decimal tutar);
}