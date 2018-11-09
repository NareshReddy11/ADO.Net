using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdoNetConsoleApplication
{
    class Student4
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=.; database=NareshReddy; integrated security=SSPI");

                SqlCommand cm = new SqlCommand("create table student4(rollNo int unique,name varchar(100),class varchar(100))", con);
                con.Open();
                cm.ExecuteNonQuery();
                Console.WriteLine("Student4 Table created Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
