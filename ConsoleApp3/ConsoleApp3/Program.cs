using MySql.Data.MySqlClient;
using System.Data.Common;
using System;


namespace ConsoleApp3
{
    class Program
    {

        private static void DentalHospital(MySqlConnection conn)
        {
            string p_dateofapplication, p_surname, p_name, p_id;
            string sql = "select p_id, p_name, p_surname, p_dateofapplication from patient where p_dateofapplication='2020-12-04'";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                       p_dateofapplication = reader["p_dateofapplication"].ToString();
                        p_name = reader["p_name"].ToString();
                        p_surname = reader["p_surname"].ToString();
                        p_id = reader["p_id"].ToString();
              
                       
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine("ID:"+p_id+"; p_name: "+p_name+"; p_surname: "+p_surname+"; Date of application: "+p_dateofapplication);
                        Console.WriteLine("--------------------------------------");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Getting conection...");
            MySqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                Console.WriteLine("Openning conection...");
                conn.Open();
                Console.WriteLine("Connection Succsessful!");
                DentalHospital(conn);
            }
            catch(Exception e)
            {
                Console.WriteLine("Error"+ e.Message);
                Console.WriteLine(e.StackTrace);
              
            }
            finally { 
                conn.Close();
                conn.Dispose();
                    }
            Console.ReadLine();

            }
       

    }
}