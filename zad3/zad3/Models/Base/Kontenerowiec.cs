namespace Zad3.Models.Base;

public class Kontenerowiec
{
    public List<Kontener> Kontenery { get; set; }
    private double MaxPredkosc;
    private int MaxKontenerow;
    private double MaxLadownosc;

    public Kontenerowiec(double maxPredkosc, int maxKontenerow, double maxLadownosc)
    {
        Kontenery = new List<Kontener>();
        MaxPredkosc = maxPredkosc;
        MaxKontenerow = maxKontenerow;
        MaxLadownosc = maxLadownosc;
    }

    public bool SprawdzenieLadownosci()
    {

        double tempMasa = 0;
        
        foreach (Kontener kontener in Kontenery)
        {
            tempMasa += kontener.Masa;
        }

        if (tempMasa > (MaxLadownosc*1000))
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public bool SprawdzenieIlosciKontenerow()
    {
        if (Kontenery.Count > MaxKontenerow)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public void DodanieKonteneru(Kontener kontener)
    {

        if (!SprawdzenieIlosciKontenerow()) 
        {
            Console.WriteLine("nie można dodać konteneru, na statku jest maksymalna ich liczba");
        }
        else if(!SprawdzenieLadownosci())
        {
            Console.WriteLine("nie można dodać konteneru, przekroczona zostałaby ładowność statku");
        }
        else
        {
            Kontenery.Add(kontener);
        }
        
        
    }
    
    public void DodanieKontenerow(List<Kontener> kontenery)
    {
        foreach (Kontener kontener in kontenery)
        {
            DodanieKonteneru(kontener);
        }
    }

    public void UsuniecieKonteneru(Kontener kontener)
    {
        Kontenery.Remove(kontener);
    }


    public void ZastapienieKonteneru(String id, Kontener nowyKontener)
    {

        List<Kontener> tempKontenery = new List<Kontener>(Kontenery);

        bool flaga = false;
        
        foreach (Kontener kontener in tempKontenery)
        {
            if (kontener.NumerSer == id)
            {
                Kontenery.Remove(kontener);
                DodanieKonteneru(nowyKontener);
                flaga = true;
            }
        }
        
        if(flaga==false) Console.WriteLine("nie znaleziono kontenera o podanym numerze seryjnym");
    }

    public void PrzeniesienieKonteneru(Kontener kontenerPrzenoszony, Kontenerowiec cel)
    {
        if (Kontenery.Contains(kontenerPrzenoszony))
        {
            Kontenery.Remove(kontenerPrzenoszony);
            cel.DodanieKonteneru(kontenerPrzenoszony);
        }
        else
        {
            Console.WriteLine("nie ma takiego kontenera na statku");
        }
        

    }
    
    public override string ToString()
    {
        string temp =  "maksymalna prędkość statku: " + MaxPredkosc + " węzłów maksymalna ładowność statku: " + MaxLadownosc +
               " ton maksymalna ilość kontenerów: " + MaxKontenerow + " kontenery na statku:";

        foreach (Kontener kontener in Kontenery)
        {
            temp += "\n" + kontener.ToString();
        }

        return temp;
    }
    
}