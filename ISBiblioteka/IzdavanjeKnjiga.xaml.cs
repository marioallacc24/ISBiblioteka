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

namespace ISBiblioteka
{
    /// <summary>
    /// Interaction logic for IzdavanjeKnjiga.xaml
    /// </summary>
    public partial class IzdavanjeKnjiga : Window
    {
        public IzdavanjeKnjiga()
        {
            InitializeComponent();
        }

        private void Dugme_Potvrdi_Click(object sender, RoutedEventArgs e)
        {
            if (TestPolja())
            {
                MessageBox.Show("Polja su pravilno popunjena", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Information);
            } else
            {
                MessageBox.Show("Polja nisu pravilno popunjena", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Error);
            }


        }

        private void Dugme_Otkazi_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private bool TestPolja()
        {
            bool verifikacija = true;

            bool verifikacija1 = true;
            bool verifikacija2 = true;
            bool verifikacija3 = true;
            bool verifikacija4 = true;
            bool verifikacija5 = true;

            if (string.IsNullOrWhiteSpace(idZaduzenjaTextBox.Text) || System.Text.RegularExpressions.Regex.IsMatch(idZaduzenjaTextBox.Text, "[^0-9]"))
            {
                idZaduzenjaTextBox.Background = Brushes.Red;
                verifikacija1 = false;
                
            }else
            {
                idZaduzenjaTextBox.Background = null;
                verifikacija1 = true;
            }

            if (string.IsNullOrWhiteSpace(idKnjigeTextBox.Text) || System.Text.RegularExpressions.Regex.IsMatch(idKnjigeTextBox.Text, "[^0-9]"))
            {
                idKnjigeTextBox.Background = Brushes.Red;
                verifikacija2 = false;

            }
            else
            {
                idKnjigeTextBox.Background = null;
                verifikacija2 = true;
            }

            if (string.IsNullOrWhiteSpace(idClanaTextBox.Text) || System.Text.RegularExpressions.Regex.IsMatch(idClanaTextBox.Text, "[^0-9]"))
            {
                idClanaTextBox.Background = Brushes.Red;
                verifikacija3 = false;

            }
            else
            {
                idClanaTextBox.Background = null;
                verifikacija3 = true;
            }

            if (string.IsNullOrWhiteSpace(datumIzdavanjaDatePicker.Text) )
            {
                datumIzdavanjaDatePicker.Background = Brushes.Red;
                verifikacija4 = false;

            }
            else
            {
                datumIzdavanjaDatePicker.Background = null;
                verifikacija4 = true;
            }

            if (string.IsNullOrWhiteSpace(datumRazduzenjaDatePicker.Text))
            {
                datumRazduzenjaDatePicker.Background = Brushes.Red;
                verifikacija5 = false;

            }
            else
            {
                datumRazduzenjaDatePicker.Background = null;
                verifikacija5 = true;
            }

            if (verifikacija1 && verifikacija2 && verifikacija3 && verifikacija4 && verifikacija5)
                return true;
            else return false;
        }
    }
}
