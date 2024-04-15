using System.Data.SqlClient;

namespace SQLlession
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Program().CreateTable();
            new Program().InsertRecord();
            new Program().DisplayData();
            new Program().DeleteData();
            
            Console.ReadKey();

        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                //Create Connection

                con = new SqlConnection("data source=LMS-LPT-04\\SQLEXPRESS; database=student; integrated security=SSPI");

                //Writing sql query

                SqlCommand cm = new SqlCommand(@"
                IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Building')
                BEGIN
                    CREATE TABLE Building (
                        Id INT NOT NULL,
                        Name VARCHAR(100),
                        Floor INT,
                        PRIMARY KEY (Id)
                    );
                END;"
               ,con);

                // Opening Connection

                con.Open();

                // Executing the SQL query

                cm.ExecuteNonQuery();

                // Displaying a massage

                Console.WriteLine("Table created Successfully");

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

        public void InsertRecord()
        {
            SqlConnection con = null;
            try
            {
                //Creating Connection
                con = new SqlConnection("data source=LMS-LPT-04\\SQLEXPRESS; database=student; integrated security=SSPI");

                // Writing sql query
                SqlCommand cm = new SqlCommand("insert into student (id , name , email, join_date) values ('101','Ronald Trump', 'Ronald@example.com' , '1/12/2017')", con);

                // Opening Connection
                con.Open();

                // Executing the SQL query
                cm.ExecuteNonQuery();

                // Displaying a massage
                Console.WriteLine("Record Inserted Succesfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs , somthing went wrong" + e);
            }
            finally
            {
                con.Close();
            }
        }

        public void DisplayData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=LMS-LPT-04\\SQLEXPRESS; database=student; integrated security=SSPI");
                SqlCommand cm = new SqlCommand("Select * from student", con);
                con.Open();
                SqlDataReader sdr = cm.ExecuteReader();
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["id"] + " " + sdr["name"] + " " + sdr["email"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs , somthing went wrong" + e);
            }
            finally
            {
                con.Close();
            }

        }
        public void DeleteData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=LMS-LPT-04\\SQLEXPRESS; database=student; integrated security=SSPI");
                SqlCommand cm = new SqlCommand("delete from student where id = '102'", con);
                con.Open();
                cm.ExecuteNonQuery();
                Console.WriteLine("Record Deleted Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs ,Something went wrong." + e);
            }
            finally
            {
                con.Close();
            }


        }
    }
}