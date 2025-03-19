namespace Cwiczenia3;

public class Kontener
{
    public double masa;
    public double wysokosc;
    public double waga_wlasna;
    public double glebokosc;
    public String numer_seryjny;
    public double maksymalna_ladownosc;

    public Kontener(double wysokosc,double wagaWlasna,double glebokosc,String numer_seryjny, double maksymalna_ladownosc)
    {
        this.wysokosc = wysokosc;
        this.waga_wlasna = wagaWlasna;
        this.glebokosc = glebokosc;
        this.numer_seryjny = numer_seryjny;
        this.maksymalna_ladownosc = maksymalna_ladownosc;
    }

    public void Oproznij()
    {
        this.masa = 0;
    }

    public void Zaladuj(double masa)
    {
        if (masa <= maksymalna_ladownosc)
        {
            this.masa = masa;
        }
        else
        {
            throw new OverfillException();
        }
    }

    public void Dane()
    {
        Console.WriteLine("Kontener ["+numer_seryjny+"] wysokość: "+wysokosc+"; glebokość: "+glebokosc+"; waga_własna: "+waga_wlasna+"; maksymalna ładowność: "+maksymalna_ladownosc+"; zawierający towar o masie: "+masa);
    }
}