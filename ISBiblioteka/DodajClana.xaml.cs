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
    /// Interaction logic for DodajClana.xaml
    /// </summary>
    public partial class DodajClana : Window
    {
        public DodajClana()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        public void ResetFields()
        {
            idClanTextBox.Text = "";
            imeTextBox.Text = "";
            prezimeTextBox.Text = "";
            emailTextBox.Text = "";
            brojTelefonaTextBox.Text = "";
            jmbgTextBox.Text = "";
            brojIndeksaTextBox.Text = "";
            fakultetComoBox.SelectedValue = null;
            godinaUpisaDatePicker.SelectedDate = null;
            datumUclanjivanjaDatePicker.SelectedDate = null;



        }
        public bool TestPolja()
        {
            bool verifikacija = false;

            bool verifikacija1 = false;
            bool verifikacija2 = false;
            bool verifikacija3 = false;
            bool verifikacija4 = false;
            bool verifikacija5 = false;
            bool verifikacija6 = false;
            bool verifikacija7 = false;
            bool verifikacija8 = false;
            bool verifikacija9 = false;
            bool verifikacija10 = false;

            if (string.IsNullOrWhiteSpace(idClanTextBox.Text) || System.Text.RegularExpressions.Regex.IsMatch(idClanTextBox.Text, "[^0-9]"))
            {
                idClanTextBox.Background = Brushes.Red;
                verifikacija1 = false;
            }
            else
            {
                idClanTextBox.Background = null;
                verifikacija1 = true;
            }

            if (string.IsNullOrWhiteSpace(imeTextBox.Text))
            {
                imeTextBox.Background = Brushes.Red;
                verifikacija2 = false;
            }
            else
            {
                imeTextBox.Background = null;
                verifikacija2 = true;
            }

            if (string.IsNullOrWhiteSpace(prezimeTextBox.Text))
            {
                prezimeTextBox.Background = Brushes.Red;
                verifikacija3 = false;
            }
            else
            {
                prezimeTextBox.Background = null;
                verifikacija3 = true;
            }

            if (string.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                emailTextBox.Background = Brushes.Red;
                verifikacija4 = false;
            }
            else
            {
                emailTextBox.Background = null;
                verifikacija4 = true;
            }

            if (string.IsNullOrWhiteSpace(brojTelefonaTextBox.Text) || System.Text.RegularExpressions.Regex.IsMatch(brojTelefonaTextBox.Text, "[^0-9]"))
            {
                brojTelefonaTextBox.Background = Brushes.Red;
                verifikacija5 = false;
            }
            else
            {
                brojTelefonaTextBox.Background = null;
                verifikacija5 = true;
            }

            if (string.IsNullOrWhiteSpace(jmbgTextBox.Text) || System.Text.RegularExpressions.Regex.IsMatch(jmbgTextBox.Text, "[^0-9]"))
            {
                jmbgTextBox.Background = Brushes.Red;
                verifikacija6 = false;
            }
            else
            {
                jmbgTextBox.Background = null;
                verifikacija6 = true;
            }

            if (string.IsNullOrEmpty(brojIndeksaTextBox.Text))
            {
                brojIndeksaTextBox.Background = Brushes.Red;
                verifikacija7 = false;
            }
            else
            {
                brojIndeksaTextBox.Background = null;
                verifikacija7 = true;
            }

            if (string.IsNullOrEmpty(fakultetComoBox.Text))
            {
                fakultetComoBox.Background = Brushes.Red;
                verifikacija8 = false;
            }
            else
            {
                fakultetComoBox.Background = null;
                verifikacija8 = true;
            }
            if (string.IsNullOrEmpty(godinaUpisaDatePicker.Text))
            {
                godinaUpisaDatePicker.Background = Brushes.Red;
                verifikacija9 = false;
            }
            else
            {
                godinaUpisaDatePicker.Background = null;
                verifikacija9 = true;
            }
            if (string.IsNullOrEmpty(datumUclanjivanjaDatePicker.Text))
            {
                datumUclanjivanjaDatePicker.Background = Brushes.Red;
                verifikacija10 = false;
            }
            else
            {
                datumUclanjivanjaDatePicker.Background = null;
                verifikacija10 = true;
            }
           
            if(verifikacija1 && verifikacija2 && verifikacija3 && verifikacija4 && verifikacija5 && verifikacija6 && verifikacija7 && verifikacija8 && verifikacija9 && verifikacija10)
            {
                return verifikacija = true;
            } else
            {
                return verifikacija = false;
            }

            
        }

        private void Dugme_Sacuvaj_Click(object sender, RoutedEventArgs e)
        {
            if (TestPolja())
            {
                MessageBox.Show("Polja su pravilno popunjena", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
              
                MessageBox.Show("Polja nisu pravilno popunjena", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Error);
                
            }
        }

        private void Dugme_Otkazi_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Dugme_Obrisi_Click(object sender, RoutedEventArgs e)
        {
            ResetFields();
        }
    }
}
