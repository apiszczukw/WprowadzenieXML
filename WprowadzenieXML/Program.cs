// See https://aka.ms/new-console-template for more information

using WprowadzenieXML.Helpers;
using WprowadzenieXML.Klasy;

string sciezkaXML = Path.Combine(AppContext.BaseDirectory, "osoby.xml");

var uczestnicy = XmlManager.DeserializujXML<Uczestnicy>(sciezkaXML);

foreach (var osoba in uczestnicy.ListaOsob)
{
    Console.WriteLine($"{osoba.Nazwisko} {osoba.Imie}");
}


