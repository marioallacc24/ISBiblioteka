using System;
using System.Collections.Generic;
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
using System.Data;
using System.Data.SQLite;

namespace ISBiblioteka.Windows
{
    /// <summary>
    /// Interaction logic for Vracanje.xaml
    /// </summary>
    public partial class Vracanje : Window
    {
        public Vracanje()
        {
            InitializeComponent();
            UcitajZaduzenja();
            AddHotKeys();
        }

        private void AddHotKeys()
        {
            try
            {
                RoutedCommand firstSettings = new RoutedCommand();
                firstSettings.InputGestures.Add(new KeyGesture(Key.Enter));
                CommandBindings.Add(new CommandBinding(firstSettings, Dugme_Vrati_Click));

                RoutedCommand secondSettings = new RoutedCommand();
                secondSettings.InputGestures.Add(new KeyGesture(Key.Escape));
                CommandBindings.Add(new CommandBinding(secondSettings, Dugme_Otkazi_Click));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void Dugme_Otkazi_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Dugme_Vrati_Click(object sender, RoutedEventArgs e)
        {
            if (TestPolja())
            {
                SqlDataAccess sql = new SqlDataAccess();
                

                if(sql.BrisanjeZaduzenja(int.Parse(idZaduzenja.Text)) && sql.PromenaDugovanjaVratio(int.Parse(idZaduzenja.Text)))
                {

                    MessageBox.Show("Knjiga je uspešno vraćenja", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Information);
                    UcitajZaduzenja();
                }
                else
                {
                    MessageBox.Show("Pogrešni ID", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Error);
                }

               // MessageBox.Show("Polja su pravilno popunjena", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Information);
            } else
            {
                MessageBox.Show("Polja nisu pravilno popunjena", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Dugme_Osvezi_Click(object sender, RoutedEventArgs e)
        {
            UcitajZaduzenja();
        }

        private void UcitajZaduzenja()
        {
            SQLiteConnection sql_con = new SQLiteConnection("Data Source=db_ISBiblioteka.db;Version=3;");   //podesavanje konekcije
            sql_con.Open(); //otvaranje kenekcije
            SQLiteCommand sql_cmd = sql_con.CreateCommand();    //podesavanje komandnog objekta na konekciju
            sql_cmd.CommandText = "SELECT * FROM pogled_zaduzenja"; //u komandni objekat saljemo sql zahtev
            SQLiteDataAdapter DB = new SQLiteDataAdapter(sql_cmd.CommandText, sql_con); //sql adapter db izvrsava komandnu odnonso u sebi cuva rezultate sql zahteva (ucitao sve podatke u sebe)
            sql_con.Close();    //zatavaramo konekciju
            DataSet DS = new DataSet();     //kreiramo objekta data set koji ce da cuva poadtke iz data dabtera

            DB.Fill(DS);    //dataset punimo podacima iz adaptera


            if (DS.Tables[0].Rows.Count > 0)
            {
                vracanjeDataGrid.ItemsSource = DS.Tables[0].DefaultView;
            }
        }

        private bool TestPolja()
        {
            bool verifikacija = true;

            if(string.IsNullOrWhiteSpace(idZaduzenja.Text) || System.Text.RegularExpressions.Regex.IsMatch(idZaduzenja.Text, "[^0-9]"))
            {
                idZaduzenja.Background = Brushes.Red;
                verifikacija = false;
                return verifikacija;
            }
            else
            {
                idZaduzenja.Background = null;
                verifikacija = true;
                return verifikacija;
            }
        
        }

        
        
    }
}
