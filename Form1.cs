using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectShelf.Properties;
using System.Data.SqlClient;


// źródło: http://jakub.otrzasek.pl/sql/412/ado-net-podlaczenie-sie-do-bazy-sql-server-w-c/

namespace ProjectShelf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShelfImage.Image = Resources.zabudowa_polki_na_ksiazki;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            OpenBook.Image = Resources.istockphoto_133632220_1024x1024;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            // Baza baza = new Baza(“test”, “test”, “localhost\\..., ...); // do uzupełnienia
            Baza baza_win = new Baza(instance, dbdir); // do uzupełnienia prawidłowymidanymi
            dataGridView1.DataSource = baza_win.pobierz_dane("do uzupełnienia"); // do uzupełnienia prawidłowymidanymi
        }
    }
}
