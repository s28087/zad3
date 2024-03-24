namespace Zad3.Models.Base;

public class Kontenerowiec
{
    private List<Kontener> Kontenery = new List<Kontener>();
    private double MaxPredkosc;
    private int MaxKontenerow;
    private double MaxLadownosc;

    public Kontenerowiec(double maxPredkosc, int maxKontenerow, double maxLadownosc)
    {
        MaxPredkosc = maxPredkosc;
        MaxKontenerow = maxKontenerow;
        MaxLadownosc = maxLadownosc;
    }

    public void SprawdzenieLadownosci()
    {

        double tempMasa = 0;
        
        foreach (Kontener kontener in Kontenery)
        {
            tempMasa += kontener.Masa;
        }

        if (tempMasa > MaxLadownosc)
        {
            throw new OverfillException("za duża ładowność");
        }
    }

    public void SprawdzenieIlosciKontenerow()
    {
        if (Kontenery.Count > MaxKontenerow)
        {
            throw new OverfillException("nie można dodać więcej kontenerów");
        }
    }

    public void DodanieKonteneru(Kontener kontener)
    {
        SprawdzenieIlosciKontenerow();
        SprawdzenieLadownosci();
        
        Kontenery.Add(kontener);
    }
    
    public void DodanieKontenerow(List<Kontener> kontenery)
    {
        SprawdzenieIlosciKontenerow();
        SprawdzenieLadownosci();

        foreach (Kontener kontener in kontenery)
        {
            Kontenery.Add(kontener);
        }
    }

    public void UsuniecieKonteneru(Kontener kontener)
    {
        Kontenery.Remove(kontener);
    }
    
    
}