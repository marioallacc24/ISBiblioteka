using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ISBiblioteka
{
    /// <summary>
    /// Interaction logic for Izdavanje.xaml
    /// </summary>
    public partial class Izdavanje : Window
    {
        public Izdavanje()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            UcitajKnjige();


        }

        private void Dugme_Otkazi_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Dugme_Izdaj_Click(object sender, RoutedEventArgs e)
        {
            IzdavanjeKnjiga izdavanjeKnjiga = new IzdavanjeKnjiga();
            izdavanjeKnjiga.Show();
            
        }

        private void UcitajKnjige()
        {
            
            SQLiteConnection sql_con = new SQLiteConnection("Data Source=db_ISBiblioteka.db;Version=3;");   //podesavanje konekcije
            sql_con.Open(); //otvaranje kenekcije
            SQLiteCommand sql_cmd = sql_con.CreateCommand();    //podesavanje komandnog objekta na konekciju
            sql_cmd.CommandText = "SELECT * FROM knjiga"; //u komandni objekat saljemo sql zahtev
            SQLiteDataAdapter DB = new SQLiteDataAdapter(sql_cmd.CommandText, sql_con); //sql adapter db izvrsava komandnu odnonso u sebi cuva rezultate sql zahteva (ucitao sve podatke u sebe)
            sql_con.Close();    //zatavaramo konekciju
            DataSet DS = new DataSet();     //kreiramo objekta data set koji ce da cuva poadtke iz data dabtera
            DB.Fill(DS);    //dataset punimo podacima iz adaptera


            if (DS.Tables[0].Rows.Count > 0)
            {
                izdavanjeDataGrid.ItemsSource = DS.Tables[0].DefaultView;
            }
        }

        private void Dugme_Obrisi_Click(object sender, RoutedEventArgs e)
        {
            BrisanjeKnjige brisanjeKnjige = new BrisanjeKnjige();
            brisanjeKnjige.ShowDialog();
        }

        private  void Dugme_Osvezi_Click(object sender, RoutedEventArgs e)
        {
            UcitajKnjige();

        }
    }
}
