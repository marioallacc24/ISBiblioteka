using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISBiblioteka
{
    public class Knjiga
    {
        private int id;
        private string isbn;
        private string naziv;
        private string autor;
        private string opis;
        private string kategorija;
        private string izdavac;
        private string format;
        private int kolicina;
        private string datumDodavanja;
        private string datumIzdavanja;

        public int Id { get => id; set => id = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Opis { get => opis; set => opis = value; }
        public string Kategorija { get => kategorija; set => kategorija = value; }
        public string Izdavac { get => izdavac; set => izdavac = value; }
        public string Format { get => format; set => format = value; }
        public int Kolicina { get => kolicina; set => kolicina = value; }
        public string DatumDodavanja { get => datumDodavanja; set => datumDodavanja = value; }
        public string DatumIzdavanja { get => datumIzdavanja; set => datumIzdavanja = value; }

        public Knjiga()
        {

        }

        public Knjiga(int id,string isbn,string naziv, string autor, string opis, string kategorija, string izdavac, string format, int kolicina, string datumIzdavanja, string datumDodavanja)
        {
            this.Id = id;
            this.Isbn = isbn;
            this.Naziv = naziv;
            this.Autor = autor;
            this.Opis = opis;
            this.Kategorija = kategorija;
            this.Izdavac = izdavac;
            this.Format = format;
            this.Kolicina = kolicina;
            this.DatumDodavanja = datumDodavanja;
            this.DatumIzdavanja = datumIzdavanja;
        }
        
    }
}
