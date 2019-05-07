using System;
using System.Collections.Generic;
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
            bool verifikacija11 = false;

            if (string.IsNullOrWhiteSpace(idTextBox.Text) || System.Text.RegularExpressions.Regex.IsMatch(idTextBox.Text, "[^0-9]"))
            {
                idTextBox.Background = Brushes.Red;
                verifikacija1 = false;
            } else
            {
                idTextBox.Background = null;
                verifikacija1 = true;
            }

            if (string.IsNullOrWhiteSpace(isbnTextBox.Text) || System.Text.RegularExpressions.Regex.IsMatch(isbnTextBox.Text, "[^0-9]"))
            {
                isbnTextBox.Background = Brushes.Red;
                verifikacija2 = false;
            } else
            {
                isbnTextBox.Background = null;
                verifikacija2 = true;
            }

            if (string.IsNullOrWhiteSpace(nazivTextBox.Text))
            {
                nazivTextBox.Background = Brushes.Red;
                verifikacija3 = false;
            } else
            {
                nazivTextBox.Background = null;
                verifikacija3 = true;
            }

            if (string.IsNullOrWhiteSpace(autorTextBox.Text))
            {
                autorTextBox.Background = Brushes.Red;
                verifikacija4 = false;
            } else
            {
                autorTextBox.Background = null;
                verifikacija4 = true;
            }

            if (string.IsNullOrWhiteSpace(opisTextBox.Text))
            {
                opisTextBox.Background = Brushes.Red;
                verifikacija5 = false;
            }
            else
            {
                opisTextBox.Background = null;
                verifikacija5 = true;
            }

            if (string.IsNullOrWhiteSpace(izdavacTextBox.Text))
            {
                izdavacTextBox.Background = Brushes.Red;
                verifikacija6 = false;
            }
            else
            {
                izdavacTextBox.Background = null;
                verifikacija6 = true;
            }

            if (string.IsNullOrEmpty(kategorijaComoBox.Text))
            {
                kategorijaComoBox.Background = Brushes.Red;
                verifikacija7 = false;
            }else
            {
                kategorijaComoBox.Background = null;
                verifikacija7 = true;
            }

            if (string.IsNullOrEmpty(formatComboBox.Text))
            {
                formatComboBox.Background = Brushes.Red;
                verifikacija8 = false;
            }
            else
            {
                formatComboBox.Background = null;
                verifikacija8 = true;
            }
            if (string.IsNullOrEmpty(kolicinaComboBox.Text) || System.Text.RegularExpressions.Regex.IsMatch(kolicinaComboBox.Text, "[^0-9]"))
            {
                kolicinaComboBox.Background = Brushes.Red;
                verifikacija9 = false;
            }
            else
            {
                kolicinaComboBox.Background = null;
                verifikacija9 = true;
            }
            if (string.IsNullOrEmpty(datumDodavanjaDatePicker.Text))
            {
                datumDodavanjaDatePicker.Background = Brushes.Red;
                verifikacija10 = false;
            }
            else
            {
                datumDodavanjaDatePicker.Background = null;
                verifikacija10 = true;
            }
            if (string.IsNullOrEmpty(datumIzdavanjaDatePicker.Text))
            {
                datumIzdavanjaDatePicker.Background = Brushes.Red;
                verifikacija11 = false;
            }
            else
            {
                datumIzdavanjaDatePicker.Background = null;
                verifikacija11 = true;
            }


            if (verifikacija1 && verifikacija2 && verifikacija3 && verifikacija4 && verifikacija5 && verifikacija6 && verifikacija7 && verifikacija8 && verifikacija9 && verifikacija10)
            {
                return verifikacija = true;
            }
            else
            {
                return verifikacija = false;
            }
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

                Knjiga knjiga = new Knjiga(int.Parse(idTextBox.Text), isbnTextBox.Text, nazivTextBox.Text, autorTextBox.Text, opisTextBox.Text, kategorijaComoBox.Text, izdavacTextBox.Text, formatComboBox.Text, int.Parse(kolicinaComboBox.Text), datumIzdavanjaDatePicker.Text, datumDodavanjaDatePicker.Text);
                SqlDataAccess sql = new SqlDataAccess();


                if (sql.CuvanjeKnjige(knjiga))
                {
                    MessageBox.Show("Polja su uspesno dodata", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Polja nisu dodata", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Error);
                }
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
