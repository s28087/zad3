namespace Zad3.Models.Base;


public abstract class Kontener
{
    
    //dostep i modyfikacja (gettery i setteryz javy)
    protected double MaxLadownosc { get; set; }
    public double Masa { get; set; }
    protected double Wysokosc { get; set; }
    protected double WagaWlasna { get; set; }
    protected double Glebokosc { get; set; }
    private static int NumerGen;
    public int id { get; set; }
    public string NumerSer;
    private char Rodzaj { get; set; }
  
    public Kontener(double maxLadownosc, double wysokosc, double wagaWlasna,
        double glebokosc, char rodzaj)
    {
        MaxLadownosc = maxLadownosc;
        Wysokosc = wysokosc;
        WagaWlasna = wagaWlasna;
        Glebokosc = glebokosc;
        Rodzaj = rodzaj;
        id = ++NumerGen;
        NumerSer = "KON-" + Rodzaj + "-" + id;

    }

    public void Oproznienie()
    {
        Masa = 0;
    }

    public virtual void Zaladowanie(double kg)
    {
        double tempMasa = Masa + kg;
        
        if (tempMasa > MaxLadownosc)
        {
            throw new OverfillException("wartosc przekroczona");
        }
        else
        {
            Masa = tempMasa;
        }
    }

    public override string ToString()
    {
        return "Numer seryjny: " + NumerSer + " aktualna masa: " + Masa + " maksymalna ładowność " + MaxLadownosc +
               " wysokość: " + Wysokosc + " waga własna: " + WagaWlasna + " głębokość: " + Glebokosc + " rodzaj: " +
               Rodzaj;
    }
    
}