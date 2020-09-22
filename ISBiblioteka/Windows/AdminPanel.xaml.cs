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
    /// Interaction logic for AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Window
    {
        public AdminPanel()
        {
            InitializeComponent();
            AddHotKeys();

        }

        private void AddHotKeys()
        {
            try
            {
                RoutedCommand firstSettings = new RoutedCommand();
                firstSettings.InputGestures.Add(new KeyGesture(Key.B, ModifierKeys.Alt));
                CommandBindings.Add(new CommandBinding(firstSettings, Dugme_DodajBibliotekara_Click));

                RoutedCommand secondSettings = new RoutedCommand();
                secondSettings.InputGestures.Add(new KeyGesture(Key.L, ModifierKeys.Alt));
                CommandBindings.Add(new CommandBinding(secondSettings, Dugme_ListaBibliotekara_Click));

                RoutedCommand eighthSettings = new RoutedCommand();
                eighthSettings.InputGestures.Add(new KeyGesture(Key.Escape));
                CommandBindings.Add(new CommandBinding(eighthSettings, Dugme_Izlaz_OnClick));
            }
            catch (Exception err)
            {
                System.Windows.MessageBox.Show(err.Message);
            }
        }



        private void Dugme_Izlaz_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        public void Dugme_DodajBibliotekara_Click(object sender, RoutedEventArgs e)
        {
            DodajBibliotekara dodajBibliotekara = new DodajBibliotekara();
            dodajBibliotekara.Show();
        }

        private void Dugme_ListaBibliotekara_Click(object sender, RoutedEventArgs e)
        {
            ListaBibliotekara listaBibliotekara = new ListaBibliotekara();
            listaBibliotekara.Show();

        }

        private void Dugme_IzlogujSe_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Windows[0].Close();
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
