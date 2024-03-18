using Zad3.Models.Base;

namespace Zad3.Models;

//ładunek zwykły (mleko) i niebezpieczny (paliwo)
public class KontnerL : Kontener, IHazardNotifier
{
    
    //ZMIENIC NA ENUM
    private string Typ;
    public KontnerL(double maxLadownosc, double masa, double wysokosc, double wagaWlasna, double glebokosc, char rodzaj, string typ) : base(maxLadownosc, masa, wysokosc, wagaWlasna, glebokosc, rodzaj)
    {
        Typ = typ;
    }
    
    public void Ostrzezenie()
    {
        Console.WriteLine("Niebezpieczna sytuacja w kontenerze numer " + id);
    }

    public void Zaladowanie(double kg)
    {
        double tempMasa = Masa + kg;
        
        if (Typ == "niebezpieczny")
        {
            if (tempMasa > (0.5 * MaxLadownosc))
            {
                Console.WriteLine("Przekroczono dozwolona masę");
                Console.WriteLine("Wcześniejsza masa: " + Masa);
                Masa = tempMasa * 0.5;
                Console.WriteLine("Aktualna masa: " + Masa);
                
            }
            else
            {
                Masa = tempMasa;
            }
        }else if (Typ == "bezpieczny")
        {
            if (tempMasa > (0.9 * MaxLadownosc))
            {
                Console.WriteLine("Przekroczono dozwolona masę");
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