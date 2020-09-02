using System;
using System.Collections.Generic;

namespace PRG5.CSharpCity.BrewMaster.Domain
{
    public enum KoffieSoort { 
        Koffie,
        Cappucino,
        Espresso,
        Ristretto,
        AvansSlootwater
    }

    public class JuraBrew
    {
        private List<KoffieSoort> _gezetteBakjes;
        private int _aantalBakjes;

        public JuraBrew()
        { 
            _aantalBakjes = 0;
            SoortBakkie = KoffieSoort.Espresso;
            _gezetteBakjes = new List<KoffieSoort>();
        }

        public List<KoffieSoort> GezetteBakjes => _gezetteBakjes;

        public KoffieSoort SoortBakkie { get; set; }

        public int AantalBakjes {
            get {
                return _aantalBakjes;
            }
        }

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
