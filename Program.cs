
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace capp.movieTalk
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var host  = new WebHostBuilder()
                            .UseKestrel()
                            .UseContentRoot(Directory.GetCurrentDirectory())
                            .UseStartup<Startup>()
                            .Build();
            host.Run();

        }
    }
}
