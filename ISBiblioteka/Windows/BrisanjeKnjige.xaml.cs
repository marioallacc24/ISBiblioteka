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

namespace ISBiblioteka.Windows
{
    /// <summary>
    /// Interaction logic for BrisanjeKnjige.xaml
    /// </summary>
    public partial class BrisanjeKnjige : Window
    {
        public BrisanjeKnjige()
        {
            InitializeComponent();
            AddHotKeys();
        }

        private void AddHotKeys()
        {
            try
            {
                RoutedCommand firstSettings = new RoutedCommand();
                firstSettings.InputGestures.Add(new KeyGesture(Key.Enter));
                CommandBindings.Add(new CommandBinding(firstSettings, Dugme_Potvrdi_Click));

                RoutedCommand secondSettings = new RoutedCommand();
                secondSettings.InputGestures.Add(new KeyGesture(Key.Escape));
                CommandBindings.Add(new CommandBinding(secondSettings, Dugme_Otkazi_Click));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private bool TestPolja()
        {
            bool verifikacija = true;

            if (string.IsNullOrWhiteSpace(idTextBox.Text) || System.Text.RegularExpressions.Regex.IsMatch(idTextBox.Text, "[^0-9]"))
            {
                idTextBox.Background = Brushes.Red;
                verifikacija = false;
                return verifikacija;
            } else
            {
                idTextBox.Background = null;
                verifikacija = true;
                return verifikacija;
            }
        }

        private void Dugme_Potvrdi_Click(object sender, RoutedEventArgs e)
        {

            if (TestPolja())
            {
                //MessageBox.Show("Polja su pravilno popunjena", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Information);

                SqlDataAccess sql = new SqlDataAccess();
                

                if (sql.BrisanjeKnjiga(int.Parse(idTextBox.Text)))
                {
                    MessageBox.Show("Knjiga je uspešno obrisana", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Knjiga nije obrisan", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Error);
                }



                
            } else
            {
                MessageBox.Show("Polja nisu pravilno popunjena", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            Close();

        }

        private void Dugme_Otkazi_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
