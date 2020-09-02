using PRG5.CSharpCity.BrewMaster.Domain;
using System;
using System.Linq;

namespace PRG5.CSharpCity.BrewMaster
{
    class Program
    {
        static void Main(string[] args)
        {
            JuraBrew KoffieMachine = new JuraBrew();
            string commandKey = Console.ReadLine();

            while (!commandKey.Equals("X"))
            {
                switch (commandKey)
                {
                    case "1":
                        koffiemachine.SoortBakkie = KoffieSoort.Koffie;
                        Console.WriteLine(koffiemachine.Brew());
                        break;
                    case "2":
                        koffiemachine.SoortBakkie = KoffieSoort.Cappucino;
                        Console.WriteLine(koffiemachine.Brew());
                        break;
                    case "3":
                        koffiemachine.SoortBakkie = KoffieSoort.Espresso;
                        Console.WriteLine(koffiemachine.Brew());
                        break;
                    case "4":
                        koffiemachine.SoortBakkie = KoffieSoort.Ristretto;
                        Console.WriteLine(koffiemachine.Brew());
                        break;
                    case "5":
                        koffiemachine.SoortBakkie = KoffieSoort.AvansSlootwater;
                        Console.WriteLine(koffiemachine.Brew());
                        break;
                    case "O":
                        koffiemachine.Ontkalken();
                        break;
                    default:
                        koffiemachine.SoortBakkie = KoffieSoort.Koffie;
                        Console.WriteLine($"Dat hebben we niet, u krijgt gewoon {koffiemachine.SoortBakkie}");
                        Console.WriteLine(koffiemachine.Brew());
                        break;
                }
                commandKey = Console.ReadLine();
            }

            Console.WriteLine($"Ik heb {koffiemachine.GezetteBakjes.Count} bakjes gezet;");
            Console.WriteLine($"Ik heb {koffiemachine.GezetteBakjes.Where(b => b == KoffieSoort.Cappucino).Count()} bakjes gezet;");

            foreach (KoffieSoort bakje in koffiemachine.GezetteBakjes)
            {
                Console.WriteLine(bakje);
            }

            Console.WriteLine("Bedankt voor het drinken van Jura Brew!");
            Console.ReadLine();
        }
    }
}
