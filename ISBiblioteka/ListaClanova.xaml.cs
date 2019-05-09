using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
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
    /// Interaction logic for ListaClanova.xaml
    /// </summary>
    public partial class ListaClanova : Window
    {
        public ListaClanova()
        {
            InitializeComponent();
            UcitajClanove();
        }

        private void Dugme_Otkazi_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void UcitajClanove()
        {

            SQLiteConnection sql_con = new SQLiteConnection("Data Source=db_ISBiblioteka.db;Version=3;");   //podesavanje konekcije
            sql_con.Open(); //otvaranje kenekcije
            SQLiteCommand sql_cmd = sql_con.CreateCommand();    //podesavanje komandnog objekta na konekciju
            sql_cmd.CommandText = "SELECT * FROM clan"; //u komandni objekat saljemo sql zahtev
            SQLiteDataAdapter DB = new SQLiteDataAdapter(sql_cmd.CommandText, sql_con); //sql adapter db izvrsava komandnu odnonso u sebi cuva rezultate sql zahteva (ucitao sve podatke u sebe)
            sql_con.Close();    //zatavaramo konekciju
            DataSet DS = new DataSet();     //kreiramo objekta data set koji ce da cuva poadtke iz data dabtera
            DB.Fill(DS);    //dataset punimo podacima iz adaptera


            clanoviListView.ItemsSource = DS.Tables[0].DefaultView;   //data set podatke ispisujemo u listview
        }

        private void Dugme_Obrisi_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
