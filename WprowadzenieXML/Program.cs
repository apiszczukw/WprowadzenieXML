// See https://aka.ms/new-console-template for more information

using WprowadzenieXML.Helpers;
using WprowadzenieXML.Klasy;

string sciezkaXML = Path.Combine(AppContext.BaseDirectory, "osoby.xml");

var uczestnicy = XmlManager.DeserializujXML<Uczestnicy>(sciezkaXML);

foreach (var osoba in uczestnicy.ListaOsob)
{
    Console.WriteLine($"{osoba.Lp}. {osoba.Nazwisko} {osoba.Imie}");
    Console.WriteLine("Kierunek: " + osoba.Kierunek);
    Console.WriteLine("Stypendium: " + osoba.Stypendium);
    Console.WriteLine("Dojazd: " + osoba.Dojazd);

    Console.Write("Przedmioty: ");
    foreach (var przedmiot in osoba.Przedmioty)
    {
        Console.Write($"{przedmiot.Nazwa}({przedmiot.IleGodzin}), ");
    }

    Console.WriteLine("\n\n----------------------------------");
}

Console.ReadKey();
