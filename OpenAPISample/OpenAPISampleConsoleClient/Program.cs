using System;
using OpenAPISampleClientLib;

namespace OpenAPISampleConsoleClient
{
    class Program
    {
        static void Main(string[ ] args)
        {
            Console.WriteLine("This is just a sample Console Client for OpenAPI.");
            WeatherForecastClient client = new WeatherForecastClient("https://localhost:44390", new System.Net.Http.HttpClient( ));
            Console.WriteLine($"The client will get forcasts form {client.BaseUrl} server." );
            var request = client.GetAsync( );
            request.Wait( );
            foreach(var forcast in request.Result)
            {
                Console.WriteLine(forcast.Summary);
            }
        }
    }
}
