﻿using Eshop;

var zbozi = new Dictionary<long, Zbozi>();

//zadávání položek do slovníku
Bloky cansonAkvarelA4 = new Bloky()
{
    Cena = 204,
    Nazev = "Canson Akvarel A4",
    Vyrobce = "Canson",
    PocetNaSklade = 24,
    EAN = 978020137,

    sirka = 21,
    vyska = 30,
    gramaz = 300,
    Varianta = Bloky.Varianty.Krouzkovy
};
zbozi.Add(cansonAkvarelA4.EAN, cansonAkvarelA4 );

Akvarel SchminckeSet = new Akvarel()
{
    Cena = 1200,
    Nazev = "Schmincke akvarel set",
    Vyrobce = "Schmincke",
    PocetNaSklade = 8,
    EAN = 524475885,

    JeVSade = true,
    TypAkvarelu = Akvarel.Typ.Tuba,
    PocetKusuVBaleni = 24
};
zbozi.Add(SchminckeSet.EAN, SchminckeSet );

//while smyčka obsahující celý program
bool jeKonec = false;
while (!jeKonec)
{
    Console.WriteLine("0 - konec programu");
    Console.WriteLine("1 - vypsat seznam položek");
    Console.WriteLine("2 - konec programu");
    Console.WriteLine("3 - konec programu");
    Console.WriteLine("4 - konec programu");
    int volba = Convert.ToInt32(Console.ReadLine());

    switch (volba)
    {
        case 0:
            jeKonec = true;
            break;
        case 1:
            foreach (var item in zbozi)
            {
                Console.Write($"{item.Key}\t{item.Value.Nazev}\t{item.Value.Cena},-Kč\t{item.Value.Vyrobce}");
                if (item.Value is Bloky)
                {
                    Bloky blok = (Bloky)item.Value;
                    Console.WriteLine($"\tBlok\t{blok.sirka}-{blok.vyska} cm\t{blok.Varianta}\t{blok.gramaz}");
                }
                if (item.Value is Akvarel)
                {
                    Akvarel akvarel = (Akvarel)item.Value;
                    string text;
                    if (akvarel.JeVSade)
                    {
                        text = "Sada " + akvarel.PocetKusuVBaleni + " Ks";
                    } else { text = "Jednotlivě"; }
                    Console.WriteLine($"\tAkvarel\t{akvarel.TypAkvarelu}\t{text}");
                }

            }
            break;
        case 2:
            break;
        case 3:
            break;
        default:
            Console.WriteLine("Nebylo zadáno správné číslo, zadejte číslo od 0 do 4");
            break;
    }
}