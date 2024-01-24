using Microsoft.Data.SqlClient;
using System.Data.SqlClient;

namespace PROJET
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Clients());
        }
        public static SqlConnection GetConnection()
        {

            SqlConnection cnx = new SqlConnection
            {
                ConnectionString = @"Server=. ; database=ProjetEventManagement ; Integrated Security=true; trustServerCertificate=true"
            };
            return cnx;
        }
    }
}