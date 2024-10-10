using MojaKnjiznica;
using System.Runtime.ConstrainedExecution;

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
