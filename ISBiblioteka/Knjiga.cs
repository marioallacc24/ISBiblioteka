using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISBiblioteka
{
    class Knjiga
    {
        public int id;
        public string isbn;
        public string naziv;
        public string autor;
        public string opis;
        public string kategorija;
        public string izdavac;
        public string format;
        public int kolicina;
        public string datumDodavanja;
        public string datumIzdavanja;
        


        public Knjiga()
        {

        }

        public Knjiga(int id,string isbn,string naziv, string autor, string opis, string kategorija, string izdavac, string format, int kolicina, string datumIzdavanja, string datumDodavanja)
        {
            this.id = id;
            this.isbn = isbn;
            this.naziv = naziv;
            this.autor = autor;
            this.opis = opis;
            this.kategorija = kategorija;
            this.izdavac = izdavac;
            this.format = format;
            this.kolicina = kolicina;
            this.datumDodavanja = datumDodavanja;
            this.datumIzdavanja = datumIzdavanja;
        }
    }
}
