using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
namespace AdopseAddsTeam5
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            //TestConnection();
        }
        private static void TestConnection()  //test
        {
            using(NpgsqlConnection con = GetConnection())
            {
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    Debug.WriteLine("Connected");
                }
            }
        }

        private static NpgsqlConnection GetConnection() //connect pgsql
        {
            return new NpgsqlConnection(@"Server=dblabs.it.teithe.gr;Port=5432;User Id=it164760;Password=stratoseus1998;Database=it164760;");
        }
    }
}
