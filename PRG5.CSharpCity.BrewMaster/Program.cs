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

            while (!commandKey.Equals("X",StringComparison.OrdinalIgnoreCase))
            {
                switch (commandKey)
                {
                    case "1":
                        KoffieMachine.SoortBakkie = KoffieSoort.Koffie;
                        Console.WriteLine(KoffieMachine.Brew());
                        break;
                    case "2":
                        KoffieMachine.SoortBakkie = KoffieSoort.Cappucino;
                        Console.WriteLine(KoffieMachine.Brew());
                        break;
                    case "3":
                        KoffieMachine.SoortBakkie = KoffieSoort.Espresso;
                        Console.WriteLine(KoffieMachine.Brew());
                        break;
                    case "4":
                        KoffieMachine.SoortBakkie = KoffieSoort.Ristretto;
                        Console.WriteLine(KoffieMachine.Brew());
                        break;
                    case "5":
                        KoffieMachine.SoortBakkie = KoffieSoort.AvansSlootwater;
                        Console.WriteLine(KoffieMachine.Brew());
                        break;
                    case "O":
                        KoffieMachine.Ontkalken();
                        break;
                    default:
                        KoffieMachine.SoortBakkie = KoffieSoort.Koffie;
                        Console.WriteLine($"Dat hebben we niet, u krijgt gewoon {KoffieMachine.SoortBakkie}");
                        Console.WriteLine(KoffieMachine.Brew());
                        break;
                }
                commandKey = Console.ReadLine();
            }

            Console.WriteLine($"Ik heb {KoffieMachine.GezetteBakjes.Count} bakjes gezet;");
            Console.WriteLine($"Ik heb {KoffieMachine.GezetteBakjes.Where(b => b == KoffieSoort.Cappucino).Count()} bakjes gezet;");

            foreach (KoffieSoort bakje in KoffieMachine.GezetteBakjes)
            {
                Console.WriteLine(bakje);
            }

            Console.WriteLine("Bedankt voor het drinken van Jura Brew!");
            Console.ReadLine();
        }
    }
}
