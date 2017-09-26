using System;
using MySql.Data.MySqlClient;

namespace Database
{
    class Program
    {
        static void Main(string[] args)
        {


            MySqlConnection comm = new MySqlConnection();

            
            comm.ConnectionString = "Server = 192.168.56.101;Port = 3306; Database = world;Uid = root;Pwd = root; ";

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = comm;
            cmd.CommandText = "SELECT count(*) FROM City";

            comm.Open();


            Console.WriteLine("Aantal steden {0}", cmd.ExecuteScalar());
            Console.Read();
        }
    }
}
