using MojaKnjiznica;
using System.ComponentModel.DataAnnotations;
using System.Formats.Tar;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Transactions;

namespace RST2_Programiranje_Vaje
{
    public enum Vaje1
    {
        Naloga112 = 1,
        Naloga121 = 2,
        Naloga123 = 3,
        Naloga131 = 4,
        Naloga141 = 5,
        Naloga122 = 6,
        Naloga132 = 7,
        Naloga133 = 8,
        Naloga134 = 9

    }

    /// <summary>
    /// Rešitve vaj - 3. oktober 2024
    /// </summary>
    public class Vaje_1
    {
        /// <summary>
        /// V rešitev iz prejšnje naloge dodajte še en projekt tipa Class Library, 
        /// vanj dodajte razred z neko metodo.
        /// Nato novi projekt dodajte kot referenco v prvega 
        /// ter v programu HelloWorld pokličite metodo iz drugega projekta.
        /// </summary>
        public static void Naloga112()
        {
            int rezultat = AuxilliaryFunctions.SUM(4, 6);
            Console.WriteLine($"Vsota števil 4 in 6 je {rezultat}");
        }

        /// <summary>
        /// Funkcija izpise dan v tednu korespondenčen vnešeni zaporedni
        /// številki
        /// </summary>
        /// <param name="day"></param>
        /// <returns></returns>
        public static string Naloga121(int day)
        {
            switch(day)
            {
                case 1:
                    return "Monday";
                case 2:
                    return "Tuesday";
                case 3:
                    return "Wednesday";
                case 4:
                    return "Thursday";
                case 5:
                    return "Friday";
                case 6:
                    return "Saturday";
                case 7:
                    return "Sunday";
                default:
                    return "Enter different number.";
            }
        }

        public static string Naloga122(int t){
            if (t < 10){
                return "Wear a sweater.";
            }
            else if(t > 20 && t < 30){
                return "Wear a T-shirt.";
            }
            else{
                return "We ran out of suggestions of what to wear :P.";
            }
        }
        
                

        /// <summary>
        /// Zapišite funkcijo, ki uporablja stavek switch, da se odloči 
        /// za izpis števila dni v danem mesecu. 
        /// Predpostavite lahko, da nismo v prestopnem letu. 
        /// Možnosti, ki vrnejo enako vrednost, združite.
        /// </summary>
        public static int Naloga123(int mesec)
        {
            switch (mesec)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    return 28;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                default: // Če številka meseca ni na interalu med 1 in 12, vrnemo 0
                    return 0;
            }
        }

        /// <summary>
        /// Zapišite metodo, ki izpisuje trenutni čas,  
        /// dokler produkt ur, minut in sekund ni deljiv s 17.
        /// Uporabite lastnost Now razreda DateTime.
        /// </summary>
        public static void Naloga131()
        {
            DateTime date1 = DateTime.Now;
            
            while((date1.Hour * date1.Minute * date1.Second % 17) != 0) {
                Thread.Sleep(500);
                date1 = DateTime.Now;
            }
            Console.WriteLine($"{date1} can be divided by 17, when hours, minutes and seconds are multiplied with each other.");
        }

        /// <summary>
        ///Zapišite metodo, ki v danem seznamu realnih števil izbriˇše vse vrednosti,
        ///ki so manjše od začetnega povprečja. Naredite dve implementaciji: eno z zanko for in eno
        ///z zanko foreach
        /// </summary>
        
        public static void Naloga132(ref List<float> myArr){
            float sum = 0;
            int l = myArr.Count;
            foreach (float item in myArr) {
                sum += item;
            }
            float avg = sum / l;

            List<float> tmp = new List<float>();

            foreach(float item in myArr) {
                if (item > avg ){
                   tmp.Add(item);
                }
            }
            myArr = tmp;
        } 

        ///<summary>
        /// Zapišite metodo, ki z uporabo zanke 
        /// do izpisuje večkratnike danega naravnega
        /// števila, dokler vrednost večkratnika ne preseže danega parametra.
        public static void Naloga133(int k, int m)  {
            int curr = k;
            int i = 1;
            do
            {   
                curr = curr * i;
                Console.WriteLine($"{curr} is smaller than {m}");
                curr = curr + k;
            } while (curr < m);
        }

        ///<summary>
        /// Zapišite metodo, ki izpiše prvih k praštevil, kjer je k parameter. V funkciji
        /// uporabite vsaj en stavek break in en stavek continue
        public static void Naloga134(int k) {
            int limit = 0;
            for(int i=1; i<=100; i++) {
                int counter=0;
                for(int j=1; j<=i; j++) {
                    if(i % j == 0) {
                        counter++;
                    }
                }
                if (counter == 2) {
                    limit++;
                    Console.WriteLine($"Prime number is: {i}");
                    continue;
                }
                if(limit == k) {
                    break;
                }
            }        
        }


        /// <summary>
        /// Zapišite metodo, ki kot parameter dobi dve celi števili 
        /// in vrne njun najmanjši skupni večkratnik ter največji skupni delitelj.
        /// </summary>
        public static (int, int) Naloga141(int x, int y)
        {
            int nsv = AuxilliaryFunctions.LCM(x, y);
            int nsd = AuxilliaryFunctions.GCD(x, y);

            // Vračamo dve (enakovredni) vrednosti, zato uporabimo 'tuple'
            return (nsv, nsd);
        }
    }
}
