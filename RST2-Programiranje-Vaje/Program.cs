namespace RST2_Programiranje_Vaje
{
    internal class Program
    {
        enum Sections
        {
            Vaje_1 = 1,
            Vaje_2 = 2
        }

        static void Main(string[] args)
        {
            switch (InterfaceFunctions.ChooseSection<Sections>())
            {
                case Sections.Vaje_1:
                    {
                        switch (InterfaceFunctions.ChooseSection<Vaje1>())
                        {
                            case Vaje1.Naloga112:
                                {
                                    Vaje_1.Naloga112();
                                }
                                break;
                            case Vaje1.Naloga121:
                                {
                                    Console.Write("Enter number corresponding to certain day: ");
                                    int day = int.Parse(Console.ReadLine());
                                    string n = Vaje_1.Naloga121(day);
                                    Console.WriteLine($"{day}: {n}");
                                }
                                break;
                            case Vaje1.Naloga122:
                            {
                                Console.Write("Enter today's temperature:");
                                int t = int.Parse(Console.ReadLine());
                                string clothes = Vaje_1.Naloga122(t);
                                Console.WriteLine($"{t}: {clothes}");
                            }
                            break;
                            case Vaje1.Naloga123:
                                {
                                    Console.Write("Vpišite številko meseca: ");
                                    int mesec = int.Parse(Console.ReadLine());
                                    int stDni = Vaje_1.Naloga123(mesec);
                                    Console.WriteLine($"V {mesec}. mesecu je {stDni} dni.");
                                }
                                break;
                            case Vaje1.Naloga131:
                                {
                                    Vaje_1.Naloga131();
                                }
                                break;
                            case Vaje1.Naloga132:
                                {
                                    List<float> ar1 = [1.3f, 1.9f, 1.2f, 3.4f, 7.8f];
                                    Console.WriteLine($"Original values: ");
                                    foreach (float v in ar1)
                                    {
                                        Console.WriteLine(v);
                                    }
                                    Vaje_1.Naloga132(ref ar1);
                                    Console.WriteLine($"Values bigger than average: {ar1}");
                                    foreach (float v in ar1)
                                    {
                                        Console.WriteLine(v);
                                    }
                                }
                                break;
                            case Vaje1.Naloga133:
                                {
                                    Console.WriteLine("Enter parameter to get multiples: ");
                                    int k = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter limit: ");
                                    int m = int.Parse(Console.ReadLine());
                                    Vaje_1.Naloga133(k,m);
                                }
                                break;
                            case Vaje1.Naloga134:
                                {
                                    Console.WriteLine("How many prime numbers you want to output?");
                                    int k = int.Parse(Console.ReadLine());
                                    Vaje_1.Naloga134(k);
                                }
                                break;      
                            case Vaje1.Naloga141:
                                {
                                    int x = 10;
                                    int y = 20;
                                    (int NSV, int NSD) = Vaje_1.Naloga141(x, y);
                                    Console.WriteLine($"Najmanjši skupni večkratnik števil {x} in {y} je {NSV}.");
                                    Console.WriteLine($"Največji skupni delitelj števil {x} in {y} je {NSD}.");
                                }
                                break;
                        }
                    }
                    break;

                case Sections.Vaje_2:
                    {
                        switch (InterfaceFunctions.ChooseSection<Vaje2>())
                        {
                            case Vaje2.Naloga135:
                                {
                                    Vaje_2.Naloga135();
                                }
                                break;
                            case Vaje2.Naloga142:
                                {
                                    int x = 11;
                                    int y = 17;
                                    int NSV = Vaje_2.Naloga142(x, y, out int? NSD, findGCD: true);
                                    Console.WriteLine($"Najmanjši skupni večkratnik števil {x} in {y} je {NSV}.");
                                    Console.WriteLine($"Največji skupni delitelj števil {x} in {y} je {NSD}.");
                                }
                                break;
                            case Vaje2.Naloga143:
                                {
                                    var newList = new List<double>()
                                            {
                                                0.9, 1.2, 3.5
                                            };

                                    Vaje_2.Naloga143(ref newList);
                                    Console.WriteLine(newList.Count);
                                }
                                break;
                            case Vaje2.Naloga152:
                                {
                                    Vaje_2.Naloga152();
                                }
                                break;
                            case Vaje2.Naloga151:
                                {
                                    Vaje_2.Naloga151();
                                }
                                break;
                                
                            case Vaje2.Naloga171:
                                {
                                    Vaje_2.Naloga171();
                                }
                                break;
                        }
                    }
                    break;
            }
            Console.Read();
        }
    }
}
