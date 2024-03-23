using Zad3.Models.Base;

namespace Zad3.Models;

public enum TypLadunku
{
    Niebezpieczny,
    Zwykły
}



//ładunek zwykły (mleko) i niebezpieczny (paliwo)
public class KontnerL : Kontener, IHazardNotifier
{
    
    //ZMIENIC NA ENUM
    private TypLadunku typLadunku;
    public KontnerL(double maxLadownosc, double masa, double wysokosc, double wagaWlasna, double glebokosc, char rodzaj, TypLadunku typLadunku) : base(maxLadownosc, masa, wysokosc, wagaWlasna, glebokosc, rodzaj)
    {
        this.typLadunku = typLadunku;
    }
    
    public void Ostrzezenie()
    {
        Console.WriteLine("Niebezpieczna sytuacja w kontenerze numer " + id);
        Console.WriteLine("Przekroczono dozwolona masę");
    }

    public void Zaladowanie(double kg)
    {
        double tempMasa = Masa + kg;
        
        if (typLadunku == TypLadunku.Niebezpieczny)
        {
            if (tempMasa > (0.5 * MaxLadownosc))
            {
                Ostrzezenie();
                Console.WriteLine("Wcześniejsza masa: " + Masa);
                Masa = tempMasa * 0.5;
                Console.WriteLine("Aktualna masa: " + Masa);
                
            }
            else
            {
                Masa = tempMasa;
            }
        }else if (typLadunku == TypLadunku.Zwykły)
        {
            if (tempMasa > (0.9 * MaxLadownosc))
            {
                Ostrzezenie();
                Console.WriteLine("Wcześniejsza masa: " + Masa);
                Masa = tempMasa * 0.9;
                Console.WriteLine("Aktualna masa: " + Masa);

                Ostrzezenie();
            }
            else
            {
                Masa = tempMasa;
            }
        }
    }
    
}