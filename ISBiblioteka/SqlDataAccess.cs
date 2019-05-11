using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SQLite;
using System.Data;
using System.Windows;

namespace ISBiblioteka
{
    public class SqlDataAccess

    {
        public SqlDataAccess()
        {
        }
        

        public bool CuvanjeKnjige(Knjiga knjiga)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=db_ISBiblioteka.db;Version=3;");
            if (m_dbConnection.State == ConnectionState.Closed)
                m_dbConnection.Open();

            try
            {


                String query = "insert into knjiga(id,isbn,naziv,autor,opis,kategorija,izdavac,format,kolicina,datumDodavanja,datumIzdavanja,dostupno)values('" + knjiga.Id + "','" + knjiga.Isbn + "','" + knjiga.Naziv + "','" + knjiga.Autor + "','" + knjiga.Opis + "','" + knjiga.Kategorija + "','" + knjiga.Izdavac + "','" + knjiga.Format + "','" + knjiga.Kolicina + "','" + knjiga.DatumDodavanja + "','" + knjiga.DatumIzdavanja + "','" + knjiga.Kolicina + "')";
                SQLiteCommand cmd = new SQLiteCommand(query, m_dbConnection);
                cmd.ExecuteNonQuery();
                return true;
               

                

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                m_dbConnection.Close();
            }

        }

        public bool CuvanjeClana(Clan clan)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=db_ISBiblioteka.db;Version=3;");
            if (m_dbConnection.State == ConnectionState.Closed)
                m_dbConnection.Open();

