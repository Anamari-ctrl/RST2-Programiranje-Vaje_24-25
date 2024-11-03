using System.Diagnostics.Metrics;
using System.Runtime.ConstrainedExecution;
namespace RST2_Programiranje_Vaje
{
    public enum Vaje3
    {
        Naloga181 = 1
        
    }
    /// <summary>
    /// Rešitve vaj - 4. oktober 2024
    /// </summary>
    public class Vaje_3
    {
        public static void Naloga181(){
            Random r = new Random();
            int i = 0;
            int t;
            while(i < 7) {
                //generic formula: st % (max - min) + min
                t = r.Next() % 39 + 1;
                Console.WriteLine(t);
                i++;
            }
            t = r.Next() % 39 + 1;
            Console.WriteLine(t);            
        }

    }
}
