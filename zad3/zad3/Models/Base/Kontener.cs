namespace Zad3.Models.Base;


public abstract class Kontener
{
    
    //dostep i modyfikacja (gettery i setteryz javy)
    protected double MaxLadownosc { get; set; }
    protected double Masa { get; set; }
    protected double Wysokosc { get; set; }
    protected double WagaWlasna { get; set; }
    protected double Glebokosc { get; set; }
    private static int NumerGen;
    public int id { get; set; }
    public string NumerSer;
    private char Rodzaj { get; set; }
    

    //ZMIEN ZEBY RODZAJ BYLO AUTOMATYCZNE NA PODSTAWIE KLASY
    public Kontener(double maxLadownosc,double masa, double wysokosc, double wagaWlasna,
        double glebokosc, char rodzaj)
    {
        MaxLadownosc = maxLadownosc;
        Masa = masa;
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

    public void Zaladowanie(double kg)
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
    
}