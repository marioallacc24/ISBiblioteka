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
    /// Interaction logic for DodajBibliotekara.xaml
    /// </summary>
    public partial class DodajBibliotekara : Window
    {
        public DodajBibliotekara()
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

        private void Dugme_Otkazi_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private bool TestPolja()
        {
            bool verifikacija = true;

            bool verifikacija1 = true;
            bool verifikacija2 = true;

            if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
            {
                usernameTextBox.Background = Brushes.Red;
                verifikacija1 = false;
            }
            else
            {
                usernameTextBox.Background = null;
                verifikacija1 = true;
            }

            if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                passwordTextBox.Background = Brushes.Red;
                verifikacija2 = false;
            }
            else
            {
                passwordTextBox.Background = null;
                verifikacija2 = true;
            }

            if (verifikacija1 && verifikacija2)
            {
                return verifikacija = true;
            }
            else
            {
                return verifikacija = false;
            }
        }

        private void ResetFields()
        {
            usernameTextBox.Text = "";
            usernameTextBox.Background = null;
            passwordTextBox.Text = "";
            passwordTextBox.Background = null;

        }

        private void Dugme_Potvrdi_Click(object sender, RoutedEventArgs e)
        {

            if (TestPolja())
            {
                Bibliotekar bibliotekar = new Bibliotekar(usernameTextBox.Text, passwordTextBox.Text);
                SqlDataAccess sql = new SqlDataAccess();

                if (sql.CuvanjeBibliotekara(bibliotekar))
                {
                    MessageBox.Show("Bibliotekar je uspešno dodat", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Bibliotekar nije dodat", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
            else
            {

                MessageBox.Show("Polja nisu pravilno popunjena", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Error);

            }

        }
    }
}
