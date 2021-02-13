using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCResponsiveWebApp
{
    public class Program
    {
        public static int AgeThisYear(int yearOfBirth)
        {
            int age;
            if (yearOfBirth >= 1900 && yearOfBirth <= 2021)
            {
                int _CURRENTYEAR = 2021;
                age = _CURRENTYEAR - yearOfBirth;
            }
            else
            {
                age = 0;
            }
            return age;
        }
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
