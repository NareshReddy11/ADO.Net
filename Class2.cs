using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdoNetConsoleApplication
{
    class Class2
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=.; database=Nareshreddy; integrated security=SSPI");

                SqlCommand cm = new SqlCommand("create table class2(class varchar(100),sub1 varchar(50),sub2 varchar(50),sub3 varchar(50))", con);
                con.Open();
                cm.ExecuteNonQuery();
                Console.WriteLine("Class2 Table created Successfully");
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
