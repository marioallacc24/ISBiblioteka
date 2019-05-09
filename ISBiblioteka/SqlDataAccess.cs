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


                String query = "insert into knjiga(id,isbn,naziv,autor,opis,kategorija,izdavac,format,kolicina,datumDodavanja,datumIzdavanja)values('" + knjiga.Id + "','" + knjiga.Isbn + "','" + knjiga.Naziv + "','" + knjiga.Autor + "','" + knjiga.Opis + "','" + knjiga.Kategorija + "','" + knjiga.Izdavac + "','" + knjiga.Format + "','" + knjiga.Kolicina + "','" + knjiga.DatumDodavanja + "','" + knjiga.DatumIzdavanja + "')";
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


                String query = "insert into clan(id,ime,prezime,email,brojTelefona,jmbg,jeStudent,brIndeksa,fakultet,godinaUpisa,datumUclanjivanja)values('" + clan.Id + "','" + clan.Ime + "','" + clan.Prezime + "','" + clan.Email + "','" + clan.BrojTelefona + "','" + clan.Jmbg + "','" + clan.JeStudent + "','" + clan.BrojIndeksa + "','" + clan.Fakultet + "','" + clan.GodinaUpisa + "','" + clan.DatumUclanjivanja + "')";
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
