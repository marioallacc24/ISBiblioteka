using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISBiblioteka
{
    public class Clan
    {

        private int id;
        private string ime;
        private string prezime;
        private string email;
        private string brojTelefona;
        private string jmbg;
        private bool jeStudent;
        private string brojIndeksa;
        private string fakultet;
        private string godinaUpisa;
        private string datumUclanjivanja;
        private bool dugovanje;

        public int Id { get => id; set => id = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Email { get => email; set => email = value; }
        public string BrojTelefona { get => brojTelefona; set => brojTelefona = value; }
        public string Jmbg { get => jmbg; set => jmbg = value; }
        public bool JeStudent { get => jeStudent; set => jeStudent = value; }
        public string BrojIndeksa { get => brojIndeksa; set => brojIndeksa = value; }
        public string Fakultet { get => fakultet; set => fakultet = value; }
        public string GodinaUpisa { get => godinaUpisa; set => godinaUpisa = value; }
        public string DatumUclanjivanja { get => datumUclanjivanja; set => datumUclanjivanja = value; }
        public bool Dugovanje { get => dugovanje; set => dugovanje = value; }

        public Clan() {
        }

        public Clan(int id,string ime,string prezime,string email,string brojTelefona, string jmbg, bool jeStudent, string brojIndeksa, string fakultet, string godinaUpisa, string datumUclanjivanja)
        {
            Id = id;
            Ime = ime;
            Prezime = prezime;
            Email = email;
            Jmbg = jmbg;
            BrojTelefona = brojTelefona;
            JeStudent = jeStudent;
            BrojIndeksa = brojIndeksa;
            Fakultet = fakultet;
            GodinaUpisa = godinaUpisa;
            DatumUclanjivanja = datumUclanjivanja;
            Dugovanje = false;
        }
    }
}
