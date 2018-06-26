using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace OdeToFood
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }


    //static void Main(string[] args)
    //{

    //    //BuildWebHost(args).Run();



    //    try
    //    {
    //        // Build connection string
    //        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
    //        builder.DataSource = "localhost";   // update me
    //        builder.UserID = "sa";              // update me
    //        builder.Password = "Aa300892.";      // update me
    //        builder.InitialCatalog = "master";

    //        // Connect to SQL
    //        Console.Write("Connecting to SQL Server ... ");
    //        using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
    //        {
    //            connection.Open();
    //            Console.WriteLine("Done.");
    //        }
    //    }
    //    catch (SqlException e)
    //    {
    //        Console.WriteLine(e.ToString());
    //    }

    //    Console.WriteLine("All done. Press any key to finish...");
    //    Console.ReadKey(true);

    //}

    //public static IWebHost BuildWebHost(string[] args) =>
    //    WebHost.CreateDefaultBuilder(args)
    //    .UseStartup<Startup>()
    //    .Build();
}


