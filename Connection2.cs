using System;
using System.Data.SqlClient;
namespace AdoNetConsoleApplication
{
    class Connection2
    {
        static void Main(string[] args)
        {
            new Connection2().Connecting();
        }
        public void Connecting()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source=.; database=NareshReddy; integrated security=SSPI");
                con.Open();
                Console.WriteLine("Connection Established Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e);
            }
            finally
            {   // Closing the connection  
                con.Close();
            }
        }
    }
}