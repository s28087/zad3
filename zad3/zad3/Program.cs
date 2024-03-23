using System;
using Zad3.Models;
using Zad3.Models.Base;

class zad3 { 
      
        // Main Method 
        static public void Main(String[] args) 
        { 
      
            Console.WriteLine("Main Method"); 
            
            //KontenerL test1 = new KontenerL(600.0, 700.0, 100.0, 400.0, 300.0,'L',"niebezpieczne");
            KontnerL test2 = new KontnerL(600.0, 700.0, 100.0,
                400.0, 300.0, 'L', TypLadunku.Niebezpieczny);
            KontnerL test3 = new KontnerL(600.0, 700.0, 100.0,
                400.0, 300.0, 'L', TypLadunku.Zwykły);

            Console.WriteLine(test2.NumerSer);
            Console.WriteLine(test3.NumerSer);
            

        } 
    }
  
