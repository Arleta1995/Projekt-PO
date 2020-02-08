using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.ComponentModel;
using System.Xaml;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Apka
{
    /// <summary>
    /// Logika interakcji dla klasy Wyszukaj.xaml
    /// </summary>
    public partial class Wyszukaj : Window
    {
        public Wyszukaj()
        {
            InitializeComponent();
        }

        private void WyszukajButton_Click(object sender, RoutedEventArgs e)
        {
            // Baza baza = new Baza(“test”, “test”, “localhost\\..., ...); // jeżeli z autoryzacją SQL Server
            Baza baza_win = new Baza("localhost", "MyMusic"); // Jeżeli z autoryzacją windows


            WyszukajDataGrid.DataContext = baza_win.pobierz_dane("SELECT * FROM Utwory"); // do uzupełnienia prawidłowymidanymi
        }
    }
}
