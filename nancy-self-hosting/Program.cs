using nancy_self_hosting;
//see: https://github.com/NancyFx/Nancy/wiki/Self-Hosting-Nancy

namespace Nancy.Demo.Hosting.Self
{
    using System;
    using System.Diagnostics;

    using Nancy.Hosting.Self;

    class Program
    {

        

        static void Main()
        {
            HostConfiguration hostConfigs = new HostConfiguration()
            {
                //the app won't run without it
                UrlReservations = new UrlReservations() { CreateAutomatically = true }
            };

            //hostConfigs have to be passed in because of the "urlreservation" issues
            using (var host = new NancyHost(new CustomBootstrapper(), hostConfigs, new Uri("http://localhost:1234")))
            {
                host.Start();
                Console.ReadLine();
            }

            /*
            NancyHost nancyHost = new NancyHost(new Uri("http://localhost:8888"), new DefaultNancyBootstrapper(), hostConfigs);
            
            //var nancyHost = new NancyHost(hostConfigs, new Uri("http://localhost:8888/nancy/"), new Uri("http://127.0.0.1:8888/nancy/"), new Uri("http://localhost:8889/nancytoo/"));
            //var nancyHost = new NancyHost(hostConfigs, new Uri("http://localhost:8854/nancy/"));
            nancyHost.Start();

            Console.WriteLine("Nancy now listening - navigating to http://localhost:8888/nancy/. Press enter to stop");
            Process.Start("http://localhost:8888/nancy/");
            Console.ReadKey();

            nancyHost.Stop();

            Console.WriteLine("Stopped. Good bye!");
             * */
        }
    }
}