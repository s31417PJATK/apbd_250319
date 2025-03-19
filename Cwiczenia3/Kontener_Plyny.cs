namespace Cwiczenia3;

public class Kontener_Plyny : Kontener, IHazardNotifier
{
    private bool niebezpieczne;
    public Kontener_Plyny(double wysokosc, double wagaWlasna, double glebokosc, string numer_seryjny, double maksymalna_ladownosc) : base(wysokosc, wagaWlasna, glebokosc, numer_seryjny, maksymalna_ladownosc)
    {
    }

    public void Notify(string message)
    {
        Console.WriteLine("["+numer_seryjny+"] "+message);
    }

    public void Zaladuj(double masa, bool niebezpieczne)
    {
        if (niebezpieczne)
        {
            if (masa > 0.5*maksymalna_ladownosc) Notify("Próba załadowania zbyt dużej ilości niebezpiecznych płynów");
            else
            {
                this.masa = masa;
                this.niebezpieczne = true;
            }
        }
        else
        {
            if (masa > 0.9*maksymalna_ladownosc) Notify("Próba załadowania zbyt dużej ilości płynów");
            else
            {
                this.masa = masa;
                this.niebezpieczne = false;
            }
            
        }
    }
    public void Dane()
    {
        Console.WriteLine("Kontener na płyny ["+numer_seryjny+"] wysokość: "+wysokosc+"; glebokość: "+glebokosc+"; waga_własna: "+waga_wlasna+"; maksymalna ładowność: "+maksymalna_ladownosc+"; zawierający "+((niebezpieczne)?"niebezpieczny":"bezpieczny")+" towar o masie: "+masa);
    }
}