namespace Cwiczenia3;

public class Kontener_Chlodnia : Kontener
{
    private string rodzaj_produktu { get; set; }
    private double temperatura { get; set; }
    private Dictionary<string,double> min_temperatura = new Dictionary<string, double>()
    {
        {"Bananas",13.3},
        {"Chocolate",18},
        {"Fish",2},
        {"Meat",-15},
        {"Ice cream",-18},
        {"Frozen pizza",-30},
        {"Cheese",7.2},
        {"Sausages",5},
        {"Butter",20.5},
        {"Eggs",19}
    };

    public Kontener_Chlodnia(double wysokosc, double wagaWlasna, double glebokosc, string numer_seryjny, double maksymalna_ladownosc, string rodzajProduktu, double temperatura) : base(wysokosc, wagaWlasna, glebokosc, numer_seryjny, maksymalna_ladownosc)
    {
        rodzaj_produktu = rodzajProduktu;
        if (temperatura < min_temperatura[rodzajProduktu])
        {
            this.temperatura = min_temperatura[rodzajProduktu];
        }
        else
        {
            this.temperatura = temperatura;
        }
    }

    public void Zaladuj(double masa,string produkt)
    {
        if (produkt == rodzaj_produktu)
        {
            if (masa <= maksymalna_ladownosc)
            {
                this.masa = masa;
            }
            else
            {
                throw new OverfillException();
            }
        } else Console.WriteLine("["+numer_seryjny+"] Kontener może przechowywać tylko produkty typu "+rodzaj_produktu);
    }
    
    public void Dane()
    {
        Console.WriteLine("Kontener chłodniczy ["+numer_seryjny+"] na "+rodzaj_produktu+" wysokość: "+wysokosc+"; glebokość: "+glebokosc+"; waga_własna: "+waga_wlasna+"; maksymalna ładowność: "+maksymalna_ladownosc+"; temperatura: "+temperatura+"; zawierający towar o masie: "+masa);
    }
}