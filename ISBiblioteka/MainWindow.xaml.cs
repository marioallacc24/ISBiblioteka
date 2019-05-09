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

namespace ISBiblioteka
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
            
        }

        private void Dugme_Izlaz_OnClick(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Dugme_DodajKnjigu_Click(object sender, RoutedEventArgs e)
        {
            DodajKnjigu dodajKnjigu = new DodajKnjigu();
            dodajKnjigu.WindowStartupLocation = System.Windows.WindowStartupLocation.Manual;
            dodajKnjigu.Left = Left + 60;
            dodajKnjigu.Top = Top + 60;
            dodajKnjigu.Show();
        }

        private void Dugme_DodajClana_Click(object sender, RoutedEventArgs e)
        {
            DodajClana dodajClana = new DodajClana();
            dodajClana.Show();
        }

        private void Dugme_AdminPanel_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Panel je u izradi", "Obaveštenje",MessageBoxButton.OK, MessageBoxImage.Error);
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
            ListaClanova listaClanova = new ListaClanova();
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
