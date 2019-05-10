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
    /// Interaction logic for IzdavanjeKnjiga.xaml
    /// </summary>
    public partial class IzdavanjeKnjiga : Window
    {
        public IzdavanjeKnjiga()
        {
            InitializeComponent();
        }

        private void Dugme_Potvrdi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Dugme_Otkazi_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
