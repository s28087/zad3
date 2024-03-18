using Zad3.Models.Base;

namespace Zad3.Models;

public class KontenerG : Kontener
{
    private int Cisnienie;
    
    public KontenerG(double maxLadownosc, double masa, double wysokosc, double wagaWlasna, double glebokosc, char rodzaj, int cisnienie) : base(maxLadownosc, masa, wysokosc, wagaWlasna, glebokosc, rodzaj)
    {
        cisnienie = Cisnienie;
    }
}