            try
            {


                String query = "insert into clan(id,ime,prezime,email,brojTelefona,jmbg,jeStudent,brIndeksa,fakultet,godinaUpisa,datumUclanjivanja,dugovanja)values('" + clan.Id + "','" + clan.Ime + "','" + clan.Prezime + "','" + clan.Email + "','" + clan.BrojTelefona + "','" + clan.Jmbg + "','" + clan.JeStudent + "','" + clan.BrojIndeksa + "','" + clan.Fakultet + "','" + clan.GodinaUpisa + "','" + clan.DatumUclanjivanja + "','" + clan.Dugovanje + "')";
                SQLiteCommand cmd = new SQLiteCommand(query, m_dbConnection);
                cmd.ExecuteNonQuery();
                return true;





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                m_dbConnection.Close();
            }

        }

        public bool CuvanjeIzmeneClan(int id, Clan clan)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=db_ISBiblioteka.db;Version=3;");
            if (m_dbConnection.State == ConnectionState.Closed)
                m_dbConnection.Open();

            try
            {

                

                String query = "UPDATE clan SET ime = '" + clan.Ime + "',prezime = '" + clan.Prezime + "',email='" + clan.Email + "' ,brojTelefona='" + clan.BrojTelefona + "' ,jmbg= '" + clan.Jmbg + "',jeStudent='" + clan.JeStudent + "' ,brIndeksa= '" + clan.BrojIndeksa + "',fakultet= '" + clan.Fakultet + "',godinaUpisa= '" + clan.GodinaUpisa + "',datumUclanjivanja= '" + clan.DatumUclanjivanja + "' where id = (" + id + ")";
                SQLiteCommand cmd = new SQLiteCommand(query, m_dbConnection);
                cmd.ExecuteNonQuery();
                return true;





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                m_dbConnection.Close();
            }
        }

        public bool CuvanjeIzmeneKnjiga(int id, Knjiga knjiga)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=db_ISBiblioteka.db;Version=3;");
            if (m_dbConnection.State == ConnectionState.Closed)
                m_dbConnection.Open();

            try
            {



                String query = "UPDATE knjiga SET isbn = '" + knjiga.Isbn + "',naziv = '" + knjiga.Naziv + "',autor='" + knjiga.Autor + "' ,opis='" + knjiga.Opis + "' ,kategorija= '" + knjiga.Kategorija + "',izdavac='" + knjiga.Izdavac + "' ,format= '" + knjiga.Format + "',kolicina= '" + knjiga.Kolicina + "',datumDodavanja= '" + knjiga.DatumDodavanja + "',datumIzdavanja= '" + knjiga.DatumIzdavanja + "' where id = (" + id + ")";
                SQLiteCommand cmd = new SQLiteCommand(query, m_dbConnection);
                cmd.ExecuteNonQuery();
                return true;





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                m_dbConnection.Close();
            }
        }
        public bool CuvanjeZaduzenja(int idZaduzenja, int idClana, int idKnjiga, string datumZaduzenja, string datumRazduzenja)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=db_ISBiblioteka.db;Version=3;");
            if (m_dbConnection.State == ConnectionState.Closed)
                m_dbConnection.Open();

            try
            {


                String query = "insert into zaduzenja(id,idClan,idKnjiga,datumZaduzenja,datumRazduzenja)values('" + idZaduzenja + "','" + idClana + "','" + idKnjiga + "','" + datumZaduzenja + "','" + datumRazduzenja + "')";
                SQLiteCommand cmd = new SQLiteCommand(query, m_dbConnection);
                cmd.ExecuteNonQuery();
                return true;





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                m_dbConnection.Close();
            }

        }

        public bool BrisanjeClana(int id)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=db_ISBiblioteka.db;Version=3;");
            if (m_dbConnection.State == ConnectionState.Closed)
                m_dbConnection.Open();

            try
            {

                String query = "DELETE FROM clan WHERE id=(" + id + ")";
                SQLiteCommand cmd = new SQLiteCommand(query, m_dbConnection);
                cmd.ExecuteNonQuery();
                return true;





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                m_dbConnection.Close();
            }

        }

        public bool BrisanjeKnjiga(int id)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=db_ISBiblioteka.db;Version=3;");
            if (m_dbConnection.State == ConnectionState.Closed)
                m_dbConnection.Open();

            try
            {

                String query = "DELETE FROM knjiga WHERE id=(" + id + ")";
                SQLiteCommand cmd = new SQLiteCommand(query, m_dbConnection);
                cmd.ExecuteNonQuery();
                return true;





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                m_dbConnection.Close();
            }
        }

        public bool BrisanjeZaduzenja(int id)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=db_ISBiblioteka.db;Version=3;");
            if (m_dbConnection.State == ConnectionState.Closed)
                m_dbConnection.Open();

            try
            {

                String query = "DELETE FROM zaduzenja WHERE id=(" + id + ")";
                SQLiteCommand cmd = new SQLiteCommand(query, m_dbConnection);
                cmd.ExecuteNonQuery();
                return true;





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                m_dbConnection.Close();
            }
        }

        public bool PromenaDugovanja(int id)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=db_ISBiblioteka.db;Version=3;");
            if (m_dbConnection.State == ConnectionState.Closed)
                m_dbConnection.Open();

            try
            {

                String query = "UPDATE clan SET dugovanja = 'True' where id=(" + id + ")";
                SQLiteCommand cmd = new SQLiteCommand(query, m_dbConnection);
                cmd.ExecuteNonQuery();
                return true;





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                m_dbConnection.Close();
            }

        }
        public bool PromenaDugovanjaVratio(int id)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=db_ISBiblioteka.db;Version=3;");
            if (m_dbConnection.State == ConnectionState.Closed)
                m_dbConnection.Open();

            try
            {

                String query = "UPDATE clan SET dugovanja = 'False' where id=(" + id + ")";
                SQLiteCommand cmd = new SQLiteCommand(query, m_dbConnection);
                cmd.ExecuteNonQuery();
                return true;





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                m_dbConnection.Close();
            }

        }

        public Clan IscitavanjeClan(int id)
        {

            SQLiteConnection sql_con = new SQLiteConnection("Data Source=db_ISBiblioteka.db;Version=3;");   //podesavanje konekcije
            sql_con.Open(); //otvaranje kenekcije
            SQLiteCommand sql_cmd = sql_con.CreateCommand();    //podesavanje komandnog objekta na konekciju
            sql_cmd.CommandText = "SELECT * FROM clan WHERE id=(" + id + ")"; //u komandni objekat saljemo sql zahtev
            SQLiteDataAdapter DB = new SQLiteDataAdapter(sql_cmd.CommandText, sql_con); //sql adapter db izvrsava komandnu odnonso u sebi cuva rezultate sql zahteva (ucitao sve podatke u sebe)
            sql_con.Close();    //zatavaramo konekciju
            DataSet DS = new DataSet();     //kreiramo objekta data set koji ce da cuva poadtke iz data dabtera
            DB.Fill(DS);    //dataset punimo podacima iz adaptera

            try
            {
                string ime = DS.Tables[0].Rows[0]["ime"].ToString();
                string prezime = DS.Tables[0].Rows[0]["prezime"].ToString();
                string email = DS.Tables[0].Rows[0]["email"].ToString();
                string brojTelefona = DS.Tables[0].Rows[0]["brojTelefona"].ToString();
                string jmbg = DS.Tables[0].Rows[0]["jmbg"].ToString();
                bool jeStudent = (bool)DS.Tables[0].Rows[0]["jeStudent"];
                string brIndeksa = DS.Tables[0].Rows[0]["brIndeksa"].ToString();
                string fakultet = DS.Tables[0].Rows[0]["fakultet"].ToString();
                string godinaUpisa = DS.Tables[0].Rows[0]["godinaUpisa"].ToString();
                string datumUclanjivanja = DS.Tables[0].Rows[0]["datumUclanjivanja"].ToString();

                Clan clan = new Clan(id, ime, prezime, email, brojTelefona, jmbg, jeStudent, brIndeksa, fakultet, godinaUpisa, datumUclanjivanja);
                return clan;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            return null;
               
        }

        public Knjiga IscitavanjeKnjiga(int id)
        {

            SQLiteConnection sql_con = new SQLiteConnection("Data Source=db_ISBiblioteka.db;Version=3;");   //podesavanje konekcije
            sql_con.Open(); //otvaranje kenekcije
            SQLiteCommand sql_cmd = sql_con.CreateCommand();    //podesavanje komandnog objekta na konekciju
            sql_cmd.CommandText = "SELECT * FROM knjiga WHERE id=(" + id + ")"; //u komandni objekat saljemo sql zahtev
            SQLiteDataAdapter DB = new SQLiteDataAdapter(sql_cmd.CommandText, sql_con); //sql adapter db izvrsava komandnu odnonso u sebi cuva rezultate sql zahteva (ucitao sve podatke u sebe)
            sql_con.Close();    //zatavaramo konekciju
            DataSet DS = new DataSet();     //kreiramo objekta data set koji ce da cuva poadtke iz data dabtera
            DB.Fill(DS);    //dataset punimo podacima iz adaptera

            try
            {
                string isbn = DS.Tables[0].Rows[0]["isbn"].ToString();
                string naziv = DS.Tables[0].Rows[0]["naziv"].ToString();
                string autor = DS.Tables[0].Rows[0]["autor"].ToString();
                string opis = DS.Tables[0].Rows[0]["opis"].ToString();
                string kategorija = DS.Tables[0].Rows[0]["kategorija"].ToString();
                string izdavac = DS.Tables[0].Rows[0]["izdavac"].ToString();
                string format = DS.Tables[0].Rows[0]["format"].ToString();
                int kolicina = Convert.ToInt32(DS.Tables[0].Rows[0]["kolicina"]);
                


                string datumDodavanja = DS.Tables[0].Rows[0]["datumDodavanja"].ToString();
                string datumIzdavanja = DS.Tables[0].Rows[0]["datumIzdavanja"].ToString();

                Knjiga knjiga = new Knjiga(id, isbn, naziv, autor, opis, kategorija, izdavac, format, kolicina, datumDodavanja, datumIzdavanja);
                return knjiga;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            return null;

        }
    }
}
