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
    /// Interaction logic for DodajKnjigu.xaml
    /// </summary>
    public partial class DodajKnjigu : Window
    {
        public DodajKnjigu()
        {
            InitializeComponent();
            
        }

        public void ResetFields()
        {
            idTextBox.Text = "";
            idTextBox.Background = null;
            isbnTextBox.Text = "";
            isbnTextBox.Background = null;
            nazivTextBox.Text = "";
            nazivTextBox.Background = null;
            autorTextBox.Text = "";
            autorTextBox.Background = null;
            opisTextBox.Text = "";
            opisTextBox.Background = null;
            izdavacTextBox.Text = "";
            izdavacTextBox.Background = null;
            kategorijaComoBox.SelectedValue = null;
            kategorijaComoBox.Background = null;
            formatComboBox.SelectedValue = null;
            formatComboBox.Background = null;
            kolicinaComboBox.SelectedValue = null;
            kolicinaComboBox.Background = null;
            datumIzdavanjaDatePicker.SelectedDate = null;
            datumIzdavanjaDatePicker.Background = null;
            datumDodavanjaDatePicker.SelectedDate = null;
            datumDodavanjaDatePicker.Background = null;


        }

        public bool TestPolja()
        {
            bool verifikacija = true;
            
            if (string.IsNullOrWhiteSpace(idTextBox.Text) || System.Text.RegularExpressions.Regex.IsMatch(idTextBox.Text, "[^0-9]"))
            {
                idTextBox.Background = Brushes.Red;
                verifikacija = false;
            } else
            {
                idTextBox.Background = null;
                verifikacija = true;
            }

            if (string.IsNullOrWhiteSpace(isbnTextBox.Text) || System.Text.RegularExpressions.Regex.IsMatch(isbnTextBox.Text, "[^0-9]"))
            {
                isbnTextBox.Background = Brushes.Red;
                verifikacija = false;
            } else
            {
                isbnTextBox.Background = null;
                verifikacija = true;
            }

            if (string.IsNullOrWhiteSpace(nazivTextBox.Text))
            {
                nazivTextBox.Background = Brushes.Red;
                verifikacija = false;
            } else
            {
                nazivTextBox.Background = null;
                verifikacija = true;
            }

            if (string.IsNullOrWhiteSpace(autorTextBox.Text))
            {
                autorTextBox.Background = Brushes.Red;
                verifikacija = false;
            } else
            {
                autorTextBox.Background = null;
                verifikacija = true;
            }

            if (string.IsNullOrWhiteSpace(opisTextBox.Text))
            {
                opisTextBox.Background = Brushes.Red;
                verifikacija = false;
            }
            else
            {
                opisTextBox.Background = null;
                verifikacija = true;
            }

            if (string.IsNullOrWhiteSpace(izdavacTextBox.Text))
            {
                izdavacTextBox.Background = Brushes.Red;
                verifikacija = false;
            }
            else
            {
                izdavacTextBox.Background = null;
                verifikacija = true;
            }

            if (string.IsNullOrEmpty(kategorijaComoBox.Text))
            {
                kategorijaComoBox.Background = Brushes.Red;
                verifikacija = false;
            }else
            {
                kategorijaComoBox.Background = null;
                verifikacija = true;
            }

            if (string.IsNullOrEmpty(formatComboBox.Text))
            {
                formatComboBox.Background = Brushes.Red;
                verifikacija = false;
            }
            else
            {
                formatComboBox.Background = null;
                verifikacija = true;
            }
            if (string.IsNullOrEmpty(kolicinaComboBox.Text) || System.Text.RegularExpressions.Regex.IsMatch(kolicinaComboBox.Text, "[^0-9]"))
            {
                kolicinaComboBox.Background = Brushes.Red;
                verifikacija = false;
            }
            else
            {
                kolicinaComboBox.Background = null;
                verifikacija = true;
            }
            if (string.IsNullOrEmpty(datumDodavanjaDatePicker.Text))
            {
                datumDodavanjaDatePicker.Background = Brushes.Red;
                verifikacija = false;
            }
            else
            {
                datumDodavanjaDatePicker.Background = null;
                verifikacija = true;
            }
            if (string.IsNullOrEmpty(datumIzdavanjaDatePicker.Text))
            {
                datumIzdavanjaDatePicker.Background = Brushes.Red;
                verifikacija = false;
            }
            else
            {
                datumIzdavanjaDatePicker.Background = null;
                verifikacija = true;
            }


            return verifikacija;
        }

        private void Dugme_Otkazi_Click(object sender, RoutedEventArgs e)
        {
            Close();
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

        private void Dugme_Obrisi_Click(object sender, RoutedEventArgs e)
        {
            ResetFields();
        }
    }
}
