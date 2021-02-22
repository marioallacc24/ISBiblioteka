﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
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
    /// Interaction logic for ListaBibliotekara.xaml
    /// </summary>
    public partial class ListaBibliotekara : Window
    {
        public ListaBibliotekara()
        {
            InitializeComponent();
            UcitajBibliotekare();
            AddHotKeys();
        }

        private void AddHotKeys()
        {
            try
            {
                RoutedCommand firstSettings = new RoutedCommand();
                firstSettings.InputGestures.Add(new KeyGesture(Key.Enter));
                CommandBindings.Add(new CommandBinding(firstSettings, Dugme_Obrisi_Click));

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

        private void UcitajBibliotekare()
        {

            SQLiteConnection sql_con = new SQLiteConnection("Data Source=db_ISBiblioteka.db;Version=3;");   //podesavanje konekcije
            sql_con.Open(); //otvaranje kenekcije
            SQLiteCommand sql_cmd = sql_con.CreateCommand();    //podesavanje komandnog objekta na konekciju
            sql_cmd.CommandText = "SELECT * FROM bibliotekar"; //u komandni objekat saljemo sql zahtev
            SQLiteDataAdapter DB = new SQLiteDataAdapter(sql_cmd.CommandText, sql_con); //sql adapter db izvrsava komandnu odnonso u sebi cuva rezultate sql zahteva (ucitao sve podatke u sebe)
            sql_con.Close();    //zatavaramo konekciju
            DataSet DS = new DataSet();     //kreiramo objekta data set koji ce da cuva poadtke iz data dabtera
            DB.Fill(DS);    //dataset punimo podacima iz adaptera


            if (DS.Tables[0].Rows.Count > 0)
            {
                listaBibliotekaraDataGrid.ItemsSource = DS.Tables[0].DefaultView;
            }
        }

        private void Dugme_Obrisi_Click(object sender, RoutedEventArgs e)
        {
            BrisanjeBibliotekara brisanjeBibliotekara = new BrisanjeBibliotekara();
            brisanjeBibliotekara.ShowDialog();

        }

        private void Dugme_Osvezi_Click(object sender, RoutedEventArgs e)
        {
            UcitajBibliotekare();
        }
    }
}