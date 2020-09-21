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
