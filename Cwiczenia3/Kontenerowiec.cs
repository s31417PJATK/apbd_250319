namespace Cwiczenia3;

public class Kontenerowiec
{
    public string nazwa;
    public double predkosc;
    public int maks_kontenerow;
    public double maks_waga_kontenerow;
    private HashSet<Kontener> kontenery = new HashSet<Kontener>();
    private double waga;
    private int ilosc_kontenerow;

    public Kontenerowiec(string nazwa, double predkosc, int maksKontenerow, double maksWaga_kontenerow)
    {
        this.nazwa = nazwa;
        this.predkosc = predkosc;
        this.maks_kontenerow = maksKontenerow;
        this.maks_waga_kontenerow = maksWaga_kontenerow;
        waga = 0;
        ilosc_kontenerow = 0;
    }

    public void Zaladuj_kontener(Kontener kontener)
    {
        if (ilosc_kontenerow + 1 <= maks_kontenerow)
        {
            if (waga + kontener.waga_wlasna + kontener.masa <= maks_waga_kontenerow)
            {
                ilosc_kontenerow++;
                waga += kontener.waga_wlasna + kontener.masa;
                kontenery.Add(kontener);
            } else Console.WriteLine("{"+nazwa+"} Nie można załadować więcej kontenerów. Osiągnięta maksymalna ładowność");
        } else Console.WriteLine("{"+nazwa+"} Nie można załadować więcej kontenerów. Osiągnięta maksymalna ilość kontenerów");
    }

    public void Zaladuj_kontener(List<Kontener> kontenery)
    {
        foreach (Kontener k in kontenery)
            Zaladuj_kontener(k);
    }

    public void Wyladuj_kontener(Kontener kontener)
    {
        if (kontenery.Contains(kontener))
        {
            kontenery.Remove(kontener);
            waga -= kontener.waga_wlasna + kontener.masa;
            ilosc_kontenerow--;
        }
    }

    public void Wyladuj()
    {
        foreach (Kontener k in kontenery)
        {
            Wyladuj_kontener(k);
        }
    }

    public void Zastap_kontener(Kontener kontener1, Kontener kontener2)
    {
        if (kontenery.Contains(kontener1))
        {
            Wyladuj_kontener(kontener1);
            Zaladuj_kontener(kontener2);
        }
    }

    public void Dane()
    {
        Console.WriteLine("Kontenerowiec {"+nazwa+"} prędkość maksymalna: "+predkosc+"; maksymalna ilość kontenerów: "+maks_kontenerow+"; maks waga kontenerów: "+maks_waga_kontenerow);
        if (kontenery.Count == 0) Console.WriteLine("Pusty");
        else
        {
            Console.WriteLine("Przewozi "+ilosc_kontenerow+" kontenerow");
            foreach (Kontener k in kontenery) k.Dane();
        }
    }
}