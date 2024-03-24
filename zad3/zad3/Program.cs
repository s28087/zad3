using System;
using Zad3.Models;
using Zad3.Models.Base;

class zad3 { 
    
        static public void Main(String[] args) 
        { 
            
            //KontenerL test1 = new KontenerL(600.0, 700.0, 100.0, 400.0, 300.0,'L',"niebezpieczne");
            /*KontnerL test2 = new KontnerL(600.0, 700.0, 100.0,
                400.0, 300.0, 'L', TypLadunku.Niebezpieczny);
            KontnerL test3 = new KontnerL(600.0, 700.0, 100.0,
                400.0, 300.0, 'L', TypLadunku.Zwykły);

            Console.WriteLine(test2.NumerSer);
            Console.WriteLine(test3.NumerSer);*/
            
            //stworzenie kontenera danego typu
            Kontener kontener1 = new KontnerL(600.0,  600.0, 100.0, 200.0, TypLadunku.Niebezpieczny);
            Kontener kontener2 = new KontnerL(600.0, 600.0, 100.0, 200.0, TypLadunku.Zwykły);

            Kontener kontener3 = new KontenerC(600.0, 600.0, 100.0, 200.0, RodzajProduktu.Bananas, 20);
            //Kontener kontener4 = new KontenerC(600.0, 600.0, 600.0, 100.0, 200.0, RodzajProduktu.Bananas, 10);
            
            Kontener kontener5 = new KontenerG(600.0, 600.0, 100.0, 200.0, 100);

            List<Kontener> kontenery = new List<Kontener>();
            kontenery.Add(kontener2);
            kontenery.Add(kontener3);
            
            Console.WriteLine(kontener1.NumerSer);
            
            //załadowanie ładunku do danego kontenera
            Console.WriteLine("Masa kontenera " + kontener1.NumerSer + " " + kontener1.Masa);
            kontener1.Zaladowanie(300);
            //kontener1.Zaladowanie(700);
            Console.WriteLine("Masa kontenera " + kontener1.NumerSer + " " + kontener1.Masa);
            
            //załadowanie kontenera na statek
            Kontenerowiec kontenerowiec1 = new Kontenerowiec(100.0,2,10000);
            kontenerowiec1.DodanieKonteneru(kontener1);
            
            //załadowanie listy kontenerów na statek
            kontenerowiec1.DodanieKontenerow(kontenery);
            
            //usunięcie kontenera ze statku
            kontenerowiec1.UsuniecieKonteneru(kontener3);
            
            //rozładowanie kontenera
            kontener1.Oproznienie();
            Console.WriteLine("Masa kontenera " + kontener1.NumerSer + " " + kontener1.Masa);
            
            //dodac
            //zastąpienie kontenera na statku o danym numerze innym kontenerem
            //możliwość przeniesienia kontenera między dwoma statkami
            
            //wypisanie informacji o danym kontenerze
            
            //wypisanie informacji o danym statku i jego ładunku
            
            //DODAC DO RESZTY toString

        } 
    }
  
