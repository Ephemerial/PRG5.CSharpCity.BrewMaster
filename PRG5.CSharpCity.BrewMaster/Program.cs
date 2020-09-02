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

            // while the command does not equal "X" or "x", our machine continues to brew another cup
            // we prefer you use the Equals method on the string to compare items. The StringComparison options
            // allow us to perform the compare in a case-insensitive way
            while (!commandKey.Equals("X",StringComparison.OrdinalIgnoreCase))
            {
                // for this simple example we can use switch on values like strings
                // later on we prefer you use enums or valuetypes like 1,2,3 etc for switches
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
                        // this is the code that we execute for all input that we don't 
                        // recognize
                        KoffieMachine.SoortBakkie = KoffieSoort.Koffie;
                        // There are many ways to format a string
                        // The method below is the newest and arguably the most readable.
                        // Marked with a $, .Net understands that the parameters in the string should be replaced by their values
                        // Other methods include appending strings using the "+" or using the string.Format method
                        Console.WriteLine($"Dat hebben we niet, u krijgt gewoon {KoffieMachine.SoortBakkie}");
                        Console.WriteLine(KoffieMachine.Brew());
                        break;
                }
                commandKey = Console.ReadLine();
            }

            // List support numerous operations, and has a few interesting properties
            // Count returns the amount of items in the list
            Console.WriteLine($"Ik heb {KoffieMachine.GezetteBakjes.Count} bakjes gezet;");
            // First steps in Linq and Lambda. The Where selects all items in the list
            // that satisfy a certain condition, in this case all items that equal Cappucino
            // The count methods returns the number of items selected by our Where
            Console.WriteLine($"Ik heb {KoffieMachine.GezetteBakjes.Where(b => b == KoffieSoort.Cappucino).Count()} bakjes {KoffieSoort.Cappucino} gezet;");

            // We can also use our plain old loop types, while, for and foreach
            // The foreach loop executes for each item in our list
            foreach (KoffieSoort bakje in KoffieMachine.GezetteBakjes)
            {
                Console.WriteLine(bakje);
            }

            Console.WriteLine("Bedankt voor het drinken van Jura Brew!");
            Console.ReadLine();
        }
    }
}
