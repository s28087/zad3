using Zad3.Models.Base;

namespace Zad3.Models;

public enum RodzajProduktu
{
    Bananas,
    Chocolate,
    Fish,
    Meat,
    Icecream,
    FrozenPizza,
    Cheese,
    Sausages,
    Butter,
    Eggs
}

public class KontenerC : Kontener
{

    private RodzajProduktu RodzajProduktu;
    private double Temperatura;
    
    public KontenerC(double maxLadownosc, double wysokosc, double wagaWlasna, double glebokosc, RodzajProduktu rodzajProduktu, double temperatura) : base(maxLadownosc,  wysokosc, wagaWlasna, glebokosc, 'C')
    {
        RodzajProduktu = rodzajProduktu;
        Temperatura = temperatura;
        
        SprawdzenieTemperatury();
    }


    private void SprawdzenieTemperatury()
    {
        double temp = PobranieTemperatury();

        if (Temperatura < temp)
        {
            throw new Exception("temperatura kontenera jest za niska na ten rodzaj produktu");
        }
    }

    private double PobranieTemperatury()
    {
        switch (RodzajProduktu)
        {
            case RodzajProduktu.Bananas:
                return 13.3;
            case RodzajProduktu.Chocolate:
                return 18;
            case RodzajProduktu.Fish:
                return 2;
            case RodzajProduktu.Meat:
                return -15;
            case RodzajProduktu.Icecream:
                return -18;
            case RodzajProduktu.FrozenPizza:
                return -30;
            case RodzajProduktu.Cheese:
                return 7.2;
            case RodzajProduktu.Sausages:
                return 5;
            case RodzajProduktu.Butter:
                return 20.5;
            case RodzajProduktu.Eggs:
                return 19;
            default:
                throw new NotSupportedException("zły rodzaj produktu");
        }
    }
    
    
}