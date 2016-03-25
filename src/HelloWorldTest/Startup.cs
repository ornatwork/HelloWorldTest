using System;
using System.Threading.Tasks;
using Grpc.Core;
using HelloWorldTest.Shared;



namespace HelloWorldTest
{

  class Program
  {
    // Port to use for gRPC 
    const int Port = 5001;

    /*
    // Fire up the server
    public static void Main(string[] args)
    {
      // Setup
      Server server = new Server
      {
        Services = { PingServer.BindService(new PingServerImpl()) },
        Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
      };
      // lets go 
      server.Start();

      // Greetings 
      Console.WriteLine("Ping server listening on port " + Port );
      Console.WriteLine("Press the any key to stop the server...");
      Console.ReadKey();

      // Shutdown
      server.ShutdownAsync().Wait();
    }
    */
  }
}
