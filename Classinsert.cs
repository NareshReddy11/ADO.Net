using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetConsoleApplication
{
    class ClassInsert
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=.; database=NareshReddy; integrated security=SSPI");

                  SqlCommand cm1 = new SqlCommand("insert into class2(class,sub1,sub2,sub3)values('101','50','40','35')", con);
                 SqlCommand cm2 = new SqlCommand("insert into class2(class,sub1,sub2,sub3)values('15','70','80','75')", con);
                 SqlCommand cm3 = new SqlCommand("insert into class2(class,sub1,sub2,sub3)values('10','75','40','65')", con);
                 SqlCommand cm4 = new SqlCommand("insert into class2(class,sub1,sub2)values('11','55','45')", con);
                 SqlCommand cm5 = new SqlCommand("insert into class2(class,sub1,sub3)values('11','55','45')", con);
                //   SqlCommand cm = new SqlCommand("insert into class2(class,sub2,sub3)values('12','55','45')", con);
                //   SqlCommand cm = new SqlCommand("insert into class2(class,sub1,sub2,sub3)values('11','77','88','99')", con);
                //   SqlCommand cm = new SqlCommand("insert into class2(class)values('10')", con);
                //  SqlCommand cm = new SqlCommand("insert into class2(sub1,sub2,sub3)values('100','90','80')", con);
                SqlCommand cm = new SqlCommand("insert into class2(sub1,sub3)values('90','80')", con);
                con.Open();

                cm.ExecuteNonQuery();
                cm1.ExecuteNonQuery();
                cm2.ExecuteNonQuery();
                cm3.ExecuteNonQuery();
                cm4.ExecuteNonQuery();
                cm5.ExecuteNonQuery();


                Console.WriteLine("Record Inserted Successfully");
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
