using Zad3.Models.Base;

namespace Zad3.Models;

public class KontenerG : Kontener, IHazardNotifier
{
    private int Cisnienie;
    
    public KontenerG(double maxLadownosc, double masa, double wysokosc, double wagaWlasna, double glebokosc, char rodzaj, int cisnienie) : base(maxLadownosc, masa, wysokosc, wagaWlasna, glebokosc, rodzaj)
    {
        Cisnienie = cisnienie;
    }

    public void Ostrzezenie()
    {
        Console.WriteLine("Niebezpieczna sytuacja w kontenerze numer " + id);
    }

    public void Oproznienie()
    {
        Masa = 0;
    }
    
    /*public override void Zaladowanie(double kg)
    {
        base.Zaladowanie(kg);
        
        
        
    }*/
}