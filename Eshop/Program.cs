using Eshop;

var zbozi = new Dictionary<long, Zbozi>();

Bloky cansonAkvarelA4 = new Bloky()
{
    Cena = 204,
    Nazev = "Canson Akvarel A4",
    Vyrobce = "Canson",
    PocetNaSklade = 24,
    EAN = 978020137962
};

zbozi.Add(cansonAkvarelA4.EAN, cansonAkvarelA4 );