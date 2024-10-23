using MojaKnjiznica;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace RST2_Programiranje_Vaje
{
    public enum Vaje2
    {
        Naloga135 = 1,
        Naloga142 = 2,
        Naloga143 = 3,
        Naloga152 = 4,
        Naloga171 = 5,
        Naloga151 = 6,
        Naloga153 = 7,
        Naloga172 = 8
    }

    /// <summary>
    /// Rešitve vaj - 4. oktober 2024
    /// </summary>
    public class Vaje_2
    {
        /// <summary>
        /// Na spletu poiščite postopek za branje izvorne kode html strani, podane z url naslovom, s C#. 
        /// Nato zapišite metodo, ki sproti izpisuje hiper-povezave, 
        /// ki se na izbrani strani pojavljajo, 
        /// pri tem pa naj izvorno kodo bere druga metoda, 
        /// ki za vračanje sprotnih hiper-povezav uporablja stavek yield return.
        /// </summary>
        public static void Naloga135()
        {
            // Url, ki ga želimo analizirati
            string url = @"https://www.delo.si";

            // Uporabimo metodo iz pomožne knjižnice,
            // ki za dani spletni naslov vrne izvorno kodo spletne strani
            string sourceCode = AuxilliaryFunctions.ReadWebPageSource(url);

            // Preverimo, kaj smo dobili - samo za potrebe debugiranja
            // Console.WriteLine(sourceCode);


            int index = 0;
            // Izpišemo vse povezave, kot nam jih pošilja funkcija GetHyperLinks
            foreach (string link in GetHyperLinks(sourceCode))
            {
                index++;
                Console.WriteLine($"{index}: {link}");
            }
        }

        /// <summary>
        /// Metoda v danem nizu najde vrednosti atributov "href" 
        /// in jih vrača eno po eno z ukazom yield return.
        /// </summary>
        private static IEnumerable<string> GetHyperLinks(string koda)
        {
            // Podniz, ki ga v danem nizu iščemo (atribut "href")
            var hrefText = "href=\"";

            // Določimo njegovo pozicijo
            var indexOfHref = koda.IndexOf(hrefText);

            // Ponavljamo po vseh atributih "href"
            while (indexOfHref > -1)
            {
                koda = koda.Substring(indexOfHref + hrefText.Length);
                var url = koda.Substring(0, koda.IndexOf("\""));
                indexOfHref = koda.IndexOf(hrefText);

                yield return url;
            }
        }


        /// <summary>
        /// Zapišite metodo z enakim imenom kot v prejšnji nalogi, 
        /// pri čemer naj ima še dodaten neobvezen parameter tipa bool, 
        /// ki odloči, če želimo poiskati tudi največji skupni delitelj 
        /// ali le najmanjši skupni večkratnik.
        /// Razmislite tudi, kaj naj metoda vrača.
        /// </summary>
        public static int Naloga142(int x, int y, out int? nsd, bool findGCD = false)
        {
            // Najmanjši skupni večkratnik izračunamo na enak način
            int nsv = AuxilliaryFunctions.LCM(x, y);

            // Največji skupni delitelj pa le v primeru, ko ga rabimo,
            // sicer vrnemo vrednost null
            if (findGCD)
                nsd = AuxilliaryFunctions.GCD(x, y);
            else
                nsd = null;

            // Vračamo le glavno vrednost, podrejeno vrnemo kot izhodni parameter
            return nsv;
        }


        /// <summary>
        /// Zapišite metodo, ki kot sklicni (oz. ref) parameter prejme seznam realnih števil. 
        /// Vrednosti v seznamu predstavljajo verjetnost padavin v zaporednih dneh, 
        /// ki so bile izračunane in se v seznam zapisale iz zunanjega vira.
        /// Naloga metode je preveriti, če so vrednosti dopustne.
        /// V primeru, da je med njimi kakšna vrednost večja kot $1$, 
        /// metoda seznam izprazni oziroma mu priredi nov, prazen seznam.
        /// V nasprotnem primeru seznama ne spreminja.
        /// </summary>
        public static void Naloga143(ref List<double> lstProbabilities)
        {
            for (int i = 0; i < lstProbabilities.Count; i++)
            {
                if (!(lstProbabilities[i] >= 0 && lstProbabilities[i] <= 1))
                {
                    // Če naredimo nov seznam, bo nanj kazala tudi spremenljivka izven funkcije.
                    // Če ref ne bi uporabili, se njen kazalec ne bi premaknil
                    lstProbabilities = new List<double>();

                    // Če bi vrednosti v seznamu samo pobrisali,
                    // bi se to odrazilo na spremenljivki v obeh primerih
                    //lstProbabilities.Clear();
                    return;
                }
            }
        }

        /// <summary>
        /// Zapišite enumeracijo za imena mesecev, 
        /// ki ima vrednosti tipa byte
        public static void Naloga151()
        {
            var month = InterfaceFunctions.ChooseSection<Months>();
            Console.WriteLine($"{month}");
        }

        public enum Months
        {
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        }


        /// <summary>
        /// Zapišite enumeracijo za imena ocen na fakulteti. 
        /// Nato pripravite funkcijo, ki profesorja vpraša, 
        /// kakšno oceno želi dati študentu na izpitu ter mu dajte na voljo ustrezne izbire.
        /// </summary>
        public static void Naloga152()
        {
            // Uporabimo kar funkcijo, ki jo že uporabljamo za izbiro nalog
            var ocena = InterfaceFunctions.ChooseSection<Ocene>();

            Console.WriteLine($"Ocena {(int)ocena} je bila uspešno vnešena");
        }

        /// <summary>
        /// Enumeracija za imena ocen
        /// </summary>
        private enum Ocene
        {

            Nezadostno = 5,
            Zadostno = 6,
            Dobro = 7,
            PravDobro1 = 8,
            PravDobro2 = 9,
            Odlično = 10
        }

        public static void Naloga153()
        {

        }


        /// <summary>
        /// Zapišite funkcijo, ki bo prebrala dano datoteko 
        /// in v novo datoteko zapisala besede, ki so podane v vsaki vrstici posebej 
        /// ki se pojavijo v prvi, vendar v abecednem vrstnem redu.
        /// </summary>
        public static void Naloga171()
        {
            string line;
            var test = new List<String>();

            using (StreamReader sr = new StreamReader("example.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    test.Add(line);
                }
            }
            test.Sort();

            using (StreamWriter sw = new StreamWriter("example1.txt"))
            {
                foreach (var item in test)
                {
                    sw.WriteLine(item);
                }
            }

        }
        public static void Naloga172()
        {
            Dictionary<char, char> pairs = new Dictionary<char, char>();
            pairs.Add('a', 'e');
            pairs.Add('e', 'i');
            pairs.Add('i', 'o');
            pairs.Add('o', 'u');
            pairs.Add('u', 'a');

            using (StreamWriter sw = new StreamWriter("zamaknjeni.txt"))
            {
                using (StreamReader sr = new StreamReader("example.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        StringBuilder newLine = new StringBuilder();

                        foreach (var c in line)
                        {
                            if (pairs.ContainsKey(c))
                            {
                                newLine.Append(pairs[c]);
                            }else{
                                newLine.Append(c);
                            }
                        }
                        sw.WriteLine(newLine.ToString());
                    }
                }
            }
        }
    }
}
