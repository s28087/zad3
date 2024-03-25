using System;
using Zad3.Models;
using Zad3.Models.Base;

class zad3 { 
    
        static public void Main(String[] args) 
        { 
            
            //stworzenie kontenera danego typu
            Kontener kontener1 = new KontnerL(600.0,  600.0, 100.0, 200.0, TypLadunku.Niebezpieczny);
            Kontener kontener2 = new KontnerL(600.0, 600.0, 100.0, 200.0, TypLadunku.Zwykły);

            Kontener kontener3 = new KontenerC(600.0, 600.0, 100.0, 200.0, RodzajProduktu.Bananas, 20);
            //kontener ze zbyt niska temperatura
            //Kontener kontener4 = new KontenerC( 600.0, 600.0, 100.0, 200.0, RodzajProduktu.Bananas, 10);
            
            Kontener kontener5 = new KontenerG(600.0, 600.0, 100.0, 200.0, 100);
            

            List<Kontener> kontenery = new List<Kontener>();
            kontenery.Add(kontener2);
            kontenery.Add(kontener3);
            kontenery.Add(kontener5);

            
            //załadowanie ładunku do danego kontenera
            Console.WriteLine();
            Console.WriteLine("załadowanie ładunku do danego kontenera");
            Console.WriteLine("masa kontenera przed " + kontener1.NumerSer + " " + kontener1.Masa);
            kontener1.Zaladowanie(300);
            
            //przeładowanie
            //kontener1.Zaladowanie(700);
            
            Console.WriteLine("masa kontenera po " + kontener1.NumerSer + " " + kontener1.Masa);
            
            
            //załadowanie kontenera na statek
            Console.WriteLine();
            Console.WriteLine("załadowanie kontenera numer 1 na statek");
            Kontenerowiec kontenerowiec1 = new Kontenerowiec(100.0,20,10);
            kontenerowiec1.DodanieKonteneru(kontener1);
            
            //załadowanie listy kontenerów na statek
            Console.WriteLine();
            Console.WriteLine("załadowanie listy kontenerow (kontener 2,3 i 5)");
            kontenerowiec1.DodanieKontenerow(kontenery);
            
            //usunięcie kontenera ze statku
            Console.WriteLine();
            Console.WriteLine("usunięcie kontenera numer 3 ze statku");
            kontenerowiec1.UsuniecieKonteneru(kontener3);
            
            //rozładowanie kontenera
            Console.WriteLine();
            Console.WriteLine("rozładowanie kontenera");
            kontener1.Oproznienie();
            Console.WriteLine("masa kontenera " + kontener1.NumerSer + " " + kontener1.Masa);
            
            
            //zastąpienie kontenera na statku o danym numerze innym kontenerem
            Console.WriteLine();
            Console.WriteLine("zastąpienie kontenera na statku o danym numerze innym kontenerem");
            Console.WriteLine("kontenery przed zamianą:");
            foreach (Kontener kontener in kontenerowiec1.Kontenery)
            {
                //wypisanie informacji o danym kontenerze
                Console.WriteLine(kontener);
            }
            
            kontenerowiec1.ZastapienieKonteneru(kontener1.NumerSer, kontener3);
            
            Console.WriteLine("kontenery po zamianie:");
            foreach (Kontener kontener in kontenerowiec1.Kontenery)
            {
                Console.WriteLine(kontener);
            }
            
            //możliwość przeniesienia kontenera między dwoma statkami
            Console.WriteLine();
            Console.WriteLine("przeniesienie kontenera numer 3 na inny statek");
            Kontenerowiec kontenerowiec2 = new Kontenerowiec(100.0,30,10);
            kontenerowiec1.PrzeniesienieKonteneru(kontener3, kontenerowiec2);
            
            //wypisanie informacji o danym statku i jego ładunku
            Console.WriteLine();
            Console.WriteLine("wypisanie informacji o danym statku i jego ładunku");
            Console.WriteLine(kontenerowiec2);
            
            //kontener5.Zaladowanie(500);
            //kontener5.Oproznienie();
            //Console.WriteLine(kontener5);

        } 
    }
  
