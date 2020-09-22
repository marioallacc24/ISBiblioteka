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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ISBiblioteka.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
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
                firstSettings.InputGestures.Add(new KeyGesture(Key.K, ModifierKeys.Alt));
                CommandBindings.Add(new CommandBinding(firstSettings, Dugme_DodajKnjigu_Click));

                RoutedCommand secondSettings = new RoutedCommand();
                secondSettings.InputGestures.Add(new KeyGesture(Key.C, ModifierKeys.Alt));
                CommandBindings.Add(new CommandBinding(secondSettings, Dugme_DodajClana_Click));

                RoutedCommand thirdSettings = new RoutedCommand();
                thirdSettings.InputGestures.Add(new KeyGesture(Key.A, ModifierKeys.Alt));
                CommandBindings.Add(new CommandBinding(thirdSettings, Dugme_AdminPanel_Click));

                RoutedCommand fourthSettings = new RoutedCommand();
                fourthSettings.InputGestures.Add(new KeyGesture(Key.I, ModifierKeys.Alt));
                CommandBindings.Add(new CommandBinding(fourthSettings, Dugme_Izdavanje_Click));

                RoutedCommand fifthSettings = new RoutedCommand();
                fifthSettings.InputGestures.Add(new KeyGesture(Key.V, ModifierKeys.Alt));
                CommandBindings.Add(new CommandBinding(fifthSettings, Dugme_Vracanje_Click));

                RoutedCommand sixthSettings = new RoutedCommand();
                sixthSettings.InputGestures.Add(new KeyGesture(Key.L, ModifierKeys.Alt));
                CommandBindings.Add(new CommandBinding(sixthSettings, Dugme_ListaClanova_Click));

                RoutedCommand seventhSettings = new RoutedCommand();
                seventhSettings.InputGestures.Add(new KeyGesture(Key.P, ModifierKeys.Alt));
                CommandBindings.Add(new CommandBinding(seventhSettings, Dugme_Pomoc_Click));

                RoutedCommand eighthSettings = new RoutedCommand();
                eighthSettings.InputGestures.Add(new KeyGesture(Key.Escape));
                CommandBindings.Add(new CommandBinding(eighthSettings, Dugme_IzlogujSe_Click));
            }
            catch (Exception err)
            {
                System.Windows.MessageBox.Show(err.Message);
            }
        }

        private void Dugme_Izlaz_OnClick(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Dugme_DodajKnjigu_Click(object sender, RoutedEventArgs e)
        {
            DodajKnjigu dodajKnjigu = new DodajKnjigu();
            dodajKnjigu.WindowStartupLocation = System.Windows.WindowStartupLocation.Manual;
            dodajKnjigu.Left = Left + 60;
            dodajKnjigu.Top = Top + 60;
            dodajKnjigu.Show();
        }

        public void Dugme_DodajClana_Click(object sender, RoutedEventArgs e)
        {
            DodajClana dodajClana = new DodajClana();
            dodajClana.Show();
        }

        private void Dugme_AdminPanel_Click(object sender, RoutedEventArgs e)
        {
            if(Global.ulogovanKorisnik != "admin")
            {
                MessageBox.Show("Ovaj panel je samo za admina. Trenutni ulogovan korisnik: " + Global.ulogovanKorisnik.ToString(), "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Error);
            } else
            {
                AdminPanel adminPanel = new AdminPanel();
                adminPanel.WindowStartupLocation = System.Windows.WindowStartupLocation.Manual;
                adminPanel.Left = Left + 60;
                adminPanel.Top = Top + 60;
                adminPanel.Show();
            }

            
        }

        private void Dugme_Izdavanje_Click(object sender, RoutedEventArgs e)
        {
            Izdavanje izdavanje = new Izdavanje();
            izdavanje.Show();
        }

        private void Dugme_Vracanje_Click(object sender, RoutedEventArgs e)
        {
            Vracanje vracanje = new Vracanje();
            vracanje.Show();
        }

        private void Dugme_ListaClanova_Click(object sender, RoutedEventArgs e)
        {
            Windows.ListaClanova listaClanova = new Windows.ListaClanova();
            listaClanova.Show();

        }

        private void Dugme_Pomoc_Click(object sender, RoutedEventArgs e)
        {
            Pomoc pomoc = new Pomoc();
            pomoc.Show();
        }

        private void Dugme_IzlogujSe_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            Close();
            login.ShowDialog();
        }

       

        private void Dugme_SvetlaTema_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources.MergedDictionaries[1].Source = new Uri("pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Light.xaml", UriKind.RelativeOrAbsolute);
        }

        private void Dugme_TamnaTema_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources.MergedDictionaries[1].Source = new Uri("pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Dark.xaml", UriKind.RelativeOrAbsolute);
        }
    }
}
