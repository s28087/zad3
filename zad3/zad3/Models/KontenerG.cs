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
    
    public override void Oproznienie()
    {
        Masa = Masa * 0.05;
    }
    
    public override string ToString()
    {
        return base.ToString() + " ciśnienie: " + Cisnienie + " atmosfer";
    }
}