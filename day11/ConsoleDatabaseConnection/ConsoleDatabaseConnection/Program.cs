using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleDatabaseConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            //OpenFlags database
            /// server name: IP 127.0.0.1
            /// username:
            /// password:
            /// database:

            string connStr = "server=192.168.70.112;uid=developer1;pwd=Cst009.com;database=market";

            SqlConnection conn=new SqlConnection(connStr);

            conn.Open(); // open database
            Console.WriteLine("DatatBase is opened successfully");

            Thread.Sleep(1000);

            conn.Close(); // close database
            conn.Dispose(); // release resource

            Console.ReadKey();


        }
    }
}
