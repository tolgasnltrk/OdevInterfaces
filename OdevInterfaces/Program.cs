
using OdevInterfaces;

Site site1 = new Site()
{
    DaireNo = 1,
    KatSayisi = 0,
    OdaSayisi = " 4 + 1",
    Blok = new Blok()
    {
        BlokNo = "A1"
    }
};

Console.WriteLine
    (
    " Blok No:" + site1.Blok.BlokNo + " " +
    " Daire No:" + site1.DaireNo + " " +
    " Kat Sayısı:" + site1.KatSayisi + " " +
    " Oda Sayısı:" + site1.OdaSayisi + " "
    );

Yazlik yazlik1 = new Yazlik()
{
    DaireNo = 2,
    BahceliMi = true ? "Bahçeli" : "Bahçesiz"

};

Console.WriteLine
    (
    " Daire No: " + " " + yazlik1.DaireNo + " " +
    " Bahçeli mi? " + " " + yazlik1.BahceliMi + "***"
    );

Apartman apartman1 = new Apartman()
{
    KatSayisi = 4,
    DaireNo = 3,
    OdaSayisi = "5 + 1"
};

Console.Write
    (
    " Kat Sayısı: " + " " + apartman1.KatSayisi + " " +
    " Daire No: " + " " + apartman1.DaireNo + " " +
    " Oda Sayısı: " + " " + apartman1.OdaSayisi + " "
    );


