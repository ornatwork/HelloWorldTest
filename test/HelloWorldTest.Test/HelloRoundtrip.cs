using Xunit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Grpc.Core;
using HelloWorldTest.Shared;
using System.Threading.Tasks;

namespace HelloWorldTest.Test
{
  /// <summary>
  /// Sample test
  /// </summary>
  public class HelloRoundTrip
  {

    [Fact]
    public void HelloServer()
    {

      Logger.Log("========== HelloServer");
      // Create server and start
      Server server = Util.CreateServer();
      // Setup client channel to server
      Channel channel = Util.CreateClientChannel();

      var client = PingServer.NewClient(channel);
      Logger.Log("Client setup");

      // Create a hello request
      HelloRequest req = new HelloRequest();
      req.Message = "olleH";
      // Say Hello
      var resp = client.Hello(req);
      Logger.Log($"Server returned a response={resp.Message}");

      // Check for a good response 
      Assert.Equal("Hello", resp.Message);


      client = null;
      // Shutdown channel connection to server, for both clients
      Util.ShutdownChannel(channel);
      // Shutdown the server
      Util.ShutdownServer(server);
    }
        
  }
}
