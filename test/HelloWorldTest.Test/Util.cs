using System;
using System.Threading;
using HelloWorldTest.Shared;
using Grpc.Core;


namespace HelloWorldTest.Test
{
  public class Util
  {
    // All the tests use the same repeat number 
    public static readonly int Repeat = 10000;
    // Port to use for gRPC 
    private const int _port = 5001;
    // Port to use for gRPC 
    private const string _host = "localhost";
    // Wait for server to disappear
    //private const int _shutDownDelayMillisec = 15 * 1000;
    

    /// <summary>
    /// Creates client channel 
    /// </summary>
    public static Channel CreateClientChannel()
    {
      Channel channel = null;

      try
      {
        // Setup client channel to server
        channel = new Channel(_host + ":" + _port, ChannelCredentials.Insecure);
        Logger.Log("Client channel setup");
      }
      catch (Exception ex)
      {
        Logger.Log("CreateClientChannel, error=" + ex);
      }

      return channel;
    }


    /// <summary>
    /// Creates a server and starts it up for the caller 
    /// </summary>
    /// <returns>The server</returns>
    public static Server CreateServer()
    {
      Server theServer = null;
      try
      {
          theServer = new Server
          {
            Services = { PingServer.BindService(new PingServerImpl()) },
            Ports = { new ServerPort(_host, _port, ServerCredentials.Insecure) }
          };
          theServer.Start();
          Logger.Log("Server running, on host=" + _host + ", port=" + _port);
      }
      catch (Exception ex)
      {
        Logger.Log("CreateServer, error=" + ex);
      }

      return theServer;
    }


    /// <summary>
    /// Shuts down the channel, with error reporting if any
    /// </summary>
    public static void ShutdownChannel(Channel openChannel)
    {
      try
      {
        Logger.Log("Shutting down client channel, state=" + openChannel.State);
        openChannel.ShutdownAsync().Wait();
        openChannel = null;
      }
      catch (Exception ex)
      {
        Logger.Log("Shutdown Channel, Error=" + ex);
      }
    }

    /// <summary>
    /// Shuts down the server, with error reporting if any
    /// </summary>
    public static void ShutdownServer(Server openServer)
    {
      try
      {
        Logger.Log("Shutting down Server");
        openServer.ShutdownAsync().Wait();
        openServer = null;
      }
      catch (Exception ex)
      {
        Logger.Log("Shutdown Server, Error=" + ex);
      }
    }


  }  // EOF
}
