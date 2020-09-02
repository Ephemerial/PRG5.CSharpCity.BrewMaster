using System;
using System.Collections.Generic;

namespace PRG5.CSharpCity.BrewMaster.Domain
{
    /// <summary>
    /// List all types of coffee our company can make
    /// </summary>
    public enum KoffieSoort { 
        Koffie,
        Cappucino,
        Espresso,
        Ristretto,
        AvansSlootwater
    }

    /// <summary>
    /// Super deluxe coffee maker, we might provide a simpler one in the future
    /// </summary>
    public class JuraBrew
    {
        private List<KoffieSoort> _gezetteBakjes;
        private int _aantalBakjes;

        /// <summary>
        /// The constructor
        /// </summary>
        public JuraBrew()
        { 
            _aantalBakjes = 0;
            SoortBakkie = KoffieSoort.Espresso;
            _gezetteBakjes = new List<KoffieSoort>();
        }

        /// <summary>
        /// This is a readonly property with an Expression to return the right private variable.
        /// The code behind the arrow (=>) is what the getter returns as value
        /// </summary>
        public List<KoffieSoort> GezetteBakjes => _gezetteBakjes;

        /// <summary>
        /// This is an automatic property. There is no other logic besides getting and setting a private variable.
        /// That would be trivial code, .Net and C# allow is the directly specify both variable and getters/setters
        /// </summary>
        public KoffieSoort SoortBakkie { get; set; }

        /// <summary>
        /// This is a readonly property. The user of this class can only read this value.
        /// </summary>
        public int AantalBakjes {
            get {
                return _aantalBakjes;
            }
        }

        /// <summary>
        /// Decalcifies the machine and resets the counter to zero. Only does that if
        /// decalcification is necessary (AantalKopjes >= 5)
        /// </summary>
        /// <returns>True if decalcified, false otherwise</returns>
        public bool Ontkalken()
        {
            if (_aantalBakjes >= 5)
            {
                _aantalBakjes = 0;
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// brews our delicious cup of coffe
        /// </summary>
        /// <returns>The coffee that we made for you!</returns>
        public string Brew()
        {
            if (_aantalBakjes < 5)
            {
                _aantalBakjes++;
                _gezetteBakjes.Add(SoortBakkie);
                return $"Alstublieft een lekker bakkie {SoortBakkie}";
            }
            else 
            {
                return "U moet eerst ontkalken.";
            }
            
        }
    }
}
