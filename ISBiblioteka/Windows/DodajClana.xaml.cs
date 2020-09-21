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
    /// Interaction logic for DodajClana.xaml
    /// </summary>
    public partial class DodajClana : Window
    {
        public DodajClana()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            AddHotKeys();
        }

        private void AddHotKeys()
        {
            try
            {
                RoutedCommand firstSettings = new RoutedCommand();
                firstSettings.InputGestures.Add(new KeyGesture(Key.Enter));
                CommandBindings.Add(new CommandBinding(firstSettings, Dugme_Sacuvaj_Click));

                RoutedCommand secondSettings = new RoutedCommand();
                secondSettings.InputGestures.Add(new KeyGesture(Key.Escape));
                CommandBindings.Add(new CommandBinding(secondSettings, Dugme_Otkazi_Click));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void ResetFields()
        {
            idClanTextBox.Text = "";
            idClanTextBox.Background = null;
            imeTextBox.Text = "";
            imeTextBox.Background = null;
            prezimeTextBox.Text = "";
            prezimeTextBox.Background = null;
            emailTextBox.Text = "";
            emailTextBox.Background = null;
            brojTelefonaTextBox.Text = "";
            brojTelefonaTextBox.Background = null;
            jmbgTextBox.Text = "";
            jmbgTextBox.Background = null;
            brojIndeksaTextBox.Text = "";
            brojIndeksaTextBox.Background = null;
            fakultetComoBox.SelectedValue = null;
            fakultetComoBox.Background = null;
            godinaUpisaDatePicker.SelectedDate = null;
            godinaUpisaDatePicker.Background = null;
            datumUclanjivanjaDatePicker.SelectedDate = null;
            datumUclanjivanjaDatePicker.Background = null;



        }
        private bool TestPolja()
        {
            bool verifikacija = true;

            bool verifikacija1 = true;
            bool verifikacija2 = true;
            bool verifikacija3 = true;
            bool verifikacija4 = true;
            bool verifikacija5 = true;
            bool verifikacija6 = true;
            bool verifikacija7 = true;
            bool verifikacija8 = true;
            bool verifikacija9 = true;
            bool verifikacija10 = true;

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

            

            if ((bool)studentJeClanCheckBox.IsChecked)
            {
                if (verifikacija1 && verifikacija2 && verifikacija3 && verifikacija4 && verifikacija5 && verifikacija6 && verifikacija7 && verifikacija8 && verifikacija9 && verifikacija10)
                {
                    return verifikacija = true;
                }
                else
                {
                    return verifikacija = false;
                }
            } else
            {
                brojIndeksaTextBox.Background = null;
                fakultetComoBox.Background = null;
                godinaUpisaDatePicker.Background = null;

                if (verifikacija1 && verifikacija2 && verifikacija3 && verifikacija4 && verifikacija5 && verifikacija6 && verifikacija10)
                {
                    return verifikacija = true;
                }
                else
                {
                    return verifikacija = false;
                }
            }
           
            

            
        }

        private bool TestID()
        {
            if(string.IsNullOrWhiteSpace(idClanTextBox.Text) || System.Text.RegularExpressions.Regex.IsMatch(idClanTextBox.Text, "[^0-9]"))
            {
                idClanTextBox.Background = Brushes.Red;
                return false;
            }
            else
            {
                idClanTextBox.Background = null;
                return true;
            }
        }

        private void Dugme_Sacuvaj_Click(object sender, RoutedEventArgs e)
        {
            if (TestPolja())
            {

                //MessageBox.Show("Polja su pravilno popunjena", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Information);

                Clan clan = new Clan(int.Parse(idClanTextBox.Text), imeTextBox.Text, prezimeTextBox.Text, emailTextBox.Text, brojTelefonaTextBox.Text, jmbgTextBox.Text, (bool)studentJeClanCheckBox.IsChecked, brojIndeksaTextBox.Text, fakultetComoBox.Text, godinaUpisaDatePicker.Text, datumUclanjivanjaDatePicker.Text);
                SqlDataAccess sql = new SqlDataAccess();

                if (sql.CuvanjeClana(clan))
                {
                    MessageBox.Show("Član je uspešno dodat", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Član nije dodat", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Error);
                }

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
            if (TestPolja())
            {

               // MessageBox.Show("Polja su pravilno popunjena", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Information);

                Clan clan = new Clan(int.Parse(idClanTextBox.Text), imeTextBox.Text, prezimeTextBox.Text, emailTextBox.Text, brojTelefonaTextBox.Text, jmbgTextBox.Text, (bool)studentJeClanCheckBox.IsChecked, brojIndeksaTextBox.Text, fakultetComoBox.Text, godinaUpisaDatePicker.Text, datumUclanjivanjaDatePicker.Text);
                SqlDataAccess sql = new SqlDataAccess();

                if (sql.CuvanjeIzmeneClan(int.Parse(idClanTextBox.Text),clan))
                {
                    MessageBox.Show("Član je uspešno izmenjen", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Izmena nije uspela", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
            else
            {

                MessageBox.Show("Polja nisu pravilno popunjena", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }

        private void Dugme_Izmena_Click(object sender, RoutedEventArgs e)
        {
            if (TestID())
            {
               // MessageBox.Show("Polja su pravilno popunjena", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Information);
                SqlDataAccess sql = new SqlDataAccess();

                PopuniPolja(sql.IscitavanjeClan(int.Parse(idClanTextBox.Text)));

            } else
            {
                MessageBox.Show("Polja nisu pravilno popunjena", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void PopuniPolja(Clan clan)
        {
            int id = clan.Id;


            idClanTextBox.Text = Convert.ToString(id);
            idClanTextBox.Background = null;

            imeTextBox.Text = clan.Ime;
            imeTextBox.Background = null;

            prezimeTextBox.Text = clan.Prezime;
            prezimeTextBox.Background = null;

            emailTextBox.Text = clan.Prezime;
            emailTextBox.Background = null;

            brojTelefonaTextBox.Text = clan.BrojTelefona;
            brojTelefonaTextBox.Background = null;

            jmbgTextBox.Text = clan.Jmbg;
            jmbgTextBox.Background = null;

            brojIndeksaTextBox.Text = clan.BrojIndeksa;
            brojIndeksaTextBox.Background = null;

            fakultetComoBox.Text = clan.Fakultet;
            fakultetComoBox.Background = null;

            godinaUpisaDatePicker.Text = clan.GodinaUpisa;
            godinaUpisaDatePicker.Background = null;

            datumUclanjivanjaDatePicker.Text = clan.DatumUclanjivanja;
            datumUclanjivanjaDatePicker.Background = null;

        }
    }
}
