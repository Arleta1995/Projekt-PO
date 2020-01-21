using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace ProjectShelf
{
    class Baza
    {
        private SqlConnection polaczenie;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pass"></param>
        /// <param name="instance"></param>
        /// <param name="dbdir"></param>
        public Baza(string user, string pass, string instance, string dbdir)
        // Konstruktor do tworzenia polaczenia za pomoca autoryzacji SQL Server
        {
            polaczenie = new SqlConnection();
            polaczenie.ConnectionString = "user id=" + user + ";" +
            "password=" + pass + ";Data Source=" + instance + ";" +
            "Trusted_Connection=no;" +
            "database=" + dbdir + "; " + //podejżewam że tu powinna być nasza baza danych
            "connection timeout=3";
            polaczenie.Open();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="instance"></param>
        /// <param name="dbdir"></param>
        public Baza(string instance, string dbdir)
           
        {
            polaczenie.ConnectionString = "Data Source=" + instance + ";" +
            "Trusted_Connection=yes;" +
            "database=" + dbdir + "; " + //podejżewam że tu powinna być nasza baza danych
            "connection timeout=3";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="q"></param>
        /// <returns></returns>
        public DataTable pobierz_dane(string q)
        // Metoda do pobierana danych z SQL Server
        //zapytanie sqL // zwraca dane w obiekcie DataTable
        {
            DataTable dt = new DataTable(); // deklaracja i utworzenie instancji obiektu DataTable o nazwie dt
            SqlDataReader dr; // deklaracja obiektu SqlDataReader o nazwie dr
            SqlCommand sqlc; // Deklaracja obiektu SqlCOmmand

            sqlc = new SqlCommand(q);
            // utworzenie instancji SQLCommand ktora ma wykonac zapytanie podane jako parametr
            // w zmiennej q

            sqlc.Connection = this.polaczenie; // wskazanie polaczenia do bazy danych
            dr = sqlc.ExecuteReader(); //wykonanie zapytanie i utworzenie wskaznika dr
            dt.Load(dr); //zaladowanie danych do obiektu DataTable
            return dt; // zwrocenie danych

        }
    }
}
