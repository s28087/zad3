using Zad3.Models.Base;

namespace Zad3.Models;

public class KontenerG : Kontener, IHazardNotifier
{
    private int Cisnienie;
    
    public KontenerG(double maxLadownosc, double wysokosc, double wagaWlasna, double glebokosc, int cisnienie) : base(maxLadownosc,  wysokosc, wagaWlasna, glebokosc, 'G')
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

    public string toString()
    {
        return base.ToString() + " ciśnienie: " + Cisnienie;
    }
    
    /*public override void Zaladowanie(double kg)
    {
        base.Zaladowanie(kg);
        
        
        
    }*/
}