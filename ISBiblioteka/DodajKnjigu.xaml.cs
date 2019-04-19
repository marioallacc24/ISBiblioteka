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
            isbnTextBox.Text = "";
            nazivTextBox.Text = "";
            autorTextBox.Text = "";
            opisTextBox.Text = "";
            izdavacTextBox.Text = "";
            kategorijaComoBox.SelectedValue = null;
            formatComboBox.SelectedValue = null;
            kolicinaComboBox.SelectedValue = null; 
            datumIzdavanjaDatePicker.SelectedDate = null;
            datumDodavanjaDatePicker.SelectedDate = null;

            
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
