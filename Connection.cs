using System;
using System.Data.SqlClient;
namespace AdoNetConsoleApplication
{
    class Connection1
    {
        static void Main(string[] args)
        {
            new Connection1().Connecting();
        }
        public void Connecting()
        {
            using (
                     // Creating Connection  
                     SqlConnection con = new SqlConnection("data source=.; database=student; integrated security=SSPI")
                 )
            {
                con.Open();
                Console.WriteLine("Connection Established Successfully");
            }
        }
    }
}