using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
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
    /// Interaction logic for Pomoc.xaml
    /// </summary>
    public partial class Pomoc : Window
    {
        public Pomoc()
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
                firstSettings.InputGestures.Add(new KeyGesture(Key.G, ModifierKeys.Alt));
                CommandBindings.Add(new CommandBinding(firstSettings, Dugme_GitHub_Click));

                RoutedCommand secondSettings = new RoutedCommand();
                secondSettings.InputGestures.Add(new KeyGesture(Key.L, ModifierKeys.Alt));
                CommandBindings.Add(new CommandBinding(secondSettings, Dugme_Linkedin_Click));

                RoutedCommand thirdSettings = new RoutedCommand();
                thirdSettings.InputGestures.Add(new KeyGesture(Key.S, ModifierKeys.Alt));
                CommandBindings.Add(new CommandBinding(thirdSettings, Dugme_Sajt_Click));

                RoutedCommand fourthSettings = new RoutedCommand();
                fourthSettings.InputGestures.Add(new KeyGesture(Key.O, ModifierKeys.Alt));
                CommandBindings.Add(new CommandBinding(fourthSettings, Dugme_O_Click));
            }
            catch (Exception err)
            {
                System.Windows.MessageBox.Show(err.Message);
            }
        }

        private const string sHTMLHelpFileName = "isBiblioteka.chm";

        private void Dugme_GitHub_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/marioallacc24/ISBiblioteka");
        }

        private void Dugme_Sajt_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://educons.edu.rs/");
        }

        private void Dugme_Linkedin_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://linkedin.com/in/mario-blagojevic-455256158");
        }

        private void Dugme_O_Click(object sender, RoutedEventArgs e)
        {

            System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + @"\" +sHTMLHelpFileName);

            
        }
    }
}
