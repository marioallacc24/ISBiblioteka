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
    }
}
