using System;
using System.Data.SqlClient;
namespace AdoNetConsoleApplication
{
    class Program1
    {
        static void Main(string[] args)
        {
            new Program1().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source=.; database=NareshReddy; integrated security=SSPI");
                // writing sql query  
                SqlCommand cm = new SqlCommand("insert into student(id, name, email, join_date)values('101', 'Ronald Trump', 'ronald@example.com', '1/12/2017')", con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Record Inserted Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
    }
}