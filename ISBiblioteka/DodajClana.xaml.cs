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
    /// Interaction logic for DodajClana.xaml
    /// </summary>
    public partial class DodajClana : Window
    {
        public DodajClana()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        public void ResetFields()
        {
            idClanTextBox.Text = "";
            imeTextBox.Text = "";
            prezimeTextBox.Text = "";
            emailTextBox.Text = "";
            brojTelefonaTextBox.Text = "";
            jmbgTextBox.Text = "";
            brojIndeksaTextBox.Text = "";
            fakultetComoBox.SelectedValue = null;
            godinaUpisaDatePicker.SelectedDate = null;
            datumUclanjivanjaDatePicker.SelectedDate = null;



        }

        private void Dugme_Otkazi_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Dugme_Obrisi_Click(object sender, RoutedEventArgs e)
        {
            ResetFields();
        }
    }
}
