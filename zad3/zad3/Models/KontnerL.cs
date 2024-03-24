using Zad3.Models.Base;

namespace Zad3.Models;

public enum TypLadunku
{
    Niebezpieczny,
    Zwykły
}

public class KontnerL : Kontener, IHazardNotifier
{

    private TypLadunku TypLadunku;
    public KontnerL(double maxLadownosc, double wysokosc, double wagaWlasna, double glebokosc, TypLadunku typLadunku) : base(maxLadownosc, wysokosc, wagaWlasna, glebokosc, 'L')
    {
        TypLadunku = typLadunku;
    }
    
    public void Ostrzezenie()
    {
        Console.WriteLine("Niebezpieczna sytuacja w kontenerze numer " + id);
        Console.WriteLine("Przekroczono dozwolona masę");
    }

    public override void Zaladowanie(double kg)
    {
        double tempMasa = Masa + kg;
        
        if (TypLadunku == TypLadunku.Niebezpieczny)
        {
            if (tempMasa > (0.5 * MaxLadownosc))
            {
                Ostrzezenie();
                //Console.WriteLine("Wcześniejsza masa: " + Masa);
                //Masa = tempMasa * 0.5;
                //Console.WriteLine("Aktualna masa: " + Masa);
                
            }
            else
            {
                Masa = tempMasa;
            }
        }else if (TypLadunku == TypLadunku.Zwykły)
        {
            if (tempMasa > (0.9 * MaxLadownosc))
            {
                Ostrzezenie();
                //Console.WriteLine("Wcześniejsza masa: " + Masa);
                //Masa = tempMasa * 0.9;
                //Console.WriteLine("Aktualna masa: " + Masa);
            }
            else
            {
                Masa = tempMasa;
            }
        }
    }
    
    public override string ToString()
    {
        return base.ToString() + " typ ładunku: " + TypLadunku;
    }
    
}