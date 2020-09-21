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
using System.Data.SQLite;
using System.Data;

namespace ISBiblioteka.Windows
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void Dugme_Login_Click(object sender, RoutedEventArgs e)
        {
            

            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=db_ISBiblioteka.db;Version=3;");
            if (m_dbConnection.State == ConnectionState.Closed)
                m_dbConnection.Open();

            try
            {


                String query = "select count(1) from bibliotekar where user=@korisnik and pass=@sifra";
                SQLiteCommand cmd = new SQLiteCommand(query, m_dbConnection);
                
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@korisnik", TextBox_Korisnik.Text);
                cmd.Parameters.AddWithValue("@sifra", PasswordBox.Password);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 1)
                {
                    MainWindow mainWindow = new MainWindow();
                    Close();
                    mainWindow.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Pogresni podaci", "Greška", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                m_dbConnection.Close();
            }

        }


        private void Dugme_Otkazi_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

    }

        
    
}
