using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djeciji_vrtic.Models
{
    

    public class PolaznikModel
    {
        public int ID_Polaznik { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Ime_Roditelja { get; set; }

        public DateTime Datum_Rodjenja { get; set; }

        public string JMBG { get; set; }

        public string Kontakt { get; set; }
        public string Pol { get; set; }

        public int ID_Grupa { get; set; }
        public string PunoIme
        {
            get { return $"{Ime},{Prezime},{JMBG}-{ID_Polaznik}"; }

        }
        
    }
   
    public class ZaposleniModel
    {
        public int ID_Zaposleni { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Ime_Roditelja { get; set; }
        public string Radna_Pozicija { get; set; }
        public string JMBG { get; set; }
        public string Kontakt { get; set; }
        public DateTime Datum_Rodjenja { get; set; }

        public string PunoIme
        {
            get { return $"{Ime}, {Prezime} -{ID_Zaposleni}"; }
            
        }

    }
    public class UplateModel
    {
        public int ID_Uplata { get; set; }
        public int ID_Polaznik { get; set; }
        public float Iznos { get; set; }
        public DateTime Datum_Uplate { get; set; }
    }
    public class GrupeModel
    {
        public int ID_Grupa { get; set; }
        public string Ime_Grupe { get; set; }
        public int Broj_Polaznika { get; set; }
        public int ID_Zaposleni { get; set; }
    }
}
