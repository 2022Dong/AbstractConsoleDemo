using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DataAccess da = new DataAccess(); // Error - benefit 1
            // SqliteDataAccess da = new SqliteDataAccess(); // OK
            //DataAccess da = new SqliteDataAccess(); // OK  - benifit 2
            

                List<DataAccess> databases = new List<DataAccess>()
            {
                //new SqlDataAccess(),
                new SqliteDataAccess()


            };

            foreach (var db in databases)
            {
                Console.WriteLine(db.LoadConnectionString("Demo")); // Demo virtual keyword - override
                //db.LoadConnectionString("demo");
                //db.LoadData("select * from table");
                //db.LoadData("insert into table");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
