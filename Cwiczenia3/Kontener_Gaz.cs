namespace Cwiczenia3;

public class Kontener_Gaz : Kontener, IHazardNotifier
{
    public double cisnienie;
    public Kontener_Gaz(double wysokosc, double wagaWlasna, double glebokosc, string numer_seryjny, double maksymalna_ladownosc) : base(wysokosc, wagaWlasna, glebokosc, numer_seryjny, maksymalna_ladownosc)
    {
    }

    public void Notify(string message)
    {
        Console.WriteLine("["+numer_seryjny+"] "+message);
    }
    
    public void Oproznij() => this.masa = this.masa*0.05;

    public void Zaladuj(double masa,double cisnienie)
    {
        if (masa <= maksymalna_ladownosc)
        {
            this.masa = masa;
            this.cisnienie = cisnienie;
        }
        else
        {
            throw new OverfillException();
        }
    }
    
    public void Dane()
    {
        Console.WriteLine("Kontener na gaz ["+numer_seryjny+"] wysokość: "+wysokosc+"; glebokość: "+glebokosc+"; waga_własna: "+waga_wlasna+"; maksymalna ładowność: "+maksymalna_ladownosc+"; zawierający towar o masie: "+masa+" pod cisnieniem "+cisnienie);
    }
}